
namespace Forms
{
    partial class FormMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbnClientesBaja = new System.Windows.Forms.RadioButton();
            this.rbnClientesActivos = new System.Windows.Forms.RadioButton();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rbnClientesBaja
            // 
            this.rbnClientesBaja.AutoSize = true;
            this.rbnClientesBaja.ForeColor = System.Drawing.Color.White;
            this.rbnClientesBaja.Location = new System.Drawing.Point(255, 578);
            this.rbnClientesBaja.Name = "rbnClientesBaja";
            this.rbnClientesBaja.Size = new System.Drawing.Size(320, 24);
            this.rbnClientesBaja.TabIndex = 9;
            this.rbnClientesBaja.TabStop = true;
            this.rbnClientesBaja.Text = "Mostrar clientes NO activos (dados de baja)";
            this.rbnClientesBaja.UseVisualStyleBackColor = true;
            this.rbnClientesBaja.CheckedChanged += new System.EventHandler(this.rbnClientesBaja_CheckedChanged);
            // 
            // rbnClientesActivos
            // 
            this.rbnClientesActivos.AutoSize = true;
            this.rbnClientesActivos.ForeColor = System.Drawing.Color.White;
            this.rbnClientesActivos.Location = new System.Drawing.Point(12, 578);
            this.rbnClientesActivos.Name = "rbnClientesActivos";
            this.rbnClientesActivos.Size = new System.Drawing.Size(185, 24);
            this.rbnClientesActivos.TabIndex = 8;
            this.rbnClientesActivos.TabStop = true;
            this.rbnClientesActivos.Text = "Mostrar clientes activos";
            this.rbnClientesActivos.UseVisualStyleBackColor = true;
            this.rbnClientesActivos.CheckedChanged += new System.EventHandler(this.rbnClientesActivos_CheckedChanged);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTexto.ForeColor = System.Drawing.Color.Transparent;
            this.lblTexto.Location = new System.Drawing.Point(12, 11);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(62, 21);
            this.lblTexto.TabIndex = 7;
            this.lblTexto.Text = "Texto";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnAceptar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.Transparent;
            this.btnAceptar.Location = new System.Drawing.Point(581, 569);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(276, 41);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(845, 505);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // FormMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(869, 620);
            this.Controls.Add(this.rbnClientesBaja);
            this.Controls.Add(this.rbnClientesActivos);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form mostrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnClientesBaja;
        private System.Windows.Forms.RadioButton rbnClientesActivos;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}