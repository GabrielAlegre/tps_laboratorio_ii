using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Forms
{
    public partial class FormPrincipalMenu : Form
    {
        private CentralAdministradora centralServicio;
        private ClaseSerializadoraXml serializadoraXml;
        private EstadisticaServicios estadisticasDeLosServicios;
        private static Random tiempoDeEsperaRandom;
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken token;

        public delegate void delegadoProgressBar(ProgressBar barraDeProgeso, Label lblInformacion, string idHilo);
        private delegadoProgressBar delegadoAumentarBarraProceso;

        public delegate void delegadoConfiguracionControles();
        public event delegadoConfiguracionControles configuracionDeControles;

        static FormPrincipalMenu()
        {
            tiempoDeEsperaRandom = new Random();
        }
        /// <summary>
        /// Constructor encargado de inicializar los atributos del form
        /// </summary>
        public FormPrincipalMenu()
        {
            InitializeComponent();
            this.centralServicio = new CentralAdministradora();
            this.serializadoraXml = new ClaseSerializadoraXml();
            this.estadisticasDeLosServicios = new EstadisticaServicios();
            configuracionDeControles += ConfiguracionControles;
            cancellationTokenSource = new CancellationTokenSource();
            token = cancellationTokenSource.Token;
        }

        /// <summary>
        /// Evento load del formulario, donde se levantaran todos los datos de los archivos xml y json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipalMenu_Load(object sender, EventArgs e)
        {
            Deserializar();
         
            Task tareaBarraProgresoXlm = Task.Run(() => ComenzarProceso(progressBarXml, lblBarraProgresoXml, cancellationTokenSource), token);
            Task tareaBarraProgresoTxt = Task.Run(() => ComenzarProceso(progressBarTxt, lblBarraProgresoTxt, cancellationTokenSource), token);

        }

        /// <summary>
        /// Evento que se producira al tocar el boton de alta, al producirse se instanciara y llamara al form encargado de pedir el dni 
        /// y en caso de que se ingrese un dni valido se instanciara y llamara al form encargado de dar el alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FormIngresoDeDni frmDni = new FormIngresoDeDni("Ingrese dni del cliente que se va a dar de alta para verificar\nsi ya esta activo en el sistema", EOpciones.DarAlta, centralServicio, estadisticasDeLosServicios);
            frmDni.ShowDialog();
            if (frmDni.DialogResult == DialogResult.OK)
            {
                FormAlta alta = new FormAlta(centralServicio, frmDni.ObtenerDniIngresado, estadisticasDeLosServicios);
                alta.ShowDialog();
            }
        }

        /// <summary>
        /// Evento que se producira al tocar el boton de modificar, al producirse se instanciara y llamara al form encargado de pedir el dni 
        /// y en caso de que se ingrese un dni valido se instanciara y llamara al form modificar, en caso de que se modifique al cliense, se guardara en el historial dicha operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormIngresoDeDni frmDni = new FormIngresoDeDni("Ingrese dni del cliente a modificar", EOpciones.Modificar, centralServicio);
            DialogResult ingresoDniDeClienteExistente = frmDni.ShowDialog();

            if (ingresoDniDeClienteExistente == DialogResult.OK)
            {
                Cliente clienteParaModificar = CentralAdministradora.BuscarClienteActivoPorDni(frmDni.ObtenerDniIngresado);
                FormModificar formModificar = new FormModificar(clienteParaModificar, "Estos son los datos actuales del cliente, modifique lo que corresponda", "Modificar");
                DialogResult confirmoModificacion = formModificar.ShowDialog();

                if (confirmoModificacion == DialogResult.OK)
                {
                    centralServicio.Guardar(centralServicio.Ruta, $"{DateTime.Now:f}hs - Se realizo una modificacion de datos al cliente:\nLlamado: {clienteParaModificar.Nombre}\nCon Dni: {clienteParaModificar.Dni}\n");
                    estadisticasDeLosServicios.CantClientesQueModificanAlgunDato += 1;
                }
            }
        }

        /// <summary>
        /// Evento que se producira al tocar el boton de baja, al producirse el evento se instanciara y llamara al form encargado de pedir el dni 
        /// y en caso de que se ingrese un dni valido se instanciara y llamara al form de dar de mostrar, para mostrar al cliente que se dara de baja
        /// en caso de que se confirme la modificacion se hara la baja logica (EstaActivo = false).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            FormIngresoDeDni frmDni = new FormIngresoDeDni("Ingrese dni del cliente que se va a dar baja su servicio", EOpciones.DarBaja, centralServicio);
            DialogResult ingresoDniDeClienteExistente = frmDni.ShowDialog();

            if (ingresoDniDeClienteExistente == DialogResult.OK)
            {
                Cliente clienteQueSeDaraDeBaja = CentralAdministradora.BuscarClienteActivoPorDni(frmDni.ObtenerDniIngresado);
                DialogResult confirmoBaja = llamarFormMostrar("Dar baja", "Se dara el siguente cliente de baja, esta seguro?", clienteQueSeDaraDeBaja.ToString());

                if (confirmoBaja == DialogResult.OK)
                {
                    clienteQueSeDaraDeBaja.EstaActivo = false;
                    estadisticasDeLosServicios.CantidadDeClientesQueDieronBaja += 1;
                    MessageBox.Show("El cliente a sido dado de baja correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    centralServicio.Guardar(centralServicio.Ruta, $"{DateTime.Now:f}hs - Se realizo la baja del cliente:\nLlamado: {clienteQueSeDaraDeBaja.Nombre}\nCon Dni: {clienteQueSeDaraDeBaja.Dni}\n");
                }
            }
        }

        /// <summary>
        /// Evento que se producira al tocar el boton mostrarClientes, se mostrara el listado de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            this.llamarFormMostrar("Listado de clientes", "Listado de clientes");
        }

        /// <summary>
        /// Evento que se producira al tocar btnHistorial, al producirse se mostrara el historial de operaciones, leyendo el archivo txt que contiene dicho historial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                string historialParaMostrar = centralServicio.Leer(centralServicio.Ruta);
                this.llamarFormMostrar("Registro de operaciones", "Historial/registro de operaciones", historialParaMostrar);
            }
            catch (FallaDeArchivoException ex)
            {
                MessageBox.Show(ex.Message, "Exception controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que se producira al tocar btnInformeEstadistico, al producirse se mostrara el informe estadistico sobre las operaciones realizadas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInformeEstadistico_Click(object sender, EventArgs e)
        {
            this.llamarFormMostrar("Informe estadistico", "Informe estadistico sobre los servicios", estadisticasDeLosServicios.MostrarInforme());
        }

        /// <summary>
        /// Metodo encargado de instanciar y llamar al formulario FormMostrar y mostrar el contenido que recibe por parametros
        /// </summary>
        /// <param name="tituloForm">Titulo que contendra el formulario</param>
        /// <param name="textoLabel">Texto del label que contendra el formulario</param>
        /// <param name="contenidoParaMostrar">Contenido que se mostrara en el formulario</param>
        /// <returns>El DialogResult del formulario mostrar</returns>
        private DialogResult llamarFormMostrar(string tituloForm, string textoLabel, string contenidoParaMostrar)
        {
            FormMostrar frmMostrarClientes = new FormMostrar(tituloForm, textoLabel, contenidoParaMostrar);
            DialogResult confirmo = frmMostrarClientes.ShowDialog();
            return confirmo;
        }

        /// <summary>
        /// Sobrecarga del metodo Metodo llamarFormMostrar, se encarga de instanciar y llamar al formulario FormMostrar
        /// </summary>
        /// <param name="tituloForm">Titulo que contendra el formulario</param>
        /// <param name="textoLabel">Texto del label que contendra el formulario</param>
        /// <returns>El DialogResult del formulario mostrar</returns>
        private DialogResult llamarFormMostrar(string tituloForm, string textoLabel)
        { 
            FormMostrar frmMostrarClientes = new FormMostrar(tituloForm, textoLabel);
            DialogResult confirmo = frmMostrarClientes.ShowDialog();
            return confirmo;
        }

        /// <summary>
        /// Metodo encargado de Deserializar los los archivos xml y json
        /// </summary>
        private void Deserializar()
        {
            try
            {
                if (serializadoraXml.Leer(serializadoraXml.RutaArchivoXml) is not null)
                {
                    CentralAdministradora.ListaDeClientes = serializadoraXml.Leer(serializadoraXml.RutaArchivoXml);
                }

                if (estadisticasDeLosServicios.Leer(estadisticasDeLosServicios.RutaSerializarJson) is not null)
                {
                    estadisticasDeLosServicios = estadisticasDeLosServicios.Leer(estadisticasDeLosServicios.RutaSerializarJson);
                }
            }
            catch (FallaDeArchivoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Excepcion controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Excepcion controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento que dara lugar al cerrarse el formulario, y se encarga de guardar/serializar los archivos xml (que contiene la lista de clientes) y el archivo json (que contiene el informe estadistico)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipalMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serializadoraXml.Guardar(serializadoraXml.RutaArchivoXml, CentralAdministradora.ListaDeClientes);
                estadisticasDeLosServicios.Guardar(estadisticasDeLosServicios.RutaSerializarJson, estadisticasDeLosServicios);
                estadisticasDeLosServicios.calcularCantidadDeOperacionesQueSeRealizaron();
                estadisticasDeLosServicios.actualizarCantidadDeGenteActivaYnoActiva();
                MessageBox.Show("Datos guardados exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FallaDeArchivoException ex)
            {
                MessageBox.Show($"{ex.Message}", "Excepcion controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Excepcion controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void horaYFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }


        /// <summary>
        /// Evento que se producira al tocar el boton de sucursales, al producirse el evento se instanciara y llamara al form de sucursales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSucursales_Click(object sender, EventArgs e)
        {
            FormSucursal formularioDeSucursales = new FormSucursal();
            formularioDeSucursales.Show();
        }   

        /// <summary>
        /// Metodo encargado de incrementar la barra de progreso (Siempre y cuaando esta no llegue al maximo)
        /// </summary>
        /// <param name="barraDeProgreso"></param>
        /// <param name="informacionDelProgreso"></param>
        private void ComenzarProceso(ProgressBar barraDeProgreso, Label informacionDelProgreso, CancellationTokenSource cancelacion)
        {
            while (barraDeProgreso.Value < barraDeProgreso.Maximum && !cancelacion.IsCancellationRequested)
            {
                Thread.Sleep(tiempoDeEsperaRandom.Next(112, 150));
                AumentarBarra(barraDeProgreso, informacionDelProgreso, Task.CurrentId.ToString());
            }
        }

        /// <summary>
        /// Metodo que se encarga de aumentar la ProgressBar y actualiza el label 
        /// </summary>
        /// <param name="barraDeProgreso">ProgressBar que va a ir incrementando</param>
        /// <param name="labelInformacionDelProgreso">Label que marca el porcentaje de la barra</param>
        /// <param name="idHilo">Id del hilo que representa en que hilo esta</param>
        private void AumentarBarra(ProgressBar barraDeProgreso, Label labelInformacionDelProgreso, string idHilo)
        {
            if(InvokeRequired)
            {
                delegadoAumentarBarraProceso = AumentarBarra;
                object[] arrayObjParam = new object[] { barraDeProgreso, labelInformacionDelProgreso, idHilo };
                Invoke(delegadoAumentarBarraProceso, arrayObjParam);
            }
            else
            {
                barraDeProgreso.Increment(1);
                configuracionDeControles.Invoke();
                if(idHilo == "1")
                {
                    labelInformacionDelProgreso.Text = $"Cargando archivos XML - {barraDeProgreso.Value}% (Hilo N° {idHilo})"; 
                }
                else
                {
                    labelInformacionDelProgreso.Text = $"Cargando archivos TXT - {barraDeProgreso.Value}% (Hilo N° {idHilo})"; 
                }
            }
        }

        /// <summary>
        /// Metodo encargado de configurar los controles del formulario.
        /// </summary>
        private void ConfiguracionControles()
        {
            
            if(progressBarTxt.Value < progressBarTxt.Maximum && progressBarXml.Value < progressBarXml.Maximum)
            {
                btnAlta.Enabled = false;
                btnAlta.ForeColor = Color.Black;
                btnAlta.BackColor = Color.White;

                btnDarDeBaja.Enabled = false;
                btnDarDeBaja.ForeColor = Color.Black;
                btnDarDeBaja.BackColor = Color.White;

                btnHistorial.Enabled = false;
                btnHistorial.ForeColor = Color.Black;
                btnHistorial.BackColor = Color.White;

                btnModificar.Enabled = false;
                btnModificar.ForeColor = Color.Black;
                btnModificar.BackColor = Color.White;

                btnMostrarClientes.Enabled = false;
                btnMostrarClientes.ForeColor = Color.Black;
                btnMostrarClientes.BackColor = Color.White;
                btnQuitarBarras.Visible = false;
            }
            else if (progressBarTxt.Value==progressBarTxt.Maximum && progressBarXml.Value == progressBarXml.Maximum)
            {
                MessageBox.Show("Se cargaron correctamente los archivos txt y xml:\n- Ya tiene habilitados los botones que necesitaban de estos archivos (Alta/baja/modificacion/mostrar)",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnQuitarBarras.Visible = true;
                btnAlta.Enabled = true;
                btnAlta.ForeColor = Color.Transparent;
                btnAlta.BackColor = Color.FromArgb(1, 16, 59);

                btnDarDeBaja.Enabled = true;
                btnDarDeBaja.ForeColor = Color.Transparent;
                btnDarDeBaja.BackColor = Color.FromArgb(1, 16, 59);

                btnHistorial.Enabled = true;
                btnHistorial.ForeColor = Color.Transparent;
                btnHistorial.BackColor = Color.FromArgb(1, 16, 59);

                btnModificar.Enabled = true;
                btnModificar.ForeColor = Color.Transparent;
                btnModificar.BackColor = Color.FromArgb(1, 16, 59);

                btnMostrarClientes.Enabled = true;
                btnMostrarClientes.ForeColor = Color.Transparent;
                btnMostrarClientes.BackColor = Color.FromArgb(1, 16, 59);

                lblInforBarra.Visible = false;
                lblInfoProgesoBtnAlta.Visible = false;
                lblInfoProgesoBtnBaja.Visible = false;
                lblInfoProgesoBtnHistorial.Visible = false;
                lblInfoProgesoBtnModificar.Visible = false;
                lblInfoProgesoBtnMostrar.Visible = false;
            }
        }

        /// <summary>
        /// Evento que se producira al tocar el boton de quitar barras, al producirse el evento se quitaran las barras del form principal con sus respectivos
        /// Label y se redimensionara el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitarBarras_Click(object sender, EventArgs e)
        {
            progressBarTxt.Visible = false;
            progressBarXml.Visible = false;
            lblBarraProgresoTxt.Visible = false;
            lblBarraProgresoXml.Visible = false;

            this.Size = new Size(937, 512);
        }
    }
}
