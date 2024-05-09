namespace AppUI
{
    public partial class UserControlBasicActions
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
            this.listBoxPost = new System.Windows.Forms.ListBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.panelBasicFriends = new System.Windows.Forms.Panel();
            this.labelFriendsList = new System.Windows.Forms.Label();
            this.panelBasicDisplayPosts = new System.Windows.Forms.Panel();
            this.labelPostList = new System.Windows.Forms.Label();
            this.panelBasicWritePost = new System.Windows.Forms.Panel();
            this.panelBasicFriends.SuspendLayout();
            this.panelBasicDisplayPosts.SuspendLayout();
            this.panelBasicWritePost.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPost
            // 
            this.listBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPost.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.listBoxPost.FormattingEnabled = true;
            this.listBoxPost.ItemHeight = 15;
            this.listBoxPost.Location = new System.Drawing.Point(19, 40);
            this.listBoxPost.Margin = new System.Windows.Forms.Padding(3, 0, 15, 3);
            this.listBoxPost.Name = "listBoxPost";
            this.listBoxPost.Size = new System.Drawing.Size(498, 409);
            this.listBoxPost.TabIndex = 2;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 15;
            this.listBoxFriends.Location = new System.Drawing.Point(20, 40);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(3, 0, 15, 3);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(189, 409);
            this.listBoxFriends.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "write a post";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPost.Location = new System.Drawing.Point(117, 6);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(400, 20);
            this.textBoxPost.TabIndex = 5;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.Location = new System.Drawing.Point(553, 6);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(188, 27);
            this.buttonPost.TabIndex = 6;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // panelBasicFriends
            // 
            this.panelBasicFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBasicFriends.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBasicFriends.Controls.Add(this.labelFriendsList);
            this.panelBasicFriends.Controls.Add(this.listBoxFriends);
            this.panelBasicFriends.Location = new System.Drawing.Point(532, 0);
            this.panelBasicFriends.Margin = new System.Windows.Forms.Padding(0);
            this.panelBasicFriends.Name = "panelBasicFriends";
            this.panelBasicFriends.Size = new System.Drawing.Size(223, 453);
            this.panelBasicFriends.TabIndex = 10;
            // 
            // labelFriendsList
            // 
            this.labelFriendsList.AutoSize = true;
            this.labelFriendsList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelFriendsList.Location = new System.Drawing.Point(14, 15);
            this.labelFriendsList.Name = "labelFriendsList";
            this.labelFriendsList.Size = new System.Drawing.Size(112, 25);
            this.labelFriendsList.TabIndex = 4;
            this.labelFriendsList.Text = "Friends List";
            // 
            // panelBasicDisplayPosts
            // 
            this.panelBasicDisplayPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBasicDisplayPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBasicDisplayPosts.Controls.Add(this.labelPostList);
            this.panelBasicDisplayPosts.Controls.Add(this.listBoxPost);
            this.panelBasicDisplayPosts.Location = new System.Drawing.Point(0, 0);
            this.panelBasicDisplayPosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelBasicDisplayPosts.Name = "panelBasicDisplayPosts";
            this.panelBasicDisplayPosts.Size = new System.Drawing.Size(532, 453);
            this.panelBasicDisplayPosts.TabIndex = 11;
            // 
            // labelPostList
            // 
            this.labelPostList.AutoSize = true;
            this.labelPostList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPostList.Location = new System.Drawing.Point(14, 15);
            this.labelPostList.Name = "labelPostList";
            this.labelPostList.Size = new System.Drawing.Size(85, 25);
            this.labelPostList.TabIndex = 3;
            this.labelPostList.Text = "Post List";
            // 
            // panelBasicWritePost
            // 
            this.panelBasicWritePost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBasicWritePost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBasicWritePost.Controls.Add(this.label1);
            this.panelBasicWritePost.Controls.Add(this.textBoxPost);
            this.panelBasicWritePost.Controls.Add(this.buttonPost);
            this.panelBasicWritePost.Location = new System.Drawing.Point(0, 456);
            this.panelBasicWritePost.Margin = new System.Windows.Forms.Padding(0);
            this.panelBasicWritePost.Name = "panelBasicWritePost";
            this.panelBasicWritePost.Size = new System.Drawing.Size(755, 40);
            this.panelBasicWritePost.TabIndex = 12;
            // 
            // UserControlBasicFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelBasicDisplayPosts);
            this.Controls.Add(this.panelBasicFriends);
            this.Controls.Add(this.panelBasicWritePost);
            this.Name = "UserControlBasicFeature";
            this.Size = new System.Drawing.Size(755, 496);
            this.panelBasicFriends.ResumeLayout(false);
            this.panelBasicFriends.PerformLayout();
            this.panelBasicDisplayPosts.ResumeLayout(false);
            this.panelBasicDisplayPosts.PerformLayout();
            this.panelBasicWritePost.ResumeLayout(false);
            this.panelBasicWritePost.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxPost;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Panel panelBasicFriends;
        private System.Windows.Forms.Panel panelBasicDisplayPosts;
        private System.Windows.Forms.Panel panelBasicWritePost;
        private System.Windows.Forms.Label labelFriendsList;
        private System.Windows.Forms.Label labelPostList;
    }
}
