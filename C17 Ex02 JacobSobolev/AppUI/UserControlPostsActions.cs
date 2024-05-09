using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace AppUI
{
    public partial class UserControlPostsActions : UserControl
    {
        private event Action<string> postDeletionCompleted;

        public UserControlPostsActions()
        {
            InitializeComponent();
            postDeletionCompleted += postDeletionCompletedCallback;
        }

        public void AddCallbackToEvents()
        {
            AppService.Instance.AddToEventPostDataChanged(updatePostListDataSource);
        }

        private void updatePostListDataSource(FacebookObjectCollection<Post> i_UserPosts)
        {
            Thread thread = new Thread(() => updatePostListDataSourceThread(i_UserPosts));
            thread.Start();
        }

        private void updatePostListDataSourceThread(FacebookObjectCollection<Post> i_UserPosts)
        {
            postListBox.Invoke(new Action(() => postedItemBindingSource.DataSource = i_UserPosts));
        }

        private void deletePosts()
        {
            MessageBox.Show("Action Being Preformed, please wait", "Delete Action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Thread(deletePostsThread).Start();
        }

        private void deletePostsThread()
        {
            StringBuilder infoMsg = new StringBuilder();

            FacebookObjectCollection<Post> deletedItems = new FacebookObjectCollection<Post>();

            Post selectedItem = postListBox.SelectedItem as Post;
            try
            {
                selectedItem.Delete();
                infoMsg.Append(string.Format("The Post: was deleted"));
                deletedItems.Add(selectedItem);
            }
            catch (Exception)
            {
                infoMsg.Append(string.Format("The Post can't be deleted, isn't your post or created by the app"));
            }

            if (postDeletionCompleted != null)
            {
                postDeletionCompleted(infoMsg.ToString());
            }
        }

        private void postDeletionCompletedCallback(string i_InfoMsg)
        {
            if (!string.IsNullOrEmpty(i_InfoMsg))
            {
                MessageBox.Show(i_InfoMsg, "Delete Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            deletePosts();
        }

        private void postListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(postListBox.SelectedItem != null)
            {
                Post postedEvent = postListBox.SelectedItem as Post;
                textBox1.Text = postedEvent.LikedBy.Count.ToString();
            }
        }
    }
}