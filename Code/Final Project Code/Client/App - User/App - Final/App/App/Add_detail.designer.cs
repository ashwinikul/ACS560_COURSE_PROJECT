namespace App
{
    partial class Add_detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_detail));
            this.label1 = new System.Windows.Forms.Label();
            this.Lk_lb_Profile = new System.Windows.Forms.LinkLabel();
            this.Logout_lklb = new System.Windows.Forms.LinkLabel();
            this.Back = new System.Windows.Forms.LinkLabel();
            this.add_Name = new System.Windows.Forms.TextBox();
            this.addname_lbl = new System.Windows.Forms.Label();
            this.addDetail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_add_comment = new System.Windows.Forms.TextBox();
            this.Comment_btn = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lb_Hello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "All in One Application";
            // 
            // Lk_lb_Profile
            // 
            this.Lk_lb_Profile.AutoSize = true;
            this.Lk_lb_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lk_lb_Profile.Location = new System.Drawing.Point(803, 86);
            this.Lk_lb_Profile.Name = "Lk_lb_Profile";
            this.Lk_lb_Profile.Size = new System.Drawing.Size(62, 24);
            this.Lk_lb_Profile.TabIndex = 1;
            this.Lk_lb_Profile.TabStop = true;
            this.Lk_lb_Profile.Text = "Profile";
            this.Lk_lb_Profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lk_lb_Profile_LinkClicked);
            // 
            // Logout_lklb
            // 
            this.Logout_lklb.AutoSize = true;
            this.Logout_lklb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_lklb.Location = new System.Drawing.Point(27, 86);
            this.Logout_lklb.Name = "Logout_lklb";
            this.Logout_lklb.Size = new System.Drawing.Size(68, 24);
            this.Logout_lklb.TabIndex = 5;
            this.Logout_lklb.TabStop = true;
            this.Logout_lklb.Text = "Logout";
            this.Logout_lklb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Logout_lklb_LinkClicked);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(708, 86);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(51, 24);
            this.Back.TabIndex = 6;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back_LinkClicked);
            // 
            // add_Name
            // 
            this.add_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_Name.Location = new System.Drawing.Point(182, 135);
            this.add_Name.Name = "add_Name";
            this.add_Name.ReadOnly = true;
            this.add_Name.Size = new System.Drawing.Size(399, 29);
            this.add_Name.TabIndex = 7;
            // 
            // addname_lbl
            // 
            this.addname_lbl.AutoSize = true;
            this.addname_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addname_lbl.Location = new System.Drawing.Point(634, 135);
            this.addname_lbl.Name = "addname_lbl";
            this.addname_lbl.Size = new System.Drawing.Size(109, 24);
            this.addname_lbl.TabIndex = 8;
            this.addname_lbl.Text = "Add Name";
            // 
            // addDetail
            // 
            this.addDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDetail.Location = new System.Drawing.Point(182, 197);
            this.addDetail.Name = "addDetail";
            this.addDetail.ReadOnly = true;
            this.addDetail.Size = new System.Drawing.Size(399, 29);
            this.addDetail.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(634, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Add Detail";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(182, 306);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(399, 260);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_add_comment
            // 
            this.txt_add_comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_add_comment.Location = new System.Drawing.Point(182, 251);
            this.txt_add_comment.Name = "txt_add_comment";
            this.txt_add_comment.Size = new System.Drawing.Size(399, 29);
            this.txt_add_comment.TabIndex = 12;
            // 
            // Comment_btn
            // 
            this.Comment_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_btn.Location = new System.Drawing.Point(636, 249);
            this.Comment_btn.Name = "Comment_btn";
            this.Comment_btn.Size = new System.Drawing.Size(175, 31);
            this.Comment_btn.TabIndex = 13;
            this.Comment_btn.Text = "Add Comment ";
            this.Comment_btn.UseVisualStyleBackColor = true;
            this.Comment_btn.Click += new System.EventHandler(this.Comment_btn_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(636, 306);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(175, 33);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lb_Hello
            // 
            this.lb_Hello.AutoSize = true;
            this.lb_Hello.BackColor = System.Drawing.Color.Transparent;
            this.lb_Hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hello.Location = new System.Drawing.Point(27, 51);
            this.lb_Hello.Name = "lb_Hello";
            this.lb_Hello.Size = new System.Drawing.Size(0, 20);
            this.lb_Hello.TabIndex = 15;
            // 
            // Add_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 569);
            this.Controls.Add(this.lb_Hello);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.Comment_btn);
            this.Controls.Add(this.txt_add_comment);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addDetail);
            this.Controls.Add(this.addname_lbl);
            this.Controls.Add(this.add_Name);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Logout_lklb);
            this.Controls.Add(this.Lk_lb_Profile);
            this.Controls.Add(this.label1);
            this.Name = "Add_detail";
            this.Text = "Add_detail";
            this.Load += new System.EventHandler(this.Add_detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Lk_lb_Profile;
        private System.Windows.Forms.LinkLabel Logout_lklb;
        private System.Windows.Forms.LinkLabel Back;
        private System.Windows.Forms.TextBox add_Name;
        private System.Windows.Forms.Label addname_lbl;
        private System.Windows.Forms.TextBox addDetail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_add_comment;
        private System.Windows.Forms.Button Comment_btn;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lb_Hello;
    }
}