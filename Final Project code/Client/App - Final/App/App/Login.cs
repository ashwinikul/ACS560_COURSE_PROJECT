using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;

namespace App
{
    public partial class Login : Form
    {
        String username = "";
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient(); //declaration of socket connection

        StreamWriter STR_W; // Declaring Writer for server
        StreamReader STR_R; // Declaring Reader For server

        EndPoint epremote;
       
        byte[] buffer; 
        public Login()
        {
            InitializeComponent();
         
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
          
        }

        
        private void bt_login_Click(object sender, EventArgs e)
        {
            
            username = txt_username.Text;
          //  MessageBox.Show(username);

          

            try
            {
               
                clientSocket.Connect(Variable.ipaddress, Variable.port);
                STR_W = new StreamWriter(clientSocket.GetStream());
                STR_R = new StreamReader(clientSocket.GetStream());
                STR_W.AutoFlush = true;
                if (clientSocket.Connected)
                {
                    STR_W.WriteLine("Login|"+ txt_username.Text+"|"+ txt_passwd.Text);

                 

                    string returndata;

                    returndata = STR_R.ReadLine();
                    if(returndata== "Failed")
                    {
                        MessageBox.Show("Username or Password is incorrect");
                        this.Hide();
                        Login frm = new Login();
                        frm.Show();

                    } 
                    else
                    {
                        clientSocket.Close();
                        Variable.gusername = txt_username.Text;
                        Variable.gusertype = returndata;
                        MessageBox.Show("Login Successful.........!", returndata);
                        if(returndata=="admin")
                        {
                            this.Hide();
                            AdminHome frm = new AdminHome();
                            frm.Show();
                        }
                        if (returndata == "enduser")
                        {
                            this.Hide();
                            UserHome frm1 = new UserHome();
                            frm1.Show();
                        }
                        if (returndata == "secmgr")
                        {
                            this.Hide();

                            this.Hide();
                        
                           
                           

                            SecurityManagerHome form2 = new SecurityManagerHome();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                        }
                    }
                    
                  
                }
            }


            catch (Exception e4)
            {
                Console.WriteLine(e4.ToString());
            }

        }

        private static Socket NewMethod()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
          

        private void txt_pipe_check_key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }

        
    }
}
