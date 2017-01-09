using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccurateAutoInventory
{
    public partial class Search : Form
    {
        String stockNum = "123";  //used for testing purposes

        public Search()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void Quit3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search3_Click(object sender, EventArgs e)
        {

        }
    }
}
