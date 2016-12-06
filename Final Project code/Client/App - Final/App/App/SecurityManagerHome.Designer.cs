namespace App
{
    partial class SecurityManagerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityManagerHome));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_security_mgr_user_name = new System.Windows.Forms.Label();
            this.linklbl_profile = new System.Windows.Forms.LinkLabel();
            this.linklbl_logout = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_pending_request = new System.Windows.Forms.TextBox();
            this.bt_submit_changes = new System.Windows.Forms.Button();
            this.dgv_review_data = new System.Windows.Forms.DataGridView();
            this.bt_refresh_entries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_review_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "All in One Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Security Manager :";
            // 
            // lbl_security_mgr_user_name
            // 
            this.lbl_security_mgr_user_name.AutoSize = true;
            this.lbl_security_mgr_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_security_mgr_user_name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_security_mgr_user_name.Location = new System.Drawing.Point(275, 117);
            this.lbl_security_mgr_user_name.Name = "lbl_security_mgr_user_name";
            this.lbl_security_mgr_user_name.Size = new System.Drawing.Size(0, 29);
            this.lbl_security_mgr_user_name.TabIndex = 4;
            // 
            // linklbl_profile
            // 
            this.linklbl_profile.AutoSize = true;
            this.linklbl_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_profile.Location = new System.Drawing.Point(962, 117);
            this.linklbl_profile.Name = "linklbl_profile";
            this.linklbl_profile.Size = new System.Drawing.Size(83, 29);
            this.linklbl_profile.TabIndex = 5;
            this.linklbl_profile.TabStop = true;
            this.linklbl_profile.Text = "Profile";
            this.linklbl_profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_profile_LinkClicked);
            // 
            // linklbl_logout
            // 
            this.linklbl_logout.AutoSize = true;
            this.linklbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklbl_logout.Location = new System.Drawing.Point(1072, 117);
            this.linklbl_logout.Name = "linklbl_logout";
            this.linklbl_logout.Size = new System.Drawing.Size(98, 29);
            this.linklbl_logout.TabIndex = 6;
            this.linklbl_logout.TabStop = true;
            this.linklbl_logout.Text = "Log Out";
            this.linklbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_logout_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(30, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pending Review:";
            // 
            // txt_pending_request
            // 
            this.txt_pending_request.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pending_request.Location = new System.Drawing.Point(243, 204);
            this.txt_pending_request.Name = "txt_pending_request";
            this.txt_pending_request.ReadOnly = true;
            this.txt_pending_request.Size = new System.Drawing.Size(185, 30);
            this.txt_pending_request.TabIndex = 8;
            // 
            // bt_submit_changes
            // 
            this.bt_submit_changes.Location = new System.Drawing.Point(462, 204);
            this.bt_submit_changes.Name = "bt_submit_changes";
            this.bt_submit_changes.Size = new System.Drawing.Size(225, 30);
            this.bt_submit_changes.TabIndex = 10;
            this.bt_submit_changes.Text = "Submit Changes";
            this.bt_submit_changes.UseVisualStyleBackColor = true;
            this.bt_submit_changes.Click += new System.EventHandler(this.bt_submit_changes_Click);
            // 
            // dgv_review_data
            // 
            this.dgv_review_data.AllowUserToAddRows = false;
            this.dgv_review_data.AllowUserToDeleteRows = false;
            this.dgv_review_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_review_data.Location = new System.Drawing.Point(35, 278);
            this.dgv_review_data.Name = "dgv_review_data";
            this.dgv_review_data.RowTemplate.Height = 24;
            this.dgv_review_data.Size = new System.Drawing.Size(1135, 426);
            this.dgv_review_data.TabIndex = 11;
            // 
            // bt_refresh_entries
            // 
            this.bt_refresh_entries.Location = new System.Drawing.Point(704, 204);
            this.bt_refresh_entries.Name = "bt_refresh_entries";
            this.bt_refresh_entries.Size = new System.Drawing.Size(225, 30);
            this.bt_refresh_entries.TabIndex = 12;
            this.bt_refresh_entries.Text = "Refresh";
            this.bt_refresh_entries.UseVisualStyleBackColor = true;
            this.bt_refresh_entries.Click += new System.EventHandler(this.bt_refresh_entries_Click);
            // 
            // SecurityManagerHome
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.bt_refresh_entries);
            this.Controls.Add(this.dgv_review_data);
            this.Controls.Add(this.bt_submit_changes);
            this.Controls.Add(this.txt_pending_request);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linklbl_logout);
            this.Controls.Add(this.linklbl_profile);
            this.Controls.Add(this.lbl_security_mgr_user_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecurityManagerHome";
            this.Text = "SecurityManagerHome";
            this.Load += new System.EventHandler(this.SecurityManagerHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_review_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_security_mgr_user_name;
        private System.Windows.Forms.LinkLabel linklbl_profile;
        private System.Windows.Forms.LinkLabel linklbl_logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_pending_request;
        private System.Windows.Forms.Button bt_submit_changes;
        private System.Windows.Forms.DataGridView dgv_review_data;
        private System.Windows.Forms.Button bt_refresh_entries;
    }
}