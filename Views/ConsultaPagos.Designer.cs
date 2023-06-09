﻿namespace ExamenSRCoppel.Views
{
    partial class ConsultaPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPagos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBonoPorHora = new System.Windows.Forms.TextBox();
            this.lblBonoPorHora = new System.Windows.Forms.Label();
            this.txtBonoPorEntrega = new System.Windows.Forms.TextBox();
            this.lblBonoPorEntrega = new System.Windows.Forms.Label();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.txtHorasPorTurno = new System.Windows.Forms.TextBox();
            this.lblHorasPorTurno = new System.Windows.Forms.Label();
            this.txtTotalEntregas = new System.Windows.Forms.TextBox();
            this.lblTotalEntregas = new System.Windows.Forms.Label();
            this.txtDiasPorTurno = new System.Windows.Forms.TextBox();
            this.lblDiasPorTurno = new System.Windows.Forms.Label();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.lblSueldoHora = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPagoNeto = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.txtValesDespensa = new System.Windows.Forms.TextBox();
            this.lblValesDespensa = new System.Windows.Forms.Label();
            this.txtIngresoNeto = new System.Windows.Forms.TextBox();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtISRAdicional = new System.Windows.Forms.TextBox();
            this.lblISRAdicional = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.lblISR = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblSueldoMasBono = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalBonoPorHora = new System.Windows.Forms.TextBox();
            this.lblTotalBonoHora = new System.Windows.Forms.Label();
            this.txtTotalBonoPorEntrega = new System.Windows.Forms.TextBox();
            this.lblTotalBonoEntrega = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRol = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 634);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago Mensual";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBonoPorHora);
            this.groupBox6.Controls.Add(this.lblBonoPorHora);
            this.groupBox6.Controls.Add(this.txtBonoPorEntrega);
            this.groupBox6.Controls.Add(this.lblBonoPorEntrega);
            this.groupBox6.Controls.Add(this.txtSueldoBruto);
            this.groupBox6.Controls.Add(this.lblSueldoBruto);
            this.groupBox6.Controls.Add(this.txtHorasPorTurno);
            this.groupBox6.Controls.Add(this.lblHorasPorTurno);
            this.groupBox6.Controls.Add(this.txtTotalEntregas);
            this.groupBox6.Controls.Add(this.lblTotalEntregas);
            this.groupBox6.Controls.Add(this.txtDiasPorTurno);
            this.groupBox6.Controls.Add(this.lblDiasPorTurno);
            this.groupBox6.Controls.Add(this.txtSueldoHora);
            this.groupBox6.Controls.Add(this.lblSueldoHora);
            this.groupBox6.Location = new System.Drawing.Point(21, 199);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(438, 121);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detalle";
            // 
            // txtBonoPorHora
            // 
            this.txtBonoPorHora.Location = new System.Drawing.Point(319, 94);
            this.txtBonoPorHora.Name = "txtBonoPorHora";
            this.txtBonoPorHora.ReadOnly = true;
            this.txtBonoPorHora.Size = new System.Drawing.Size(100, 20);
            this.txtBonoPorHora.TabIndex = 34;
            // 
            // lblBonoPorHora
            // 
            this.lblBonoPorHora.AutoSize = true;
            this.lblBonoPorHora.Location = new System.Drawing.Point(216, 97);
            this.lblBonoPorHora.Name = "lblBonoPorHora";
            this.lblBonoPorHora.Size = new System.Drawing.Size(79, 13);
            this.lblBonoPorHora.TabIndex = 33;
            this.lblBonoPorHora.Text = "Bono por Hora:";
            // 
            // txtBonoPorEntrega
            // 
            this.txtBonoPorEntrega.Location = new System.Drawing.Point(319, 68);
            this.txtBonoPorEntrega.Name = "txtBonoPorEntrega";
            this.txtBonoPorEntrega.ReadOnly = true;
            this.txtBonoPorEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtBonoPorEntrega.TabIndex = 32;
            // 
            // lblBonoPorEntrega
            // 
            this.lblBonoPorEntrega.AutoSize = true;
            this.lblBonoPorEntrega.Location = new System.Drawing.Point(216, 71);
            this.lblBonoPorEntrega.Name = "lblBonoPorEntrega";
            this.lblBonoPorEntrega.Size = new System.Drawing.Size(93, 13);
            this.lblBonoPorEntrega.TabIndex = 31;
            this.lblBonoPorEntrega.Text = "Bono por Entrega:";
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(319, 42);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.ReadOnly = true;
            this.txtSueldoBruto.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoBruto.TabIndex = 30;
            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(216, 49);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(71, 13);
            this.lblSueldoBruto.TabIndex = 29;
            this.lblSueldoBruto.Text = "Sueldo Bruto:";
            // 
            // txtHorasPorTurno
            // 
            this.txtHorasPorTurno.Location = new System.Drawing.Point(319, 18);
            this.txtHorasPorTurno.Name = "txtHorasPorTurno";
            this.txtHorasPorTurno.ReadOnly = true;
            this.txtHorasPorTurno.Size = new System.Drawing.Size(100, 20);
            this.txtHorasPorTurno.TabIndex = 28;
            // 
            // lblHorasPorTurno
            // 
            this.lblHorasPorTurno.AutoSize = true;
            this.lblHorasPorTurno.Location = new System.Drawing.Point(216, 25);
            this.lblHorasPorTurno.Name = "lblHorasPorTurno";
            this.lblHorasPorTurno.Size = new System.Drawing.Size(87, 13);
            this.lblHorasPorTurno.TabIndex = 27;
            this.lblHorasPorTurno.Text = "Horas por Turno:";
            // 
            // txtTotalEntregas
            // 
            this.txtTotalEntregas.Location = new System.Drawing.Point(99, 68);
            this.txtTotalEntregas.Name = "txtTotalEntregas";
            this.txtTotalEntregas.ReadOnly = true;
            this.txtTotalEntregas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalEntregas.TabIndex = 26;
            // 
            // lblTotalEntregas
            // 
            this.lblTotalEntregas.AutoSize = true;
            this.lblTotalEntregas.Location = new System.Drawing.Point(4, 71);
            this.lblTotalEntregas.Name = "lblTotalEntregas";
            this.lblTotalEntregas.Size = new System.Drawing.Size(94, 13);
            this.lblTotalEntregas.TabIndex = 25;
            this.lblTotalEntregas.Text = "Total de Entregas:";
            // 
            // txtDiasPorTurno
            // 
            this.txtDiasPorTurno.Location = new System.Drawing.Point(99, 42);
            this.txtDiasPorTurno.Name = "txtDiasPorTurno";
            this.txtDiasPorTurno.ReadOnly = true;
            this.txtDiasPorTurno.Size = new System.Drawing.Size(100, 20);
            this.txtDiasPorTurno.TabIndex = 24;
            // 
            // lblDiasPorTurno
            // 
            this.lblDiasPorTurno.AutoSize = true;
            this.lblDiasPorTurno.Location = new System.Drawing.Point(8, 49);
            this.lblDiasPorTurno.Name = "lblDiasPorTurno";
            this.lblDiasPorTurno.Size = new System.Drawing.Size(82, 13);
            this.lblDiasPorTurno.TabIndex = 23;
            this.lblDiasPorTurno.Text = "Días por Turno:";
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.Location = new System.Drawing.Point(99, 18);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.ReadOnly = true;
            this.txtSueldoHora.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoHora.TabIndex = 22;
            // 
            // lblSueldoHora
            // 
            this.lblSueldoHora.AutoSize = true;
            this.lblSueldoHora.Location = new System.Drawing.Point(8, 25);
            this.lblSueldoHora.Name = "lblSueldoHora";
            this.lblSueldoHora.Size = new System.Drawing.Size(87, 13);
            this.lblSueldoHora.TabIndex = 21;
            this.lblSueldoHora.Text = "Sueldo por Hora:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPagoNeto);
            this.groupBox5.Controls.Add(this.lblTotalPagar);
            this.groupBox5.Controls.Add(this.txtValesDespensa);
            this.groupBox5.Controls.Add(this.lblValesDespensa);
            this.groupBox5.Controls.Add(this.txtIngresoNeto);
            this.groupBox5.Controls.Add(this.lblSueldoNeto);
            this.groupBox5.Location = new System.Drawing.Point(24, 536);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 80);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Totales";
            // 
            // txtPagoNeto
            // 
            this.txtPagoNeto.Location = new System.Drawing.Point(303, 50);
            this.txtPagoNeto.Name = "txtPagoNeto";
            this.txtPagoNeto.ReadOnly = true;
            this.txtPagoNeto.Size = new System.Drawing.Size(100, 20);
            this.txtPagoNeto.TabIndex = 5;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(223, 53);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPagar.TabIndex = 4;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // txtValesDespensa
            // 
            this.txtValesDespensa.Location = new System.Drawing.Point(109, 47);
            this.txtValesDespensa.Name = "txtValesDespensa";
            this.txtValesDespensa.ReadOnly = true;
            this.txtValesDespensa.Size = new System.Drawing.Size(100, 20);
            this.txtValesDespensa.TabIndex = 3;
            // 
            // lblValesDespensa
            // 
            this.lblValesDespensa.AutoSize = true;
            this.lblValesDespensa.Location = new System.Drawing.Point(21, 50);
            this.lblValesDespensa.Name = "lblValesDespensa";
            this.lblValesDespensa.Size = new System.Drawing.Size(87, 13);
            this.lblValesDespensa.TabIndex = 2;
            this.lblValesDespensa.Text = "Vales Despensa:";
            // 
            // txtIngresoNeto
            // 
            this.txtIngresoNeto.Location = new System.Drawing.Point(108, 19);
            this.txtIngresoNeto.Name = "txtIngresoNeto";
            this.txtIngresoNeto.ReadOnly = true;
            this.txtIngresoNeto.Size = new System.Drawing.Size(100, 20);
            this.txtIngresoNeto.TabIndex = 1;
            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(20, 22);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(69, 13);
            this.lblSueldoNeto.TabIndex = 0;
            this.lblSueldoNeto.Text = "Sueldo Neto:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtISRAdicional);
            this.groupBox4.Controls.Add(this.lblISRAdicional);
            this.groupBox4.Controls.Add(this.txtISR);
            this.groupBox4.Controls.Add(this.lblISR);
            this.groupBox4.Location = new System.Drawing.Point(24, 462);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 59);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deducciones";
            // 
            // txtISRAdicional
            // 
            this.txtISRAdicional.Location = new System.Drawing.Point(251, 28);
            this.txtISRAdicional.Name = "txtISRAdicional";
            this.txtISRAdicional.ReadOnly = true;
            this.txtISRAdicional.Size = new System.Drawing.Size(100, 20);
            this.txtISRAdicional.TabIndex = 3;
            // 
            // lblISRAdicional
            // 
            this.lblISRAdicional.AutoSize = true;
            this.lblISRAdicional.Location = new System.Drawing.Point(171, 31);
            this.lblISRAdicional.Name = "lblISRAdicional";
            this.lblISRAdicional.Size = new System.Drawing.Size(74, 13);
            this.lblISRAdicional.TabIndex = 2;
            this.lblISRAdicional.Text = "ISR Adicional:";
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(50, 28);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(100, 20);
            this.txtISR.TabIndex = 1;
            // 
            // lblISR
            // 
            this.lblISR.AutoSize = true;
            this.lblISR.Location = new System.Drawing.Point(16, 31);
            this.lblISR.Name = "lblISR";
            this.lblISR.Size = new System.Drawing.Size(28, 13);
            this.lblISR.TabIndex = 0;
            this.lblISR.Text = "ISR:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.lblSueldoMasBono);
            this.groupBox3.Location = new System.Drawing.Point(21, 401);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 55);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sub Totales";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(104, 24);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 1;
            // 
            // lblSueldoMasBono
            // 
            this.lblSueldoMasBono.AutoSize = true;
            this.lblSueldoMasBono.Location = new System.Drawing.Point(13, 27);
            this.lblSueldoMasBono.Name = "lblSueldoMasBono";
            this.lblSueldoMasBono.Size = new System.Drawing.Size(85, 13);
            this.lblSueldoMasBono.TabIndex = 0;
            this.lblSueldoMasBono.Text = "Sueldo + Bonos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalBonoPorHora);
            this.groupBox2.Controls.Add(this.lblTotalBonoHora);
            this.groupBox2.Controls.Add(this.txtTotalBonoPorEntrega);
            this.groupBox2.Controls.Add(this.lblTotalBonoEntrega);
            this.groupBox2.Location = new System.Drawing.Point(21, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 69);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Percepciones";
            // 
            // txtTotalBonoPorHora
            // 
            this.txtTotalBonoPorHora.Location = new System.Drawing.Point(319, 26);
            this.txtTotalBonoPorHora.Name = "txtTotalBonoPorHora";
            this.txtTotalBonoPorHora.ReadOnly = true;
            this.txtTotalBonoPorHora.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBonoPorHora.TabIndex = 3;
            // 
            // lblTotalBonoHora
            // 
            this.lblTotalBonoHora.AutoSize = true;
            this.lblTotalBonoHora.Location = new System.Drawing.Point(220, 30);
            this.lblTotalBonoHora.Name = "lblTotalBonoHora";
            this.lblTotalBonoHora.Size = new System.Drawing.Size(88, 13);
            this.lblTotalBonoHora.TabIndex = 2;
            this.lblTotalBonoHora.Text = "Total Bono Hora:";
            // 
            // txtTotalBonoPorEntrega
            // 
            this.txtTotalBonoPorEntrega.Location = new System.Drawing.Point(111, 26);
            this.txtTotalBonoPorEntrega.Name = "txtTotalBonoPorEntrega";
            this.txtTotalBonoPorEntrega.ReadOnly = true;
            this.txtTotalBonoPorEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBonoPorEntrega.TabIndex = 1;
            // 
            // lblTotalBonoEntrega
            // 
            this.lblTotalBonoEntrega.AutoSize = true;
            this.lblTotalBonoEntrega.Location = new System.Drawing.Point(8, 28);
            this.lblTotalBonoEntrega.Name = "lblTotalBonoEntrega";
            this.lblTotalBonoEntrega.Size = new System.Drawing.Size(102, 13);
            this.lblTotalBonoEntrega.TabIndex = 0;
            this.lblTotalBonoEntrega.Text = "Total Bono Entrega:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 653);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbMes);
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.dtYear);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.txtRol);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.txtNombreEmpleado);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.txtIDEmpleado);
            this.groupBox8.Controls.Add(this.label5);
            this.groupBox8.Location = new System.Drawing.Point(22, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(433, 172);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Empleado";
            // 
            // cbMes
            // 
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
            this.cbMes.Location = new System.Drawing.Point(118, 135);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(250, 21);
            this.cbMes.TabIndex = 29;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mes:";
            // 
            // dtYear
            // 
            this.dtYear.CustomFormat = "yyyy";
            this.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtYear.Location = new System.Drawing.Point(118, 109);
            this.dtYear.Name = "dtYear";
            this.dtYear.Size = new System.Drawing.Size(80, 20);
            this.dtYear.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Año:";
            // 
            // txtRol
            // 
            this.txtRol.Location = new System.Drawing.Point(118, 79);
            this.txtRol.Name = "txtRol";
            this.txtRol.ReadOnly = true;
            this.txtRol.Size = new System.Drawing.Size(300, 20);
            this.txtRol.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Rol:";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(118, 48);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(300, 20);
            this.txtNombreEmpleado.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nombre Empleado:";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(118, 17);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(300, 20);
            this.txtIDEmpleado.TabIndex = 21;
            this.txtIDEmpleado.TextChanged += new System.EventHandler(this.txtIDEmpleado_TextChanged);
            this.txtIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDEmpleado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID Empleado:";
            // 
            // ConsultaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 688);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pagos";
            this.Load += new System.EventHandler(this.ConsultaPagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBonoPorHora;
        private System.Windows.Forms.Label lblBonoPorHora;
        private System.Windows.Forms.TextBox txtBonoPorEntrega;
        private System.Windows.Forms.Label lblBonoPorEntrega;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Label lblSueldoBruto;
        private System.Windows.Forms.TextBox txtHorasPorTurno;
        private System.Windows.Forms.Label lblHorasPorTurno;
        private System.Windows.Forms.TextBox txtTotalEntregas;
        private System.Windows.Forms.Label lblTotalEntregas;
        private System.Windows.Forms.TextBox txtDiasPorTurno;
        private System.Windows.Forms.Label lblDiasPorTurno;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.Label lblSueldoHora;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPagoNeto;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox txtValesDespensa;
        private System.Windows.Forms.Label lblValesDespensa;
        private System.Windows.Forms.TextBox txtIngresoNeto;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtISRAdicional;
        private System.Windows.Forms.Label lblISRAdicional;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.Label lblISR;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblSueldoMasBono;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalBonoPorHora;
        private System.Windows.Forms.Label lblTotalBonoHora;
        private System.Windows.Forms.TextBox txtTotalBonoPorEntrega;
        private System.Windows.Forms.Label lblTotalBonoEntrega;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label label5;
    }
}