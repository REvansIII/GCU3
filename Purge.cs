using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccurateAutoInventory
{
    public partial class Purge : Form
    {

        private string password = "autho1";

        public Purge()
        {
            InitializeComponent();
        }

        private void Menu5_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void Quit5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == password)
            {
                MessageBox.Show("Access Granted");

                string sqlTrunc = "DELETE FROM Inventory2"; //name of Table
                string connString = "Provider = Microsoft.JET.OLEDB.4.0;" + "Data Source = C:\\Users\\Robbie\\Documents\\Auto_Inventory.mdb"; //database that's being accessed

                using (OleDbConnection connection = new OleDbConnection(connString))
                {
                    //Create a SqlCommand instance 
                    OleDbCommand command = new OleDbCommand(sqlTrunc, connection);

                    
                    //Execute the query
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }

            }
            else
                MessageBox.Show("Access Denied");
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
