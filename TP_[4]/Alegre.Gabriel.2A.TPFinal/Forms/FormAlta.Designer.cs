
namespace Forms
{
    partial class FormAlta
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
            this.components = new System.ComponentModel.Container();
            this.lblNumeroDeCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAltaServico = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbDatosDelPlan = new System.Windows.Forms.RichTextBox();
            this.rbnPlanIntermedio = new System.Windows.Forms.RadioButton();
            this.rbnPlanPremium = new System.Windows.Forms.RadioButton();
            this.rbnPlanBasico = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.toolTipParaDatos = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumeroDeCliente
            // 
            this.lblNumeroDeCliente.AutoSize = true;
            this.lblNumeroDeCliente.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNumeroDeCliente.Location = new System.Drawing.Point(248, 12);
            this.lblNumeroDeCliente.Name = "lblNumeroDeCliente";
            this.lblNumeroDeCliente.Size = new System.Drawing.Size(110, 13);
            this.lblNumeroDeCliente.TabIndex = 29;
            this.lblNumeroDeCliente.Text = "Numero de cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Para dar de alta no debe haber campos vacios";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(15, 176);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(99, 15);
            this.lblDni.TabIndex = 27;
            this.lblDni.Text = "Dni ingresado";
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(17, 193);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.MaxLength = 20;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(456, 23);
            this.txtDni.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(239, 480);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(234, 22);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.toolTipParaDatos.SetToolTip(this.BtnCancelar, "Cancelar el alta");
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAltaServico
            // 
            this.btnAltaServico.BackColor = System.Drawing.Color.White;
            this.btnAltaServico.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAltaServico.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAltaServico.ForeColor = System.Drawing.Color.Black;
            this.btnAltaServico.Location = new System.Drawing.Point(12, 480);
            this.btnAltaServico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaServico.Name = "btnAltaServico";
            this.btnAltaServico.Size = new System.Drawing.Size(216, 22);
            this.btnAltaServico.TabIndex = 8;
            this.btnAltaServico.Text = "Confirmar alta";
            this.btnAltaServico.UseVisualStyleBackColor = false;
            this.btnAltaServico.Click += new System.EventHandler(this.btnAltaServico_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.rtbDatosDelPlan);
            this.groupBox1.Controls.Add(this.rbnPlanIntermedio);
            this.groupBox1.Controls.Add(this.rbnPlanPremium);
            this.groupBox1.Controls.Add(this.rbnPlanBasico);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 230);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 223);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes disponibles";
            // 
            // rtbDatosDelPlan
            // 
            this.rtbDatosDelPlan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbDatosDelPlan.Location = new System.Drawing.Point(133, 14);
            this.rtbDatosDelPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDatosDelPlan.Name = "rtbDatosDelPlan";
            this.rtbDatosDelPlan.ReadOnly = true;
            this.rtbDatosDelPlan.Size = new System.Drawing.Size(317, 188);
            this.rtbDatosDelPlan.TabIndex = 3;
            this.rtbDatosDelPlan.Text = "";
            // 
            // rbnPlanIntermedio
            // 
            this.rbnPlanIntermedio.AutoSize = true;
            this.rbnPlanIntermedio.Location = new System.Drawing.Point(8, 108);
            this.rbnPlanIntermedio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnPlanIntermedio.Name = "rbnPlanIntermedio";
            this.rbnPlanIntermedio.Size = new System.Drawing.Size(109, 19);
            this.rbnPlanIntermedio.TabIndex = 6;
            this.rbnPlanIntermedio.TabStop = true;
            this.rbnPlanIntermedio.Text = "Plan intermedio";
            this.rbnPlanIntermedio.UseVisualStyleBackColor = true;
            this.rbnPlanIntermedio.CheckedChanged += new System.EventHandler(this.rbnPlanIntermedio_CheckedChanged);
            // 
            // rbnPlanPremium
            // 
            this.rbnPlanPremium.AutoSize = true;
            this.rbnPlanPremium.BackColor = System.Drawing.Color.Transparent;
            this.rbnPlanPremium.Location = new System.Drawing.Point(8, 164);
            this.rbnPlanPremium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnPlanPremium.Name = "rbnPlanPremium";
            this.rbnPlanPremium.Size = new System.Drawing.Size(100, 19);
            this.rbnPlanPremium.TabIndex = 7;
            this.rbnPlanPremium.TabStop = true;
            this.rbnPlanPremium.Text = "Plan premium";
            this.rbnPlanPremium.UseVisualStyleBackColor = false;
            this.rbnPlanPremium.CheckedChanged += new System.EventHandler(this.rbnPlanPremium_CheckedChanged);
            // 
            // rbnPlanBasico
            // 
            this.rbnPlanBasico.AutoSize = true;
            this.rbnPlanBasico.Location = new System.Drawing.Point(8, 46);
            this.rbnPlanBasico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbnPlanBasico.Name = "rbnPlanBasico";
            this.rbnPlanBasico.Size = new System.Drawing.Size(85, 19);
            this.rbnPlanBasico.TabIndex = 5;
            this.rbnPlanBasico.TabStop = true;
            this.rbnPlanBasico.Text = "Plan basico";
            this.rbnPlanBasico.UseVisualStyleBackColor = true;
            this.rbnPlanBasico.CheckedChanged += new System.EventHandler(this.rbnPlanBasico_CheckedChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(15, 141);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Ingrese direccion del cliente";
            this.txtDireccion.Size = new System.Drawing.Size(456, 23);
            this.txtDireccion.TabIndex = 3;
            this.toolTipParaDatos.SetToolTip(this.txtDireccion, "Por ejemplo: Calle falsa 123");
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(15, 89);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese apellido del cliente";
            this.txtApellido.Size = new System.Drawing.Size(456, 23);
            this.txtApellido.TabIndex = 2;
            this.toolTipParaDatos.SetToolTip(this.txtApellido, "Por ejemplo: Doe");
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(15, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese nombre del cliente";
            this.txtNombre.Size = new System.Drawing.Size(456, 23);
            this.txtNombre.TabIndex = 1;
            this.toolTipParaDatos.SetToolTip(this.txtNombre, "Por ejemplo: John");
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(15, 124);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 15);
            this.lblDireccion.TabIndex = 19;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(13, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 15);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(15, 73);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 15);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(480, 513);
            this.Controls.Add(this.lblNumeroDeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAltaServico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta de cliente";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroDeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ToolTip toolTipParaDatos;
        private System.Windows.Forms.Button btnAltaServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbDatosDelPlan;
        private System.Windows.Forms.RadioButton rbnPlanIntermedio;
        private System.Windows.Forms.RadioButton rbnPlanPremium;
        private System.Windows.Forms.RadioButton rbnPlanBasico;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
    }
}