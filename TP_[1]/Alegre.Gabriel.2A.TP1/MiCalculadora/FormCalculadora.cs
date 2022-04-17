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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que se encargara de borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = string.Empty;
            txtNumero2.Text = "";
            cmbOperador.SelectedIndex = 0;
            lblResultado.Text = "";
        }

        /// <summary>
        /// Metodo que se encarga de operar entre dos numeros.
        /// </summary>
        /// <param name="numero1">Valor del primer operando.</param>
        /// <param name="numero2">Valor del segundo operando.</param>
        /// <param name="operador">Operando que representa que operacion realizar.</param>
        /// <returns>Valor double que representa el resultado de la operacion elegida.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), char.Parse(operador));
        }

        /// <summary>
        /// Evento que dispara al momento de presionar el boton operar. 
        /// Se encarga de realizar una operacion y de reflejar el resultado de esta en el Formuladio y en historial.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string resultado;
            double primerOperando = 0;
            double segundoOperando = 0;
            double.TryParse(txtNumero1.Text.Replace(".", ","), out primerOperando);
            double.TryParse(txtNumero2.Text.Replace(".", ","), out segundoOperando);

            if (cmbOperador.Text == "")
            {
                cmbOperador.SelectedIndex = 1;
            }

            resultado = Operar(primerOperando.ToString(), segundoOperando.ToString(), cmbOperador.Text).ToString();

            if (double.Parse(resultado) == double.MinValue)
            {
                lblResultado.Text = "Error, no se puede dividir por 0";
            }
            else
            {
                lblResultado.Text = resultado;
            }

            lstOperaciones.Items.Add($"{primerOperando} {cmbOperador.Text} {segundoOperando} = {resultado}");

            if (txtNumero1.Text == "")
            {
                txtNumero1.Text = "0";
            }

            if (txtNumero2.Text == "")
            {
                txtNumero2.Text = "0";
            }
        }

        /// <summary>
        /// Borrará los datos de los TextBox, ComboBox y Label de la pantalla. 
        /// El evento da lugar cuando el usuario aprete el boton limpiar.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento para cerrar el formulario.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento click del botón btnConvertirABinario, convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != string.Empty)
            {
                lblResultado.Text = Operando.DecimalBinario(lblResultado.Text);
            }
            else
            {
                lblResultado.Text = "No hay un resultado a convertir";
            }
        }

        /// <summary>
        /// Evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (lblResultado.Text != "")
            {
                lblResultado.Text = Operando.BinarioDecimal(lblResultado.Text);
            }
            else
            {
                lblResultado.Text = "No hay un resultado a convertir";
            }
        }

        /// <summary>
        /// Evento que se dara lugar cuando el usuario quiera cerrar el formulario. Este evento se encarga de reafirmar la voluntad de cierre atraves de una pregunta de confirmacion.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirmaIrse = MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirmaIrse == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Evento que se produce antes de que se muestre el formulario por primera vez.
        /// Se encarga de cargar los datos del combo box y en limpiar el formulario.
        /// </summary>
        /// <param name="sender">Objeto que representa a quien provoco la accion.</param>
        /// <param name="e">Parameto que contiene data del evento, es decir, proveen algunos atributos para realizar alguna accion en el evento.</param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            Limpiar();
        }
    }
}
