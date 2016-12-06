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
    public partial class Profile : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        System.Net.Sockets.TcpClient clientSocket2 = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        String Data_send = "";
        String Data_send2 = "";

        StreamWriter STR_W; // Declaring Writer for server
        StreamReader STR_R;  // Declaring Reader For server


        StreamWriter STR_W2;
        StreamReader STR_R2;

        public Profile()
        {
            InitializeComponent();
        }

        private void txt_Contact_no_key_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void show_next_form()
        {

            if (Variable.gusertype=="admin")
            {
                this.Hide();
                AdminHome form2 = new AdminHome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            } else if (Variable.gusertype =="secmgr")
            {
                this.Hide();
                SecurityManagerHome form2 = new SecurityManagerHome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            } else if (Variable.gusertype =="enduser")
            {
                this.Hide();
                UserHome form2 = new UserHome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }
        private void txt_full_name_key_press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_pipe_check_key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '|')
            {
                e.Handled = true;
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lb_hello_usr.Text = "Hi " + Variable.gusername;
            Data_send2 = "Profile|"+Variable.gusername+"|"+Variable.gusertype;

            txt_full_name.ReadOnly = true;
            txt_username.ReadOnly = true;
            txt_gender.ReadOnly = true;

            try
            { 
            clientSocket2.Connect(Variable.ipaddress, Variable.port);
            STR_W2 = new StreamWriter(clientSocket2.GetStream());
            STR_R2 = new StreamReader(clientSocket2.GetStream());
            STR_W2.AutoFlush = true;

      
            if (clientSocket2.Connected)
                {
                    STR_W2.WriteLine(Data_send2);

                    string profiledata;

                    profiledata = STR_R2.ReadLine();
            //        MessageBox.Show(profiledata);
                  

                    string[] data2 = profiledata.Split('|');

              //      MessageBox.Show(data2[0]);

              
                    txt_full_name.Text =data2[2];
                    txt_username.Text =data2[0];
                    txt_gender.Text =data2[3];
                    txt_Contact_no.Text =data2[5];
                    txt_location.Text =data2[4];
                    txt_passwd.Text =data2[8];
                    txt_passwd_confirm.Text= data2[8];
                    txt_ans.Text =data2[7];
                    

                    for (int i = 0; i < 5; i++)
                    {
                        if(Variable.sec_qus[i,0]==data2[6])
                        {
                            cb_security_qus.SelectedIndex = Int32.Parse(Variable.sec_qus[i,1]);
                        }
                    }


                        clientSocket2.Close();


                        }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }


        }

        private void bt_Profile_Click(object sender, EventArgs e)
        {
            if (txt_username.Text != "" && txt_passwd.Text != "" && txt_passwd_confirm.Text != "" && txt_full_name.Text != "" && txt_gender.Text != "" && txt_location.Text != "" && txt_Contact_no.Text != "" && cb_security_qus.Text != "" && txt_ans.Text != "")
            {


                if (txt_Contact_no.Text.Length < 10)
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
                        Data_send = "Profile_Change|" + txt_username.Text + "|" + txt_passwd.Text + "|" + txt_full_name.Text + "|" + txt_gender.Text + "|" + txt_location.Text + "|" + txt_Contact_no.Text + "|" + cb_security_qus.Text + "|" + txt_ans.Text;
                //        MessageBox.Show(Data_send);
                        try
                        {
                           
                            clientSocket.Connect(Variable.ipaddress, Variable.port);
                            STR_W = new StreamWriter(clientSocket.GetStream());
                            STR_R = new StreamReader(clientSocket.GetStream());
                            STR_W.AutoFlush = true;
                            Data_send = "Profile_Change|" + txt_username.Text + "|" + txt_passwd.Text + "|" + txt_full_name.Text + "|" + txt_gender.Text + "|" + txt_location.Text + "|" + txt_Contact_no.Text + "|" + cb_security_qus.Text + "|" + txt_ans.Text;
                            if (clientSocket.Connected)
                            {
                                STR_W.WriteLine(Data_send);

                               
                                string returndata;

                                returndata = STR_R.ReadLine();
                                //String returndata2 = STR_R.ReadLine();
                  //              MessageBox.Show(returndata);
                              //  MessageBox.Show(returndata2);
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
                                    else if (Variable.gusertype == "secmgr")
                                    {
                                        this.Hide();
                                        SecurityManagerHome form2 = new SecurityManagerHome();
                                        form2.Closed += (s, args) => this.Close();
                                        form2.Show();

                                    }
                                    else if (Variable.gusertype == "enduser")
                                    {
                                        this.Hide();
                                        UserHome form2 = new UserHome();
                                        form2.Closed += (s, args) => this.Close();
                                        form2.Show();
                                    }
                                    // this.show_next_form();
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

        private void bt_back_to_pre_form_Click(object sender, EventArgs e)
        {
            if (Variable.gusertype == "admin")
            {
                this.Hide();
                AdminHome form2 = new AdminHome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            }
            else if (Variable.gusertype == "secmgr")
            {
                this.Hide();
                SecurityManagerHome form2 = new SecurityManagerHome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            }
            else if (Variable.gusertype == "enduser")
            {
                this.Hide();
                UserHome form2 = new UserHome();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }
    }
}
