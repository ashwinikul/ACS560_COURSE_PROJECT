namespace App
{
    partial class UserHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.label1 = new System.Windows.Forms.Label();
            this.link_Profile = new System.Windows.Forms.LinkLabel();
            this.newaddlink = new System.Windows.Forms.LinkLabel();
            this.Logoutlink = new System.Windows.Forms.LinkLabel();
            this.Myadd = new System.Windows.Forms.LinkLabel();
            this.Search_Textbox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.searchhere = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_Hello_userhome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 42;
            this.label1.Text = "All in One Application";
            // 
            // link_Profile
            // 
            this.link_Profile.AutoSize = true;
            this.link_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_Profile.LinkColor = System.Drawing.Color.Blue;
            this.link_Profile.Location = new System.Drawing.Point(681, 109);
            this.link_Profile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_Profile.Name = "link_Profile";
            this.link_Profile.Size = new System.Drawing.Size(62, 24);
            this.link_Profile.TabIndex = 43;
            this.link_Profile.TabStop = true;
            this.link_Profile.Text = "Profile";
            this.link_Profile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Profile_LinkClicked);
            // 
            // newaddlink
            // 
            this.newaddlink.AutoSize = true;
            this.newaddlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newaddlink.Location = new System.Drawing.Point(772, 109);
            this.newaddlink.Name = "newaddlink";
            this.newaddlink.Size = new System.Drawing.Size(89, 24);
            this.newaddlink.TabIndex = 44;
            this.newaddlink.TabStop = true;
            this.newaddlink.Text = "New Add";
            // 
            // Logoutlink
            // 
            this.Logoutlink.AutoSize = true;
            this.Logoutlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutlink.Location = new System.Drawing.Point(12, 109);
            this.Logoutlink.Name = "Logoutlink";
            this.Logoutlink.Size = new System.Drawing.Size(68, 24);
            this.Logoutlink.TabIndex = 45;
            this.Logoutlink.TabStop = true;
            this.Logoutlink.Text = "Logout";
            // 
            // Myadd
            // 
            this.Myadd.AutoSize = true;
            this.Myadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Myadd.Location = new System.Drawing.Point(117, 109);
            this.Myadd.Name = "Myadd";
            this.Myadd.Size = new System.Drawing.Size(81, 24);
            this.Myadd.TabIndex = 46;
            this.Myadd.TabStop = true;
            this.Myadd.Text = "My adds";
            // 
            // Search_Textbox
            // 
            this.Search_Textbox.Location = new System.Drawing.Point(121, 181);
            this.Search_Textbox.Name = "Search_Textbox";
            this.Search_Textbox.Size = new System.Drawing.Size(300, 20);
            this.Search_Textbox.TabIndex = 47;
            this.Search_Textbox.TextChanged += new System.EventHandler(this.Search_Textbox_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchButton.Location = new System.Drawing.Point(463, 170);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(158, 31);
            this.SearchButton.TabIndex = 48;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // searchhere
            // 
            this.searchhere.AutoSize = true;
            this.searchhere.BackColor = System.Drawing.Color.White;
            this.searchhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchhere.Location = new System.Drawing.Point(354, 184);
            this.searchhere.Name = "searchhere";
            this.searchhere.Size = new System.Drawing.Size(65, 13);
            this.searchhere.TabIndex = 49;
            this.searchhere.Text = "Search here";
            this.searchhere.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(698, 333);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb_Hello_userhome
            // 
            this.lb_Hello_userhome.AutoSize = true;
            this.lb_Hello_userhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Hello_userhome.Location = new System.Drawing.Point(25, 69);
            this.lb_Hello_userhome.Name = "lb_Hello_userhome";
            this.lb_Hello_userhome.Size = new System.Drawing.Size(0, 24);
            this.lb_Hello_userhome.TabIndex = 51;
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(886, 602);
            this.Controls.Add(this.lb_Hello_userhome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchhere);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Search_Textbox);
            this.Controls.Add(this.Myadd);
            this.Controls.Add(this.Logoutlink);
            this.Controls.Add(this.newaddlink);
            this.Controls.Add(this.link_Profile);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.Load += new System.EventHandler(this.UserHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel link_Profile;
        private System.Windows.Forms.LinkLabel newaddlink;
        private System.Windows.Forms.LinkLabel Logoutlink;
        private System.Windows.Forms.LinkLabel Myadd;
        private System.Windows.Forms.TextBox Search_Textbox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label searchhere;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_Hello_userhome;
    }
}