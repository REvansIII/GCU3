using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccurateAutoInventory
{
    public partial class RemoveVehicle : Form
    {
        
        private string stockNum = "123";  //initial stock # for testing purposes

        public RemoveVehicle()
        {
            InitializeComponent();
        }

        private void Menu2_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void Quit2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.JET.OLEDB.4.0;" + "Data Source = C:\\Users\\Robbie\\Documents\\Auto_Inventory.mdb"; //database that's being accessed

            //take heed of table name here
            string commandText = "DELETE FROM Inventory2 WHERE textBox1.Text = StockID";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                //Create a Command instance
                OleDbCommand command = new OleDbCommand(commandText, connection);

                command.Parameters.Add("@StockID", OleDbType.Double, 1000).Value = textBox1.Text;
                command.Parameters.Add("@Make", OleDbType.VarWChar, 20).Value = null;
                command.Parameters.Add("@Model", OleDbType.VarWChar, 20).Value = null;
                command.Parameters.Add("@ModelYear", OleDbType.VarWChar, 4).Value = null;

                //Execute the query
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


        }
    }
}
