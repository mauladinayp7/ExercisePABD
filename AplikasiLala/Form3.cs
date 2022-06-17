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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tugasLalaDataSet3.CatatanPengingat' table. You can move, or remove it, as needed.
            this.catatanPengingatTableAdapter.Fill(this.tugasLalaDataSet3.CatatanPengingat);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 mn = new Form4();
            mn.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
