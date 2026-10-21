namespace DeskIU.Presentacion.Forms
{
    partial class FrmTecnico
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.lblEsp = new System.Windows.Forms.Label();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblDisp = new System.Windows.Forms.Label();
            this.cbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgTecnicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgTecnicos)).BeginInit();
            this.SuspendLayout();

            this.lblTitulo.Text = "Registro de Tecnicos";
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(12, 10);
            this.lblTitulo.Size = new System.Drawing.Size(560, 30);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 58);
            this.lblNombre.AutoSize = true;
            this.tbNombre.Location = new System.Drawing.Point(150, 55);
            this.tbNombre.Size = new System.Drawing.Size(280, 22);
            this.tbNombre.MaxLength = 100;

            this.lblApellido.Text = "Apellido:";
            this.lblApellido.Location = new System.Drawing.Point(20, 93);
            this.lblApellido.AutoSize = true;
            this.tbApellido.Location = new System.Drawing.Point(150, 90);
            this.tbApellido.Size = new System.Drawing.Size(280, 22);
            this.tbApellido.MaxLength = 100;

            this.lblCorreo.Text = "Correo:";
            this.lblCorreo.Location = new System.Drawing.Point(20, 128);
            this.lblCorreo.AutoSize = true;
            this.tbCorreo.Location = new System.Drawing.Point(150, 125);
            this.tbCorreo.Size = new System.Drawing.Size(280, 22);
            this.tbCorreo.MaxLength = 150;

            this.lblEsp.Text = "Especialidad:";
            this.lblEsp.Location = new System.Drawing.Point(20, 163);
            this.lblEsp.AutoSize = true;
            this.cbEspecialidad.Items.AddRange(new object[] { "Hardware", "Software", "Accesos y Red" });
            this.cbEspecialidad.Location = new System.Drawing.Point(150, 160);
            this.cbEspecialidad.Size = new System.Drawing.Size(280, 25);
            this.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblDisp.Text = "Disponibilidad:";
            this.lblDisp.Location = new System.Drawing.Point(20, 198);
            this.lblDisp.AutoSize = true;
            this.cbDisponibilidad.Items.AddRange(new object[] { "Disponible", "Ocupado", "No Disponible" });
            this.cbDisponibilidad.Location = new System.Drawing.Point(150, 195);
            this.cbDisponibilidad.Size = new System.Drawing.Size(280, 25);
            this.cbDisponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

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

            this.btnRegistrar.Click += new System.EventHandler(btnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(btnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(btnEliminar_Click);
            this.btnLimpiar.Click += new System.EventHandler(btnLimpiar_Click);
            this.btnSalir.Click += new System.EventHandler(btnSalir_Click);

            this.lblLista.Text = "Tecnicos registrados:";
            this.lblLista.Location = new System.Drawing.Point(20, 285);
            this.lblLista.AutoSize = true;
            this.dgTecnicos.Location = new System.Drawing.Point(20, 305);
            this.dgTecnicos.Size = new System.Drawing.Size(740, 190);
            this.dgTecnicos.ReadOnly = true;
            this.dgTecnicos.AllowUserToAddRows = false;
            this.dgTecnicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTecnicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTecnicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgTecnicos_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.AddRange(new System.Windows.Forms.Control[]{
                lblTitulo,lblNombre,tbNombre,lblApellido,tbApellido,lblCorreo,tbCorreo,
                lblEsp,cbEspecialidad,lblDisp,cbDisponibilidad,
                btnRegistrar,btnActualizar,btnEliminar,btnLimpiar,btnSalir,lblLista,dgTecnicos});
            this.Name = "FrmTecnico"; this.Text = "DeskIU - Tecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(FrmTecnico_Load);
            ((System.ComponentModel.ISupportInitialize)(dgTecnicos)).EndInit();
            this.ResumeLayout(false);
        }

        System.Windows.Forms.Label lblTitulo, lblNombre, lblApellido, lblCorreo, lblEsp, lblDisp, lblLista;
        System.Windows.Forms.TextBox tbNombre, tbApellido, tbCorreo;
        System.Windows.Forms.ComboBox cbEspecialidad, cbDisponibilidad;
        System.Windows.Forms.Button btnRegistrar, btnActualizar, btnEliminar, btnLimpiar, btnSalir;
        System.Windows.Forms.DataGridView dgTecnicos;
    }
}
