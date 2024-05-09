using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public class DataService
    {
        public static event Action<string> UserNameChanged;

        public static event Action<string> ProfilePictureURLChanged;

        public static event Action<FacebookObjectCollection<Post>> PostDataChanged;

        public static event Action<FacebookObjectCollection<User>> FriendsDataChanged;

        public static event Action<FacebookObjectCollection<Page>> PagesDataChanged;

        private User m_CurrentUser;
        private string m_UserName;
        private string m_ProfilePicureURL;
        private FacebookObjectCollection<Post> m_Posts;
        private FacebookObjectCollection<User> m_Friends;
        private FacebookObjectCollection<Page> m_Pages;

        public DataService(User i_CurrentUser)
        {
            m_CurrentUser = i_CurrentUser;
        }

        public void RetrieveAllData()
        {
            new Thread(retriveUserName).Start();
            new Thread(retriveProfilePicureURL).Start();
            new Thread(retrievePostData).Start();
            new Thread(retrieveFriendsData).Start();
            new Thread(retrivePagesData).Start();
        }

        private void retriveUserName()
        {
            m_UserName = string.Format("{0} {1}", m_CurrentUser.FirstName, m_CurrentUser.LastName);

            if(UserNameChanged != null)
            {
                UserNameChanged(m_UserName);
            }
        }

        private void retriveProfilePicureURL()
        {
            m_ProfilePicureURL = m_CurrentUser.PictureNormalURL;

            if (ProfilePictureURLChanged != null)
            {
                ProfilePictureURLChanged(m_ProfilePicureURL);
            }
        }

        private void retrievePostData()
        {
            m_Posts = m_CurrentUser.Posts;
            if (PostDataChanged != null)
            {
                PostDataChanged(m_Posts);
            }
        }

        private void retrieveFriendsData()
        {
            m_Friends = m_CurrentUser.Friends;
            if (FriendsDataChanged != null)
            {
                FriendsDataChanged(m_Friends);
            }
        }

        private void retrivePagesData()
        {
            m_Pages = m_CurrentUser.LikedPages;

            if (PagesDataChanged != null)
            {
                PagesDataChanged(m_Pages);
            }
        }
    }
}
