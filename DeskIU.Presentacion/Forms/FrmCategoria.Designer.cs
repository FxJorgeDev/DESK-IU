namespace DeskIU.Presentacion.Forms
{
    partial class FrmCategoria
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label(); this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label(); this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button(); this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button(); this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dgCategorias)).BeginInit();
            this.SuspendLayout();

            lblTitulo.Text = "Gestion de Categorias"; lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location = new System.Drawing.Point(12, 10); lblTitulo.Size = new System.Drawing.Size(560, 30); lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 58);
            this.lblNombre.AutoSize = true;
            this.tbNombre.Location = new System.Drawing.Point(150, 55);
            this.tbNombre.Size = new System.Drawing.Size(350, 22);
            this.tbNombre.MaxLength = 100;

            this.lblDesc.Text = "Descripcion:";
            this.lblDesc.Location = new System.Drawing.Point(20, 93);
            this.lblDesc.AutoSize = true;
            this.tbDescripcion.Location = new System.Drawing.Point(150, 90);
            this.tbDescripcion.Size = new System.Drawing.Size(350, 55);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.MaxLength = 200;

            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Location = new System.Drawing.Point(20, 155);
            this.btnRegistrar.Size = new System.Drawing.Size(110, 32);
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(40, 120, 40);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Location = new System.Drawing.Point(140, 155);
            this.btnActualizar.Size = new System.Drawing.Size(110, 32);
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(260, 155);
            this.btnEliminar.Size = new System.Drawing.Size(110, 32);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(160, 80, 40);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(380, 155);
            this.btnLimpiar.Size = new System.Drawing.Size(110, 32);
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(500, 155);
            this.btnSalir.Size = new System.Drawing.Size(110, 32);
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnRegistrar.Click += new System.EventHandler(btnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(btnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(btnEliminar_Click);
            this.btnLimpiar.Click += new System.EventHandler(btnLimpiar_Click);
            this.btnSalir.Click += new System.EventHandler(btnSalir_Click);

            lblLista.Text = "Categorias registradas:"; lblLista.Location = new System.Drawing.Point(20, 200); lblLista.AutoSize = true;
            dgCategorias.Location = new System.Drawing.Point(20, 220); dgCategorias.Size = new System.Drawing.Size(620, 180);
            dgCategorias.ReadOnly = true; dgCategorias.AllowUserToAddRows = false;
            dgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgCategorias_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { lblTitulo, lblNombre, tbNombre, lblDesc, tbDescripcion, btnRegistrar, btnActualizar, btnEliminar, btnLimpiar, btnSalir, lblLista, dgCategorias });
            this.Name = "FrmCategoria"; this.Text = "DeskIU - Categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(dgCategorias)).EndInit();
            this.ResumeLayout(false);
        }
        System.Windows.Forms.Label lblTitulo, lblNombre, lblDesc, lblLista;
        System.Windows.Forms.TextBox tbNombre, tbDescripcion;
        System.Windows.Forms.Button btnRegistrar, btnActualizar, btnEliminar, btnLimpiar, btnSalir;
        System.Windows.Forms.DataGridView dgCategorias;
    }
}
