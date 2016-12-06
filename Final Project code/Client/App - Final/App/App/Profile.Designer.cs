namespace App
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.cb_security_qus = new System.Windows.Forms.ComboBox();
            this.txt_Contact_no = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_full_name = new System.Windows.Forms.TextBox();
            this.txt_passwd_confirm = new System.Windows.Forms.TextBox();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.bt_Profile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_hello_usr = new System.Windows.Forms.Label();
            this.bt_back_to_pre_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ans
            // 
            this.txt_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ans.Location = new System.Drawing.Point(511, 558);
            this.txt_ans.MaxLength = 10;
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(200, 34);
            this.txt_ans.TabIndex = 18;
            this.txt_ans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pipe_check_key_press);
            // 
            // cb_security_qus
            // 
            this.cb_security_qus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_security_qus.FormattingEnabled = true;
            this.cb_security_qus.Items.AddRange(new object[] {
            "Favorite Food?",
            "Favorite Teacher?",
            "Favorite Hobby?",
            "Pet Name?",
            "Highschool name?"});
            this.cb_security_qus.Location = new System.Drawing.Point(511, 514);
            this.cb_security_qus.Name = "cb_security_qus";
            this.cb_security_qus.Size = new System.Drawing.Size(504, 37);
            this.cb_security_qus.TabIndex = 17;
            // 
            // txt_Contact_no
            // 
            this.txt_Contact_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact_no.Location = new System.Drawing.Point(511, 313);
            this.txt_Contact_no.MaxLength = 10;
            this.txt_Contact_no.Name = "txt_Contact_no";
            this.txt_Contact_no.Size = new System.Drawing.Size(200, 34);
            this.txt_Contact_no.TabIndex = 13;
            this.txt_Contact_no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contact_no_key_press);
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(511, 362);
            this.txt_location.MaxLength = 300;
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(500, 34);
            this.txt_location.TabIndex = 14;
            this.txt_location.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pipe_check_key_press);
            // 
            // txt_full_name
            // 
            this.txt_full_name.BackColor = System.Drawing.SystemColors.Info;
            this.txt_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_full_name.Location = new System.Drawing.Point(511, 160);
            this.txt_full_name.MaxLength = 100;
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.ReadOnly = true;
            this.txt_full_name.Size = new System.Drawing.Size(200, 34);
            this.txt_full_name.TabIndex = 10;
            this.txt_full_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_full_name_key_press);
            // 
            // txt_passwd_confirm
            // 
            this.txt_passwd_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwd_confirm.Location = new System.Drawing.Point(511, 467);
            this.txt_passwd_confirm.Name = "txt_passwd_confirm";
            this.txt_passwd_confirm.PasswordChar = '*';
            this.txt_passwd_confirm.Size = new System.Drawing.Size(200, 34);
            this.txt_passwd_confirm.TabIndex = 16;
            // 
            // txt_passwd
            // 
            this.txt_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwd.Location = new System.Drawing.Point(511, 416);
            this.txt_passwd.MaxLength = 10;
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.PasswordChar = '*';
            this.txt_passwd.Size = new System.Drawing.Size(200, 34);
            this.txt_passwd.TabIndex = 15;
            this.txt_passwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pipe_check_key_press);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.SystemColors.Info;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(511, 217);
            this.txt_username.MaxLength = 20;
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(200, 34);
            this.txt_username.TabIndex = 11;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_full_name_key_press);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(168, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "Answer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Contact No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Enter Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(168, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Confirm Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Security Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name  ";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(168, 217);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(151, 29);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "User Name ";
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.SystemColors.Info;
            this.txt_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender.Location = new System.Drawing.Point(511, 264);
            this.txt_gender.MaxLength = 1;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.Size = new System.Drawing.Size(200, 34);
            this.txt_gender.TabIndex = 12;
            // 
            // bt_Profile
            // 
            this.bt_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Profile.Location = new System.Drawing.Point(511, 617);
            this.bt_Profile.Name = "bt_Profile";
            this.bt_Profile.Size = new System.Drawing.Size(300, 53);
            this.bt_Profile.TabIndex = 20;
            this.bt_Profile.Text = "Submit Change";
            this.bt_Profile.UseVisualStyleBackColor = true;
            this.bt_Profile.Click += new System.EventHandler(this.bt_Profile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "All in One Application";
            // 
            // lb_hello_usr
            // 
            this.lb_hello_usr.AutoSize = true;
            this.lb_hello_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello_usr.Location = new System.Drawing.Point(1, 96);
            this.lb_hello_usr.Name = "lb_hello_usr";
            this.lb_hello_usr.Size = new System.Drawing.Size(0, 31);
            this.lb_hello_usr.TabIndex = 42;
            // 
            // bt_back_to_pre_form
            // 
            this.bt_back_to_pre_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back_to_pre_form.Location = new System.Drawing.Point(849, 617);
            this.bt_back_to_pre_form.Name = "bt_back_to_pre_form";
            this.bt_back_to_pre_form.Size = new System.Drawing.Size(166, 53);
            this.bt_back_to_pre_form.TabIndex = 43;
            this.bt_back_to_pre_form.Text = "Back";
            this.bt_back_to_pre_form.UseVisualStyleBackColor = true;
            this.bt_back_to_pre_form.Click += new System.EventHandler(this.bt_back_to_pre_form_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.bt_back_to_pre_form);
            this.Controls.Add(this.lb_hello_usr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Profile);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.cb_security_qus);
            this.Controls.Add(this.txt_Contact_no);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_full_name);
            this.Controls.Add(this.txt_passwd_confirm);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_username);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.ComboBox cb_security_qus;
        private System.Windows.Forms.TextBox txt_Contact_no;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_full_name;
        private System.Windows.Forms.TextBox txt_passwd_confirm;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Button bt_Profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_hello_usr;
        private System.Windows.Forms.Button bt_back_to_pre_form;
    }
}