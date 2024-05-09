using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace AppLogic
{
    public class LoginService
    {
        public event Action LoginOccured;

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

        public User LoggedUser { get; private set; }

        public string LastToken { get; private set; }

        public LoginService(string i_LastToken)
        {
            LastToken = i_LastToken;
        }

        public void Login()
        {
            LoginResult result = FacebookService.Login(k_AppID, r_LoginParams);

            if (!result.FacebookOAuthResult.IsSuccess)
            {
                throw new Exception(result.ErrorMessage);
            }

            LoggedUser = result.LoggedInUser;

            LastToken = result.AccessToken;

            if (LoginOccured != null)
            {
                LoginOccured();
            }
        }

        public void ConnectWithLastToken()
        {
            if (!string.IsNullOrEmpty(LastToken))
            {
                LoginResult result = FacebookService.Connect(LastToken);
                LoggedUser = result.LoggedInUser;

                if (LoginOccured != null)
                {
                    LoginOccured();
                }
            }
        }

        public void Logout()
        {
            LoggedUser = null;
            FacebookService.Logout(null);          
        }
    }
}
