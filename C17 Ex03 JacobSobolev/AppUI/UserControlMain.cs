using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;

namespace AppUI
{
    public partial class UserControlMain : SmartUserControl
    {
        public UserControlMain() : base()
        {
            InitializeComponent();          
        }

        protected override void AddCallbackToEvents()
        {
            AppService.Instance.AddToEventUserNameChanged(updateUserName);
            AppService.Instance.AddToEventProfilePictureURLChanged(updateProfilePicture);
        }

        private void updateUserName(string i_UserName)
        {
            Thread thread = new Thread(() => updateUserNameThread(i_UserName));
            thread.Start();
        }

        private void updateUserNameThread(string i_UserName)
        {
            labelUserName.Invoke(new Action(() => { labelUserName.Text = i_UserName; }));
        }

        public void updateProfilePicture(string i_PictureURL)
        {
            Thread thread = new Thread(() => updateProfilePictureThread(i_PictureURL));
            thread.Start();
        }

        private void updateProfilePictureThread(string i_PictureURL)
        {
            picBoxProfilePicture.Invoke(new Action(() => { picBoxProfilePicture.Load(i_PictureURL); }));
        }

        private void picBoxLogout_Click(object sender, EventArgs e)
        {
            AppService.Instance.AppLogout();
            this.Visible = false;
        }

        private void picBoxLogout_MouseEnter(object sender, EventArgs e)
        {
            picBoxLogout.BackColor = Color.Transparent;
            picBoxLogout.Image = Properties.Resources.fbLogoutHover;
        }

        private void picBoxLogout_MouseLeave(object sender, EventArgs e)
        {
            picBoxLogout.BackColor = Color.Transparent;
            picBoxLogout.Image = Properties.Resources.fbLogoutNormal;
        }
    }
}