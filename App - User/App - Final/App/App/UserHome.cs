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
    public partial class UserHome : Form

    {
        
        String search  = ""; 
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        System.Net.Sockets.TcpClient clientSocket2 = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        String Data_send = "";
        StreamWriter STR_W; // Declaring Writer for server
        StreamReader STR_R; // Declaring Reader For server

        public UserHome()
        {
            InitializeComponent();
            Variable.Tab_sec = Variable.Tab_default; 

            while(Variable.Tab_sec.Columns.Count>0) // Checking & Removing Columns in Data grid View
            {
                Variable.Tab_sec.Columns.RemoveAt(0);
            }
        }

        private void link_Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Jumping  on Profile Form  
        {
            this.Hide();
            Profile frm1 = new Profile();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void UserHome_Load(object sender, EventArgs e)

        {
            lb_Hello_userhome.Text = "Hi " + Variable.gusername;


            Data_send = "My_adds|" + Variable.gusername + "|" +"A"; // Defining data Sent to server 
           // MessageBox.Show(Data_send);
             // Declaration of Columns of Data table 
            Variable.Tab_sec.Columns.Add("Date", typeof(string));
            Variable.Tab_sec.Columns.Add("addid", typeof(string));
            Variable.Tab_sec.Columns.Add("username", typeof(string));
            Variable.Tab_sec.Columns.Add("add_name", typeof(string));
            Variable.Tab_sec.Columns.Add("add_detail", typeof(string));
         
            dataGridView1.DataSource = Variable.Tab_sec; // setting up datasource for data table


            Variable.Tab_sec.Rows.Clear(); 
         // Connecting to Server and reading & Writing data from server using Ip & port 
            try
            {
                clientSocket.Connect(Variable.ipaddress, Variable.port);
                STR_W = new StreamWriter(clientSocket.GetStream());
                STR_R = new StreamReader(clientSocket.GetStream());
                STR_W.AutoFlush = true;
                if (clientSocket.Connected)
                {
                    STR_W.WriteLine(Data_send);
                    string returndata;

                    String total_count = STR_R.ReadLine();
                    //MessageBox.Show(total_count);
                    int tc = int.Parse(total_count);
                    //MessageBox.Show(tc.ToString());
                  // Loop for retrieving multiple data from Server 
                    for (int k = 0; k < tc; k++)
                    {
                        returndata = "";
                        returndata = STR_R.ReadLine();
                      //  MessageBox.Show(returndata);
                        string[] data1 = returndata.Split('|');

                        Variable.Tab_sec.Rows.Add(data1[5], data1[2], data1[1], data1[3], data1[4]);


                    }
                    clientSocket.Close(); // Closing connection 
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
             // Setting up data which we need to show & Which we need to hide 
            foreach (DataGridViewColumn dc in dataGridView1.Columns)
            {
                if (dc.HeaderText == "add_name"|| dc.HeaderText == "Date")
                {
                    dc.ReadOnly = true;
                }
                
                if (dc.HeaderText == "addid" || dc.HeaderText == "username" || dc.HeaderText == "add_detail")
                {
                    dc.Visible = false;
                }
            }


        }


        private void Search_Textbox_TextChanged(object sender, EventArgs e)
        {
        }
            private void txt_pipe_check_key_press(object sender, KeyPressEventArgs e) // Setting up restrictions on text box so user cannot enter pipe operator because we are sending data which we are sepearting with pipe operator
        {
            if (e.KeyChar == '|')
            {
                e.Handled = true;
            }
        }
    

        private void Logoutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // On Click Jumping to Logout
        {
            this.Hide();
            MessageBox.Show("User has been successfully Logout");
            Application form2 = new Application();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void newaddlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // On click jumping to New add if user wants to post new add
        {
            this.Hide();
            PostNewAddHere frm3 = new PostNewAddHere();
            frm3.Closed += (s, args) => this.Close();
            frm3.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retriving data which we need to show to user and on Clicking particular add it will go to next form
            var item = dataGridView1.Rows[e.RowIndex].Cells[1].Value; 
           // MessageBox.Show(item.ToString());
            Variable.add_id = item.ToString();
            item = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            Variable.add_name = item.ToString();
            //MessageBox.Show(item.ToString());
            item = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
            Variable.add_detail = item.ToString();
           // MessageBox.Show(item.ToString());

           this.Hide();
            
            Add_detail form2 = new Add_detail();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
           

        }

        private void SearchButton_Click(object sender, EventArgs e)

        {
            // This Block of program sends to server what user search in search text box and also get results in data table
            Variable.Tab_sec.Rows.Clear();
            search = Search_Textbox.Text.ToString();
            //MessageBox.Show(search);
            Data_send = "Search_Add|" + Variable.gusername + "|" + search ;
            //MessageBox.Show(Data_send);

            // Connecting To server for  Reading/ Writing 
            try
            {
                clientSocket2.Connect(Variable.ipaddress, Variable.port);
                STR_W = new StreamWriter(clientSocket2.GetStream());
                STR_R = new StreamReader(clientSocket2.GetStream());
                STR_W.AutoFlush = true;
                if (clientSocket2.Connected)
                {
                    STR_W.WriteLine(Data_send);
                    string returndata;

                    String total_count = STR_R.ReadLine();
              //      MessageBox.Show(total_count);
                    int tc = int.Parse(total_count);
                //    MessageBox.Show(tc.ToString());
                 
                    for (int k = 0; k < tc; k++)
                    {
                        returndata = "";
                        returndata = STR_R.ReadLine();
                  //      MessageBox.Show(returndata);
                        string[] data1 = returndata.Split('|');

                        Variable.Tab_sec.Rows.Add(data1[5], data1[2], data1[1], data1[3], data1[4]); // geting data as an array 


                    }
                    clientSocket2.Close(); // Closing Connection 
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
            foreach (DataGridViewColumn dc in dataGridView1.Columns) // Setting up columns which we need to show and which we need to hide
            {
                if (dc.HeaderText == "add_name" || dc.HeaderText == "Date")
                {
                    dc.ReadOnly = true;
                }

                if (dc.HeaderText == "addid" || dc.HeaderText == "username" || dc.HeaderText == "add_detail")
                {
                    dc.Visible = false;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            this.Hide();

            UserHome form2 = new UserHome();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }

    }


