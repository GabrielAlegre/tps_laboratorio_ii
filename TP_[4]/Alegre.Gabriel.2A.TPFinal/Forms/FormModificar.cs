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
    public partial class FormModificar : Form
    {
        private Cliente ClienteSinModificacionesAplicadas;
        private string mensajeMessageBox;
        private string datosDelClienteSinModificar;

        /// <summary>
        /// Constructor encargado de inicializar los atributos del form y personalizar las propiedades de los controles utilizados en el form
        /// </summary>
        /// <param name="ClienteParaModificar">"Cliente que se le modificaran los datos"</param>
        /// <param name="textoLabel">texto que se le pondra al label</param>
        /// <param name="textoBoton">Texto del boton</param>
        public FormModificar(Cliente ClienteParaModificar, string textoLabel, string textoBoton)
        {
            InitializeComponent();
            this.ClienteSinModificacionesAplicadas = ClienteParaModificar;
            this.lblTexto.Text = textoLabel;
            this.btnModificar.Text = textoBoton;
            this.txtApellido.Text = ClienteParaModificar.Apellido;
            this.txtNombre.Text = ClienteParaModificar.Nombre;
            this.txtDireccion.Text = ClienteParaModificar.DireccionDelDomicilio;
            this.txtDni.Text = ClienteParaModificar.Dni.ToString();
            this.rbnPlanBasico.Checked = ClienteParaModificar.PlanEligido is PlanBasico;
            this.rbnPlanIntermedio.Checked = ClienteParaModificar.PlanEligido is PlanIntermedio;
            this.rbnPlanPremium.Checked = ClienteParaModificar.PlanEligido is PlanPremium;
            this.mensajeMessageBox = string.Empty;
            this.datosDelClienteSinModificar = ClienteSinModificacionesAplicadas.ToString();
            this.rbMostrarClienteOriginar.Checked = true;
        }

        /// <summary>
        /// En caso de que efectivamente se halla modificado algun dato sé preguntara si esta seguro de la modificacion, si la rta es si, se hara la modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteAux = AplicarModificaciones();
            if (clienteAux is not null)
            {
                DialogResult rta = MessageBox.Show(mensajeMessageBox, "Se espera respuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rta == DialogResult.Yes)
                {
                    RemplazarDatosDelCliente(clienteAux, ClienteSinModificacionesAplicadas);
                    MessageBox.Show("Modificacion exitosa");
                }
                else if (rta == DialogResult.No)
                {
                    MessageBox.Show("Se cancelo la modificacion");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                MessageBox.Show("No se realizo ninguna modificacion ya que no modifico ningun dato del cliente ");
                this.DialogResult = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Metodo que se encarga de remplazara los datos de un cliente por otro los datos de otro
        /// </summary>
        /// <param name="clienteConLosDatosModificados">Cliente que contendra los datos modificados</param>
        /// <param name="clienteQueVaSerModificado">Cliente al cual se le aplicaran dichos datos modificados</param>
        private void RemplazarDatosDelCliente(Cliente clienteConLosDatosModificados, Cliente clienteQueVaSerModificado)
        {
            clienteQueVaSerModificado.Apellido = clienteConLosDatosModificados.Apellido;
            clienteQueVaSerModificado.Nombre = clienteConLosDatosModificados.Nombre;
            clienteQueVaSerModificado.DireccionDelDomicilio = clienteConLosDatosModificados.DireccionDelDomicilio;
            clienteQueVaSerModificado.PlanEligido = clienteConLosDatosModificados.PlanEligido;
        }

        /// <summary>
        /// Metodo que verifica si realmente se modifico algo y en caso de ser asi se guardara en una string un mensaje con los datos que se modificaron
        /// </summary>
        /// <returns>Si realmente se modifico un dato se retorna Un cliente auxiliar con los datos modificados, en caso contrario se retorna null</returns>
        public Cliente AplicarModificaciones()
        {
            bool seModificoAlgo = false;
            Plan planElegido = PlanElegido();
            Cliente clienteAux = new Cliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, int.Parse(txtDni.Text), planElegido);
            clienteAux.NumeroDeCliente = ClienteSinModificacionesAplicadas.NumeroDeCliente;
            mensajeMessageBox = "Esta seguro que desea modificar los siguientes datos del cliente:\n";
            if (ClienteSinModificacionesAplicadas.Nombre != txtNombre.Text)
            {
                clienteAux.Nombre = txtNombre.Text;
                mensajeMessageBox += $"- Nombre: {txtNombre.Text} por {ClienteSinModificacionesAplicadas.Nombre}\n";
                seModificoAlgo = true;
            }

            if (ClienteSinModificacionesAplicadas.Apellido != txtApellido.Text)
            {
                mensajeMessageBox += $"- Apellido: {txtApellido.Text} por {ClienteSinModificacionesAplicadas.Apellido}\n";
                clienteAux.Apellido = txtApellido.Text;
                seModificoAlgo = true;

            }

            if (ClienteSinModificacionesAplicadas.DireccionDelDomicilio != txtDireccion.Text)
            {
                mensajeMessageBox += $"- Domicilio: {txtDireccion.Text} por {ClienteSinModificacionesAplicadas.DireccionDelDomicilio}\n";
                clienteAux.DireccionDelDomicilio = txtDireccion.Text;
                seModificoAlgo = true;
            }

            if (ClienteSinModificacionesAplicadas.PlanEligido.GetType().Name != planElegido.GetType().Name)
            {
                mensajeMessageBox += $"- Plan: {planElegido.GetType().Name} por {ClienteSinModificacionesAplicadas.PlanEligido.GetType().Name}\n";
                clienteAux.PlanEligido = planElegido;
                seModificoAlgo = true;
            }

            if (!seModificoAlgo)
            {
                return null;
            }
            else
            {
                return clienteAux;
            }
        }

        /// <summary>
        /// Metodo encargado de verificar que plan se eligio y lo retornara
        /// </summary>
        /// <returns>El plan elegido</returns>
        private Plan PlanElegido()
        {
            Plan planEligido = null;

            if (rbnPlanBasico.Checked == true)
            {
                planEligido = new PlanBasico();
            }

            if (rbnPlanIntermedio.Checked == true)
            {
                planEligido = new PlanIntermedio();
            }

            if (rbnPlanPremium.Checked == true)
            {
                planEligido = new PlanPremium();
            }

            return planEligido;
        }

        /// <summary>
        /// Metodo encargado de verificar que no se deje ningun textBox vacio, en caso de que se haya dejado uno vacio no se permitira la modificacion
        /// </summary>
        private void NoHayCamposVacios()
        {
            if (txtNombre.Text.IsNullOrEmptyMultiple(txtApellido.Text, txtDireccion.Text))
            {
                btnModificar.Enabled = false;
                lblBotonModificar.Visible = true;
            }
            else
            {
                btnModificar.Enabled = true;
                lblBotonModificar.Visible = false;
            }
        }

        /// <summary>
        /// Evento click del boton cancelar, se cierra el formulario de modificacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo la modificacion");
            this.Close();
        }

        /// <summary>
        /// Evento TextChanged del txtNombre que se genera cuando el contenido del cuadro de texto cambia y verifica que este txt no este vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            this.NoHayCamposVacios();
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea una letra, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormAlta.soloString("No se puede ingresar numeros o simbolos en el Nombre!", e);
        }

        /// <summary>
        /// Evento TextChanged del txtApellido que se genera cuando el contenido del cuadro de texto cambia y verifica que este txt no este vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            this.NoHayCamposVacios();
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea una letra, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormAlta.soloString("No se puede ingresar numeros o simbolos en el Nombre!", e);
        }

        /// <summary>
        /// Evento TextChanged del txtDireccion que se genera cuando el contenido del cuadro de texto cambia y verifica que este txt no este vacio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            this.NoHayCamposVacios();
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea un caracter valido, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormAlta.ValidacionDireccion("No se puede ingresar numeros en el Nombre!", e);
        }

        /// <summary>
        /// Evento que se encarga de verificar cual plan seleccionado y si coincide con el que tiene el cliente se pone visible un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnPlanBasico_CheckedChanged(object sender, EventArgs e)
        {
            if (ClienteSinModificacionesAplicadas.PlanEligido is PlanBasico)
            {
                lblPlanes.Visible = true;
            }
            else
            {
                lblPlanes.Visible = false;
            }
        }

        /// <summary>
        /// Evento que se encarga de verificar cual plan seleccionado y si coincide con el que tiene el cliente se pone visible un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnPlanIntermedio_CheckedChanged(object sender, EventArgs e)
        {
            if (ClienteSinModificacionesAplicadas.PlanEligido is PlanIntermedio)
            {
                lblPlanes.Visible = true;
            }
            else
            {
                lblPlanes.Visible = false;
            }
        }

        /// <summary>
        /// Evento que se encarga de verificar cual plan seleccionado y si coincide con el que tiene el cliente se pone visible un mensaje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnPlanPremium_CheckedChanged(object sender, EventArgs e)
        {
            if (ClienteSinModificacionesAplicadas.PlanEligido is PlanPremium)
            {
                lblPlanes.Visible = true;
            }
            else
            {
                lblPlanes.Visible = false;
            }
        }

        /// <summary>
        /// Evento que se encarga en que cada vez que se selecciona el radio button rbMostrarClienteOriginar se muestren los datos del cliente sin modificar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMostrarClienteOriginar_CheckedChanged(object sender, EventArgs e)
        {
            rtbDatosDelCliente.Text = datosDelClienteSinModificar;
        }

        /// <summary>
        /// Evento que se encarga en que cada vez que se selecciona el radio button rbMostrarClienteOriginar se muestren los datos del cliente modificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbMostrarClienteModificado_CheckedChanged(object sender, EventArgs e)
        {
            Cliente clienteModificacion = AplicarModificaciones();
            if (clienteModificacion is not null)
            {
                rtbDatosDelCliente.Text = clienteModificacion.ToString();

            }
            else
            {
                rtbDatosDelCliente.Text = "No se modifico nada";
            }
        }
    }
}
