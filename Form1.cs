using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LogInDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Log = @"C:\\Users\\Alex Moyo\\source\\repos\\LogInDemo\\LogInDemo\\Register\\register.txt";
            using (StreamWriter alex = new StreamWriter(Log, true))
            {
                alex.Write(  txtUserName.Text + " ");
                alex.Write(" " + txtPassword.Text + "\r\n");
               

               
                    if (txtPassword.Text == txtCon.Text)
                    {
                        MessageBox.Show("Hi " + txtUserName.Text + " Your Registration details have been captured successfully \n" +
                   "Please proceed to Login \n Dont Forget your Log In details" );
                    }
                else 
                {
                    MessageBox.Show("Hi " + txtUserName.Text +" Please make sure your password and Confirm Password are the " +
                        "same \n" +
                        "Please try again", "ERROR!!!");
                }

               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginN A = new LoginN();
            A.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
