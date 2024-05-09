namespace AppUI
{
   public partial class FormMain
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
            this.userControlMain = new AppUI.UserControlMain();
            this.userControlLogin = new AppUI.UserControlLogin();
            this.SuspendLayout();
            // 
            // userControlMain
            // 
            this.userControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMain.Location = new System.Drawing.Point(0, 0);
            this.userControlMain.Name = "userControlMain";
            this.userControlMain.Size = new System.Drawing.Size(784, 661);
            this.userControlMain.TabIndex = 0;
            // 
            // userControlLogin
            // 
            this.userControlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLogin.Location = new System.Drawing.Point(0, 0);
            this.userControlLogin.Name = "userControlLogin";
            this.userControlLogin.Size = new System.Drawing.Size(784, 661);
            this.userControlLogin.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.userControlLogin);
            this.Controls.Add(this.userControlMain);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlMain userControlMain;
        private UserControlLogin userControlLogin;
    }
}