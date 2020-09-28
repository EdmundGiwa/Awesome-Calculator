using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     /*   private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } */

        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return Double.Parse((string)row["expression"]);
                
         }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        string expression = "";

        public double lastAns
        {
            get;
            private set;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblCalculation.Text =  expression = "";
            lblResult.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnEqualto_Click(object sender, EventArgs e)
        {
            lastAns = Evaluate(expression);
            timerAnimate.Start();
        }
    

        string GetRandomNums(int length)
        {
        
            string temp = "";
            Random ran = new Random();
            for (int i = 0; i < length; i++)
            {
                temp += ran.Next();
            }
            return temp;
        }

        int i = 0;
        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            if (i < 10) {
                lblResult.Text = GetRandomNums(this.lastAns.ToString().Length);
                i++;
            }
            else
            {
                i = 0;
                lblResult.Text = lastAns.ToString();
                timerAnimate.Stop();
            }
            
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            lblResult.Text = 0.ToString();
            lblCalculation.Text = (expression += ((Control)sender).Tag.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                lblCalculation.Text = expression = expression.Substring(0, expression.Length - 1);
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
