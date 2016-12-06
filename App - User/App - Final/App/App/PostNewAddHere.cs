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
    public partial class PostNewAddHere : Form
    {

        String Add = "";
        String AddDescr = "";
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
      //  System.Net.Sockets.TcpClient clientSocket2 = new System.Net.Sockets.TcpClient();
        String Data_send = "";
        //String Data_receive = "";
        StreamWriter STR_W;
        StreamReader STR_R;



        public PostNewAddHere()
        {
            InitializeComponent();
        }

        private void linkLbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            MessageBox.Show("User has been successfully Logout");
            Application form2 = new Application();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void linkLbl_Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Profile frm1 = new Profile();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void linkLb_back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserHome frm1 = new UserHome();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void PostNewAddHere_Load(object sender, EventArgs e)
        {
            lb_hello.Text = "Hi " + Variable.gusername;

        }
        private void txt_pipe_check_key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }


        private void post_add_Click(object sender, EventArgs e)
        {
            Add = add_text.Text.ToString();
            //MessageBox.Show(Add);
            AddDescr = Add_Descr.Text.ToString();
            Data_send = "Add_Insert|" + Variable.gusername + "|" + Add + "|" + AddDescr;
            //MessageBox.Show(Data_send);
            try
            {
                clientSocket.Connect(Variable.ipaddress, Variable.port);
                STR_W = new StreamWriter(clientSocket.GetStream());
                STR_R = new StreamReader(clientSocket.GetStream());
                STR_W.AutoFlush = true;
                if (clientSocket.Connected)
                {
                    STR_W.WriteLine(Data_send);
                    string returndata; returndata = STR_R.ReadLine();
                 
                    if (returndata == "Success")
                    {
              //          MessageBox.Show("Your add has been Posted for Review");
                        this.Hide();
                        UserHome frm1 = new UserHome();
                        frm1.Show();
                        clientSocket.Close();

                    }
                    else
                    {
                        clientSocket.Close();
                        this.Hide();
                        PostNewAddHere form3 = new PostNewAddHere();
                        form3.Show();
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


