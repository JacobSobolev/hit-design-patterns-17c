using System;
using System.Collections;
using System.Windows.Forms;

namespace AppUI
{
    public class ListViewItemComparer : IComparer
    {
        public int ColomnNum { get; set; }

        public SortOrder SortOrder { get; set; }

        public ListViewItemComparer()
        {
            ColomnNum = 0;
            SortOrder = SortOrder.Ascending;
        }

        public int Compare(object x, object y)
        {
            int returnVal = -1;
            int xValue = 0;
            int yValue = 0;
            if (int.TryParse(((ListViewItem)x).SubItems[ColomnNum].Text, out xValue) && int.TryParse(((ListViewItem)y).SubItems[ColomnNum].Text, out yValue))
            {
                returnVal = xValue - yValue;
            }
            else
            {
                returnVal = string.Compare(((ListViewItem)x).SubItems[ColomnNum].Text, ((ListViewItem)y).SubItems[ColomnNum].Text);
            }

            if (SortOrder == SortOrder.Descending)
            {
                returnVal *= -1;
            }
                
            return returnVal;
        }
    }
}
