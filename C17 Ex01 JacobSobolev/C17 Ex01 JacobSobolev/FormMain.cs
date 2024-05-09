using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using C17_Ex01;

namespace C17_Ex01_LiatLevi_203505953
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            userControlMain.VisibleChanged += new System.EventHandler(this.userControlVisableChanged);
            userControlLogin.VisibleChanged += new System.EventHandler(this.userControlVisableChanged);
        }

        private void userControlVisableChanged(object sender, EventArgs e)
        {
            if (sender is UserControlLogin && userControlLogin.Visible == false)
            {
                userControlMain.Visible = true;
            }
            else if (sender is UserControlMain && userControlLogin.Visible == false)
            {
                userControlLogin.Visible = true;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSettings.Instance.Save();
        }
    }
}
