using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        /// <summary>
        /// Constructor encargado de inicializar los atributos del form
        /// </summary>
        public FormPrincipalMenu()
        {
            InitializeComponent();
            this.centralServicio = new CentralAdministradora();
            this.serializadoraXml = new ClaseSerializadoraXml();
            this.estadisticasDeLosServicios = new EstadisticaServicios();
        }

        /// <summary>
        /// Evento load del formulario, donde se levantaran todos los datos de los archivos xml y json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPrincipalMenu_Load(object sender, EventArgs e)
        {
            Deserializar();
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
    }
}
