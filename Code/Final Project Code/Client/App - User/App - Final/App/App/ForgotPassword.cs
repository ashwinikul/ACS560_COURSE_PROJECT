// Created By Ashwini

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
    public partial class ForgotPassword : Form
    {
        String username = "";
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        
        
        String Sec_Qus_ans = "";
        String Sec_passwd = "";
        StreamWriter STR_W;
        StreamReader STR_R;

        public ForgotPassword()
        {
            InitializeComponent();
            //txt_username.Text=Variable.gusername;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application form2 = new Application();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        
        private void bt_get_passwd_Click(object sender, EventArgs e)
        {
            //byte[] bytes = new byte[1024];
            
            username = txt_username.Text;
            //MessageBox.Show(username);

            if (txt_ans.Text == "")
            {
                MessageBox.Show("Answer field is empty");
            }

            else
            {

                if (txt_ans.Text==Sec_Qus_ans)
                {
                    MessageBox.Show("Please note down your password. Password is :" +Sec_passwd);
                    Sec_passwd = "";
                    this.Hide();
                    Application form2 = new Application();
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("User name or Answer is incorrect.....! ");

                }
            }
 

            

        }

        private static Socket NewMethod()
        {
            return new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_get_qus_Click(object sender, EventArgs e)
        {
            try
            {
                //epremote = new IPEndPoint(IPAddress.Parse("10.0.0.2"), Convert.ToInt32("12000"));
                //10.100.220.33
                clientSocket.Connect(Variable.ipaddress, Variable.port);
                STR_W = new StreamWriter(clientSocket.GetStream());
                STR_R = new StreamReader(clientSocket.GetStream());
                STR_W.AutoFlush = true;
                if (clientSocket.Connected)
                {
                    STR_W.WriteLine("Get_Sec_Qus|" + txt_username.Text);

                    string returndata;

                    returndata = STR_R.ReadLine();


                    if (returndata=="Username Not Exists")
                    {
                        
                        MessageBox.Show("Username Doesnot exists.....!");

                        this.Hide();
                        ForgotPassword form2 = new ForgotPassword();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else
                    {
                        string[] data1 = returndata.Split('|');
                        txt_qus.Text = data1[1];
                        Sec_Qus_ans = data1[2];
                        Sec_passwd = data1[3];
                        clientSocket.Close();

                    }
                    



                }
               // clientSocket.Close();
            }


            catch (Exception e4)
            {
                clientSocket.Close();
                Console.WriteLine(e4.ToString());
            }


        }
    }
}
