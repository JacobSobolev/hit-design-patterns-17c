namespace AppUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label bioLabel;
            this.panelMultiDisplayPosts = new System.Windows.Forms.Panel();
            this.postListBox = new System.Windows.Forms.ListBox();
            this.postedItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPostList = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonDeletePost = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bioTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.createdTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            createdTimeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            bioLabel = new System.Windows.Forms.Label();
            this.panelMultiDisplayPosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postedItemBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(24, 25);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 57);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(24, 89);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(53, 13);
            messageLabel.TabIndex = 4;
            messageLabel.Text = "Message:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(24, 195);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // bioLabel
            // 
            bioLabel.AutoSize = true;
            bioLabel.Location = new System.Drawing.Point(24, 122);
            bioLabel.Name = "bioLabel";
            bioLabel.Size = new System.Drawing.Size(25, 13);
            bioLabel.TabIndex = 9;
            bioLabel.Text = "Bio:";
            // 
            // panelMultiDisplayPosts
            // 
            this.panelMultiDisplayPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMultiDisplayPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMultiDisplayPosts.Controls.Add(this.postListBox);
            this.panelMultiDisplayPosts.Controls.Add(this.labelPostList);
            this.panelMultiDisplayPosts.Location = new System.Drawing.Point(0, 17);
            this.panelMultiDisplayPosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelMultiDisplayPosts.Name = "panelMultiDisplayPosts";
            this.panelMultiDisplayPosts.Padding = new System.Windows.Forms.Padding(15);
            this.panelMultiDisplayPosts.Size = new System.Drawing.Size(343, 514);
            this.panelMultiDisplayPosts.TabIndex = 1;
            // 
            // postListBox
            // 
            this.postListBox.DataSource = this.postedItemBindingSource;
            this.postListBox.DisplayMember = "Message";
            this.postListBox.FormattingEnabled = true;
            this.postListBox.Location = new System.Drawing.Point(15, 29);
            this.postListBox.Name = "postListBox";
            this.postListBox.Size = new System.Drawing.Size(310, 381);
            this.postListBox.TabIndex = 2;
            this.postListBox.SelectedIndexChanged += new System.EventHandler(this.postListBox_SelectedIndexChanged);
            // 
            // postedItemBindingSource
            // 
            this.postedItemBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.PostedItem);
            // 
            // labelPostList
            // 
            this.labelPostList.AutoSize = true;
            this.labelPostList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPostList.Location = new System.Drawing.Point(10, 1);
            this.labelPostList.Margin = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.labelPostList.Name = "labelPostList";
            this.labelPostList.Size = new System.Drawing.Size(166, 25);
            this.labelPostList.TabIndex = 1;
            this.labelPostList.Text = "Message Post List";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonDeletePost
            // 
            this.buttonDeletePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeletePost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePost.Location = new System.Drawing.Point(358, 396);
            this.buttonDeletePost.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.buttonDeletePost.Name = "buttonDeletePost";
            this.buttonDeletePost.Size = new System.Drawing.Size(368, 23);
            this.buttonDeletePost.TabIndex = 0;
            this.buttonDeletePost.Text = "Delete Post";
            this.buttonDeletePost.UseVisualStyleBackColor = true;
            this.buttonDeletePost.Click += new System.EventHandler(this.buttonDeletePost_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(bioLabel);
            this.panel1.Controls.Add(this.bioTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.imageNormalPictureBox);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeDateTimePicker);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Location = new System.Drawing.Point(349, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 321);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Like Count";
            // 
            // bioTextBox
            // 
            this.bioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postedItemBindingSource, "From.Bio", true));
            this.bioTextBox.Location = new System.Drawing.Point(158, 118);
            this.bioTextBox.Name = "bioTextBox";
            this.bioTextBox.Size = new System.Drawing.Size(100, 20);
            this.bioTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postedItemBindingSource, "From.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(158, 188);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(103, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postedItemBindingSource, "From.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(27, 224);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(93, 78);
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // createdTimeDateTimePicker
            // 
            this.createdTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.postedItemBindingSource, "CreatedTime", true));
            this.createdTimeDateTimePicker.Location = new System.Drawing.Point(158, 21);
            this.createdTimeDateTimePicker.Name = "createdTimeDateTimePicker";
            this.createdTimeDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.createdTimeDateTimePicker.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postedItemBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(158, 54);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postedItemBindingSource, "Message", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "No Message"));
            this.messageTextBox.Location = new System.Drawing.Point(158, 86);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(203, 20);
            this.messageTextBox.TabIndex = 5;
            // 
            // UserControlPostsActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonDeletePost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMultiDisplayPosts);
            this.Name = "UserControlPostsActions";
            this.Size = new System.Drawing.Size(755, 543);
            this.panelMultiDisplayPosts.ResumeLayout(false);
            this.panelMultiDisplayPosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postedItemBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMultiDisplayPosts;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonDeletePost;
        private System.Windows.Forms.Label labelPostList;
        private System.Windows.Forms.ListBox postListBox;
        private System.Windows.Forms.BindingSource postedItemBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.PictureBox imageNormalPictureBox;
        private System.Windows.Forms.DateTimePicker createdTimeDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bioTextBox;
    }
}
