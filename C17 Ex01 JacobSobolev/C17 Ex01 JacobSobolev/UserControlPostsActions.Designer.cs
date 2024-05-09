namespace C17_Ex01
{
    public partial class UserControlPostsActions
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
            this.panelMultiFilter = new System.Windows.Forms.Panel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.panelMultiDisplayPosts = new System.Windows.Forms.Panel();
            this.labelPostList = new System.Windows.Forms.Label();
            this.checkedListBoxPostist = new System.Windows.Forms.CheckedListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panelMultiWriteComment = new System.Windows.Forms.Panel();
            this.buttonLikeCount = new System.Windows.Forms.Button();
            this.buttonDeletePost = new System.Windows.Forms.Button();
            this.panelMultiFilter.SuspendLayout();
            this.panelMultiDisplayPosts.SuspendLayout();
            this.panelMultiWriteComment.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMultiFilter
            // 
            this.panelMultiFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMultiFilter.Controls.Add(this.buttonClear);
            this.panelMultiFilter.Controls.Add(this.buttonFilter);
            this.panelMultiFilter.Controls.Add(this.textBoxFilter);
            this.panelMultiFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMultiFilter.Location = new System.Drawing.Point(0, 0);
            this.panelMultiFilter.Margin = new System.Windows.Forms.Padding(0);
            this.panelMultiFilter.Name = "panelMultiFilter";
            this.panelMultiFilter.Size = new System.Drawing.Size(755, 45);
            this.panelMultiFilter.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(654, 12);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(15);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(86, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.Location = new System.Drawing.Point(557, 12);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(15);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(86, 23);
            this.buttonFilter.TabIndex = 2;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(15, 15);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(508, 20);
            this.textBoxFilter.TabIndex = 1;
            // 
            // panelMultiDisplayPosts
            // 
            this.panelMultiDisplayPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMultiDisplayPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMultiDisplayPosts.Controls.Add(this.labelPostList);
            this.panelMultiDisplayPosts.Controls.Add(this.checkedListBoxPostist);
            this.panelMultiDisplayPosts.Location = new System.Drawing.Point(0, 49);
            this.panelMultiDisplayPosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelMultiDisplayPosts.Name = "panelMultiDisplayPosts";
            this.panelMultiDisplayPosts.Padding = new System.Windows.Forms.Padding(15);
            this.panelMultiDisplayPosts.Size = new System.Drawing.Size(755, 411);
            this.panelMultiDisplayPosts.TabIndex = 1;
            // 
            // labelPostList
            // 
            this.labelPostList.AutoSize = true;
            this.labelPostList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPostList.Location = new System.Drawing.Point(10, 1);
            this.labelPostList.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.labelPostList.Name = "labelPostList";
            this.labelPostList.Size = new System.Drawing.Size(85, 25);
            this.labelPostList.TabIndex = 1;
            this.labelPostList.Text = "Post List";
            // 
            // checkedListBoxPostist
            // 
            this.checkedListBoxPostist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxPostist.FormattingEnabled = true;
            this.checkedListBoxPostist.Location = new System.Drawing.Point(15, 26);
            this.checkedListBoxPostist.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.checkedListBoxPostist.Name = "checkedListBoxPostist";
            this.checkedListBoxPostist.Size = new System.Drawing.Size(725, 379);
            this.checkedListBoxPostist.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panelMultiWriteComment
            // 
            this.panelMultiWriteComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMultiWriteComment.Controls.Add(this.buttonLikeCount);
            this.panelMultiWriteComment.Controls.Add(this.buttonDeletePost);
            this.panelMultiWriteComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMultiWriteComment.Location = new System.Drawing.Point(0, 460);
            this.panelMultiWriteComment.Margin = new System.Windows.Forms.Padding(0);
            this.panelMultiWriteComment.Name = "panelMultiWriteComment";
            this.panelMultiWriteComment.Size = new System.Drawing.Size(755, 36);
            this.panelMultiWriteComment.TabIndex = 2;
            // 
            // buttonLikeCount
            // 
            this.buttonLikeCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLikeCount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonLikeCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLikeCount.Location = new System.Drawing.Point(15, 0);
            this.buttonLikeCount.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.buttonLikeCount.Name = "buttonLikeCount";
            this.buttonLikeCount.Size = new System.Drawing.Size(328, 23);
            this.buttonLikeCount.TabIndex = 2;
            this.buttonLikeCount.Text = "Like Count";
            this.buttonLikeCount.UseVisualStyleBackColor = true;
            this.buttonLikeCount.Click += new System.EventHandler(this.buttonLikeCount_Click);
            // 
            // buttonDeletePost
            // 
            this.buttonDeletePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeletePost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePost.Location = new System.Drawing.Point(373, 0);
            this.buttonDeletePost.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.buttonDeletePost.Name = "buttonDeletePost";
            this.buttonDeletePost.Size = new System.Drawing.Size(368, 23);
            this.buttonDeletePost.TabIndex = 0;
            this.buttonDeletePost.Text = "Delete Post";
            this.buttonDeletePost.UseVisualStyleBackColor = true;
            this.buttonDeletePost.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // UserControlPostsActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panelMultiWriteComment);
            this.Controls.Add(this.panelMultiDisplayPosts);
            this.Controls.Add(this.panelMultiFilter);
            this.Name = "UserControlPostsActions";
            this.Size = new System.Drawing.Size(755, 496);
            this.panelMultiFilter.ResumeLayout(false);
            this.panelMultiFilter.PerformLayout();
            this.panelMultiDisplayPosts.ResumeLayout(false);
            this.panelMultiDisplayPosts.PerformLayout();
            this.panelMultiWriteComment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMultiFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Panel panelMultiDisplayPosts;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.CheckedListBox checkedListBoxPostist;
        private System.Windows.Forms.Panel panelMultiWriteComment;
        private System.Windows.Forms.Button buttonDeletePost;
        private System.Windows.Forms.Label labelPostList;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLikeCount;
    }
}
