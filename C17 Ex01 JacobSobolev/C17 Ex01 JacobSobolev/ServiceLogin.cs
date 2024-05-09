using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C17_Ex01
{
    public static class ServiceLogin
    {
        public static Action LoginOccured;
        public static User LoggedUser;
        private const string k_AppID = "1507284912663837";
        private static readonly string[] r_LoginParams =
            { 
            "publish_actions",
            "user_likes",
            "user_photos",
            "user_posts",
            "user_website",
            "pages_messaging",
            "publish_pages",
            "pages_show_list",
            "pages_manage_cta",
            "pages_messaging_subscriptions",
            "manage_pages"
        };

        public static void Login()
        {
            LoginResult result = FacebookService.Login(k_AppID, r_LoginParams);

            if (!result.FacebookOAuthResult.IsSuccess)
            {
                throw new Exception(result.ErrorMessage);
            }

            LoggedUser = result.LoggedInUser;
            AppSettings.Instance.LastAccessToken = result.AccessToken;

            if (LoginOccured != null)
            {
                LoginOccured();
            }
        }

        public static void ConnectWithLastToken()
        {
            if (!string.IsNullOrEmpty(AppSettings.Instance.LastAccessToken))
            {
                LoginResult result = FacebookService.Connect(AppSettings.Instance.LastAccessToken);
                LoggedUser = result.LoggedInUser;

                if (LoginOccured != null)
                {
                    LoginOccured();
                }
            }
        }

        public static void Logout()
        {
            LoggedUser = null;
            AppSettings.Instance.LastAccessToken = null;
            AppSettings.Instance.RemmberMe = false;
            FacebookService.Logout(null);
        }
    }
}
