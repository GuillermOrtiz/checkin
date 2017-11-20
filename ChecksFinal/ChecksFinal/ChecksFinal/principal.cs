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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void holaToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkin chk = new Checkin();
            chk.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkout cho = new checkout();
            cho.Show();
        }
    }
}
