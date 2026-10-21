namespace DeskIU.Presentacion.Forms
{
    partial class FrmSolicitud
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTit = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.tbObservacion = new System.Windows.Forms.TextBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cbTecnico = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgSolicitudes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(16, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1147, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Solicitudes";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Location = new System.Drawing.Point(27, 65);
            this.lblTit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(43, 16);
            this.lblTit.TabIndex = 1;
            this.lblTit.Text = "Titulo:";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(227, 59);
            this.tbTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTitulo.MaxLength = 200;
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(372, 22);
            this.tbTitulo.TabIndex = 2;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(27, 106);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(82, 16);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Descripcion:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(227, 87);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescripcion.MaxLength = 500;
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(372, 67);
            this.tbDescripcion.TabIndex = 4;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(27, 180);
            this.lblObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(87, 16);
            this.lblObs.TabIndex = 5;
            this.lblObs.Text = "Observacion:";
            // 
            // tbObservacion
            // 
            this.tbObservacion.Location = new System.Drawing.Point(227, 176);
            this.tbObservacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbObservacion.MaxLength = 500;
            this.tbObservacion.Multiline = true;
            this.tbObservacion.Name = "tbObservacion";
            this.tbObservacion.Size = new System.Drawing.Size(372, 54);
            this.tbObservacion.TabIndex = 6;
            // 
            // lblPrioridad
            // 
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(735, 65);
            this.lblPrioridad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(65, 16);
            this.lblPrioridad.TabIndex = 11;
            this.lblPrioridad.Text = "Prioridad:";
            // 
            // cbPrioridad
            // 
            this.cbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.cbPrioridad.Location = new System.Drawing.Point(878, 62);
            this.cbPrioridad.Margin = new System.Windows.Forms.Padding(4);
            this.cbPrioridad.Name = "cbPrioridad";
            this.cbPrioridad.Size = new System.Drawing.Size(265, 24);
            this.cbPrioridad.TabIndex = 12;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(735, 106);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Location = new System.Drawing.Point(878, 98);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(265, 24);
            this.cbCategoria.TabIndex = 14;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(743, 138);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.Location = new System.Drawing.Point(878, 130);
            this.cbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(265, 24);
            this.cbUsuario.TabIndex = 16;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Location = new System.Drawing.Point(684, 179);
            this.lblTecnico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(120, 16);
            this.lblTecnico.TabIndex = 17;
            this.lblTecnico.Text = "Tecnico Asignado:";
            // 
            // cbTecnico
            // 
            this.cbTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTecnico.Location = new System.Drawing.Point(878, 176);
            this.cbTecnico.Margin = new System.Windows.Forms.Padding(4);
            this.cbTecnico.Name = "cbTecnico";
            this.cbTecnico.Size = new System.Drawing.Size(265, 24);
            this.cbTecnico.TabIndex = 18;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(27, 330);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(173, 39);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(314, 330);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(173, 39);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(584, 330);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 39);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(27, 385);
            this.lblLista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(289, 16);
            this.lblLista.TabIndex = 23;
            this.lblLista.Text = "Solicitudes registradas (click para seleccionar):";
            // 
            // dgSolicitudes
            // 
            this.dgSolicitudes.AllowUserToAddRows = false;
            this.dgSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSolicitudes.ColumnHeadersHeight = 29;
            this.dgSolicitudes.Location = new System.Drawing.Point(27, 410);
            this.dgSolicitudes.Margin = new System.Windows.Forms.Padding(4);
            this.dgSolicitudes.Name = "dgSolicitudes";
            this.dgSolicitudes.ReadOnly = true;
            this.dgSolicitudes.RowHeadersWidth = 51;
            this.dgSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSolicitudes.Size = new System.Drawing.Size(1147, 246);
            this.dgSolicitudes.TabIndex = 24;
            this.dgSolicitudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSolicitudes_CellClick);
            // 
            // FrmSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 681);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.tbObservacion);
            this.Controls.Add(this.lblPrioridad);
            this.Controls.Add(this.cbPrioridad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.cbTecnico);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.dgSolicitudes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeskIU - Solicitudes";
            this.Load += new System.EventHandler(this.FrmSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        System.Windows.Forms.Label lblTitulo, lblTit, lblDesc, lblObs, lblPrioridad, lblCategoria, lblUsuario, lblTecnico, lblLista;
        System.Windows.Forms.TextBox tbTitulo, tbDescripcion, tbObservacion;
        System.Windows.Forms.ComboBox cbPrioridad, cbCategoria, cbUsuario, cbTecnico;
        System.Windows.Forms.Button btnRegistrar, btnEliminar, btnSalir;
        System.Windows.Forms.DataGridView dgSolicitudes;
    }
}
