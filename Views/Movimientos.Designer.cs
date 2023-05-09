namespace ExamenSRCoppel.Views
{
    partial class Movimientos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.txtCantidadEntregas = new System.Windows.Forms.TextBox();
            this.lblCantidadEntregas = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtYear);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.txtCantidadEntregas);
            this.panel1.Controls.Add(this.lblCantidadEntregas);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.cbMes);
            this.panel1.Controls.Add(this.lblMes);
            this.panel1.Controls.Add(this.txtRol);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.lblNombreEmpleado);
            this.panel1.Controls.Add(this.txtIDEmpleado);
            this.panel1.Controls.Add(this.lblIDEmpleado);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 266);
            this.panel1.TabIndex = 0;
            // 
            // dtYear
            // 
            this.dtYear.CustomFormat = "yyyy";
            this.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtYear.Location = new System.Drawing.Point(130, 192);
            this.dtYear.Name = "dtYear";
            this.dtYear.Size = new System.Drawing.Size(80, 20);
            this.dtYear.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(422, 47);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = global::ExamenSRCoppel.Properties.Resources.Agregar40;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(44, 44);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidadEntregas
            // 
            this.txtCantidadEntregas.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidadEntregas.Location = new System.Drawing.Point(130, 226);
            this.txtCantidadEntregas.Name = "txtCantidadEntregas";
            this.txtCantidadEntregas.Size = new System.Drawing.Size(271, 20);
            this.txtCantidadEntregas.TabIndex = 11;
            this.txtCantidadEntregas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadEntregas_KeyPress);
            // 
            // lblCantidadEntregas
            // 
            this.lblCantidadEntregas.AutoSize = true;
            this.lblCantidadEntregas.Location = new System.Drawing.Point(13, 226);
            this.lblCantidadEntregas.Name = "lblCantidadEntregas";
            this.lblCantidadEntregas.Size = new System.Drawing.Size(112, 13);
            this.lblCantidadEntregas.TabIndex = 10;
            this.lblCantidadEntregas.Text = "Cantidad de Entregas:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(13, 192);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Año:";
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.SystemColors.Control;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Seleccione un mes",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(130, 157);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(271, 21);
            this.cbMes.TabIndex = 7;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(13, 157);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 6;
            this.lblMes.Text = "Mes:";
            // 
            // txtRol
            // 
            this.txtRol.BackColor = System.Drawing.SystemColors.Control;
            this.txtRol.Location = new System.Drawing.Point(130, 123);
            this.txtRol.Name = "txtRol";
            this.txtRol.Size = new System.Drawing.Size(271, 20);
            this.txtRol.TabIndex = 5;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(13, 126);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(26, 13);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreEmpleado.Location = new System.Drawing.Point(130, 92);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(271, 20);
            this.txtNombreEmpleado.TabIndex = 3;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(13, 99);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(114, 13);
            this.lblNombreEmpleado.TabIndex = 2;
            this.lblNombreEmpleado.Text = "Nombre del Empleado:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.txtIDEmpleado.Location = new System.Drawing.Point(130, 61);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(271, 20);
            this.txtIDEmpleado.TabIndex = 1;
            this.txtIDEmpleado.TextChanged += new System.EventHandler(this.txtIDEmpleado_TextChanged);
            this.txtIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDEmpleado_KeyPress);
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(13, 64);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(71, 13);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "ID Empleado:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(42, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 319);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Movimientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.TextBox txtCantidadEntregas;
        private System.Windows.Forms.Label lblCantidadEntregas;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtYear;
    }
}