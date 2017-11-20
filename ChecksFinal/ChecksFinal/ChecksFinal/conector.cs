using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;

namespace ChecksFinal
{
    class conector
    {
        OdbcConnection con = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; Dsn=analisis; ");
        
        OdbcCommand cmd;
        OdbcDataReader dr;
        OdbcDataAdapter da;

       

        //Conexion
        public void cone()
        {
            
            try {
                con.Open();
                MessageBox.Show("Conexion creada satisfactoriamente ");
            }
            catch (OdbcException ex) {
                MessageBox.Show("La conexión no se pudo establecer "+ ex.ToString());
            }
        }

        /*public bool comprobacionConexion()
        {
            try
            {
                cone();
                return true;
            }
            catch (OdbcException ex)
            {
                return false;
            }
        }*/

        //consulta de datos 
        public void consulta(String sql, String CampoAObtener, String resultado) {
            cmd = new OdbcCommand(sql, con);
            con.Open();
            OdbcDataReader leer = cmd.ExecuteReader();
            if (leer.Read() == true)
            {
                resultado = leer[CampoAObtener].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el registro en la base de datos");
            }
            con.Close();
        }


    //    string id_usuario; int id = 0;
    //    com = new OdbcCommand("select id_usuario from usuario where usuario ='" + txt_usuario.Text + "' ", con.conexion());
    //    dr = com.ExecuteReader();
    //            while (dr.Read())
    //            {
    //                id_usuario = dr["id_usuario"].ToString();
    //    id = Convert.ToInt32(id_usuario);
    //            }
    //dr.Close();

        public void DevolverIdConsulta(String SQL, String campo, int resultado) {
            con.Open();
            cmd = new OdbcCommand (SQL, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                campo = dr[campo].ToString();
                resultado = Convert.ToInt32(campo);
            }
            con.Close();
        }

        public void ConsultaVacía(String SQL)
        {
            try
            {
                con.Open();
                cmd = new OdbcCommand(SQL, con);
                dr = cmd.ExecuteReader();
                con.Close();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("Error al ejecutar el comando SQL //conector.css \n \n", ex.ToString());
            }
            
        }

        public void LlenarDGV(String SQL, DataGridView dgv)
        {
            // Se abre la conexion
            con.Open();
            try

            {
                cmd = new OdbcCommand(SQL, con);
                da = new OdbcDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el dataGridView ....... \n" + ex.ToString());
            }
            // Se cierra la conexión a la base de datos
            con.Close();
        }

        //Obtener fecha datetimepicker
        public void obtenerFecha(DateTimePicker dtp, String fecha)
        {
            String año, mes, dia;
            año = dtp.Value.Year.ToString();
            mes = dtp.Value.Month.ToString();
            dia = dtp.Value.Day.ToString();
            fecha = año + "/" + mes + "/" + dia;
        }


        //con.llenarCMB(SQL, cmb1);
        public void llenarCMB(String SQL, ComboBox cmb)
        {
            cmb.Text = "";
            cmb.Items.Clear();
            try
            {
                con.Open();
                cmd = new OdbcCommand(SQL, con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmb.Refresh();
                    cmb.Items.Add(dr.GetValue(0).ToString());
                }
                con.Close();
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("No se pudo llenar el comboBox \n \n" + ex.ToString());
            }
        }
       

    }
}
