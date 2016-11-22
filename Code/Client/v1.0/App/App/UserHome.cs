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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void link_Profile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Profile frm1 = new Profile();
            frm1.Show();
        }

        private void UserHome_Load(object sender, EventArgs e)

        {
            lb_Hello_userhome.Text = "Hi " + Variable.gusername;


            // DataGridViewLinkColumn link = new DataGridViewLinkColumn();
            //link.HeaderText = "Add Link";
            //dataGridView1.Columns.Add(link);

            DataGridViewLinkColumn dgvlc = new DataGridViewLinkColumn();
            dgvlc.UseColumnTextForLinkValue = true;
            dgvlc.Text = "Select Items";
            dgvlc.Name = "OpenFormLinkColumn";
            dataGridView1.Columns.Insert(0, dgvlc);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Search_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv.Columns[e.ColumnIndex].Name == "OpenFormLinkColumn")
            {

                var result = from cell in dataGridView1.Rows[e.RowIndex].Cells.Cast<DataGridViewCell>()
                             select cell.Value;
                List<Object> ItemsToPass = result.ToList();

                Form2 frm2 = new Form2();
                frm2.Collection = ItemsToPass;
                frm2.Show();
            }
        }



        }

    }


