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

namespace C17_Ex01
{
    public partial class UserControlBasicActions : UserControl
    {
        private static Action PostDataChanged;
        private static Action FriendsDataChanged;
        private static Action postActionCompleted;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<User> m_Friends;

        public UserControlBasicActions()
        {
            InitializeComponent();
            PostDataChanged += new Action(postDataChangedCallback);
            FriendsDataChanged += new Action(friendsDataChangedCallback);
            postActionCompleted += new Action(postActionCompletedCallback);
            ServiceLogin.LoginOccured += new Action(retrieveAllData);
        }

        private void retrieveAllData()
        {
            retrievePostData();
            retrieveFriendsData();
        }

        private void retrievePostData()
        {
            new Thread(retrievePostDataThread).Start();
        }

        private void retrievePostDataThread()
        {
            User loggedUser = ServiceLogin.LoggedUser;
            m_Posts = loggedUser.Posts;
            if (PostDataChanged != null)
            {
                PostDataChanged();
            }
        }

        private void postDataChangedCallback()
        {
            updatePostList();
        }

        private void retrieveFriendsData()
        {
            new Thread(retrieveFriendsDataThread).Start();
        }

        private void retrieveFriendsDataThread()
        {
            User loggedUser = ServiceLogin.LoggedUser;
            m_Friends = loggedUser.Friends;
            if (FriendsDataChanged != null)
            {
                FriendsDataChanged();
            }
        }

        private void friendsDataChangedCallback()
        {
            updateFriendsList();
        }

        private void updatePostList()
        {
            new Thread(updatePostListThread).Start();
        }

        private void updatePostListThread()
        {
            listBoxPost.Invoke(new Action(() =>
            {
                listBoxPost.Items.Clear();
                foreach (Post post in m_Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPost.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPost.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxPost.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }));
        }

        private void updateFriendsList()
        {
            new Thread(updateFriendsListThread).Start();
        }

        private void updateFriendsListThread()
        {
            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.Items.Clear();
                listBoxFriends.DisplayMember = "Name";
                foreach (User friend in m_Friends)
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
            Status postedStatus = ServiceLogin.LoggedUser.PostStatus(textBoxPost.Text);
            if (postActionCompleted != null)
            {
                postActionCompleted();
            }
        }

        private void postActionCompletedCallback()
        {
            MessageBox.Show("The post posted in successfully");
            retrievePostData();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            makePost();
        }
    }
}