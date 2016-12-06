// Created By Ashwini
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

namespace App
{
    public partial class Register : Form
    {
  
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        String Data_send = "";

        StreamWriter STR_W; // Declaring Writer for server
        StreamReader STR_R; // Declaring Reader For server
        public Register()
        {
            InitializeComponent();
        }


        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_full_name.Clear();
            txt_username.Clear();
            txt_Contact_no.Clear();
            txt_passwd.Clear();
            txt_passwd_confirm.Clear();
            txt_ans.Clear();
            txt_location.Clear();
          
        }



        private void txt_Contact_no_key_press(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void txt_full_name_key_press(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)|| e.KeyChar==' '))
            {
                e.Handled = true;
            }
        }



        private void txt_user_name_key_press(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)|| char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_pipe_check_key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='|')
            {
                e.Handled = true;
            }
        }

        private void bt_Register_Click(object sender, EventArgs e)
        {

            if (txt_username.Text != "" && txt_passwd.Text != "" && txt_passwd_confirm.Text != "" && txt_full_name.Text != "" && cb_gender.Text != "" && txt_location.Text != "" && txt_Contact_no.Text != "" && cb_security_qus.Text != "" && txt_ans.Text != "")
            {


                if (txt_Contact_no.Text.Length<10)
                {
                    MessageBox.Show("Contact no. should be 10 digit......!");

                }
                else
                {
                    if (txt_passwd.Text != txt_passwd_confirm.Text)
                    {
                        txt_passwd.Clear();
                        txt_passwd_confirm.Clear();

                    }
                    else
                    {
                        Data_send = "Register|" + txt_username.Text + "|" + txt_passwd.Text + "|" + txt_full_name.Text + "|" + cb_gender.Text + "|" + txt_location.Text + "|" + txt_Contact_no.Text + "|" + cb_security_qus.Text + "|" + txt_ans.Text;
                 //       MessageBox.Show(Data_send);
                        try
                        {
                           
                            clientSocket.Connect(Variable.ipaddress, Variable.port);
                            STR_W = new StreamWriter(clientSocket.GetStream());
                            STR_R = new StreamReader(clientSocket.GetStream());
                            STR_W.AutoFlush = true;

                            if (Variable.gusertype=="admin") 
                            {
                                Data_send = "SMRegister|" + txt_username.Text + "|" + txt_passwd.Text + "|" + txt_full_name.Text + "|" + cb_gender.Text + "|" + txt_location.Text + "|" + txt_Contact_no.Text + "|" + cb_security_qus.Text + "|" + txt_ans.Text;
                            }
                            else
                            {
                                Data_send = "Register|" + txt_username.Text + "|" + txt_passwd.Text + "|" + txt_full_name.Text + "|" + cb_gender.Text + "|" + txt_location.Text + "|" + txt_Contact_no.Text + "|" + cb_security_qus.Text + "|" + txt_ans.Text;
                            }
                            
                            if (clientSocket.Connected)
                            {
                                STR_W.WriteLine(Data_send);

                               
                                string returndata;

                                returndata = STR_R.ReadLine();
                               // MessageBox.Show(returndata);
                                if (returndata == "Success")
                                {
                                    
                                    clientSocket.Close();
                                    if (Variable.gusertype == "admin")
                                    {
                                        this.Hide();
                                        AdminHome form2 = new AdminHome();
                                        form2.Closed += (s, args) => this.Close();
                                        form2.Show();
                                    }
                                    else
                                    {
                                        clientSocket.Close();
                                        this.Hide();
                                        Login form3 = new Login();
                                        form3.Closed += (s, args) => this.Close();
                                        form3.Show();
                                    }
                                    

                                }
                                if (returndata == "User already present")
                                {
                                    txt_passwd.Clear();
                                    txt_passwd_confirm.Clear();
                                    txt_username.Clear();
                                    clientSocket.Close();
                                    MessageBox.Show("Username is already present");

                                    this.Hide();
                                    Register form2 = new Register();
                                    form2.Closed += (s, args) => this.Close();
                                    form2.Show();
                                }
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.ToString());
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show("Must need to fill each field......!");

            }


        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
