using System;
using System.Collections;
using System.Windows.Forms;

namespace AppUI
{
    public class ListViewItemComparer : IComparer
    {
        private int n_ColNum;
        private SortOrder m_SortOrder;

        public ListViewItemComparer()
        {
            n_ColNum = 0;
            m_SortOrder = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            n_ColNum = column;
            this.m_SortOrder = order;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = string.Compare(((ListViewItem)x).SubItems[n_ColNum].Text, ((ListViewItem)y).SubItems[n_ColNum].Text);
            if (m_SortOrder == SortOrder.Descending)
            {
                returnVal *= -1;
            }
                
            return returnVal;
        }
    }
}
