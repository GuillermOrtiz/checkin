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
            String sql = "select r.id_reservacion, r.fechaEntrada, r.fechaSalida, c.nombreCliente, c.apellidoCliente from cliente c, reservacion r where c.idcliente = r.Cliente_idCliente AND c.nombreCliente like '" + txtNombreReserva.Text + "%';";
            con.LlenarDGV(sql, dataGridView1);
        }

        private void txtNombreReserva_ModifiedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.idReserva = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Program.fechaEntrada = dataGridView1.CurrentRow.Cells[1].Value.ToString();  
            Program.fechaSalida = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Program.nombreCliente = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Program.apellidoCliente = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void busquedaReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
