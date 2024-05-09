using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppUI
{
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        public void AddCallbackToEvents()
        {
            AppService.Instance.AddToEventLoginOccured(UserLogedInCallback);
            VisibleChanged += userControlLoginVisableChanged;
        }

        private void checkBoxRemmberMe_CheckedChanged(object sender, EventArgs e)
        {
            AppService.Instance.AppSettingsRemmberMe = checkBoxRemmberMe.Checked;
        }

        private void picBoxFbLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AppService.Instance.AppLogin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBoxFbLogin_MouseEnter(object sender, EventArgs e)
        {
            picBoxFbLogin.Image = Properties.Resources.fbLoginHover;
        }

        private void picBoxFbLogin_MouseLeave(object sender, EventArgs e)
        {
            picBoxFbLogin.Image = Properties.Resources.fbLoginNormal;
        }

        private void UserControlLogin_SizeChanged(object sender, EventArgs e)
        {
            picBoxFbLogin.Left = (this.ClientSize.Width - picBoxFbLogin.Width) / 2;
            picBoxFbLogin.Top = (this.ClientSize.Height - picBoxFbLogin.Height) / 2;
            checkBoxRemmberMe.Left = (this.ClientSize.Width - checkBoxRemmberMe.Width) / 2;
            checkBoxRemmberMe.Top = ((this.ClientSize.Height - checkBoxRemmberMe.Height) / 2) + 100;
        }

        private void UserLogedInCallback()
        {
            this.Visible = false;
        }

        private void userControlLoginVisableChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                if (AppService.Instance.AppSettingsRemmberMe)
                {
                    try
                    {
                        AppService.Instance.AppConnectWithLastToken();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
