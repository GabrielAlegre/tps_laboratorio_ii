
namespace Forms
{
    partial class FormAltaSucursal
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnAltaSucursal = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(12, 296);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(225, 13);
            this.lblInfo.TabIndex = 41;
            this.lblInfo.Text = "Para dar de alta no debe haber campos vacios";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(239, 311);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(234, 29);
            this.BtnCancelar.TabIndex = 35;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAltaSucursal
            // 
            this.btnAltaSucursal.BackColor = System.Drawing.Color.White;
            this.btnAltaSucursal.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAltaSucursal.Font = new System.Drawing.Font("Mongolian Baiti", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAltaSucursal.ForeColor = System.Drawing.Color.Black;
            this.btnAltaSucursal.Location = new System.Drawing.Point(12, 311);
            this.btnAltaSucursal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAltaSucursal.Name = "btnAltaSucursal";
            this.btnAltaSucursal.Size = new System.Drawing.Size(216, 29);
            this.btnAltaSucursal.TabIndex = 34;
            this.btnAltaSucursal.Text = "Confirmar alta";
            this.btnAltaSucursal.UseVisualStyleBackColor = false;
            this.btnAltaSucursal.Click += new System.EventHandler(this.btnAltaServico_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(12, 92);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PlaceholderText = "Ingrese la direccion de la sucursal";
            this.txtDireccion.Size = new System.Drawing.Size(456, 23);
            this.txtDireccion.TabIndex = 32;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(12, 31);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLocalidad.MaxLength = 20;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.PlaceholderText = "Ingrese la localidad donde se encontrara la localidad";
            this.txtLocalidad.Size = new System.Drawing.Size(456, 23);
            this.txtLocalidad.TabIndex = 31;
            this.txtLocalidad.TextChanged += new System.EventHandler(this.txtLocalidad_TextChanged);
            this.txtLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLocalidad_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.Location = new System.Drawing.Point(12, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(71, 15);
            this.lblDireccion.TabIndex = 38;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblProvincia.Location = new System.Drawing.Point(11, 28);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(70, 15);
            this.lblProvincia.TabIndex = 37;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblLocalidad.Location = new System.Drawing.Point(12, 15);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(72, 15);
            this.lblLocalidad.TabIndex = 36;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(9, 46);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(456, 23);
            this.cmbProvincias.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbProvincias);
            this.groupBox1.Controls.Add(this.lblProvincia);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 89);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione la provincia donde se encuentra la localidad";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(12, 152);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PlaceholderText = "Ingrese el telefono correspondiente a la sucursal (10 numeros si o si)";
            this.txtTelefono.Size = new System.Drawing.Size(456, 23);
            this.txtTelefono.TabIndex = 44;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTelefono.Location = new System.Drawing.Point(12, 135);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(66, 15);
            this.lblTelefono.TabIndex = 45;
            this.lblTelefono.Text = "Telefono";
            // 
            // FormAltaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(485, 355);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAltaSucursal);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblLocalidad);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAltaSucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAltaSucursal";
            this.Load += new System.EventHandler(this.FormAltaSucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnAltaSucursal;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
    }
}