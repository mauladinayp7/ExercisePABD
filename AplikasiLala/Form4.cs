using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiLala
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasLalaDataSet2.CatatanPenting' table. You can move, or remove it, as needed.
            this.catatanPentingTableAdapter.Fill(this.tugasLalaDataSet2.CatatanPenting);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
