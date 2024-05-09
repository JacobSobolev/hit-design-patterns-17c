using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace C17_Ex01
{
    public partial class UserControlLogin : UserControl
    {
        public UserControlLogin()
        {
            InitializeComponent();
        }

        private void picBoxFbLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceLogin.Login();
                if (ServiceLogin.LoggedUser != null)
                {
                    this.Visible = false;
                }
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

        private void ConnectToFacebook_SizeChanged(object sender, EventArgs e)
        {
            picBoxFbLogin.Left = (this.ClientSize.Width - picBoxFbLogin.Width) / 2;
            picBoxFbLogin.Top = (this.ClientSize.Height - picBoxFbLogin.Height) / 2;
            checkBoxRemmberMe.Left = (this.ClientSize.Width - checkBoxRemmberMe.Width) / 2;
            checkBoxRemmberMe.Top = ((this.ClientSize.Height - checkBoxRemmberMe.Height) / 2) + 100;
        }

        private void checkBoxRemmberMe_CheckedChanged(object sender, EventArgs e)
        {
            AppSettings.Instance.RemmberMe = checkBoxRemmberMe.Checked;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (Visible)
            {
                if (AppSettings.Instance.RemmberMe)
                {
                    try
                    {
                        ServiceLogin.ConnectWithLastToken();
                        if (ServiceLogin.LoggedUser != null)
                        {
                            this.Visible = false;
                        }
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
