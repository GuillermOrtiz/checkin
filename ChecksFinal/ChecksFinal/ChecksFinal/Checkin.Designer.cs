namespace ChecksFinal
{
    partial class Checkin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.nudBebes = new System.Windows.Forms.NumericUpDown();
            this.nudNiños = new System.Windows.Forms.NumericUpDown();
            this.nudAdultos = new System.Windows.Forms.NumericUpDown();
            this.txtNoReserva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.cmbNoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblprueba = new System.Windows.Forms.Label();
            this.dgvcheckin = new System.Windows.Forms.DataGridView();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcheckin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(136, 363);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(141, 24);
            this.cmbTipoHabitacion.TabIndex = 31;
            this.cmbTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoHabitacion_SelectedIndexChanged);
            // 
            // nudBebes
            // 
            this.nudBebes.Location = new System.Drawing.Point(399, 317);
            this.nudBebes.Name = "nudBebes";
            this.nudBebes.Size = new System.Drawing.Size(44, 22);
            this.nudBebes.TabIndex = 30;
            // 
            // nudNiños
            // 
            this.nudNiños.Location = new System.Drawing.Point(217, 317);
            this.nudNiños.Name = "nudNiños";
            this.nudNiños.Size = new System.Drawing.Size(44, 22);
            this.nudNiños.TabIndex = 29;
            // 
            // nudAdultos
            // 
            this.nudAdultos.Location = new System.Drawing.Point(72, 317);
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(44, 22);
            this.nudAdultos.TabIndex = 28;
            this.nudAdultos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtNoReserva
            // 
            this.txtNoReserva.Location = new System.Drawing.Point(115, 115);
            this.txtNoReserva.Name = "txtNoReserva";
            this.txtNoReserva.Size = new System.Drawing.Size(201, 22);
            this.txtNoReserva.TabIndex = 25;
            this.txtNoReserva.TextChanged += new System.EventHandler(this.txtNoReserva_TextChanged);
            this.txtNoReserva.Leave += new System.EventHandler(this.txtNoReserva_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo de habitación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Habitación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Bebés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Niños";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adultos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de salida prevista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "No. reserva";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(472, 113);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 17);
            this.lblCliente.TabIndex = 33;
            this.lblCliente.Text = "Nit cliente:";
            this.lblCliente.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNitCliente.Location = new System.Drawing.Point(585, 110);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.Size = new System.Drawing.Size(231, 22);
            this.txtNitCliente.TabIndex = 34;
            // 
            // cmbNoHabitacion
            // 
            this.cmbNoHabitacion.FormattingEnabled = true;
            this.cmbNoHabitacion.Location = new System.Drawing.Point(374, 363);
            this.cmbNoHabitacion.Name = "cmbNoHabitacion";
            this.cmbNoHabitacion.Size = new System.Drawing.Size(69, 24);
            this.cmbNoHabitacion.TabIndex = 35;
            this.cmbNoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbNoHabitacion_SelectedIndexChanged);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombreCliente.Location = new System.Drawing.Point(115, 153);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(238, 22);
            this.txtNombreCliente.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nombre Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtApellidoCliente.Location = new System.Drawing.Point(585, 153);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(231, 22);
            this.txtApellidoCliente.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Apellido cliente:";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(185, 216);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaEntrada.TabIndex = 40;
            this.dtpFechaEntrada.Value = new System.DateTime(2017, 11, 19, 0, 0, 0, 0);
            this.dtpFechaEntrada.ValueChanged += new System.EventHandler(this.dtpFechaEntrada_ValueChanged);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(185, 262);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaSalida.TabIndex = 41;
            this.dtpFechaSalida.Value = new System.DateTime(2017, 11, 19, 0, 0, 0, 0);
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.Location = new System.Drawing.Point(643, 485);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(0, 17);
            this.lblprueba.TabIndex = 42;
            // 
            // dgvcheckin
            // 
            this.dgvcheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcheckin.Location = new System.Drawing.Point(475, 229);
            this.dgvcheckin.Name = "dgvcheckin";
            this.dgvcheckin.RowTemplate.Height = 24;
            this.dgvcheckin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcheckin.Size = new System.Drawing.Size(436, 154);
            this.dgvcheckin.TabIndex = 44;
            this.dgvcheckin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(322, 115);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(31, 23);
            this.btnReserva.TabIndex = 45;
            this.btnReserva.Text = "....";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(828, 130);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(83, 69);
            this.btnIngresar.TabIndex = 46;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(145, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 49);
            this.panel1.TabIndex = 48;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(254, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cliente";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Reserva";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(920, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.dgvcheckin);
            this.Controls.Add(this.lblprueba);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbNoHabitacion);
            this.Controls.Add(this.txtNitCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbTipoHabitacion);
            this.Controls.Add(this.nudBebes);
            this.Controls.Add(this.nudNiños);
            this.Controls.Add(this.nudAdultos);
            this.Controls.Add(this.txtNoReserva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Checkin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Check in";
            this.Activated += new System.EventHandler(this.Checkin_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBebes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcheckin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblprueba;
        private System.Windows.Forms.DataGridView dgvcheckin;
        private System.Windows.Forms.Button btnReserva;
        public System.Windows.Forms.TextBox txtNoReserva;
        public System.Windows.Forms.TextBox txtNitCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtApellidoCliente;
        public System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        public System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.ComboBox cmbTipoHabitacion;
        public System.Windows.Forms.NumericUpDown nudBebes;
        public System.Windows.Forms.NumericUpDown nudNiños;
        public System.Windows.Forms.NumericUpDown nudAdultos;
        public System.Windows.Forms.ComboBox cmbNoHabitacion;
    }
}

