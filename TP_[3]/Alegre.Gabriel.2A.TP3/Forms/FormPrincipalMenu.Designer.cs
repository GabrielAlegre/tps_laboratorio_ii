
namespace Forms
{
    partial class FormPrincipalMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalMenu));
            this.pictureBoxFotoPrincipal = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnInformeEstadistico = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnDarDeBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.toolTipFormPrincipal = new System.Windows.Forms.ToolTip(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaYFecha = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFotoPrincipal
            // 
            this.pictureBoxFotoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFotoPrincipal.Image")));
            this.pictureBoxFotoPrincipal.Location = new System.Drawing.Point(211, 68);
            this.pictureBoxFotoPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFotoPrincipal.Name = "pictureBoxFotoPrincipal";
            this.pictureBoxFotoPrincipal.Size = new System.Drawing.Size(549, 322);
            this.pictureBoxFotoPrincipal.TabIndex = 0;
            this.pictureBoxFotoPrincipal.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 5);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(210, 78);
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnInformeEstadistico
            // 
            this.btnInformeEstadistico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnInformeEstadistico.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnInformeEstadistico.ForeColor = System.Drawing.Color.Transparent;
            this.btnInformeEstadistico.Location = new System.Drawing.Point(233, 9);
            this.btnInformeEstadistico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInformeEstadistico.Name = "btnInformeEstadistico";
            this.btnInformeEstadistico.Size = new System.Drawing.Size(195, 56);
            this.btnInformeEstadistico.TabIndex = 14;
            this.btnInformeEstadistico.Text = "Informe estadistico de los servicios";
            this.toolTipFormPrincipal.SetToolTip(this.btnInformeEstadistico, "Informe estadistico de las operaciones realizadas por el empleado ");
            this.btnInformeEstadistico.UseVisualStyleBackColor = false;
            this.btnInformeEstadistico.Click += new System.EventHandler(this.btnInformeEstadistico_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnModificar.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(10, 147);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(195, 56);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "Modificar Cliente/servicio";
            this.toolTipFormPrincipal.SetToolTip(this.btnModificar, "Modificar el servicio (O algun otro dato) de un cliente activo");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnMostrarClientes.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnMostrarClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnMostrarClientes.Location = new System.Drawing.Point(10, 267);
            this.btnMostrarClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(195, 56);
            this.btnMostrarClientes.TabIndex = 16;
            this.btnMostrarClientes.Text = "Mostrar clientes";
            this.toolTipFormPrincipal.SetToolTip(this.btnMostrarClientes, "Listado de clientes");
            this.btnMostrarClientes.UseVisualStyleBackColor = false;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnHistorial.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHistorial.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistorial.Location = new System.Drawing.Point(10, 327);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(195, 56);
            this.btnHistorial.TabIndex = 18;
            this.btnHistorial.Text = "Historial de operaciones";
            this.toolTipFormPrincipal.SetToolTip(this.btnHistorial, "Mostra el historial de todas las operaciones realizadas");
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnDarDeBaja.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDarDeBaja.ForeColor = System.Drawing.Color.Transparent;
            this.btnDarDeBaja.Location = new System.Drawing.Point(10, 207);
            this.btnDarDeBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDarDeBaja.Name = "btnDarDeBaja";
            this.btnDarDeBaja.Size = new System.Drawing.Size(195, 56);
            this.btnDarDeBaja.TabIndex = 17;
            this.btnDarDeBaja.Text = "Baja Cliente/servicio";
            this.toolTipFormPrincipal.SetToolTip(this.btnDarDeBaja, "Dar de baja un cliente y en consecuencia el servicio adquirido por el mismo tambi" +
        "en");
            this.btnDarDeBaja.UseVisualStyleBackColor = false;
            this.btnDarDeBaja.Click += new System.EventHandler(this.btnDarDeBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnAlta.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAlta.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlta.Location = new System.Drawing.Point(10, 87);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(195, 56);
            this.btnAlta.TabIndex = 15;
            this.btnAlta.Text = "Alta Cliente/Servicio";
            this.toolTipFormPrincipal.SetToolTip(this.btnAlta, "Dar de alta un cliente ofreciendole los respectivos planes");
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(456, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(59, 20);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHora.ForeColor = System.Drawing.Color.Transparent;
            this.lblHora.Location = new System.Drawing.Point(520, 19);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 20;
            this.lblHora.Text = "Hora";
            // 
            // horaYFecha
            // 
            this.horaYFecha.Enabled = true;
            this.horaYFecha.Tick += new System.EventHandler(this.horaYFecha_Tick);
            // 
            // FormPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(760, 391);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnInformeEstadistico);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxFotoPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipalMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipalMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipalMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFotoPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFotoPrincipal;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnInformeEstadistico;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnDarDeBaja;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ToolTip toolTipFormPrincipal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaYFecha;
    }
}

