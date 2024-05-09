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

namespace C17_Ex01
{
    public partial class UserControlMain : UserControl
    {
        public UserControlMain()
        {
            InitializeComponent();
            ServiceLogin.LoginOccured += new Action(updateUiComponents);
        }

        private void updateUiComponents()
        {
            updateProfilePicture();
            updateUserName();
        }

        public void updateProfilePicture()
        {
            new Thread(updateProfilePictureThread).Start();
        }

        private void updateProfilePictureThread()
        {
            picBoxProfilePicture.Invoke(new Action(() => { picBoxProfilePicture.LoadAsync(ServiceLogin.LoggedUser.PictureLargeURL); }));
        }

        private void updateUserName()
        {
            new Thread(updateUserNameThread).Start();
        }

        private void updateUserNameThread()
        {
            labelUserName.Invoke(new Action(() => { labelUserName.Text = ServiceLogin.LoggedUser.Name; }));
        }

        private void picBoxLogout_Click(object sender, EventArgs e)
        {
            ServiceLogin.Logout();
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