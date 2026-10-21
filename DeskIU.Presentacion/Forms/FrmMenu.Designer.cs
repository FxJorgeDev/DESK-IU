namespace DeskIU.Presentacion.Forms
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnTecnicos = new System.Windows.Forms.Button();
            this.btnSolicitudes = new System.Windows.Forms.Button();
            this.btnAsignaciones = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnResolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(200, 135);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(267, 47);
            this.btnUsuarios.TabIndex = 2;
            this.btnUsuarios.Text = "Registrar Usuario";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnTecnicos
            // 
            this.btnTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTecnicos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTecnicos.ForeColor = System.Drawing.Color.White;
            this.btnTecnicos.Location = new System.Drawing.Point(200, 194);
            this.btnTecnicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTecnicos.Name = "btnTecnicos";
            this.btnTecnicos.Size = new System.Drawing.Size(267, 47);
            this.btnTecnicos.TabIndex = 3;
            this.btnTecnicos.Text = "Registrar Tecnico";
            this.btnTecnicos.UseVisualStyleBackColor = false;
            this.btnTecnicos.Click += new System.EventHandler(this.btnTecnicos_Click);
            // 
            // btnSolicitudes
            // 
            this.btnSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitudes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSolicitudes.ForeColor = System.Drawing.Color.White;
            this.btnSolicitudes.Location = new System.Drawing.Point(200, 254);
            this.btnSolicitudes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSolicitudes.Name = "btnSolicitudes";
            this.btnSolicitudes.Size = new System.Drawing.Size(267, 47);
            this.btnSolicitudes.TabIndex = 4;
            this.btnSolicitudes.Text = "Registrar Solicitudes";
            this.btnSolicitudes.UseVisualStyleBackColor = false;
            this.btnSolicitudes.Click += new System.EventHandler(this.btnSolicitudes_Click);
            // 
            // btnAsignaciones
            // 
            this.btnAsignaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnAsignaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignaciones.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAsignaciones.ForeColor = System.Drawing.Color.White;
            this.btnAsignaciones.Location = new System.Drawing.Point(200, 313);
            this.btnAsignaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsignaciones.Name = "btnAsignaciones";
            this.btnAsignaciones.Size = new System.Drawing.Size(267, 47);
            this.btnAsignaciones.TabIndex = 5;
            this.btnAsignaciones.Text = "Visualizar Asignaciones";
            this.btnAsignaciones.UseVisualStyleBackColor = false;
            this.btnAsignaciones.Click += new System.EventHandler(this.btnAsignaciones_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(200, 431);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(267, 47);
            this.btnCategorias.TabIndex = 7;
            this.btnCategorias.Text = "Gestion Categorias";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(200, 490);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(267, 47);
            this.btnReportes.TabIndex = 8;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(200, 549);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(267, 47);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 25);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(667, 62);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DeskIU";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 80);
            this.lblSubtitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(667, 31);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Sistema de Soporte Tecnico Interno";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnResolver.ForeColor = System.Drawing.Color.White;
            this.btnResolver.Location = new System.Drawing.Point(200, 372);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(267, 47);
            this.btnResolver.TabIndex = 6;
            this.btnResolver.Text = "Resolver Solicitud";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.btnResolver_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(667, 652);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnTecnicos);
            this.Controls.Add(this.btnSolicitudes);
            this.Controls.Add(this.btnAsignaciones);
            this.Controls.Add(this.btnResolver);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskIU - Sistema de Soporte Tecnico";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnTecnicos;
        private System.Windows.Forms.Button btnSolicitudes;
        private System.Windows.Forms.Button btnAsignaciones;
        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
    }
}
