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
//using System.DBNull;

namespace App
{
    public partial class AdminHome : Form
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        System.Net.Sockets.TcpClient clientSocket2 = new System.Net.Sockets.TcpClient();
        String Data_send = "";

        // String Data_receive = "";
        StreamWriter STR_W;
        StreamReader STR_R;
        public AdminHome()
        {
            InitializeComponent();
            int desiredSize = 0;
            while (Variable.Tab_sec.Columns.Count > desiredSize)
            {
                Variable.Tab_sec.Columns.RemoveAt(desiredSize);
                //desiredSize++;
            }
        }


        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lbl_admin_name.Text = Variable.gusername.ToUpper();
            int review_count = 0;
            int desiredSize = 0;

            Variable.Tab_sec=Variable.Tab_default;

            /* while (Variable.Tab_sec.Columns.Count > desiredSize)
             {
                 Variable.Tab_sec.Columns.RemoveAt(desiredSize);
             }*/



            //cb_sm_list.DisplayMember = "Text";
            //cb_sm_list.ValueMember = "Value";



            //List<List_default> SM_list = new List<List_default>();

            Variable.Tab_sec.Columns.Add("userid", typeof(string));
            Variable.Tab_sec.Columns.Add("username", typeof(string));
            Variable.Tab_sec.Columns.Add("Security Manager Status", typeof(string));
            Variable.Tab_sec.Columns.Add("Pending review Count", typeof(string));
            Variable.Tab_sec.Columns.Add("Latest request Time frame (Mins)", typeof(string));
            Variable.Tab_sec.Columns.Add("Old request Time frame (Mins)", typeof(string));

            Data_send = "Admin_Get_Data|" + Variable.gusername;
           // MessageBox.Show(Data_send);


            for (int i = Variable.Tab_sec.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = Variable.Tab_sec.Rows[i];
               // if (dr["name"] == "Joe")
                    if(dr["userid"] == DBNull.Value)
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
                    string halt_status = null;

                    String total_count = STR_R.ReadLine();
             //       MessageBox.Show(total_count);
                    int tc = int.Parse(total_count);
               //     MessageBox.Show(tc.ToString());
                    lbl_tot_sm_cnt.Text = tc.ToString();
                    for (int k = 0; k < tc; k++)
                    {
                        returndata = "";
                        returndata = STR_R.ReadLine();
                 //       MessageBox.Show(returndata);
                        string[] data1 = returndata.Split('|');

                        if (data1[2]=="secmgr")
                        {
                            halt_status = "Working";
                        }
                        else
                        {
                            halt_status = "Not Working";
                        }
                        Variable.Tab_sec.Rows.Add(data1[0], data1[1], halt_status, data1[3], data1[4], data1[5]);
                        review_count = review_count + int.Parse(data1[3]);


                        // SM_list.Add(new List_default(data1[1], data1[0]));
                        cb_sm_list.Items.Add(new Item(data1[1].ToString(), int.Parse(data1[0])));


                    }
                    clientSocket.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
                clientSocket.Close();
            }

            DataGridViewComboBoxColumn cb_allow = new DataGridViewComboBoxColumn();
            cb_allow.HeaderText = "Security Manager Status Change";
            cb_allow.Items.Add("Allow");
            cb_allow.Items.Add("Halt");
            dgv_sm_work_detail.Columns.Add(cb_allow);

            dgv_sm_work_detail.DataSource = Variable.Tab_sec;


            foreach (DataGridViewColumn dc in dgv_sm_work_detail.Columns)
            {
                if (dc.HeaderText == "Security Manager Status Change")
                {
                    dc.ReadOnly = false;
                }
                else
                {
                    dc.ReadOnly = true;
                }

                if (dc.HeaderText == "userid" )
                {
                    dc.Visible = false;
                }
            }

           // cb_sm_list.DataSource = SM_list;


        }

        private void linklbl_profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Profile form2 = new Profile();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void linklbl_LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("User has been successfully Logout");
            Application form2 = new Application();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_add_sm_Click(object sender, EventArgs e)
        {
            Variable.Tab_sec = Variable.Tab_default;
            this.Hide();
            Register form2 = new Register();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void bt_delete_SM_Click(object sender, EventArgs e)
        {
            Variable.Tab_sec = Variable.Tab_default;
            //int sm_id=0;

            //sm_id = int.Parse(cb_sm_list.SelectedValue.ToString());

          //  MessageBox.Show("inside delete");

            if (Variable.sm_id == "0")
            {
                MessageBox.Show("Need to select Security Manager Before Delete Operation");
            }

            else
            {
                Data_send = "Admin_Delete_SM|" + Variable.gusername + "|" + Variable.sm_id;
            //    MessageBox.Show(Data_send);
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

                        if (returndata == "Success")
                        {
                            MessageBox.Show("Selected Security manager has been deleted");
                            this.Hide();
                            //MessageBox.Show("User has been successfully Logout");
                            AdminHome form2 = new AdminHome();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                        }
                        else
                        {
                            MessageBox.Show("Error in Operations");
                        }

                        clientSocket2.Close();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                    clientSocket2.Close();
                }
            }

        }

        private void cb_sm_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            Variable.sm_id = cb_sm_list.SelectedItem.ToString();
            //MessageBox.Show(Variable.sm_id);
        }

        private void bt_SM_halt_changes_Click(object sender, EventArgs e)
        {
            String Data;
            String I1 = "0";
            foreach (DataGridViewColumn dc in dgv_sm_work_detail.Columns)
            {
                if (dc.HeaderText == "Security Manager Status Change")
                {
                    I1 = dc.Index.ToString();
              //      MessageBox.Show(I1);
                }
            }

            String halt_sm_id = "0";
            String allow_sm_id = "0";


            foreach (DataGridViewRow row in dgv_sm_work_detail.Rows)
            {

                if (row.Cells["userid"].Value==DBNull.Value)
                {
                }
                else
                {
                    Data = (String)row.Cells["userid"].Value;
                //    MessageBox.Show(Data);

                    Data = (String)row.Cells[int.Parse(I1)].Value;
                  //  MessageBox.Show(Data);
                    if (Data == "Allow")
                    {
                        Data = (String)row.Cells["userid"].Value;
                        allow_sm_id = allow_sm_id + "," + Data.Trim();

                    }
                    if (Data == "Halt")
                    {
                        Data = (String)row.Cells["userid"].Value;
                        halt_sm_id = halt_sm_id + "," + Data.Trim();

                    }
                }
            }
                Data_send = "Admin_Sm_Halt|" + Variable.gusername + "|" + allow_sm_id + "|" + halt_sm_id;

               /* Variable.Tab_sec = Variable.Tab_default;
                if (Variable.Tab_sec.Columns.Count > 0)
                {
                    Variable.Tab_sec.Reset();
                }*/



                //MessageBox.Show(Data_send);
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

                        if (returndata == "Success")
                        {
                           
                            MessageBox.Show("Security Manager Status updated  in database");
                            clientSocket2.Close();



                            

                            this.Hide();
                            AdminHome form2 = new AdminHome();
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

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            Variable.Tab_sec = Variable.Tab_default;
            AdminHome form2 = new AdminHome();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
