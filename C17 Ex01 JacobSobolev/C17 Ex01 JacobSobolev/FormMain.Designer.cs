namespace C17_Ex01_LiatLevi_203505953
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.checkBoxIfRemmberMe = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userControlLogin = new C17_Ex01.UserControlLogin();
            this.userControlMain = new C17_Ex01.UserControlMain();
            this.SuspendLayout();
            // 
            // checkBoxIfRemmberMe
            // 
            this.checkBoxIfRemmberMe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIfRemmberMe.AutoSize = true;
            this.checkBoxIfRemmberMe.Font = new System.Drawing.Font("David", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxIfRemmberMe.Location = new System.Drawing.Point(154, 186);
            this.checkBoxIfRemmberMe.Name = "checkBoxIfRemmberMe";
            this.checkBoxIfRemmberMe.Size = new System.Drawing.Size(143, 19);
            this.checkBoxIfRemmberMe.TabIndex = 1;
            this.checkBoxIfRemmberMe.Text = "Keep me logged in";
            this.checkBoxIfRemmberMe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(154, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 70);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userControlLogin
            // 
            this.userControlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlLogin.Location = new System.Drawing.Point(0, 0);
            this.userControlLogin.Name = "userControlLogin";
            this.userControlLogin.Size = new System.Drawing.Size(787, 672);
            this.userControlLogin.TabIndex = 11;
            // 
            // userControlMain
            // 
            this.userControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlMain.Location = new System.Drawing.Point(0, 0);
            this.userControlMain.Name = "userControlMain";
            this.userControlMain.Size = new System.Drawing.Size(787, 662);
            this.userControlMain.TabIndex = 10;
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
            this.Text = "FacebookAplication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxIfRemmberMe;
        private C17_Ex01.UserControlLogin userControlLogin;
        private C17_Ex01.UserControlMain userControlMain;
    }
}