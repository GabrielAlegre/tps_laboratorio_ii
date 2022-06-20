using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class FormSucursal : Form
    {
        public FormSucursal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo encargado de agregar al ComboBox todas las provincias de argentina apartir de un enumerado
        /// </summary>
        private void CargarCombo()
        {
            cmbProvincias.Items.Add("Todas");
            foreach (EProvinciasArgentinas unaProvincia in Enum.GetValues(typeof(EProvinciasArgentinas)))
            {
                cmbProvincias.Items.Add(ValidarProvincia(unaProvincia));
            }
        }

        /// <summary>
        /// Metodo encargado de Validar el nombre de la provincia, ya que lo hago apartir de un enumerado; si no hay espacio entre palabras se lo agrego
        /// </summary>
        /// <param name="provincia">Nombre de la provincia</param>
        /// <returns>La misma provincia recibida por parametro pero validada</returns>
        public static string ValidarProvincia(EProvinciasArgentinas provincia)
        {
            string nombreProvinciaValidada = null;
            foreach (char caracter in provincia.ToString())
            {
                if (char.IsUpper(caracter) && caracter != provincia.ToString()[0])
                {
                    nombreProvinciaValidada += ' ';
                    nombreProvinciaValidada += caracter;
                }
                else
                {
                    nombreProvinciaValidada += caracter;
                }
            }
            return nombreProvinciaValidada;
        }

        /// <summary>
        /// Evento load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSucursal_Load(object sender, EventArgs e)
        {
            CargarCombo();
            cmbProvincias.SelectedIndex = 0;
            actualizarDataGrid();
        }

        /// <summary>
        /// Evento que se cuando se modificada la propiedad SelectedIndex, es decir, cada vez que se seleccione una provincia del
        /// combo box y buscara en la base de datos todas las sucursales que coincidan con la provincia seleccionada 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtgvSucursales.DataSource = SqlSucursalesClass.Leer(cmbProvincias.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups, ocurrio un error a la hora de cargar las sucursales que se encuentran en la base de datos\n\n"+ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo encargado de actualizar el data grid
        /// </summary>
        private void actualizarDataGrid()
        {
            try
            {
                dtgvSucursales.DataSource = SqlSucursalesClass.Leer("Todas");
                dtgvSucursales.Update();
                dtgvSucursales.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups, ocurrio un error a la hora de cargar las sucursales que se encuentran en la base de datos\n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Evento click del boton EliminarSucursal, al presionarlo primero chequeara que se haya seleccionado una sucursal y en caso de ser asi la eliminara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarSucursal_Click(object sender, EventArgs e)
        {
            if(dtgvSucursales.SelectedRows.Count>0)
            {
                Sucursal sucusalQueSeEliminara = (Sucursal)dtgvSucursales.CurrentRow.DataBoundItem;
                string textoMessageBox = $"Esta seguro que desea eliminar a la sucursal con ID {sucusalQueSeEliminara.IdSucursal} que tiene los siguientes datos:" +
                    $"\n\n{sucusalQueSeEliminara.ToString()}";

                DialogResult rta = MessageBox.Show(textoMessageBox, "Se espera confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if(rta==DialogResult.Yes)
                {
                    try
                    {
                        SqlSucursalesClass.Eliminar(sucusalQueSeEliminara.IdSucursal);
                        MessageBox.Show("La sucursal fue eliminada de la base de datos correctamente");
                        actualizarDataGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ups, ocurrio un error a la hora de eliminar una sucursal de la base de datos\n\n" + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Se cancelo la baja correctamente");
                }
            }
        }

        /// <summary>
        /// Evento click del boton agregarSucursal, al presionarlo se llamara al formulario encargado de agregar una sucursal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSucursal_Click(object sender, EventArgs e)
        {
            FormAltaSucursal formDeAltaSucursal = new FormAltaSucursal();
            DialogResult resul= formDeAltaSucursal.ShowDialog();
            if(resul == DialogResult.OK)
            {
                actualizarDataGrid();
            }
        }

        /// <summary>
        /// evento click del boton salir, se cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
