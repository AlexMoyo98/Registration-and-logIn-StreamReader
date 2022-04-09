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
    public partial class LoginN : Form
    {
        public LoginN()
        {
            InitializeComponent();
        }
        string[] username = { "username1", "username2" };
        string[] password = { "password1", "password2" };
        List<string> user = new List<string>();
        List<string> pass = new List<string>();

        
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
           
            if (username.Contains(txtName.Text) && password.Contains(txtPassword.Text) && Array.IndexOf(username, txtName.Text) == Array.IndexOf(password, txtPassword.Text))
            {
                
               
               
            }

          else  if (user.Contains(txtName.Text) && pass.Contains(txtPassword.Text) && Array.IndexOf(user.ToArray(),txtName.Text) == Array.IndexOf(pass.ToArray(), txtPassword.Text))
            {
                MessageBox.Show("Welcome " + txtName.Text );
                Home H = new Home();
                H.Show();

            }
            else
            {
                MessageBox.Show("The details you provided are incorrect. \n" + "Please try again. ", "Error! Incorrect details provided!!!", MessageBoxButtons.OK);
            }
              


                //output

            
           

        }

        private void LoginN_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\\Users\\Alex Moyo\\source\\repos\\LogInDemo\\LogInDemo\\Register\\register.txt");
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] components = line.Split(" ".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
                user.Add(components[0]);
                pass.Add(components[1]);


            }
            sr.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}   
