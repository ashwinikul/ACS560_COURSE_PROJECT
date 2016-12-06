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
    public partial class Add_detail : Form

    {
        String add_id= "";
        String AddComment = "";
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        System.Net.Sockets.TcpClient clientSocket2 = new System.Net.Sockets.TcpClient();
        String Data_send = "";
        //String Data_receive = "";
        StreamWriter STR_W;
        StreamReader STR_R;

        public Add_detail()
        {
            InitializeComponent();
            Variable.Tab_sec = Variable.Tab_default;

            while (Variable.Tab_sec.Columns.Count > 0)
            {
                Variable.Tab_sec.Columns.RemoveAt(0);
            }
        }

        private void Add_detail_Load(object sender, EventArgs e)

        {
            lb_Hello.Text = Variable.gusername.ToUpper();

            add_Name.Text = Variable.add_name;
            addDetail.Text = Variable.add_detail;
            
            Data_send = "Get_Add_Details|" + Variable.gusername + "|" + Variable.add_id;

            Variable.Tab_sec.Columns.Add("Modified Date", typeof(string));
      
            Variable.Tab_sec.Columns.Add("addid", typeof(string));
            Variable.Tab_sec.Columns.Add("username", typeof(string));
            Variable.Tab_sec.Columns.Add("Comment", typeof(string));
          
            dataGridView2.DataSource = Variable.Tab_sec;

            Variable.Tab_sec.Rows.Clear();
           
            try
            {
                clientSocket.Connect(Variable.ipaddress, Variable.port );
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
                   // MessageBox.Show(tc.ToString());
                    // txt_pending_request.Text = tc.ToString();
                    for (int k = 0; k < tc; k++)
                    {
                        returndata = "";
                        returndata = STR_R.ReadLine();
                     //   MessageBox.Show(returndata);
                        string[] data1 = returndata.Split('|');

                        Variable.Tab_sec.Rows.Add(data1[4], data1[2], data1[1], data1[3]);


                    }
                    clientSocket.Close();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }

            foreach (DataGridViewColumn dc in dataGridView2.Columns)
            {
                if (dc.HeaderText == "Comment" || dc.HeaderText == "Modified Date"|| dc.HeaderText == "username")
                {
                    dc.ReadOnly = true;
                }

                if (dc.HeaderText == "addid")
                {
                    dc.Visible = false;
                }
            }


        }


    private void Lk_lb_Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Profile frm1 = new Profile();
            frm1.Closed += (s, args) => this.Close();
            frm1.Show();
        }

        private void Logout_lklb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("User has been successfully Logout");
            Application form2 = new Application();
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            UserHome frm3 = new UserHome();
            frm3.Closed += (s, args) => this.Close();
            frm3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Comment_btn_Click(object sender, EventArgs e)
        {
            AddComment = txt_add_comment.Text.ToString();
            //MessageBox.Show(Variable.add_id);
            //AddDescr = Add_Descr.Text.ToString();
            Data_send = "Comment_Insert|" + Variable.gusername + "|" + Variable.add_id +"|" + AddComment;
            //MessageBox.Show(Data_send);
            try
            {
                clientSocket2.Connect(Variable.ipaddress, 12000);
                STR_W = new StreamWriter(clientSocket2.GetStream());
                STR_R = new StreamReader(clientSocket2.GetStream());
                STR_W.AutoFlush = true;
                if (clientSocket2.Connected)
                {
                    STR_W.WriteLine(Data_send);
                    string returndata; returndata = STR_R.ReadLine();

                    if (returndata == "Success")
                    {
                        MessageBox.Show("Your Comment has been submitted for Review");
                        this.Hide();
                        Add_detail frm1 = new Add_detail();
                        frm1.Show();
                        clientSocket2.Close();

                    }
                    else
                    {
                        clientSocket2.Close();

                        MessageBox.Show("Error");
                        this.Hide();
                        Add_detail form3 = new Add_detail();
                        form3.Show();
                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_detail form3 = new Add_detail();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}

