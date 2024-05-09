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
    public partial class UserControlPostsActions : UserControl
    {
        private static Action PostDataChanged;
        private static Action<string> checkLikesCompleted;
        private static Action<string> postDeletionCompleted;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<Post> m_PostsFiltered;

        public UserControlPostsActions()
        {
            InitializeComponent();
            m_PostsFiltered = new FacebookObjectCollection<Post>();
            PostDataChanged += new Action(postDataChangeCallback);
            checkLikesCompleted += new Action<string>(checkLikesCompletedCallback);
            postDeletionCompleted += new Action<string>(postDeletionCompletedCallback);
            ServiceLogin.LoginOccured += new Action(retrievePostData);
        }

        private void retrievePostData()
        {
            new Thread(retrievePostDataThread).Start();
        }

        private void retrievePostDataThread()
        {
            User loggedUser = ServiceLogin.LoggedUser;
            m_Posts = loggedUser.Posts;
            m_PostsFiltered.Clear();
            foreach (Post item in m_Posts)
            {
                m_PostsFiltered.Add(item);
            }

            if (PostDataChanged != null)
            {
                PostDataChanged();
            }
        }

        private void postDataChangeCallback()
        {
            updatePostList();
        }

        private void updatePostList()
        {
            new Thread(updatePostListThread).Start();
        }

        private void updatePostListThread()
        {
            checkedListBoxPostist.Invoke(new Action(() =>
            {
                checkedListBoxPostist.Items.Clear();
                foreach (Post post in m_PostsFiltered)
                {
                    if (post.Message != null)
                    {
                        checkedListBoxPostist.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        checkedListBoxPostist.Items.Add(post.Caption);
                    }
                    else
                    {
                        checkedListBoxPostist.Items.Add(string.Format("[{0}]", post.Type));
                    }
                }
            }));
        }

        private void filterPostsList()
        {
            new Thread(filterPostsListThread).Start();
        }

        private void filterPostsListThread()
        {
            string filterString = textBoxFilter.Text;
            if (!string.IsNullOrEmpty(filterString))
            {
                FacebookObjectCollection<Post> newFilterCollection = new FacebookObjectCollection<Post>();
                foreach (Post item in m_PostsFiltered)
                {
                    if (item.Message != null)
                    {
                        if (item.Message.Contains(filterString))
                        {
                            newFilterCollection.Add(item);
                        }
                    }
                    else if (item.Caption != null)
                    {
                        if (item.Caption.Contains(filterString))
                        {
                            newFilterCollection.Add(item);
                        }
                    }
                }

                m_PostsFiltered.Clear();
                foreach (Post item in newFilterCollection)
                {
                    m_PostsFiltered.Add(item);
                }

                if (PostDataChanged != null)
                {
                    PostDataChanged();
                }
            }
        }
        
        private void clearFilterPosts()
        {
            new Thread(clearFilterPostsThread).Start();
        }

        private void clearFilterPostsThread()
        {
            m_PostsFiltered.Clear();
            foreach (Post item in m_Posts)
            {
                m_PostsFiltered.Add(item);
            }

            textBoxFilter.Invoke(new Action(() => { textBoxFilter.Text = string.Empty; }));

            if (PostDataChanged != null)
            {
                PostDataChanged();
            }
        }

        private void checkLikesPosts()
        {
            new Thread(checkLikesPostsThread).Start();
        }

        private void checkLikesPostsThread()
        {
            StringBuilder infoMsg = new StringBuilder();
            foreach (Post post in m_PostsFiltered)
            {
                if (checkedListBoxPostist.CheckedItems.Contains(post.Message))
                {
                    infoMsg.Append(string.Format("Post: {0}, Has likes: {1}{2}", post.Message, post.LikedBy.Count.ToString(), System.Environment.NewLine));
                }
            }

            if (checkLikesCompleted != null && infoMsg.Length > 0)
            {
                checkLikesCompleted(infoMsg.ToString());
            }
        }

        private void checkLikesCompletedCallback(string i_Msg)
        {
            MessageBox.Show(i_Msg, "Post Likes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FacebookObjectCollection<Post> newPostsList;

            foreach (Post post in m_PostsFiltered)
            {
                if (checkedListBoxPostist.CheckedItems.Contains(post.Message))
                {
                    try
                    {
                        post.Delete();
                        infoMsg.Append(string.Format("Post: {0}, was deleted {1}", post.Message, System.Environment.NewLine));
                        deletedItems.Add(post);
                    }
                    catch (Exception)
                    {
                        infoMsg.Append(string.Format("Post: {0}, can't be deleted, isn't your post{1}", post.Message, System.Environment.NewLine));
                    }
                }
            }

            if (deletedItems.Count > 0)
            {
                newPostsList = new FacebookObjectCollection<Post>();
                foreach (Post post in m_Posts)
                {
                    newPostsList.Add(post);
                }

                foreach (Post post in deletedItems)
                {
                    newPostsList.Remove(post);
                }

                m_Posts.Clear();
                m_PostsFiltered.Clear();

                foreach (Post post in newPostsList)
                {
                    m_Posts.Add(post);
                    m_PostsFiltered.Add(post);
                }

                if (textBoxFilter.Text.Length > 0)
                {
                    filterPostsList();
                }
                else
                {
                    if (PostDataChanged != null)
                    {
                        PostDataChanged();
                    }
                }
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

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filterPostsList();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFilterPosts();
        }

        private void buttonLikeCount_Click(object sender, EventArgs e)
        {
            checkLikesPosts();
        }

        private void buttonDeletePost_Click(object sender, EventArgs e)
        {
            deletePosts();
        }
    }
}
