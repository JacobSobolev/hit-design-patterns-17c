namespace DP_HIT_C17
{
    partial class MainForm
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
            this.userControlLogin = new DP_HIT_C17.UserControlLogin();
            this.SuspendLayout();

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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.userControlLogin);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Main";
            this.Text = "Facebook Application";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlLogin userControlLogin;
    }
}