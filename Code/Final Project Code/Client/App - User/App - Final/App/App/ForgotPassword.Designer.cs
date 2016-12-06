namespace App
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_ans = new System.Windows.Forms.TextBox();
            this.bt_get_passwd = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_get_qus = new System.Windows.Forms.Button();
            this.txt_qus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "All in One Application";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(453, 214);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(144, 29);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "User Name";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(453, 343);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(99, 29);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Answer";
            this.lbl_pass.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(650, 214);
            this.txt_username.MaxLength = 20;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(321, 34);
            this.txt_username.TabIndex = 4;
            // 
            // txt_ans
            // 
            this.txt_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ans.Location = new System.Drawing.Point(650, 338);
            this.txt_ans.MaxLength = 10;
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.PasswordChar = '*';
            this.txt_ans.Size = new System.Drawing.Size(321, 34);
            this.txt_ans.TabIndex = 5;
            // 
            // bt_get_passwd
            // 
            this.bt_get_passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_get_passwd.Location = new System.Drawing.Point(650, 519);
            this.bt_get_passwd.Name = "bt_get_passwd";
            this.bt_get_passwd.Size = new System.Drawing.Size(321, 50);
            this.bt_get_passwd.TabIndex = 6;
            this.bt_get_passwd.Text = "Retrieve Password";
            this.bt_get_passwd.UseVisualStyleBackColor = true;
            this.bt_get_passwd.Click += new System.EventHandler(this.bt_get_passwd_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(458, 519);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(150, 50);
            this.bt_reset.TabIndex = 7;
            this.bt_reset.Text = "Back";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_get_qus
            // 
            this.bt_get_qus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_get_qus.Location = new System.Drawing.Point(276, 276);
            this.bt_get_qus.Name = "bt_get_qus";
            this.bt_get_qus.Size = new System.Drawing.Size(321, 34);
            this.bt_get_qus.TabIndex = 8;
            this.bt_get_qus.Text = "Get Security Qus";
            this.bt_get_qus.UseVisualStyleBackColor = true;
            this.bt_get_qus.Click += new System.EventHandler(this.bt_get_qus_Click);
            // 
            // txt_qus
            // 
            this.txt_qus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qus.Location = new System.Drawing.Point(650, 276);
            this.txt_qus.MaxLength = 10;
            this.txt_qus.Name = "txt_qus";
            this.txt_qus.ReadOnly = true;
            this.txt_qus.Size = new System.Drawing.Size(321, 34);
            this.txt_qus.TabIndex = 9;
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.txt_qus);
            this.Controls.Add(this.bt_get_qus);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_get_passwd);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_ans;
        private System.Windows.Forms.Button bt_get_passwd;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_get_qus;
        private System.Windows.Forms.TextBox txt_qus;
    }
}