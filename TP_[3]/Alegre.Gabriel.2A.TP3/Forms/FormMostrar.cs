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
    public partial class FormMostrar : Form
    {
        /// <summary>
        /// constructor que personaliza las propiedades de los controles utilizados en el form con lo que recibe por parametro
        /// </summary>
        /// <param name="ClienteParaModificar">"Cliente que se le modificaran los datos"</param>
        /// <param name="textoLabel">texto que se le pondra al label</param>
        /// <param name="textoBoton">Texto del boton</param>
        public FormMostrar(string tituloForm, string textoLabel)
        {
            InitializeComponent();
            this.Text = tituloForm;
            this.lblTexto.Text = textoLabel;
            this.rbnClientesActivos.Checked = true;
        }

        public FormMostrar(string tituloForm, string textoLabel, string textoRich):this(tituloForm, textoLabel)
        {
            this.richTextBox1.Text = textoRich;
            this.rbnClientesActivos.Visible = false;
            this.rbnClientesBaja.Visible = false;
        }

        /// <summary>
        /// Evento del boton click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Evento que sera producido si se selecciona el rbnClientesActivos y mostrara un listado de clientes activos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnClientesActivos_CheckedChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "Listado de clientes activos:\n" + CentralAdministradora.MostrarClientes(EClienteEstado.Activo);
        }
        /// <summary>
        /// Evento que sera producido si se selecciona el rbnClientesActivos y mostrara un listado de clientes NO activos (los clientes que se dieron de baja)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbnClientesBaja_CheckedChanged(object sender, EventArgs e)
        {
            string clientesNoActivos = CentralAdministradora.MostrarClientes(EClienteEstado.NoActivo);
            if(clientesNoActivos == string.Empty)
            {
                this.richTextBox1.Text = "Listado de clientes NO activos:\nActualmente no hay ningun cliente dado de baja en el sistema";
            }
            else
            {
                this.richTextBox1.Text = "Listado de clientes NO activos:\n" + clientesNoActivos;

            }
        }
    }
}
