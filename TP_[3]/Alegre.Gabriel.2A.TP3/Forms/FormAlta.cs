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
    public partial class FormAlta : Form
    {
        private int dni;
        private PlanBasico planBasico;
        private PlanIntermedio planIntermedio;
        private PlanPremium planPremium;
        private CentralAdministradora servidorDeClientes;
        private EstadisticaServicios estadisticasDeLosServicios;

        /// <summary>
        /// Constructor encargado de inicializar los atributos del form y personalizar las propiedades de los controles utilizados en el form
        /// </summary>
        /// <param name="centralDeServicios">Objeto de tipo CentralAdministradora</param>
        /// <param name="dniIngresado">Dni ingresado</param>
        /// <param name="estadisticaDeLosServicios">Objeto de tipo EstadisticaServicios para poder contar las acciones realizadas</param>
        public FormAlta(CentralAdministradora centralDeServicios, int dniIngresado, EstadisticaServicios estadisticaDeLosServicios)
        {
            InitializeComponent();
            this.estadisticasDeLosServicios = estadisticaDeLosServicios;
            this.dni = dniIngresado;
            this.planBasico = new PlanBasico();
            this.planIntermedio = new PlanIntermedio();
            this.planPremium = new PlanPremium();
            this.servidorDeClientes = centralDeServicios;
            this.btnAltaServico.Enabled = false;
            this.txtDni.Text = dniIngresado.ToString();
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAlta_Load(object sender, EventArgs e)
        {
            rbnPlanBasico.Checked = true;
            lblNumeroDeCliente.Text = "Numero de cliente asignado: " + CentralAdministradora.ProximoNumeroDeCliente().ToString();
        }

        /// <summary>
        /// Evento click del boton cancelar, se cierra el formulario de alta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento click del boton dar de alta, donde se instancia un cliente con los datos ingresados y se agrega a la lista de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaServico_Click(object sender, EventArgs e)
        {
            Cliente unCliente = new Cliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, dni, PlanElegido());

            MessageBox.Show("Se dio de alta al siguiente cliente:\n" + unCliente.ToString(), "Alta correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            servidorDeClientes.agregarCliente(unCliente);
            estadisticasDeLosServicios.CantidadDeAltas += 1;
        }

        /// <summary>
        /// Metodo encargado de verificar que plan eligio y lo retornara
        /// </summary>
        /// <returns>El plan elegido</returns>
        private Plan PlanElegido()
        {
            Plan planEligido = planBasico;

            if (rbnPlanIntermedio.Checked == true)
            {
                planEligido = planIntermedio;
            }

            if (rbnPlanPremium.Checked == true)
            {
                planEligido = planPremium;
            }

            return planEligido;
        }

        /// <summary>
        /// Metodo encargado de verificar que no se deje ningun textBox vacio, en caso de que se haya dejado uno vacio no se permitira el alta
        /// </summary>
        private void VerificacionQueNoHayaCamposVacios()
        {
            if (String.IsNullOrEmpty(txtNombre.Text) || String.IsNullOrEmpty(txtApellido.Text) || String.IsNullOrEmpty(txtDireccion.Text))
            {
                btnAltaServico.Enabled = false;
                label1.Visible = true;
            }
            else
            {
                btnAltaServico.Enabled = true;
                label1.Visible = false;
            }
        }

        /// <summary>
        /// Metodo encargado de verificar que el caracter ingresado sea una letra, en caso de no ser una letra avisara en forma de error con un messegeBox
        /// </summary>
        /// <param name="textoMessageBox">string que contendra el mensaje del MessageBox</param>
        /// <param name="e">Caracter a validar</param>
        public static void soloString(string textoMessageBox, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(textoMessageBox, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Metodo encargado de verificar que el caracter ingresado sea una letra o un numero, en caso de no serlo avisara en forma de error con un messegeBox
        /// </summary>
        /// <param name="textoMessageBox"></param>
        /// <param name="e"></param>
        public static void ValidacionDireccion(string textoMessageBox, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show(textoMessageBox, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento TextChanged del txtNombre que se genera cuando el contenido del cuadro de texto cambia y verifica que no este vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.VerificacionQueNoHayaCamposVacios();
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea una letra, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloString("No se puede ingresar numeros o simbolos en el Nombre!", e);
        }

        /// <summary>
        /// Evento TextChanged del txtApellido que se genera cuando el contenido del cuadro de texto cambia y verifica que no este vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            this.VerificacionQueNoHayaCamposVacios();
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea una letra, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloString("No se puede ingresar numeros o simbolos en el Apellido!", e);
        }

        /// <summary>
        /// Evento TextChanged del txtDireccion que se genera cuando el contenido del cuadro de texto cambia y verifica que no este vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            this.VerificacionQueNoHayaCamposVacios();
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea un caracter valido, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionDireccion("No se pueden ingresar simbolos en la direccion", e);
        }

        /// <summary>
        /// Evento que verifica y se encarga de que si se selecciona el radio button de plan basico muestre los datos de este
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnPlanBasico_CheckedChanged(object sender, EventArgs e)
        {
            rtbDatosDelPlan.Text = planBasico.MostarDatosDelPlan();
        }

        /// <summary>
        /// Evento que verifica y se encarga de que si se selecciona el radio button de plan intermedio muestre los datos de este
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnPlanIntermedio_CheckedChanged(object sender, EventArgs e)
        {
            rtbDatosDelPlan.Text = planIntermedio.MostarDatosDelPlan();
        }

        /// <summary>
        /// Evento que verifica y se encarga de que si se selecciona el radio button de plan premium muestre los datos de este
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnPlanPremium_CheckedChanged(object sender, EventArgs e)
        {
            rtbDatosDelPlan.Text = planPremium.MostarDatosDelPlan();
        }

    }
}