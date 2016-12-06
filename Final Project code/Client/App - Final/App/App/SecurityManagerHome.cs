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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace App
{
    public partial class SecurityManagerHome : Form
    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        System.Net.Sockets.TcpClient clientSocket2 = new System.Net.Sockets.TcpClient(); //declaration of socket connection
        String Data_send = "";
        StreamWriter STR_W; // Declaring Writer for server
        StreamReader STR_R; // Declaring Reader For server

        public SecurityManagerHome()
        {
            InitializeComponent();
            int desiredSize = 0;
            while (Variable.Tab_sec.Columns.Count > desiredSize) // Checking & Removing Columns in Data grid View
            {
                Variable.Tab_sec.Columns.RemoveAt(desiredSize);
            
            }

        }


        private void SecurityManagerHome_Load(object sender, EventArgs e)
        {
            lbl_security_mgr_user_name.Text = Variable.gusername.ToUpper();

            // Declaration of Columns of Data table 
            MessageBox.Show("Please wait.. ");
            Variable.Tab_sec.Columns.Add("Type", typeof(string));
            Variable.Tab_sec.Columns.Add("addid", typeof(string));
            Variable.Tab_sec.Columns.Add("commentid", typeof(string));
            Variable.Tab_sec.Columns.Add("text_data", typeof(string));
            Variable.Tab_sec.Columns.Add("userid", typeof(string));
            Variable.Tab_sec.Columns.Add("block", typeof(string));


            Data_send = "SM_Get_Data|" + Variable.gusername; // Defining data Sent to server
            //MessageBox.Show(Data_send);
            // Connecting to Server and reading & Writing data from server using Ip & port 

            for (int i = Variable.Tab_sec.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = Variable.Tab_sec.Rows[i];
                // if (dr["name"] == "Joe")
                if (dr["userid"] == DBNull.Value)
                    dr.Delete();
            }

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
                    txt_pending_request.Text = tc.ToString();
                    for (int k=0;k<tc;k++)    // Loop for retrieving multiple data from Server 
                    {
                        returndata = "";
                        returndata = STR_R.ReadLine();
                      //  MessageBox.Show(returndata);
                        string[] data1 = returndata.Split('|');

                        Variable.Tab_sec.Rows.Add(data1[0], data1[1], data1[2], data1[3], data1[4], data1[5]);


                    }
                    clientSocket.Close(); // Closing connection 
                }
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

            // Creating Columns of Combo Box 
            DataGridViewComboBoxColumn cb_allow = new DataGridViewComboBoxColumn();
            cb_allow.HeaderText = "Review";
            cb_allow.Items.Add("Allow");
            cb_allow.Items.Add("Reject");
            dgv_review_data.Columns.Add(cb_allow);

            dgv_review_data.DataSource = Variable.Tab_sec;

            // Setting up data which we need to show & Which we need to hide 

            foreach (DataGridViewColumn dc in dgv_review_data.Columns)
            {
                if (dc.HeaderText== "Review")
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }

                if(dc.HeaderText=="addid" || dc.HeaderText == "commentid" || dc.HeaderText == "userid" || dc.HeaderText == "block")
                {
                    dc.Visible = false;
                }
            }
           
        }

        private void linklbl_profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Jumping to Profile For on click of Profile
        {
           
            this.Hide();
            Profile form2 = new Profile();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void linklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Jumping to Logout form on Logout Click 
        {
            this.Hide();
            MessageBox.Show("User has been successfully Logout");
            Application form2 = new Application();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
            
           
        }

        private void bt_submit_changes_Click(object sender, EventArgs e)  // coding for Submit Button 
        {

            String Data;
            String I1="0";
            foreach (DataGridViewColumn dc in dgv_review_data.Columns)
            {
                if (dc.HeaderText == "Review")
                {
                    I1 = dc.Index.ToString();
                   // MessageBox.Show(I1);
                }
            }
           
            String allowed_add_id="0";
            String allowed_comment_id="0";
            String rejected_add_id="0";
            String rejected_comment_id="0";
            foreach (DataGridViewRow row in dgv_review_data.Rows)
            {
                Data = (String)row.Cells["userid"].Value;
               // MessageBox.Show(Data);

                Data = (String)row.Cells[int.Parse(I1)].Value;
               // MessageBox.Show(Data);

                if (row.Cells["userid"].Value == DBNull.Value)
                {
                }
                else
                 {
                    if (Data == "Allow")
                    {
                        Data = "";
                        Data = (String)row.Cells["Type"].Value;
                       // MessageBox.Show(Data);
                        if (Data == "add")
                        {
                            Data = "";
                            Data = (String)row.Cells["addid"].Value;
                          //  MessageBox.Show(Data);
                          
                            allowed_add_id = allowed_add_id + "," + Data.Trim();
                        }
                        if (Data == "comment")
                        {
                            Data = "";
                            Data = (String)row.Cells["commentid"].Value;
                           // MessageBox.Show(Data);
                            allowed_comment_id = allowed_comment_id + "," + Data.Trim();
                        }

                    }
                    if (Data == "Reject")  
                    {
                        Data = "";
                        Data = (String)row.Cells["Type"].Value;
                      //  MessageBox.Show(Data);
                        if (Data == "add")
                        {
                            Data = "";
                            Data = (String)row.Cells["addid"].Value;
                       //     MessageBox.Show(Data);
                           
                            rejected_add_id = rejected_add_id + "," + Data.Trim();
                        }
                        if (Data == "comment")
                        {
                            Data = "";
                            Data = (String)row.Cells["commentid"].Value;
                            MessageBox.Show(Data);
                            rejected_comment_id = rejected_comment_id + "," + Data.Trim();
                        }

                    }

               }


            }

            Data_send = "SM_ALLOW|" + Variable.gusername+"|" + allowed_add_id  + "|" + allowed_comment_id + "|" + rejected_add_id + "|" + rejected_comment_id; // sending all id to server 
            //MessageBox.Show(Data_send); // sending data to server 
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

                    returndata = STR_R.ReadLine();

                    if(returndata== "Success")
                    {
                        MessageBox.Show("Review add & comments are updated in database");
                        clientSocket2.Close();
                      
                        Variable.Tab_sec = Variable.Tab_default;
                       

                        this.Hide();
                        SecurityManagerHome form2 = new SecurityManagerHome();
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error in updating in database");
                        clientSocket2.Close();
                    }

                }

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

          

        }

        private void bt_refresh_entries_Click(object sender, EventArgs e) // On refresh Click Form gets refreshed
        {
            Variable.Tab_sec = Variable.Tab_default;



            this.Hide();
            SecurityManagerHome form3 = new SecurityManagerHome();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
