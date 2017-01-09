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
    public partial class RunReports : Form
    {
        private string report1 = "inventory";
        private string report2 = "models";
        private string report3 = "type";

        public RunReports()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AaiMain main = new AaiMain();
            main.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ReportEnter_Click(object sender, EventArgs e)
        { if (textBox1.Text == report1)
            {
                MessageBox.Show("return Report1");

                string connString = "Provider = Microsoft.JET.OLEDB.4.0;" + "Data Source = C:\\Users\\Robbie\\Documents\\Auto_Inventory.mdb"; //database that's being accessed

                //pay attention to table name here
                string commandText = "SELECT StockID, ModelYear, Make, Model from Inventory2 ORDER BY StockID";

                using (OleDbConnection connection = new OleDbConnection(connString))
                {
                    //Create a Command instance
                    OleDbCommand command = new OleDbCommand(commandText, connection);


                    //Execute the query
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        OleDbDataReader reader = command.ExecuteReader();
                       
                        while (reader.Read())                            
                         Console.WriteLine(reader.GetString(1)); // needs revision to show client outcome
                        reader.Close();



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
            else
                MessageBox.Show("No report found; Please try again");
                }
            }
        }
    

