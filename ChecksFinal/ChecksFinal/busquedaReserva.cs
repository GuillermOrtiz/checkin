using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChecksFinal
{
    public partial class busquedaReserva : Form
    {
        conector con = new conector();
        public String idreserva = "";



        public busquedaReserva()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String sql = "select * from reservacion where nombreCliente like '" + txtNombreReserva.Text + "%';";
            con.LlenarDGV(sql, dataGridView1);
        }

        private void txtNombreReserva_ModifiedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.idReserva = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.nombre = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //Program.apellido = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Program.fechaEntrada = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Program.fechaSalida = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
