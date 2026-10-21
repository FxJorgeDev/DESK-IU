namespace DeskIU.Presentacion.Forms
{
    partial class FrmAsignaciones
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
        private void InitializeComponent()
        {
            this.lblTitulo=new System.Windows.Forms.Label();
            this.lblSolicitudes=new System.Windows.Forms.Label();
            this.dgSolicitudes=new System.Windows.Forms.DataGridView();
            this.lblInfo=new System.Windows.Forms.Label();
            this.lblTecnico=new System.Windows.Forms.Label();
            this.lblEspecialidad=new System.Windows.Forms.Label();
            this.lblDisponibilidad=new System.Windows.Forms.Label();
            this.btnSalir=new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgSolicitudes)).BeginInit();
            this.SuspendLayout();

            lblTitulo.Text="Visualizar Asignaciones"; lblTitulo.Font=new System.Drawing.Font("Segoe UI",14F,System.Drawing.FontStyle.Bold);
            lblTitulo.Location=new System.Drawing.Point(12,10); lblTitulo.Size=new System.Drawing.Size(860,30); lblTitulo.TextAlign=System.Drawing.ContentAlignment.MiddleCenter;

            lblSolicitudes.Text="Solicitudes (haga clic en una fila para ver el tecnico asignado):";
            lblSolicitudes.Location=new System.Drawing.Point(20,50); lblSolicitudes.AutoSize=true;

            dgSolicitudes.Location=new System.Drawing.Point(20,70); dgSolicitudes.Size=new System.Drawing.Size(860,220);
            dgSolicitudes.ReadOnly=true; dgSolicitudes.AllowUserToAddRows=false;
            dgSolicitudes.AutoSizeColumnsMode=System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgSolicitudes.SelectionMode=System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgSolicitudes.CellClick+=new System.Windows.Forms.DataGridViewCellEventHandler(dgSolicitudes_CellClick);

            lblInfo.Text="Informacion del Tecnico Asignado:"; lblInfo.Font=new System.Drawing.Font("Segoe UI",10F,System.Drawing.FontStyle.Bold);
            lblInfo.Location=new System.Drawing.Point(20,305); lblInfo.AutoSize=true;

            lblTecnico.Text="Tecnico: —"; lblTecnico.Location=new System.Drawing.Point(20,330); lblTecnico.AutoSize=true; lblTecnico.Font=new System.Drawing.Font("Segoe UI",10F);
            lblEspecialidad.Text="Especialidad: —"; lblEspecialidad.Location=new System.Drawing.Point(20,355); lblEspecialidad.AutoSize=true; lblEspecialidad.Font=new System.Drawing.Font("Segoe UI",10F);
            lblDisponibilidad.Text="Disponibilidad: —"; lblDisponibilidad.Location=new System.Drawing.Point(20,380); lblDisponibilidad.AutoSize=true; lblDisponibilidad.Font=new System.Drawing.Font("Segoe UI",10F);

            btnSalir.Text="Salir"; btnSalir.Location=new System.Drawing.Point(750,415); btnSalir.Size=new System.Drawing.Size(130,32);
            btnSalir.BackColor=System.Drawing.Color.FromArgb(160,40,40); btnSalir.ForeColor=System.Drawing.Color.White; btnSalir.FlatStyle=System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Click+=new System.EventHandler(btnSalir_Click);

            this.AutoScaleDimensions=new System.Drawing.SizeF(6F,13F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize=new System.Drawing.Size(900,460);
            this.Controls.AddRange(new System.Windows.Forms.Control[]{lblTitulo,lblSolicitudes,dgSolicitudes,lblInfo,lblTecnico,lblEspecialidad,lblDisponibilidad,btnSalir});
            this.Name="FrmAsignaciones"; this.Text="DeskIU - Visualizar Asignaciones";
            this.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load+=new System.EventHandler(FrmAsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(dgSolicitudes)).EndInit();
            this.ResumeLayout(false);
        }
        System.Windows.Forms.Label lblTitulo,lblSolicitudes,lblInfo,lblTecnico,lblEspecialidad,lblDisponibilidad;
        System.Windows.Forms.DataGridView dgSolicitudes;
        System.Windows.Forms.Button btnSalir;
    }
}
