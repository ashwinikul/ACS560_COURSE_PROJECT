using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    
    public partial class Application : Form
    {

        
        public Application()
        {
            InitializeComponent();
        }

        private void Application_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }



        private void bt_login_Click(object sender, EventArgs e)
        {
            //Variable.gusername = "qwe";
           // this.Hide();
            
            //Login frm2 = new Login();
            //this.Close();
            //frm2.Show();

            this.Hide();
            Login form2 = new Login();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void bt_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register frm1 = new Register();
            frm1.Show();
        }

        private void lbl_forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword form2 = new ForgotPassword();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }
    }
}
