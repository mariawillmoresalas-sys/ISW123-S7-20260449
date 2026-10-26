namespace VillaCoralReservas
{
    partial class Form1
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
            lblCliente = new Label();
            txtCliente = new TextBox();
            lblTipoDeHabitacion = new Label();
            cmbTipoDeHabitacion = new ComboBox();
            lblFechaDeEntrada = new Label();
            dtpFechaDeEntrada = new DateTimePicker();
            lblNoches = new Label();
            nudNoches = new NumericUpDown();
            nudHuespedes = new NumericUpDown();
            lblHuespedes = new Label();
            btnAgregarReserva = new Button();
            btnBuscarCliente = new Button();
            btnVerResumen = new Button();
            lblTarifas = new Label();
            lstReservas = new ListBox();
            txtResumen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHuespedes).BeginInit();
            SuspendLayout();
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(44, 34);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(94, 26);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(299, 23);
            txtCliente.TabIndex = 1;
            // 
            // lblTipoDeHabitacion
            // 
            lblTipoDeHabitacion.AutoSize = true;
            lblTipoDeHabitacion.Location = new Point(44, 71);
            lblTipoDeHabitacion.Name = "lblTipoDeHabitacion";
            lblTipoDeHabitacion.Size = new Size(106, 15);
            lblTipoDeHabitacion.TabIndex = 2;
            lblTipoDeHabitacion.Text = "Tipo de habitación";
            // 
            // cmbTipoDeHabitacion
            // 
            cmbTipoDeHabitacion.FormattingEnabled = true;
            cmbTipoDeHabitacion.Location = new Point(156, 63);
            cmbTipoDeHabitacion.Name = "cmbTipoDeHabitacion";
            cmbTipoDeHabitacion.Size = new Size(121, 23);
            cmbTipoDeHabitacion.TabIndex = 3;
            // 
            // lblFechaDeEntrada
            // 
            lblFechaDeEntrada.AutoSize = true;
            lblFechaDeEntrada.Location = new Point(44, 105);
            lblFechaDeEntrada.Name = "lblFechaDeEntrada";
            lblFechaDeEntrada.Size = new Size(97, 15);
            lblFechaDeEntrada.TabIndex = 4;
            lblFechaDeEntrada.Text = "Fecha de entrada";
            // 
            // dtpFechaDeEntrada
            // 
            dtpFechaDeEntrada.Format = DateTimePickerFormat.Short;
            dtpFechaDeEntrada.Location = new Point(156, 99);
            dtpFechaDeEntrada.Name = "dtpFechaDeEntrada";
            dtpFechaDeEntrada.Size = new Size(121, 23);
            dtpFechaDeEntrada.TabIndex = 5;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(44, 136);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(47, 15);
            lblNoches.TabIndex = 6;
            lblNoches.Text = "Noches";
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(115, 134);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(63, 23);
            nudNoches.TabIndex = 7;
            nudNoches.TextAlign = HorizontalAlignment.Center;
            nudNoches.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudHuespedes
            // 
            nudHuespedes.Location = new Point(115, 175);
            nudHuespedes.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudHuespedes.Name = "nudHuespedes";
            nudHuespedes.Size = new Size(63, 23);
            nudHuespedes.TabIndex = 9;
            nudHuespedes.TextAlign = HorizontalAlignment.Center;
            nudHuespedes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblHuespedes
            // 
            lblHuespedes.AutoSize = true;
            lblHuespedes.Location = new Point(44, 179);
            lblHuespedes.Name = "lblHuespedes";
            lblHuespedes.Size = new Size(65, 15);
            lblHuespedes.TabIndex = 10;
            lblHuespedes.Text = "Huespedes";
            // 
            // btnAgregarReserva
            // 
            btnAgregarReserva.Location = new Point(349, 89);
            btnAgregarReserva.Name = "btnAgregarReserva";
            btnAgregarReserva.Size = new Size(111, 27);
            btnAgregarReserva.TabIndex = 11;
            btnAgregarReserva.Text = "Agregar reserva";
            btnAgregarReserva.UseVisualStyleBackColor = true;
            btnAgregarReserva.Click += btnAgregarReserva_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(349, 124);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(111, 27);
            btnBuscarCliente.TabIndex = 12;
            btnBuscarCliente.Text = "Buscar cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // btnVerResumen
            // 
            btnVerResumen.Location = new Point(349, 163);
            btnVerResumen.Name = "btnVerResumen";
            btnVerResumen.Size = new Size(111, 27);
            btnVerResumen.TabIndex = 13;
            btnVerResumen.Text = "Ver resumen";
            btnVerResumen.UseVisualStyleBackColor = true;
            // 
            // lblTarifas
            // 
            lblTarifas.AutoSize = true;
            lblTarifas.Location = new Point(403, 254);
            lblTarifas.Name = "lblTarifas";
            lblTarifas.Size = new Size(13, 15);
            lblTarifas.TabIndex = 14;
            lblTarifas.Text = "0";
            // 
            // lstReservas
            // 
            lstReservas.FormattingEnabled = true;
            lstReservas.Location = new Point(12, 254);
            lstReservas.Name = "lstReservas";
            lstReservas.Size = new Size(381, 154);
            lstReservas.TabIndex = 15;
            // 
            // txtResumen
            // 
            txtResumen.Location = new Point(548, 71);
            txtResumen.Multiline = true;
            txtResumen.Name = "txtResumen";
            txtResumen.ReadOnly = true;
            txtResumen.ScrollBars = ScrollBars.Vertical;
            txtResumen.Size = new Size(187, 337);
            txtResumen.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 450);
            Controls.Add(txtResumen);
            Controls.Add(lstReservas);
            Controls.Add(lblTarifas);
            Controls.Add(btnVerResumen);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnAgregarReserva);
            Controls.Add(lblHuespedes);
            Controls.Add(nudHuespedes);
            Controls.Add(nudNoches);
            Controls.Add(lblNoches);
            Controls.Add(dtpFechaDeEntrada);
            Controls.Add(lblFechaDeEntrada);
            Controls.Add(cmbTipoDeHabitacion);
            Controls.Add(lblTipoDeHabitacion);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Name = "Form1";
            Text = "VillaCoralReservas-MariaTeresaSalasW:2026-0449";
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHuespedes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCliente;
        private TextBox txtCliente;
        private Label lblTipoDeHabitacion;
        private ComboBox cmbTipoDeHabitacion;
        private Label lblFechaDeEntrada;
        private DateTimePicker dtpFechaDeEntrada;
        private Label lblNoches;
        private NumericUpDown nudNoches;
        private Label lblHuesped;
        private NumericUpDown nudHuespedes;
        private Label lblHuespedes;
        private Button btnAgregarReserva;
        private Button btnBuscarCliente;
        private Button btnVerResumen;
        private Label lblTarifas;
        private ListBox lstReservas;
        private TextBox txtResumen;
    }
}
