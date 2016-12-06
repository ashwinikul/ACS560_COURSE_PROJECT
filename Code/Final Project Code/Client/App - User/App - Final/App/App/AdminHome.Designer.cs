namespace App
{
    partial class AdminHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_admin_name = new System.Windows.Forms.Label();
            this.linklbl_profile = new System.Windows.Forms.LinkLabel();
            this.linklbl_LogOut = new System.Windows.Forms.LinkLabel();
            this.bt_add_sm = new System.Windows.Forms.Button();
            this.bt_delete_SM = new System.Windows.Forms.Button();
            this.bt_SM_halt_changes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_sm_list = new System.Windows.Forms.ComboBox();
            this.lbl_tot_sm_cnt = new System.Windows.Forms.Label();
            this.lbl_tot_sm = new System.Windows.Forms.Label();
            this.dgv_sm_work_detail = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sm_work_detail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "All in One Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin :";
            // 
            // lbl_admin_name
            // 
            this.lbl_admin_name.AutoSize = true;
            this.lbl_admin_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_admin_name.Location = new System.Drawing.Point(144, 124);
            this.lbl_admin_name.Name = "lbl_admin_name";
            this.lbl_admin_name.Size = new System.Drawing.Size(0, 29);
            this.lbl_admin_name.TabIndex = 4;
            // 
            // linklbl_profile
            // 
            this.linklbl_profile.AutoSize = true;
            this.linklbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_profile.Location = new System.Drawing.Point(925, 124);
            this.linklbl_profile.Name = "linklbl_profile";
            this.linklbl_profile.Size = new System.Drawing.Size(83, 29);
            this.linklbl_profile.TabIndex = 5;
            this.linklbl_profile.TabStop = true;
            this.linklbl_profile.Text = "Profile";
            this.linklbl_profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_profile_LinkClicked);
            // 
            // linklbl_LogOut
            // 
            this.linklbl_LogOut.AutoSize = true;
            this.linklbl_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_LogOut.Location = new System.Drawing.Point(1043, 124);
            this.linklbl_LogOut.Name = "linklbl_LogOut";
            this.linklbl_LogOut.Size = new System.Drawing.Size(98, 29);
            this.linklbl_LogOut.TabIndex = 6;
            this.linklbl_LogOut.TabStop = true;
            this.linklbl_LogOut.Text = "Log Out";
            this.linklbl_LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_LogOut_LinkClicked);
            // 
            // bt_add_sm
            // 
            this.bt_add_sm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_sm.Location = new System.Drawing.Point(21, 13);
            this.bt_add_sm.Name = "bt_add_sm";
            this.bt_add_sm.Size = new System.Drawing.Size(353, 35);
            this.bt_add_sm.TabIndex = 7;
            this.bt_add_sm.Text = "Add Security Manager";
            this.bt_add_sm.UseVisualStyleBackColor = true;
            this.bt_add_sm.Click += new System.EventHandler(this.bt_add_sm_Click);
            // 
            // bt_delete_SM
            // 
            this.bt_delete_SM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete_SM.Location = new System.Drawing.Point(21, 226);
            this.bt_delete_SM.Name = "bt_delete_SM";
            this.bt_delete_SM.Size = new System.Drawing.Size(353, 35);
            this.bt_delete_SM.TabIndex = 8;
            this.bt_delete_SM.Text = "Delete Security Manager";
            this.bt_delete_SM.UseVisualStyleBackColor = true;
            this.bt_delete_SM.Click += new System.EventHandler(this.bt_delete_SM_Click);
            // 
            // bt_SM_halt_changes
            // 
            this.bt_SM_halt_changes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SM_halt_changes.Location = new System.Drawing.Point(37, 186);
            this.bt_SM_halt_changes.Name = "bt_SM_halt_changes";
            this.bt_SM_halt_changes.Size = new System.Drawing.Size(481, 35);
            this.bt_SM_halt_changes.TabIndex = 9;
            this.bt_SM_halt_changes.Text = "Submit Security Manager Status Information";
            this.bt_SM_halt_changes.UseVisualStyleBackColor = true;
            this.bt_SM_halt_changes.Click += new System.EventHandler(this.bt_SM_halt_changes_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_sm_list);
            this.panel1.Controls.Add(this.lbl_tot_sm_cnt);
            this.panel1.Controls.Add(this.lbl_tot_sm);
            this.panel1.Controls.Add(this.bt_delete_SM);
            this.panel1.Controls.Add(this.bt_add_sm);
            this.panel1.Location = new System.Drawing.Point(785, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 569);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_sm_list
            // 
            this.cb_sm_list.FormattingEnabled = true;
            this.cb_sm_list.Location = new System.Drawing.Point(21, 166);
            this.cb_sm_list.Name = "cb_sm_list";
            this.cb_sm_list.Size = new System.Drawing.Size(353, 24);
            this.cb_sm_list.TabIndex = 12;
            this.cb_sm_list.SelectedIndexChanged += new System.EventHandler(this.cb_sm_list_SelectedIndexChanged);
            // 
            // lbl_tot_sm_cnt
            // 
            this.lbl_tot_sm_cnt.AutoSize = true;
            this.lbl_tot_sm_cnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot_sm_cnt.ForeColor = System.Drawing.Color.Navy;
            this.lbl_tot_sm_cnt.Location = new System.Drawing.Point(310, 89);
            this.lbl_tot_sm_cnt.Name = "lbl_tot_sm_cnt";
            this.lbl_tot_sm_cnt.Size = new System.Drawing.Size(0, 29);
            this.lbl_tot_sm_cnt.TabIndex = 11;
            // 
            // lbl_tot_sm
            // 
            this.lbl_tot_sm.AutoSize = true;
            this.lbl_tot_sm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot_sm.ForeColor = System.Drawing.Color.Navy;
            this.lbl_tot_sm.Location = new System.Drawing.Point(23, 89);
            this.lbl_tot_sm.Name = "lbl_tot_sm";
            this.lbl_tot_sm.Size = new System.Drawing.Size(281, 29);
            this.lbl_tot_sm.TabIndex = 10;
            this.lbl_tot_sm.Text = "Security Manager Count :";
            // 
            // dgv_sm_work_detail
            // 
            this.dgv_sm_work_detail.AllowUserToAddRows = false;
            this.dgv_sm_work_detail.AllowUserToDeleteRows = false;
            this.dgv_sm_work_detail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_sm_work_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sm_work_detail.Location = new System.Drawing.Point(37, 267);
            this.dgv_sm_work_detail.Name = "dgv_sm_work_detail";
            this.dgv_sm_work_detail.RowTemplate.Height = 24;
            this.dgv_sm_work_detail.Size = new System.Drawing.Size(726, 474);
            this.dgv_sm_work_detail.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.Location = new System.Drawing.Point(561, 186);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(202, 35);
            this.bt_refresh.TabIndex = 12;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.dgv_sm_work_detail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_SM_halt_changes);
            this.Controls.Add(this.linklbl_LogOut);
            this.Controls.Add(this.linklbl_profile);
            this.Controls.Add(this.lbl_admin_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.Load += new System.EventHandler(this.AdminHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sm_work_detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_admin_name;
        private System.Windows.Forms.LinkLabel linklbl_profile;
        private System.Windows.Forms.LinkLabel linklbl_LogOut;
        private System.Windows.Forms.Button bt_add_sm;
        private System.Windows.Forms.Button bt_delete_SM;
        private System.Windows.Forms.Button bt_SM_halt_changes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_sm_work_detail;
        private System.Windows.Forms.Label lbl_tot_sm;
        private System.Windows.Forms.Label lbl_tot_sm_cnt;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cb_sm_list;
        private System.Windows.Forms.Button bt_refresh;
    }
}