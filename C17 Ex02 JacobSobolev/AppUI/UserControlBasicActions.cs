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
    public partial class UserControlBasicActions : UserControl
    {
        private event Action postActionCompleted;

        public UserControlBasicActions()
        {
            InitializeComponent();
            postActionCompleted += postActionCompletedCallback;
        }

        public void AddCallbackToEvents()
        {
            AppService.Instance.AddToEventPostDataChanged(updatePostList);
            AppService.Instance.AddToEventFriendsDataChanged(updateFriendsList);
        }

        private void updatePostList(FacebookObjectCollection<Post> i_UserPosts)
        {
            Thread thread = new Thread(() => updatePostListThread(i_UserPosts));
            thread.Start();
        }

        private void updatePostListThread(FacebookObjectCollection<Post> i_UserPosts)
        {
            listBoxPost.Invoke(new Action(() =>
            {
                listBoxPost.Items.Clear();
                foreach (Post post in i_UserPosts)
                {
                    string strToAdd;
                    if (post.Message != null)
                    {
                        strToAdd = post.Message;
                    }
                    else if (post.Caption != null)
                    {
                        strToAdd = post.Caption;
                    }
                    else if (post.Place != null)
                    {
                        strToAdd = string.Format("CheckIn At: {0}", post.Place.Name);
                    }
                    else if (post.PictureURL != null)
                    {
                        strToAdd = string.Format("Post Of : {0}", post.Name);
                    }
                    else
                    {
                        strToAdd = string.Format("[{0}]", post.Type);
                    }

                    listBoxPost.Items.Add(strToAdd);
                }
            }));
        }

        private void updateFriendsList(FacebookObjectCollection<User> i_UserFriends)
        {
            Thread thread = new Thread(() => updateFriendsListThread(i_UserFriends));
            thread.Start();
        }

        private void updateFriendsListThread(FacebookObjectCollection<User> i_UserFriends)
        {
            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
                foreach (User friend in i_UserFriends)
                {
                    listBoxFriends.Items.Add(friend);
                }
            }));
        }

        private void makePost()
        {
            new Thread(makePostThread).Start();
        }

        private void makePostThread()
        {
            if (textBoxPost.Text.Length > 0)
            {
                AppService.Instance.PostStatus(textBoxPost.Text);
                if (postActionCompleted != null)
                {
                    postActionCompleted();
                }
            }
        }

        private void postActionCompletedCallback()
        {
            MessageBox.Show("The post posted in successfully");
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            makePost();
        }

        private void textBoxPost_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPost.Text.Length > 0)
            {
                buttonPost.Enabled = true;
            }
            else
            {
                buttonPost.Enabled = false;
            }
        }
    }
}