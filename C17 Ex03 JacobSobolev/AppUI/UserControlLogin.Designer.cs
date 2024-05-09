namespace AppUI
{
    public partial class UserControlLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxRemmberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxFbLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxRemmberMe
            // 
            this.checkBoxRemmberMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRemmberMe.AutoSize = true;
            this.checkBoxRemmberMe.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRemmberMe.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxRemmberMe.Location = new System.Drawing.Point(167, 369);
            this.checkBoxRemmberMe.Name = "checkBoxRemmberMe";
            this.checkBoxRemmberMe.Size = new System.Drawing.Size(222, 44);
            this.checkBoxRemmberMe.TabIndex = 4;
            this.checkBoxRemmberMe.Text = "Remmber Me";
            this.checkBoxRemmberMe.UseVisualStyleBackColor = true;
            this.checkBoxRemmberMe.CheckedChanged += new System.EventHandler(this.checkBoxRemmberMe_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::AppUI.Properties.Resources.fbGradiant;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxFbLogin
            // 
            this.picBoxFbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBoxFbLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxFbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxFbLogin.Image = global::AppUI.Properties.Resources.fbLoginNormal;
            this.picBoxFbLogin.Location = new System.Drawing.Point(86, 160);
            this.picBoxFbLogin.Name = "picBoxFbLogin";
            this.picBoxFbLogin.Size = new System.Drawing.Size(580, 132);
            this.picBoxFbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxFbLogin.TabIndex = 6;
            this.picBoxFbLogin.TabStop = false;
            this.picBoxFbLogin.Click += new System.EventHandler(this.picBoxFbLogin_Click);
            this.picBoxFbLogin.MouseEnter += new System.EventHandler(this.picBoxFbLogin_MouseEnter);
            this.picBoxFbLogin.MouseLeave += new System.EventHandler(this.picBoxFbLogin_MouseLeave);
            // 
            // UserControlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picBoxFbLogin);
            this.Controls.Add(this.checkBoxRemmberMe);
            this.Name = "UserControlLogin";
            this.Size = new System.Drawing.Size(800, 700);
            this.SizeChanged += new System.EventHandler(this.UserControlLogin_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxRemmberMe;
        private System.Windows.Forms.PictureBox picBoxFbLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
