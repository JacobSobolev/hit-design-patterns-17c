namespace AppUI
{
    public partial class UserControlMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBasic = new System.Windows.Forms.TabPage();
            this.tabPageMultiComment = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelUserName = new System.Windows.Forms.Label();
            this.picBoxLogout = new System.Windows.Forms.PictureBox();
            this.picBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrad = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userControlBasicActions = new AppUI.UserControlBasicActions();
            this.userControlPostsActions = new AppUI.UserControlPostsActions();
            this.userControlPagesTable = new AppUI.UserControlPagesTable();
            this.tabControl1.SuspendLayout();
            this.tabPageBasic.SuspendLayout();
            this.tabPageMultiComment.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBasic);
            this.tabControl1.Controls.Add(this.tabPageMultiComment);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tabControl1.Location = new System.Drawing.Point(15, 154);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 527);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPageBasic
            // 
            this.tabPageBasic.Controls.Add(this.userControlBasicActions);
            this.tabPageBasic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBasic.Location = new System.Drawing.Point(4, 26);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasic.Size = new System.Drawing.Size(761, 497);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Basic";
            this.tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // tabPageMultiComment
            // 
            this.tabPageMultiComment.Controls.Add(this.userControlPostsActions);
            this.tabPageMultiComment.Location = new System.Drawing.Point(4, 26);
            this.tabPageMultiComment.Name = "tabPageMultiComment";
            this.tabPageMultiComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultiComment.Size = new System.Drawing.Size(761, 497);
            this.tabPageMultiComment.TabIndex = 1;
            this.tabPageMultiComment.Text = "Post Actions";
            this.tabPageMultiComment.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.userControlPagesTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pages Table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(155, 118);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(120, 30);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "User Name";
            // 
            // picBoxLogout
            // 
            this.picBoxLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxLogout.BackColor = System.Drawing.Color.Transparent;
            this.picBoxLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBoxLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxLogout.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogout.Image")));
            this.picBoxLogout.Location = new System.Drawing.Point(600, 89);
            this.picBoxLogout.Name = "picBoxLogout";
            this.picBoxLogout.Size = new System.Drawing.Size(180, 59);
            this.picBoxLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxLogout.TabIndex = 10;
            this.picBoxLogout.TabStop = false;
            this.picBoxLogout.Click += new System.EventHandler(this.picBoxLogout_Click);
            this.picBoxLogout.MouseEnter += new System.EventHandler(this.picBoxLogout_MouseEnter);
            this.picBoxLogout.MouseLeave += new System.EventHandler(this.picBoxLogout_MouseLeave);
            // 
            // picBoxProfilePicture
            // 
            this.picBoxProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxProfilePicture.BackgroundImage")));
            this.picBoxProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxProfilePicture.Location = new System.Drawing.Point(15, 14);
            this.picBoxProfilePicture.Name = "picBoxProfilePicture";
            this.picBoxProfilePicture.Size = new System.Drawing.Size(134, 134);
            this.picBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProfilePicture.TabIndex = 6;
            this.picBoxProfilePicture.TabStop = false;
            // 
            // pictureBoxGrad
            // 
            this.pictureBoxGrad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxGrad.Image = global::AppUI.Properties.Resources.fbGradiant;
            this.pictureBoxGrad.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGrad.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxGrad.Name = "pictureBoxGrad";
            this.pictureBoxGrad.Size = new System.Drawing.Size(800, 151);
            this.pictureBoxGrad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGrad.TabIndex = 11;
            this.pictureBoxGrad.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(15, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // userControlBasicActions
            // 
            this.userControlBasicActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlBasicActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBasicActions.Location = new System.Drawing.Point(3, 3);
            this.userControlBasicActions.Name = "userControlBasicActions";
            this.userControlBasicActions.Size = new System.Drawing.Size(755, 491);
            this.userControlBasicActions.TabIndex = 0;
            // 
            // userControlPostsActions
            // 
            this.userControlPostsActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlPostsActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPostsActions.Location = new System.Drawing.Point(3, 3);
            this.userControlPostsActions.Name = "userControlPostsActions";
            this.userControlPostsActions.Size = new System.Drawing.Size(755, 491);
            this.userControlPostsActions.TabIndex = 0;
            // 
            // userControlPagesTable
            // 
            this.userControlPagesTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlPagesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPagesTable.Location = new System.Drawing.Point(0, 0);
            this.userControlPagesTable.Name = "userControlPagesTable";
            this.userControlPagesTable.Size = new System.Drawing.Size(761, 497);
            this.userControlPagesTable.TabIndex = 0;
            // 
            // UserControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxLogout);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.picBoxProfilePicture);
            this.Controls.Add(this.pictureBoxGrad);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserControlMain";
            this.Size = new System.Drawing.Size(800, 700);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBasic.ResumeLayout(false);
            this.tabPageMultiComment.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBasic;
        private System.Windows.Forms.TabPage tabPageMultiComment;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox picBoxProfilePicture;
        private System.Windows.Forms.PictureBox picBoxLogout;
        private System.Windows.Forms.PictureBox pictureBoxGrad;
        private System.Windows.Forms.PictureBox pictureBox2;
        private UserControlBasicActions userControlBasicActions;
        private UserControlPostsActions userControlPostsActions;
        private UserControlPagesTable userControlPagesTable;
    }
}
