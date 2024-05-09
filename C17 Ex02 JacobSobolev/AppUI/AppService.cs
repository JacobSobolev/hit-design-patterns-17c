using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using AppLogic;

namespace AppUI
{
    public class AppService
    {
        private static readonly object sr_LockObject = new object();
        private static AppService s_Instance = null;
        private AppSettings m_Settings;
        private LoginService m_ServiceLogin;
        private DataService m_DataService;

        public static AppService Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_LockObject)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppService();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public bool AppSettingsRemmberMe
        {
            get { return m_Settings.RemmberMe; }
            set { m_Settings.RemmberMe = value; }
        }

        private AppService()
        {
            m_Settings = AppSettings.LoadOrCreate();
            m_ServiceLogin = new LoginService(m_Settings.LastAccessToken);
            AddToEventLoginOccured(onLoginCallback);
        }

        public void AddToEventLoginOccured(Action i_Callback)
        {
            m_ServiceLogin.LoginOccured += i_Callback;
        }

        public void AddToEventUserNameChanged(Action<string> i_Callback)
        {
            DataService.UserNameChanged += i_Callback;
        }

        public void AddToEventProfilePictureURLChanged(Action<string> i_Callback)
        {
            DataService.ProfilePictureURLChanged += i_Callback;
        }

        public void AddToEventPostDataChanged(Action<FacebookObjectCollection<Post>> i_Callback)
        {
            DataService.PostDataChanged += i_Callback;
        }

        public void AddToEventFriendsDataChanged(Action<FacebookObjectCollection<User>> i_Callback)
        {
            DataService.FriendsDataChanged += i_Callback;
        }

        public void AddToEventPagesDataChanged(Action<FacebookObjectCollection<Page>> i_Callback)
        {
            DataService.PagesDataChanged += i_Callback;
        }

        public void AppSettingsSave()
        {
            m_Settings.LastAccessToken = m_ServiceLogin.LastToken;
            m_Settings.Save();
        }

        public void AppSettingsReset()
        {
            m_Settings.LastAccessToken = null;
            m_Settings.RemmberMe = false;
        }

        public void AppLogin()
        {
            m_ServiceLogin.Login();
        }

        public void AppConnectWithLastToken()
        {
            m_ServiceLogin.ConnectWithLastToken();
        }

        public void AppLogout()
        {
            AppSettingsReset();
            m_ServiceLogin.Logout();
        }

        private void onLoginCallback()
        {
            m_DataService = new DataService(m_ServiceLogin.LoggedUser);
            m_DataService.RetrieveAllData();
        }

        public void PostStatus(string i_StrPost)
        {
            if (m_ServiceLogin.LoggedUser == null)
            {
                throw new Exception("Trying To Make Post But The User Is Null");
            }

            if (string.IsNullOrEmpty(i_StrPost))
            {
                throw new Exception("Trying To Make Post With Empty Or Null String");
            }

            m_ServiceLogin.LoggedUser.PostStatus(i_StrPost);
        }
    }
}