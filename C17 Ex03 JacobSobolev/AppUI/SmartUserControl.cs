using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppUI
{
    public abstract class SmartUserControl : UserControl
    {
        public SmartUserControl()
        {
            AddCallbackToEvents();
        }

        protected abstract void AddCallbackToEvents();
    }
}
