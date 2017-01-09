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
    public partial class AddVehicle : Form
    {
       

        public AddVehicle()
        {
            InitializeComponent();
        }

        public static object Me { get; internal set; }

        private void Menu1_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void Quit1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {         

         

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.JET.OLEDB.4.0;" + "Data Source = C:\\Users\\Robbie\\Documents\\Auto_Inventory.mdb"; //database that's being accessed

            //pay attention to table name here
            string commandText = "INSERT INTO Inventory2  (ModelYear, Make, Model) VALUES (textBox4.Text, textBox2.Text, textBox3.Text)";

            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                //Create a Command instance
                OleDbCommand command = new OleDbCommand(commandText, connection);
               

                //Add the parameter
                command.Parameters.Add("@Make", OleDbType.VarWChar, 20).Value = textBox2.Text;
                command.Parameters.Add("@Model", OleDbType.VarWChar, 20).Value = textBox3.Text;
                command.Parameters.Add("@ModelYear", OleDbType.VarWChar, 4).Value = textBox4.Text;

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



    } }
