namespace DeskIU.Presentacion.Forms
{
    partial class FrmResolverSolicitud
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgSolicitudes = new System.Windows.Forms.DataGridView();
            this.lblObs = new System.Windows.Forms.Label();
            this.tbObservacion = new System.Windows.Forms.TextBox();
            this.btnResolver = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitudes)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.Text = "Resolver Solicitud";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Size = new System.Drawing.Size(760, 30);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTecnico.Text = "Seleccionar Tecnico:";
            this.lblTecnico.Location = new System.Drawing.Point(20, 55);
            this.lblTecnico.AutoSize = true;
            this.cbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecnico.Location = new System.Drawing.Point(160, 52);
            this.cbTecnico.Size = new System.Drawing.Size(300, 25);
            this.cbTecnico.SelectedIndexChanged += new System.EventHandler(cbTecnico_SelectedIndexChanged);

            this.lblLista.Text = "Solicitudes Pendientes:";
            this.lblLista.Location = new System.Drawing.Point(20, 90);
            this.lblLista.AutoSize = true;
            this.dgSolicitudes.Location = new System.Drawing.Point(20, 110);
            this.dgSolicitudes.Size = new System.Drawing.Size(760, 200);
            this.dgSolicitudes.ReadOnly = true;
            this.dgSolicitudes.AllowUserToAddRows = false;
            this.dgSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgSolicitudes_CellClick);

            this.lblInfo.Text = "Seleccione una solicitud";
            this.lblInfo.Location = new System.Drawing.Point(20, 320);
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.lblObs.Text = "Observacion / Comentario:";
            this.lblObs.Location = new System.Drawing.Point(20, 345);
            this.lblObs.AutoSize = true;
            this.tbObservacion.Location = new System.Drawing.Point(20, 365);
            this.tbObservacion.Size = new System.Drawing.Size(500, 22);
            this.tbObservacion.MaxLength = 500;
            this.tbObservacion.Multiline = true;
            this.tbObservacion.Height = 60;

            this.btnResolver.Text = "Marcar como Resuelto";
            this.btnResolver.Location = new System.Drawing.Point(540, 365);
            this.btnResolver.Size = new System.Drawing.Size(200, 40);
            this.btnResolver.BackColor = System.Drawing.Color.FromArgb(40, 120, 40);
            this.btnResolver.ForeColor = System.Drawing.Color.White;
            this.btnResolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolver.Click += new System.EventHandler(btnResolver_Click);

            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(640, 440);
            this.btnSalir.Size = new System.Drawing.Size(140, 32);
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Click += new System.EventHandler(btnSalir_Click);

            this.lblTotal.Text = "Pendientes: 0";
            this.lblTotal.Location = new System.Drawing.Point(600, 90);
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitulo, lblTecnico, cbTecnico, lblLista, dgSolicitudes,
                lblInfo, lblObs, tbObservacion, btnResolver, btnSalir, lblTotal });
            this.Name = "FrmResolverSolicitud";
            this.Text = "DeskIU - Resolver Solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(FrmResolverSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(dgSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        System.Windows.Forms.Label lblTitulo, lblTecnico, lblLista, lblObs, lblTotal, lblInfo;
        System.Windows.Forms.ComboBox cbTecnico;
        System.Windows.Forms.DataGridView dgSolicitudes;
        System.Windows.Forms.TextBox tbObservacion;
        System.Windows.Forms.Button btnResolver, btnSalir;
    }
}
