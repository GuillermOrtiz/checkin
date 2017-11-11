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
using Navegador;

namespace ChecksFinal
{
    public partial class Checkin : Form
    {
        conector con = new conector();
        


        public Checkin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String TipoHabitacion = "select nombreTipoHabitacion from tipoHabitacion;";
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
            String SQL = "select h.numeroHabitacion ";
            SQL += "from habitacion as h, tipoHabitacion as t ";
            SQL += "where h.tipohabitacion_idTipoHabitacion = t.idtipoHabitacion ";
            SQL += "and t.nombreTipoHabitacion = '" + cmbTipoHabitacion.SelectedItem.ToString() + "'";
            SQL += "and h.estatusHabitacion = 'si' ;";

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            String sql = "select *from CLIENTE where nitCliente = " + txtNitCliente.Text + ";";
            con.LlenarDGV(sql, dataGridView1);
            //String sql = "Select  * from reservacion where nombreCliente = '"+txtNombreCliente.Text+"';";
            //String camp = "idReservacion";
            //String resultado = "";
            //con.consulta(sql,camp,resultado);
            //txtNoReserva.Text = resultado.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Llenar txt con datos del dataGridView
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

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
            txtNombreCliente.Text = Program.nombre.ToString();
            //txtApellidoCliente.Text = Program.apellido.ToString();
            dtpFechaEntrada.Text = Program.fechaEntrada.ToString();
            dtpFechaSalida.Text = Program.fechaSalida.ToString();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            //OBTENER LAS FECHAS CONVERTIDAS PAR INSERTARLAS EN LA BASE DE DATOS
            String fechaEntrada = "";
            con.obtenerFecha(dtpFechaEntrada,fechaEntrada);
            String fechaSalida = "";
            con.obtenerFecha(dtpFechaSalida, fechaSalida);

            String idCliente = "idCliente";
            String resIdCliente = "";
            String Sql1 = "select *from cliente where nombreCliente = '"+txtNombreCliente.Text+"' AND apellidoCliente = '"+txtApellidoCliente.Text+"' ;";
            
            con.consulta(Sql1,idCliente,resIdCliente);
            String sqlInsert = "insert into checkin (fechaEntrada, fechaSalida, cliente_idCliente) values ('"+fechaEntrada.ToString()+"','"+fechaSalida.ToString()+"','"+resIdCliente+"');";
            //con.ConsultaVacía(sqlInsert);
            label11.Text = resIdCliente.ToString();
        }
    }
}
