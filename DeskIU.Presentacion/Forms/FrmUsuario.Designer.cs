namespace DeskIU.Presentacion.Forms
{
    partial class FrmUsuario
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.tbCelular = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.Text = "Registro de Usuarios";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Size = new System.Drawing.Size(560, 30);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 58);
            this.lblNombre.AutoSize = true;
            this.tbNombre.Location = new System.Drawing.Point(140, 55);
            this.tbNombre.Size = new System.Drawing.Size(300, 22);
            this.tbNombre.MaxLength = 100;

            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new System.Drawing.Point(20, 93);
            this.lblApellido.AutoSize = true;
            this.tbApellido.Location = new System.Drawing.Point(140, 90);
            this.tbApellido.Size = new System.Drawing.Size(300, 22);
            this.tbApellido.MaxLength = 100;

            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.Location = new System.Drawing.Point(20, 128);
            this.lblCorreo.AutoSize = true;
            this.tbCorreo.Location = new System.Drawing.Point(140, 125);
            this.tbCorreo.Size = new System.Drawing.Size(300, 22);
            this.tbCorreo.MaxLength = 150;

            this.lblCelular.Text = "Celular:";
            this.lblCelular.Location = new System.Drawing.Point(20, 163);
            this.lblCelular.AutoSize = true;
            this.tbCelular.Location = new System.Drawing.Point(140, 160);
            this.tbCelular.Size = new System.Drawing.Size(300, 22);
            this.tbCelular.MaxLength = 9;

            this.lblTipo.Text = "Tipo Usuario:";
            this.lblTipo.Location = new System.Drawing.Point(20, 198);
            this.lblTipo.AutoSize = true;
            this.cbTipoUsuario.Items.AddRange(new object[] { "Estudiante", "Docente", "Administrativo" });
            this.cbTipoUsuario.Location = new System.Drawing.Point(140, 195);
            this.cbTipoUsuario.Size = new System.Drawing.Size(300, 25);
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Location = new System.Drawing.Point(20, 240);
            this.btnRegistrar.Size = new System.Drawing.Size(120, 32);
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(40, 120, 40);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Location = new System.Drawing.Point(150, 240);
            this.btnActualizar.Size = new System.Drawing.Size(120, 32);
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(280, 240);
            this.btnEliminar.Size = new System.Drawing.Size(120, 32);
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(160, 80, 40);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Location = new System.Drawing.Point(410, 240);
            this.btnLimpiar.Size = new System.Drawing.Size(120, 32);
            this.btnLimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(540, 240);
            this.btnSalir.Size = new System.Drawing.Size(120, 32);
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            this.lblLista.Text = "Usuarios registrados:";
            this.lblLista.Location = new System.Drawing.Point(20, 285);
            this.lblLista.AutoSize = true;
            this.dgUsuarios.Location = new System.Drawing.Point(20, 305);
            this.dgUsuarios.Size = new System.Drawing.Size(740, 200);
            this.dgUsuarios.ReadOnly = true;
            this.dgUsuarios.AllowUserToAddRows = false;
            this.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 530);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblTitulo, lblNombre, tbNombre, lblApellido, tbApellido,
                lblCorreo, tbCorreo, lblCelular, tbCelular, lblTipo, cbTipoUsuario,
                btnRegistrar, btnActualizar, btnEliminar, btnLimpiar, btnSalir, lblLista, dgUsuarios });
            this.Name = "FrmUsuario";
            this.Text = "DeskIU - Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo, lblNombre, lblApellido, lblCorreo, lblCelular, lblTipo, lblLista;
        private System.Windows.Forms.TextBox tbNombre, tbApellido, tbCorreo, tbCelular;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Button btnRegistrar, btnActualizar, btnEliminar, btnLimpiar, btnSalir;
        private System.Windows.Forms.DataGridView dgUsuarios;
    }
}
