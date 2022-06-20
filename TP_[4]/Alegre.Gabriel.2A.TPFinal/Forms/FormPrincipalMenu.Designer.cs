
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
            this.btnSucursales = new System.Windows.Forms.Button();
            this.btnQuitarBarras = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaYFecha = new System.Windows.Forms.Timer(this.components);
            this.progressBarXml = new System.Windows.Forms.ProgressBar();
            this.progressBarTxt = new System.Windows.Forms.ProgressBar();
            this.lblBarraProgresoXml = new System.Windows.Forms.Label();
            this.lblBarraProgresoTxt = new System.Windows.Forms.Label();
            this.lblInfoProgesoBtnMostrar = new System.Windows.Forms.Label();
            this.lblInfoProgesoBtnModificar = new System.Windows.Forms.Label();
            this.lblInfoProgesoBtnBaja = new System.Windows.Forms.Label();
            this.lblInfoProgesoBtnHistorial = new System.Windows.Forms.Label();
            this.lblInfoProgesoBtnAlta = new System.Windows.Forms.Label();
            this.lblInforBarra = new System.Windows.Forms.Label();
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
            this.pictureBoxFotoPrincipal.Size = new System.Drawing.Size(710, 397);
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
            this.btnModificar.Location = new System.Drawing.Point(12, 182);
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
            this.btnMostrarClientes.Location = new System.Drawing.Point(10, 334);
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
            this.btnHistorial.Location = new System.Drawing.Point(10, 409);
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
            this.btnDarDeBaja.Location = new System.Drawing.Point(12, 258);
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
            this.btnAlta.Location = new System.Drawing.Point(12, 106);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(195, 56);
            this.btnAlta.TabIndex = 15;
            this.btnAlta.Text = "Alta Cliente/Servicio";
            this.toolTipFormPrincipal.SetToolTip(this.btnAlta, "Dar de alta un cliente ofreciendole los respectivos planes");
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnSucursales.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSucursales.ForeColor = System.Drawing.Color.Transparent;
            this.btnSucursales.Location = new System.Drawing.Point(446, 8);
            this.btnSucursales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(195, 56);
            this.btnSucursales.TabIndex = 22;
            this.btnSucursales.Text = "Sucursales";
            this.toolTipFormPrincipal.SetToolTip(this.btnSucursales, "Eliminar, Agregar y Ver sucursales de NetCom");
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // btnQuitarBarras
            // 
            this.btnQuitarBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(16)))), ((int)(((byte)(59)))));
            this.btnQuitarBarras.Font = new System.Drawing.Font("Mongolian Baiti", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnQuitarBarras.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuitarBarras.Location = new System.Drawing.Point(10, 570);
            this.btnQuitarBarras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuitarBarras.Name = "btnQuitarBarras";
            this.btnQuitarBarras.Size = new System.Drawing.Size(901, 25);
            this.btnQuitarBarras.TabIndex = 33;
            this.btnQuitarBarras.Text = "Quitar barras";
            this.toolTipFormPrincipal.SetToolTip(this.btnQuitarBarras, "Al presionar el boton se quitaran las barras de tareas");
            this.btnQuitarBarras.UseVisualStyleBackColor = false;
            this.btnQuitarBarras.Click += new System.EventHandler(this.btnQuitarBarras_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(647, 44);
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
            this.lblHora.Location = new System.Drawing.Point(741, 18);
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
            // progressBarXml
            // 
            this.progressBarXml.Location = new System.Drawing.Point(12, 493);
            this.progressBarXml.Name = "progressBarXml";
            this.progressBarXml.Size = new System.Drawing.Size(899, 23);
            this.progressBarXml.TabIndex = 23;
            // 
            // progressBarTxt
            // 
            this.progressBarTxt.Location = new System.Drawing.Point(10, 542);
            this.progressBarTxt.Name = "progressBarTxt";
            this.progressBarTxt.Size = new System.Drawing.Size(901, 23);
            this.progressBarTxt.TabIndex = 24;
            // 
            // lblBarraProgresoXml
            // 
            this.lblBarraProgresoXml.AutoSize = true;
            this.lblBarraProgresoXml.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBarraProgresoXml.ForeColor = System.Drawing.Color.Transparent;
            this.lblBarraProgresoXml.Location = new System.Drawing.Point(10, 474);
            this.lblBarraProgresoXml.Name = "lblBarraProgresoXml";
            this.lblBarraProgresoXml.Size = new System.Drawing.Size(175, 16);
            this.lblBarraProgresoXml.TabIndex = 25;
            this.lblBarraProgresoXml.Text = "Barra progeso archivos";
            // 
            // lblBarraProgresoTxt
            // 
            this.lblBarraProgresoTxt.AutoSize = true;
            this.lblBarraProgresoTxt.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblBarraProgresoTxt.ForeColor = System.Drawing.Color.Transparent;
            this.lblBarraProgresoTxt.Location = new System.Drawing.Point(10, 523);
            this.lblBarraProgresoTxt.Name = "lblBarraProgresoTxt";
            this.lblBarraProgresoTxt.Size = new System.Drawing.Size(181, 16);
            this.lblBarraProgresoTxt.TabIndex = 26;
            this.lblBarraProgresoTxt.Text = "Barra progreso archivos";
            // 
            // lblInfoProgesoBtnMostrar
            // 
            this.lblInfoProgesoBtnMostrar.AutoSize = true;
            this.lblInfoProgesoBtnMostrar.Font = new System.Drawing.Font("Mongolian Baiti", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInfoProgesoBtnMostrar.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoProgesoBtnMostrar.Location = new System.Drawing.Point(35, 316);
            this.lblInfoProgesoBtnMostrar.Name = "lblInfoProgesoBtnMostrar";
            this.lblInfoProgesoBtnMostrar.Size = new System.Drawing.Size(151, 16);
            this.lblInfoProgesoBtnMostrar.TabIndex = 27;
            this.lblInfoProgesoBtnMostrar.Text = "Boton deshabilitado";
            // 
            // lblInfoProgesoBtnModificar
            // 
            this.lblInfoProgesoBtnModificar.AutoSize = true;
            this.lblInfoProgesoBtnModificar.Font = new System.Drawing.Font("Mongolian Baiti", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInfoProgesoBtnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoProgesoBtnModificar.Location = new System.Drawing.Point(37, 164);
            this.lblInfoProgesoBtnModificar.Name = "lblInfoProgesoBtnModificar";
            this.lblInfoProgesoBtnModificar.Size = new System.Drawing.Size(151, 16);
            this.lblInfoProgesoBtnModificar.TabIndex = 28;
            this.lblInfoProgesoBtnModificar.Text = "Boton deshabilitado";
            // 
            // lblInfoProgesoBtnBaja
            // 
            this.lblInfoProgesoBtnBaja.AutoSize = true;
            this.lblInfoProgesoBtnBaja.Font = new System.Drawing.Font("Mongolian Baiti", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInfoProgesoBtnBaja.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoProgesoBtnBaja.Location = new System.Drawing.Point(37, 240);
            this.lblInfoProgesoBtnBaja.Name = "lblInfoProgesoBtnBaja";
            this.lblInfoProgesoBtnBaja.Size = new System.Drawing.Size(151, 16);
            this.lblInfoProgesoBtnBaja.TabIndex = 29;
            this.lblInfoProgesoBtnBaja.Text = "Boton deshabilitado";
            // 
            // lblInfoProgesoBtnHistorial
            // 
            this.lblInfoProgesoBtnHistorial.AutoSize = true;
            this.lblInfoProgesoBtnHistorial.Font = new System.Drawing.Font("Mongolian Baiti", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInfoProgesoBtnHistorial.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoProgesoBtnHistorial.Location = new System.Drawing.Point(35, 392);
            this.lblInfoProgesoBtnHistorial.Name = "lblInfoProgesoBtnHistorial";
            this.lblInfoProgesoBtnHistorial.Size = new System.Drawing.Size(151, 16);
            this.lblInfoProgesoBtnHistorial.TabIndex = 30;
            this.lblInfoProgesoBtnHistorial.Text = "Boton deshabilitado";
            // 
            // lblInfoProgesoBtnAlta
            // 
            this.lblInfoProgesoBtnAlta.AutoSize = true;
            this.lblInfoProgesoBtnAlta.Font = new System.Drawing.Font("Mongolian Baiti", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInfoProgesoBtnAlta.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfoProgesoBtnAlta.Location = new System.Drawing.Point(37, 88);
            this.lblInfoProgesoBtnAlta.Name = "lblInfoProgesoBtnAlta";
            this.lblInfoProgesoBtnAlta.Size = new System.Drawing.Size(151, 16);
            this.lblInfoProgesoBtnAlta.TabIndex = 31;
            this.lblInfoProgesoBtnAlta.Text = "Boton deshabilitado";
            // 
            // lblInforBarra
            // 
            this.lblInforBarra.AutoSize = true;
            this.lblInforBarra.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInforBarra.ForeColor = System.Drawing.Color.Transparent;
            this.lblInforBarra.Location = new System.Drawing.Point(386, 471);
            this.lblInforBarra.Name = "lblInforBarra";
            this.lblInforBarra.Size = new System.Drawing.Size(514, 19);
            this.lblInforBarra.TabIndex = 32;
            this.lblInforBarra.Text = "Para habilitar los btn y manejar archivos txt y xml se deben completar las barras" +
    "";
            // 
            // FormPrincipalMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(921, 601);
            this.Controls.Add(this.pictureBoxFotoPrincipal);
            this.Controls.Add(this.btnQuitarBarras);
            this.Controls.Add(this.lblInforBarra);
            this.Controls.Add(this.lblInfoProgesoBtnAlta);
            this.Controls.Add(this.lblInfoProgesoBtnHistorial);
            this.Controls.Add(this.lblInfoProgesoBtnBaja);
            this.Controls.Add(this.lblInfoProgesoBtnModificar);
            this.Controls.Add(this.lblInfoProgesoBtnMostrar);
            this.Controls.Add(this.lblBarraProgresoTxt);
            this.Controls.Add(this.lblBarraProgresoXml);
            this.Controls.Add(this.progressBarTxt);
            this.Controls.Add(this.progressBarXml);
            this.Controls.Add(this.btnSucursales);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnDarDeBaja);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnInformeEstadistico);
            this.Controls.Add(this.pictureBoxLogo);
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
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.ProgressBar progressBarXml;
        private System.Windows.Forms.ProgressBar progressBarTxt;
        private System.Windows.Forms.Label lblBarraProgresoXml;
        private System.Windows.Forms.Label lblBarraProgresoTxt;
        private System.Windows.Forms.Label lblInfoProgesoBtnMostrar;
        private System.Windows.Forms.Label lblInfoProgesoBtnModificar;
        private System.Windows.Forms.Label lblInfoProgesoBtnBaja;
        private System.Windows.Forms.Label lblInfoProgesoBtnHistorial;
        private System.Windows.Forms.Label lblInfoProgesoBtnAlta;
        private System.Windows.Forms.Label lblInforBarra;
        private System.Windows.Forms.Button btnQuitarBarras;
    }
}

