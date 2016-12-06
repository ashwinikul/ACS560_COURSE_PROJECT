namespace App
{
    partial class PostNewAddHere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostNewAddHere));
            this.post_add = new System.Windows.Forms.Button();
            this.add_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLbl_logout = new System.Windows.Forms.LinkLabel();
            this.linkLbl_Profile = new System.Windows.Forms.LinkLabel();
            this.linkLb_back = new System.Windows.Forms.LinkLabel();
            this.Post = new System.Windows.Forms.Label();
            this.Add_Descr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_hello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // post_add
            // 
            this.post_add.ForeColor = System.Drawing.Color.Black;
            this.post_add.Location = new System.Drawing.Point(654, 238);
            this.post_add.Margin = new System.Windows.Forms.Padding(6);
            this.post_add.Name = "post_add";
            this.post_add.Size = new System.Drawing.Size(150, 37);
            this.post_add.TabIndex = 3;
            this.post_add.Text = "PostAdd";
            this.post_add.UseVisualStyleBackColor = true;
            this.post_add.Click += new System.EventHandler(this.post_add_Click);
            // 
            // add_text
            // 
            this.add_text.Location = new System.Drawing.Point(96, 214);
            this.add_text.Margin = new System.Windows.Forms.Padding(6);
            this.add_text.MaxLength = 200;
            this.add_text.Name = "add_text";
            this.add_text.Size = new System.Drawing.Size(518, 31);
            this.add_text.TabIndex = 1;
            // this.add_text.TextChanged += new System.EventHandler(this.add_text_TextChanged);
            this.add_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pipe_check_key_press);

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "All in One Application";
            // 
            // linkLbl_logout
            // 
            this.linkLbl_logout.AutoSize = true;
            this.linkLbl_logout.Location = new System.Drawing.Point(22, 129);
            this.linkLbl_logout.Name = "linkLbl_logout";
            this.linkLbl_logout.Size = new System.Drawing.Size(78, 25);
            this.linkLbl_logout.TabIndex = 4;
            this.linkLbl_logout.TabStop = true;
            this.linkLbl_logout.Text = "Logout";
            this.linkLbl_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_logout_LinkClicked);
            // 
            // linkLbl_Profile
            // 
            this.linkLbl_Profile.AutoSize = true;
            this.linkLbl_Profile.Location = new System.Drawing.Point(729, 129);
            this.linkLbl_Profile.Name = "linkLbl_Profile";
            this.linkLbl_Profile.Size = new System.Drawing.Size(73, 25);
            this.linkLbl_Profile.TabIndex = 5;
            this.linkLbl_Profile.TabStop = true;
            this.linkLbl_Profile.Text = "Profile";
            this.linkLbl_Profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_Profile_LinkClicked);
            // 
            // linkLb_back
            // 
            this.linkLb_back.AutoSize = true;
            this.linkLb_back.Location = new System.Drawing.Point(649, 129);
            this.linkLb_back.Name = "linkLb_back";
            this.linkLb_back.Size = new System.Drawing.Size(60, 25);
            this.linkLb_back.TabIndex = 6;
            this.linkLb_back.TabStop = true;
            this.linkLb_back.Text = "Back";
            this.linkLb_back.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLb_back_LinkClicked);
            // 
            // Post
            // 
            this.Post.AutoSize = true;
            this.Post.BackColor = System.Drawing.Color.White;
            this.Post.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Post.Location = new System.Drawing.Point(523, 220);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(84, 20);
            this.Post.TabIndex = 7;
            this.Post.Text = "Add Name";
            // 
            // Add_Descr
            // 
            this.Add_Descr.Location = new System.Drawing.Point(96, 268);
            this.Add_Descr.MaxLength = 500;
            this.Add_Descr.Name = "Add_Descr";
            this.Add_Descr.Size = new System.Drawing.Size(518, 31);
            this.Add_Descr.TabIndex = 2;
            this.Add_Descr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pipe_check_key_press);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add Description";
            // 
            // lb_hello
            // 
            this.lb_hello.AutoSize = true;
            this.lb_hello.BackColor = System.Drawing.Color.Transparent;
            this.lb_hello.Location = new System.Drawing.Point(22, 72);
            this.lb_hello.Name = "lb_hello";
            this.lb_hello.Size = new System.Drawing.Size(0, 25);
            this.lb_hello.TabIndex = 10;
            // 
            // PostNewAddHere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 602);
            this.Controls.Add(this.lb_hello);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Descr);
            this.Controls.Add(this.Post);
            this.Controls.Add(this.linkLb_back);
            this.Controls.Add(this.linkLbl_Profile);
            this.Controls.Add(this.linkLbl_logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_text);
            this.Controls.Add(this.post_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PostNewAddHere";
            this.Load += new System.EventHandler(this.PostNewAddHere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button post_add;
        private System.Windows.Forms.TextBox add_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLbl_logout;
        private System.Windows.Forms.LinkLabel linkLbl_Profile;
        private System.Windows.Forms.LinkLabel linkLb_back;
        private System.Windows.Forms.Label Post;
        private System.Windows.Forms.TextBox Add_Descr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_hello;
    }
}