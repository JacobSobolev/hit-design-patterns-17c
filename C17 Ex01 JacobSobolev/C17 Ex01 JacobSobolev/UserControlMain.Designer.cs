namespace C17_Ex01
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
            this.userControlMainFeatur1 = new C17_Ex01.UserControlBasicActions();
            this.tabPageMultiComment = new System.Windows.Forms.TabPage();
            this.userControlMultiCommentFeature1 = new C17_Ex01.UserControlPostsActions();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.userControlPagesByPopularity1 = new C17_Ex01.UserControlPagesTable();
            this.labelUserName = new System.Windows.Forms.Label();
            this.picBoxLogout = new System.Windows.Forms.PictureBox();
            this.picBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrad = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.tabPageBasic.Controls.Add(this.userControlMainFeatur1);
            this.tabPageBasic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBasic.Location = new System.Drawing.Point(4, 26);
            this.tabPageBasic.Name = "tabPageBasic";
            this.tabPageBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBasic.Size = new System.Drawing.Size(761, 497);
            this.tabPageBasic.TabIndex = 0;
            this.tabPageBasic.Text = "Basic";
            this.tabPageBasic.UseVisualStyleBackColor = true;
            // 
            // userControlMainFeatur1
            // 
            this.userControlMainFeatur1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlMainFeatur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMainFeatur1.Location = new System.Drawing.Point(3, 3);
            this.userControlMainFeatur1.Margin = new System.Windows.Forms.Padding(0);
            this.userControlMainFeatur1.Name = "userControlMainFeatur1";
            this.userControlMainFeatur1.Size = new System.Drawing.Size(755, 491);
            this.userControlMainFeatur1.TabIndex = 0;
            // 
            // tabPageMultiComment
            // 
            this.tabPageMultiComment.Controls.Add(this.userControlMultiCommentFeature1);
            this.tabPageMultiComment.Location = new System.Drawing.Point(4, 26);
            this.tabPageMultiComment.Name = "tabPageMultiComment";
            this.tabPageMultiComment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultiComment.Size = new System.Drawing.Size(761, 497);
            this.tabPageMultiComment.TabIndex = 1;
            this.tabPageMultiComment.Text = "Post Actions";
            this.tabPageMultiComment.UseVisualStyleBackColor = true;
            // 
            // userControlMultiCommentFeature1
            // 
            this.userControlMultiCommentFeature1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlMultiCommentFeature1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMultiCommentFeature1.Location = new System.Drawing.Point(3, 3);
            this.userControlMultiCommentFeature1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlMultiCommentFeature1.Name = "userControlMultiCommentFeature1";
            this.userControlMultiCommentFeature1.Size = new System.Drawing.Size(755, 491);
            this.userControlMultiCommentFeature1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.userControlPagesByPopularity1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(761, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pages Table";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // userControlPagesByPopularity1
            // 
            this.userControlPagesByPopularity1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControlPagesByPopularity1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPagesByPopularity1.Location = new System.Drawing.Point(0, 0);
            this.userControlPagesByPopularity1.Margin = new System.Windows.Forms.Padding(0);
            this.userControlPagesByPopularity1.Name = "userControlPagesByPopularity1";
            this.userControlPagesByPopularity1.Size = new System.Drawing.Size(761, 497);
            this.userControlPagesByPopularity1.TabIndex = 0;
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
            this.pictureBoxGrad.Image = global::C17_Ex01.Properties.Resources.fbGradiant;
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
        private UserControlBasicActions userControlMainFeatur1;
        private UserControlPostsActions userControlMultiCommentFeature1;
        private UserControlPagesTable userControlPagesByPopularity1;
    }
}
