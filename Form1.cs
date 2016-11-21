using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public delegate int Calculate(int a, int b, int c, int d, int e, int f);

    public partial class MySimpleCalc : Form
    {
        public MySimpleCalc()
        {
            InitializeComponent();
        }



       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            richTextBox1.Text = "1";

        }

        private void button2_Click(object sender, EventArgs e) {
            richTextBox1.Text = "2";

        }

        private void button3_Click(object sender, EventArgs e) {
            richTextBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e) {
            richTextBox1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e) {
            richTextBox1.Text = "5";

        }

        private void button6_Click(object sender, EventArgs e){
            richTextBox1.Text = "6";
        }

        private void button7_Click(object sender, EventArgs e){
            richTextBox1.Text = "7";

        }

        private void button8_Click(object sender, EventArgs e){
            richTextBox1.Text = "8";
            
        }

        private void button9_Click(object sender, EventArgs e){
            richTextBox1.Text = "9";
         
        }

        private void button10_Click(object sender, EventArgs e){
            richTextBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e){
            richTextBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e){
            richTextBox1.Text = "/";
        }

        private void button14_Click(object sender, EventArgs e){
            richTextBox1.Text = "*";

        }

        private void button11_Click(object sender, EventArgs e){
            richTextBox1.Text = "-";
        }

        private void button12_Click(object sender, EventArgs e){
            richTextBox1.Text = "+";
          //  int.TryParse(richTextBox1.Text );

        }

        private void button15_Click(object sender, EventArgs e ){ 
            richTextBox1.Text = "=";
            int.Parse(richTextBox1.Text);     
         }

      /*  public static int Sum(int a, int b, int c, int d, int e, int f,) {

            return a + b + c + d + e + f;
        }

        public static int Product(int a, int b, int c, int d, int e, int f) {

            return a * b * c * d * e * f;
        }

        public static int Difference(int a, int b, int c, int d, int e, int f,){

            return a - b - c - d - e - f;
        }

        public static int Quotient(int a, int b, int c, int d, int e, int f,){

            return a / b / c / d / e / f;
        }  */

    }
}
