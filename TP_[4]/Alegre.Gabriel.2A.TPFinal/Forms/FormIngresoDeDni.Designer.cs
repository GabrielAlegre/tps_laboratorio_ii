
namespace Forms
{
    partial class FormIngresoDeDni
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
            this.lblInformacionBoton = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIngresarDni = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInformacionBoton
            // 
            this.lblInformacionBoton.AutoSize = true;
            this.lblInformacionBoton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInformacionBoton.ForeColor = System.Drawing.Color.White;
            this.lblInformacionBoton.Location = new System.Drawing.Point(190, 124);
            this.lblInformacionBoton.Name = "lblInformacionBoton";
            this.lblInformacionBoton.Size = new System.Drawing.Size(202, 17);
            this.lblInformacionBoton.TabIndex = 9;
            this.lblInformacionBoton.Text = "Ingrese el dni para activar el boton";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.ForeColor = System.Drawing.Color.Transparent;
            this.lblTexto.Location = new System.Drawing.Point(13, 15);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(64, 28);
            this.lblTexto.TabIndex = 8;
            this.lblTexto.Text = "Texto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(395, 144);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(169, 29);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnIngresarDni
            // 
            this.btnIngresarDni.BackColor = System.Drawing.Color.White;
            this.btnIngresarDni.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnIngresarDni.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnIngresarDni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresarDni.Location = new System.Drawing.Point(203, 144);
            this.btnIngresarDni.Name = "btnIngresarDni";
            this.btnIngresarDni.Size = new System.Drawing.Size(169, 29);
            this.btnIngresarDni.TabIndex = 6;
            this.btnIngresarDni.Text = "Ingresar DNI";
            this.btnIngresarDni.UseVisualStyleBackColor = false;
            this.btnIngresarDni.Click += new System.EventHandler(this.btnIngresarDni_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(24, 84);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "Ingrese DNI";
            this.txtDni.Size = new System.Drawing.Size(540, 27);
            this.txtDni.TabIndex = 5;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // FormIngresoDeDni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(577, 188);
            this.Controls.Add(this.lblInformacionBoton);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIngresarDni);
            this.Controls.Add(this.txtDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIngresoDeDni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese DNI";
            this.Load += new System.EventHandler(this.FormIngresoDeDni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacionBoton;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIngresarDni;
        private System.Windows.Forms.TextBox txtDni;
    }
}