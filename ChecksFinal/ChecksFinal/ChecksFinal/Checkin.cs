using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChecksFinal
{
    public partial class Checkin : Form
    {
        conector con = new conector();

        OdbcConnection cone = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=analisis; ");

        OdbcCommand cmd;
        OdbcDataReader dr;


        public Checkin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //desactivar todos los campos que puedan ser llenados
            txtApellidoCliente.Enabled = false;
            txtNitCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtNoReserva.Enabled = false;
            nudAdultos.Enabled = true;
            nudBebes.Enabled = true;
            nudNiños.Enabled = true;
            dtpFechaEntrada.Enabled = true;
            dtpFechaSalida.Enabled = true;

            
            cmbNoHabitacion.Enabled = true;
            cmbTipoHabitacion.Enabled = true;



            String TipoHabitacion = "select tipo_habitacion from tipo_Habitacion;";
            con.llenarCMB(TipoHabitacion, cmbTipoHabitacion);

           
            

            /*string sql = "select nitCliente Nit, nombreCliente Nombre, apellidoCliente Apellido from cliente;";
            con.LlenarDGV(sql,dataGridView1);*/
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SQL = "select h.noHabitacion ";
            SQL += "from habitacion as h, tipo_habitacion as t ";
            SQL += "where h.tipo_habitacion_idTipo_Habitacion = t.idtipo_Habitacion ";
            SQL += "and t.Tipo_Habitacion = '" + cmbTipoHabitacion.SelectedItem.ToString() + "'";
            SQL += "and h.disponibilidad = 'si' ;";

            con.llenarCMB(SQL, cmbNoHabitacion);
        }

        private void dtpFechaEntrada_ValueChanged(object sender, EventArgs e)
        {
                        
        }

        private void txtNoReserva_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNoReserva_Leave(object sender, EventArgs e)
        {

            

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar txt con datos del dataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvcheckin.Rows[e.RowIndex];

                txtNitCliente.Text = row.Cells["nitCliente"].Value.ToString();
                txtNombreCliente.Text = row.Cells["nombreCliente"].Value.ToString();
                txtApellidoCliente.Text = row.Cells["apellidoCliente"].Value.ToString();
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_RecibidorActualizar(object sender, EventArgs e)
        {



        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            busquedaReserva bsq = new busquedaReserva();
            bsq.Show();
            txtNoReserva.Text = Program.idReserva.ToString();
            txtNombreCliente.Text = Program.nombreCliente.ToString();
            //txtApellidoCliente.Text = Program.apellido.ToString();
            dtpFechaEntrada.Text = Program.fechaEntrada.ToString();
            dtpFechaSalida.Text = Program.fechaSalida.ToString();
            }

        public void button2_Click(object sender, EventArgs e)
        {
            //OBTENER LAS FECHAS CONVERTIDAS PAR INSERTARLAS EN LA BASE DE DATOS
            String fechaEntrada = "";
            con.obtenerFecha(dtpFechaEntrada, fechaEntrada);
            String fechaSalida = "";
            con.obtenerFecha(dtpFechaSalida, fechaSalida);




            //////////////////////////ENCONTRAR EL ID DE RESERVACION 
            String SQL = "select nitcliente from cliente where nombreCLiente = '" + txtNombreCliente.Text +"';";
            String idcampo = "nitCliente";
            int resultadoIdCheck = 0;
            cone.Open();
            cmd = new OdbcCommand(SQL, cone);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idcampo = dr["nitCliente"].ToString();
                resultadoIdCheck = Convert.ToInt32(idcampo);
            }
            cone.Close();
            txtNitCliente.Text = resultadoIdCheck.ToString();


            String SQL = "select r.id_reservacion  from cliente c, reservacion r where c.idcliente = r.Cliente_idCliente And c.nombreCliente = '"+txtNombreCliente.Text+"';";
";
            String idres = "id_reservacion";
            int resultadoIdreserv = 0;
            cone.Open();
            cmd = new OdbcCommand(SQL, cone);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                idcampo = dr["id_reservacion"].ToString();
                resultadoIdCheck = Convert.ToInt32(idcampo);
            }
            cone.Close();
            txtNoReserva.Text = resultadoIdreserv.ToString();
            /////////////////////////nombre cliente
            //String sqlN = "Insert into checkin() ";


            try
            {
                String ins = "Insert into checkin(FechaEntrada, fechaSalida, cliente_idCliente, reservacion_id_reservacion) values('"+fechaEntrada.ToString()+"','"+fechaSalida.ToString()+"','"+resultadoIdCheck.ToString()+"','"+resultadoIdreserv.ToString()+"')";
            }
            catch (OdbcException ex)
            {

            }





        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            String Sql = "Select *from cliente";
            con.LlenarDGV(Sql, dgvcheckin);
            btnIngresar.Enabled = true;

        }

        private void Checkin_Activated(object sender, EventArgs e)
        {

        }

        private void cmbNoHabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
        }
    }
}
