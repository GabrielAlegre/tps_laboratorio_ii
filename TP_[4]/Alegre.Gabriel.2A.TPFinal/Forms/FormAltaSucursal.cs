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
    public partial class FormAltaSucursal : Form
    {
        /// <summary>
        /// Constructor encargado de inicializar los atributos del form y personalizar las propiedades de los controles utilizados en el form
        /// </summary>
        public FormAltaSucursal()
        {
            InitializeComponent();
            btnAltaSucursal.Enabled = false;
        }

        /// <summary>
        /// Metodo encargado de agregar al ComboBox todas las provincias de argentina apartir de un enumerado
        /// </summary>
        private void CargarCombo()
        {
            foreach (EProvinciasArgentinas unaProvincia in Enum.GetValues(typeof(EProvinciasArgentinas)))
            {
                cmbProvincias.Items.Add(FormSucursal.ValidarProvincia(unaProvincia));
            }
        }

        /// <summary>
        /// Evento click del boton  alta, donde se instancia una sucursal con los datos ingresados y luego se agrega a la base de datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaServico_Click(object sender, EventArgs e)
        {
            Sucursal sucursalNueva = new Sucursal(cmbProvincias.SelectedItem.ToString(), txtLocalidad.Text, txtDireccion.Text, txtTelefono.Text);
            DialogResult rta = MessageBox.Show($"Esta seguro que quiere agregar la siguiente sucursal a la base de datos:\n\n {sucursalNueva}",
                "Esperando respuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(rta == DialogResult.Yes)
            {
                try
                {
                    SqlSucursalesClass.GuardarSucursal(sucursalNueva);
                    MessageBox.Show("Se agrego correctamente la sucursal a la base de datos");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ups, ocurrio un error a la hora de agregar una sucursal a la base de datos\n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo correctamente la agregacion de la sucursal a la base de datos");
                this.Close();
            }
        }

        /// <summary>
        /// Evento load del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAltaSucursal_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cmbProvincias.SelectedIndex = 0;
        }

        /// <summary>
        /// Evento TextChanged del txtLocalidad que se genera cuando el contenido del cuadro de texto cambia y verifica que no este vacio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            this.VerificacionQueNoHayaCamposVacios();
        }

        /// <summary>
        /// Evento TextChanged del txtDireccion que se genera cuando el contenido del cuadro de texto cambia y verifica que no este vacio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            this.VerificacionQueNoHayaCamposVacios();
        }

        /// <summary>
        /// Evento TextChanged del txtTelefono que se genera cuando el contenido del cuadro de texto cambia y verifica que no este vacio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            this.VerificacionQueNoHayaCamposVacios();
        }

        /// <summary>
        /// Metodo encargado de verificar que no se deje ningun textBox vacio, en caso de que se haya dejado uno vacio se desactivara el boton de alta, imposibilitando asi dicha alta
        /// </summary>
        private void VerificacionQueNoHayaCamposVacios()
        {
            if (txtDireccion.Text.IsNullOrEmptyMultiple(txtLocalidad.Text, txtTelefono.Text))
            {
                btnAltaSucursal.Enabled = false;
                lblInfo.Visible = true;
            }
            else
            {
                btnAltaSucursal.Enabled = true;
                lblInfo.Visible = false;
            }
        }
        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea una letra, en caso de no serlo se informara el de error con un messegeBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormAlta.soloString("No se puede ingresar numeros o simbolos en la localidad!", e);
        }

        /// <summary>
        /// Evento que se produce cada vez que se presiona una tecla y valida que el caracter ingresado sea un caracter valido, en caso de no serlo se informara el de error con un messegeBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormAlta.ValidacionDireccion("No se puede ingresar simbolos en la direccion!", e);
        }

        /// <summary>
        /// Evento que valida los caractes ingresados, en caso de no ser un numero avisara en forma de error con un messegeBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("No se pueden ingresar caracteres en el telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Evento click del boton cancelar, se cierra el formulario de alta sucursal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
