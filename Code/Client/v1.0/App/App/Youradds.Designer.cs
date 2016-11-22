namespace App
{
    partial class Youradds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Youradds));
            this.Myadds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Myadds
            // 
            this.Myadds.AutoSize = true;
            this.Myadds.Location = new System.Drawing.Point(70, 45);
            this.Myadds.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Myadds.Name = "Myadds";
            this.Myadds.Size = new System.Drawing.Size(81, 24);
            this.Myadds.TabIndex = 0;
            this.Myadds.Text = "My adds";
            this.Myadds.Click += new System.EventHandler(this.label1_Click);
            // 
            // Youradds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.Myadds);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Youradds";
            this.Text = "Youradds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Myadds;
    }
}