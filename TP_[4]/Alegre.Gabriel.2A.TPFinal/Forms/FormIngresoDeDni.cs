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

    public partial class FormIngresoDeDni : Form
    {
        private string texto;
        private int dni;
        private CentralAdministradora centralAdministradora;
        private EOpciones opcionAbm;
        private EstadisticaServicios estadisticasDeLosServicios;

        /// <summary>
        /// Constructor encargado de inicializar los atributos del form y personalizar las propiedades de los controles utilizados en el form
        /// </summary>
        /// <param name="textoForm">Texto que va a tener el form</param>
        /// <param name="opcionElegida">Enumerado que describe para que accion se va a usar el form (para dar de alta, dar de baja, modificar)</param>
        /// <param name="central">"Objeto de tipo CentralAdministradora"</param>
        public FormIngresoDeDni(string textoForm, EOpciones opcionElegida, CentralAdministradora central)
        {
            InitializeComponent();
            this.texto = textoForm;
            this.opcionAbm = opcionElegida;
            this.centralAdministradora = central;
            this.btnIngresarDni.Enabled = false;
        }

        /// <summary>
        /// Constructor encargado de "asociar" los metodos que se van a ejecutar cuando se invoque el evento
        /// </summary>
        static FormIngresoDeDni()
        {
            CentralAdministradora.EventAvisadorQueClienteNoExiste += MensajeAvisador;

            CentralAdministradora.EventAvisadorQueClienteExisteYEstaActivo += MensajeAvisador;

        }

        /// <summary>
        /// Sobrecarga del constructor encargado de inicializar los atributos del form y personalizar las propiedades de los controles utilizados en el form
        /// </summary>
        /// <param name="textoForm">Texto que va a tener el form</param>
        /// <param name="opcionElegida">Enumerado que describe para que accion se va a usar el form (para dar de alta, dar de baja, modificar)</param>
        /// <param name="central">"Objeto de tipo CentralAdministradora"</param>
        /// <param name="estadisticaServicio">"Objeto de tipo EstadisticaServicios para poder contar las acciones realizadas"</param>
        public FormIngresoDeDni(string textoForm, EOpciones opcionElegida, CentralAdministradora central, EstadisticaServicios estadisticaServicio)
            : this(textoForm, opcionElegida, central)
        {
            this.estadisticasDeLosServicios = estadisticaServicio;
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIngresoDeDni_Load(object sender, EventArgs e)
        {
            this.lblTexto.Text = texto;
        }

        public int ObtenerDniIngresado
        {
            get
            {
                return dni;
            }
        }

        /// <summary>
        /// Evento clic del btnIngresarDni, chequea para que accion se quiera utilizar el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarDni_Click(object sender, EventArgs e)
        {
            try
            {
                this.dni = int.Parse(txtDni.Text);
                switch (opcionAbm)
                {
                    case EOpciones.DarAlta:
                        this.opcionAlta();
                        break;
                    case EOpciones.DarBaja:
                        this.VerificarQueElClienteEsteActivoEnElSistema();
                        break;
                    case EOpciones.Modificar:
                        this.VerificarQueElClienteEsteActivoEnElSistema();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingreso un dni invalido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Metodo que se encarga de verificar de que el dni ingresado pertenezca a un cliente activo en el sistema
        /// dicho metodo sera utilizado en caso de que se quiera dar de baja o modificar
        /// </summary>
        private void VerificarQueElClienteEsteActivoEnElSistema()
        {
            try
            {
                if (CentralAdministradora.VerificarSiElClienteExisteYEstaActivoEnElSistema(dni))
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (NoExisteClienteActivoConElDniIngresadoException e)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(e.Message, "excepción (Propia) controlada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Metodo que sera utilizado en caso de que se quiera dar de alta (que apreten el boton de alta)
        /// Si el dni ingresado no pertenece a ningun cliente activo doy DialogResult.OK para que se abra el form de alta
        /// En caso de que el dni ingresado pertenezca a un cliente no activo (un cliente dado de baja) se llamara al metodo altaSiClienteEstaEnElSistemaPeroNoActivo que se encargara de dar el alta
        /// </summary>
        private void opcionAlta()
        {
            if (!CentralAdministradora.VerificarSiClienteEstaEnElSistema(dni))
            {

                this.DialogResult = DialogResult.OK;

            }
            else if (CentralAdministradora.BuscarClienteNoActivoEnLaLista(dni) is not null)
            {
                altaSiClienteEstaEnElSistemaPeroNoActivo();
            }
            else
            {
                MessageBox.Show("Este cliente ya esta activo en el sistema con un plan adquirido, si quiere, lo puede modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Metodo que se encarga de realizar el alta de un cliente no activo (un cliente dado de baja)
        /// sera utilizado en caso de que se quiera dar de alta (que apreten el boton de alta) y que el dni ingresado pertenezca a un cliente no activo (un cliente dado de baja)
        /// </summary>
        private void altaSiClienteEstaEnElSistemaPeroNoActivo()
        {
            Cliente clienteQuePasaraActivoNuevamente = CentralAdministradora.BuscarClienteNoActivoEnLaLista(dni);

            string MensajeMessegeBox = "Esta persona ya fue cliente de NetCom en el pasado\n" +
                "- Seleccione SI: para darla de alta con lo mismos datos que tenia cuando era cliente\n" +
                "- Seleccione NO: para darla de alta con algun dato modificado";

            DialogResult rta = MessageBox.Show(MensajeMessegeBox, "AVISO: Se espera respuesta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (rta == DialogResult.Yes)
            {
                PasarActivoUnClienteDadoDeBaja(clienteQuePasaraActivoNuevamente);
                MessageBox.Show("Se realizo la alta exitosamente");
                this.DialogResult = DialogResult.Cancel;
            }
            else if (rta == DialogResult.No)
            {
                FormModificar formModificador = new FormModificar(clienteQuePasaraActivoNuevamente,
                    "Estos son los datos que tenia el cliente cuando estaba activo en el\nsistema, modifique el dato que corresponda", "Dar alta");

                DialogResult confirmaAltaDelCliente = formModificador.ShowDialog();

                if (confirmaAltaDelCliente == DialogResult.OK)
                {
                    PasarActivoUnClienteDadoDeBaja(clienteQuePasaraActivoNuevamente);
                }
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Metodo encargado de dar el alta logica (pasar el EstaActivo a true) y guardar en el historial que se realizo el alta de un cliente no activo
        /// </summary>
        /// <param name="clienteQuaPasaraActivo">Cliente no activo que pasara a darse de alta</param>
        public void PasarActivoUnClienteDadoDeBaja(Cliente clienteQuaPasaraActivo)
        {
            string mensajeDelHistorial = $"{DateTime.Now:f}hs - Se realizo el alta de un cliente que anteriormente se habia dado de baja\n" +
                $"Llamado: {clienteQuaPasaraActivo.Nombre}\nCon DNI: {clienteQuaPasaraActivo.Dni}"; 
                
            clienteQuaPasaraActivo.EstaActivo = true;
            centralAdministradora.Guardar(centralAdministradora.Ruta, mensajeDelHistorial);
            estadisticasDeLosServicios.CantNoActivosQueSeVolvieronADarDeAlta += 1;
            estadisticasDeLosServicios.CantidadDeAltas += 1;
        }

        /// <summary>
        /// evento encargado de no permitir clickear el boton de ingresar dni cuando el txtDni este vacio o la cantidad de numeros que se ingresen se corresponda a un dni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDni.Text))
            {
                btnIngresarDni.Enabled = false;
                lblInformacionBoton.Visible = true;
            }
            else if (!txtDni.Text.EsDni())
            {
                btnIngresarDni.Enabled = false;
                lblInformacionBoton.Visible = true;
                lblInformacionBoton.Text = "  El DNI debe tener 7 u 8 numeros";
            }
            else
            {
                btnIngresarDni.Enabled = true;
                lblInformacionBoton.Visible = false;
            }
        }

        /// <summary>
        /// Evento que valida los caractes ingresados, en caso de no ser un numero avisara en forma de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se pueden ingresar caracteres en el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Al momento de ejecutarse los eventos "EventAvisadorQueClienteNoExiste" y "EventAvisadorQueClienteExisteYEstaActivo"
        /// se llamara a este metodo que se encarga de avisar lo sucedido atravez de un messegeBox
        /// </summary>
        /// <param name="mensaje">Mensaje que se dara</param>
        private static void MensajeAvisador(string mensaje)
        {
            MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
