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
            this.label9 = new System.Windows.Forms.Label();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.cmbNoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblprueba = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.navegador1 = new Navegador.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.nudBebes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoHabitacion
            // 
            this.cmbTipoHabitacion.FormattingEnabled = true;
            this.cmbTipoHabitacion.Location = new System.Drawing.Point(165, 360);
            this.cmbTipoHabitacion.Name = "cmbTipoHabitacion";
            this.cmbTipoHabitacion.Size = new System.Drawing.Size(141, 24);
            this.cmbTipoHabitacion.TabIndex = 31;
            this.cmbTipoHabitacion.SelectedIndexChanged += new System.EventHandler(this.cmbTipoHabitacion_SelectedIndexChanged);
            // 
            // nudBebes
            // 
            this.nudBebes.Location = new System.Drawing.Point(428, 314);
            this.nudBebes.Name = "nudBebes";
            this.nudBebes.Size = new System.Drawing.Size(44, 22);
            this.nudBebes.TabIndex = 30;
            // 
            // nudNiños
            // 
            this.nudNiños.Location = new System.Drawing.Point(246, 314);
            this.nudNiños.Name = "nudNiños";
            this.nudNiños.Size = new System.Drawing.Size(44, 22);
            this.nudNiños.TabIndex = 29;
            // 
            // nudAdultos
            // 
            this.nudAdultos.Location = new System.Drawing.Point(101, 314);
            this.nudAdultos.Name = "nudAdultos";
            this.nudAdultos.Size = new System.Drawing.Size(44, 22);
            this.nudAdultos.TabIndex = 28;
            this.nudAdultos.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtNoReserva
            // 
            this.txtNoReserva.Location = new System.Drawing.Point(144, 112);
            this.txtNoReserva.Name = "txtNoReserva";
            this.txtNoReserva.Size = new System.Drawing.Size(201, 22);
            this.txtNoReserva.TabIndex = 25;
            this.txtNoReserva.TextChanged += new System.EventHandler(this.txtNoReserva_TextChanged);
            this.txtNoReserva.Leave += new System.EventHandler(this.txtNoReserva_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tipo de habitación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Habitación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Bebés";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Niños";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Adultos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de salida prevista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "No. reserva";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nit cliente:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNitCliente.Location = new System.Drawing.Point(614, 107);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.Size = new System.Drawing.Size(231, 22);
            this.txtNitCliente.TabIndex = 34;
            // 
            // cmbNoHabitacion
            // 
            this.cmbNoHabitacion.FormattingEnabled = true;
            this.cmbNoHabitacion.Location = new System.Drawing.Point(403, 360);
            this.cmbNoHabitacion.Name = "cmbNoHabitacion";
            this.cmbNoHabitacion.Size = new System.Drawing.Size(69, 24);
            this.cmbNoHabitacion.TabIndex = 35;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNombreCliente.Location = new System.Drawing.Point(144, 150);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(238, 22);
            this.txtNombreCliente.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Nombre Cliente";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtApellidoCliente.Location = new System.Drawing.Point(614, 150);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(231, 22);
            this.txtApellidoCliente.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(501, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Apellido cliente:";
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(214, 213);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaEntrada.TabIndex = 40;
            this.dtpFechaEntrada.ValueChanged += new System.EventHandler(this.dtpFechaEntrada_ValueChanged);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(214, 259);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(246, 22);
            this.dtpFechaSalida.TabIndex = 41;
            // 
            // lblprueba
            // 
            this.lblprueba.AutoSize = true;
            this.lblprueba.Location = new System.Drawing.Point(643, 421);
            this.lblprueba.Name = "lblprueba";
            this.lblprueba.Size = new System.Drawing.Size(0, 17);
            this.lblprueba.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(454, 154);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(879, 27);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(83, 65);
            this.btnConsulta.TabIndex = 43;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 45;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(879, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 69);
            this.button2.TabIndex = 46;
            this.button2.Text = "Ingresar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(58, 27);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(745, 58);
            this.navegador1.sNombreBD = null;
            this.navegador1.sNombreTabla = null;
            this.navegador1.sPass = null;
            this.navegador1.sResult = null;
            this.navegador1.sServidor = null;
            this.navegador1.sUsuario = null;
            this.navegador1.TabIndex = 47;
            // 
            // Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(998, 413);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblprueba);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.dtpFechaEntrada);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbNoHabitacion);
            this.Controls.Add(this.txtNitCliente);
            this.Controls.Add(this.label9);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBebes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNiños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipoHabitacion;
        private System.Windows.Forms.NumericUpDown nudBebes;
        private System.Windows.Forms.NumericUpDown nudNiños;
        private System.Windows.Forms.NumericUpDown nudAdultos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbNoHabitacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblprueba;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtNoReserva;
        public System.Windows.Forms.TextBox txtNitCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtApellidoCliente;
        public System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        public System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Button button2;
        private Navegador.Navegador navegador1;
    }
}

