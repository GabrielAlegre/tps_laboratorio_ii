
namespace Forms
{
    partial class FormModificar
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbDatosDelCliente = new System.Windows.Forms.RichTextBox();
            this.rbMostrarClienteModificado = new System.Windows.Forms.RadioButton();
            this.rbMostrarClienteOriginar = new System.Windows.Forms.RadioButton();
            this.lblPlanes = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblBotonModificar = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnPlanIntermedio = new System.Windows.Forms.RadioButton();
            this.rbnPlanPremium = new System.Windows.Forms.RadioButton();
            this.rbnPlanBasico = new System.Windows.Forms.RadioButton();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(50)))));
            this.groupBox2.Controls.Add(this.rtbDatosDelCliente);
            this.groupBox2.Controls.Add(this.rbMostrarClienteModificado);
            this.groupBox2.Controls.Add(this.rbMostrarClienteOriginar);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(499, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(466, 332);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "visibilidad";
            // 
            // rtbDatosDelCliente
            // 
            this.rtbDatosDelCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rtbDatosDelCliente.Location = new System.Drawing.Point(27, 72);
            this.rtbDatosDelCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDatosDelCliente.Name = "rtbDatosDelCliente";
            this.rtbDatosDelCliente.ReadOnly = true;
            this.rtbDatosDelCliente.Size = new System.Drawing.Size(422, 248);
            this.rtbDatosDelCliente.TabIndex = 33;
            this.rtbDatosDelCliente.Text = "";
            // 
            // rbMostrarClienteModificado
            // 
            this.rbMostrarClienteModificado.AutoSize = true;
            this.rbMostrarClienteModificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.rbMostrarClienteModificado.Location = new System.Drawing.Point(23, 43);
            this.rbMostrarClienteModificado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMostrarClienteModificado.Name = "rbMostrarClienteModificado";
            this.rbMostrarClienteModificado.Size = new System.Drawing.Size(323, 19);
            this.rbMostrarClienteModificado.TabIndex = 11;
            this.rbMostrarClienteModificado.TabStop = true;
            this.rbMostrarClienteModificado.Text = "Mostrar como quedaria el cliente con las modificaciones";
            this.rbMostrarClienteModificado.UseVisualStyleBackColor = false;
            this.rbMostrarClienteModificado.CheckedChanged += new System.EventHandler(this.rbMostrarClienteModificado_CheckedChanged);
            // 
            // rbMostrarClienteOriginar
            // 
            this.rbMostrarClienteOriginar.AutoSize = true;
            this.rbMostrarClienteOriginar.Location = new System.Drawing.Point(23, 20);
            this.rbMostrarClienteOriginar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMostrarClienteOriginar.Name = "rbMostrarClienteOriginar";
            this.rbMostrarClienteOriginar.Size = new System.Drawing.Size(231, 19);
            this.rbMostrarClienteOriginar.TabIndex = 10;
            this.rbMostrarClienteOriginar.TabStop = true;
            this.rbMostrarClienteOriginar.Text = "Mostrar cliente con los datos originales";
            this.rbMostrarClienteOriginar.UseVisualStyleBackColor = true;
            this.rbMostrarClienteOriginar.CheckedChanged += new System.EventHandler(this.rbMostrarClienteOriginar_CheckedChanged);
            // 
            // lblPlanes
            // 
            this.lblPlanes.AutoSize = true;
            this.lblPlanes.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblPlanes.ForeColor = System.Drawing.Color.White;
            this.lblPlanes.Location = new System.Drawing.Point(18, 239);
            this.lblPlanes.Name = "lblPlanes";
            this.lblPlanes.Size = new System.Drawing.Size(369, 13);
            this.lblPlanes.TabIndex = 50;
            this.lblPlanes.Text = "El plan seleccionado actualmente es el que tenia el cliente, puede modificarlo";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(18, 64);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Ingrese nombre del cliente";
            this.txtNombre.Size = new System.Drawing.Size(456, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre";
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTexto.ForeColor = System.Drawing.Color.White;
            this.lblTexto.Location = new System.Drawing.Point(16, 14);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(45, 19);
            this.lblTexto.TabIndex = 47;
            this.lblTexto.Text = "Texto";
            // 
            // lblBotonModificar
            // 
            this.lblBotonModificar.AutoSize = true;
            this.lblBotonModificar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblBotonModificar.ForeColor = System.Drawing.Color.White;
            this.lblBotonModificar.Location = new System.Drawing.Point(11, 330);
            this.lblBotonModificar.Name = "lblBotonModificar";
            this.lblBotonModificar.Size = new System.Drawing.Size(224, 13);
            this.lblBotonModificar.TabIndex = 46;
            this.lblBotonModificar.Text = "Para modificar no deben haber campos vacios";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(18, 191);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(99, 15);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "Dni ingresado";
            // 
            // txtDni
            // 
            this.txtDni.Enabled = false;
            this.txtDni.Location = new System.Drawing.Point(18, 207);
            this.txtDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDni.MaxLength = 20;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(456, 23);
            this.txtDni.TabIndex = 4;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(239, 345);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(234, 22);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModificar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModificar.Location = new System.Drawing.Point(14, 345);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(216, 22);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.groupBox1.Controls.Add(this.rbnPlanIntermedio);
            this.groupBox1.Controls.Add(this.rbnPlanPremium);
            this.groupBox1.Controls.Add(this.rbnPlanBasico);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 254);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(456, 67);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planes disponibles";
            // 
            // rbnPlanIntermedio
            // 
            this.rbnPlanIntermedio.AutoSize = true;
            this.rbnPlanIntermedio.Location = new System.Drawing.Point(161, 28);
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
            this.rbnPlanPremium.Location = new System.Drawing.Point(333, 28);
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
            this.rbnPlanBasico.Location = new System.Drawing.Point(8, 28);
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
            this.txtDireccion.Location = new System.Drawing.Point(18, 160);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Ingrese direccion del cliente";
            this.txtDireccion.Size = new System.Drawing.Size(456, 23);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(18, 112);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.MaxLength = 20;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "Ingrese apellido del cliente";
            this.txtApellido.Size = new System.Drawing.Size(456, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(16, 144);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 15);
            this.lblDireccion.TabIndex = 38;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(16, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 15);
            this.lblApellido.TabIndex = 37;
            this.lblApellido.Text = "Apellido";
            // 
            // FormModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(977, 380);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblPlanes);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.lblBotonModificar);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificacion de datos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbDatosDelCliente;
        private System.Windows.Forms.RadioButton rbMostrarClienteModificado;
        private System.Windows.Forms.RadioButton rbMostrarClienteOriginar;
        private System.Windows.Forms.Label lblPlanes;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblBotonModificar;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnPlanIntermedio;
        private System.Windows.Forms.RadioButton rbnPlanPremium;
        private System.Windows.Forms.RadioButton rbnPlanBasico;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido;
    }
}