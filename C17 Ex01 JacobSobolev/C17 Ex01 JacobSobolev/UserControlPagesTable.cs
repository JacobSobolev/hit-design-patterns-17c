using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace C17_Ex01
{
    public partial class UserControlPagesTable : UserControl
    {
        private static Action PagesDataChanged;
        private int sortColumn;
        private FacebookObjectCollection<Page> m_Pages;
        private FacebookObjectCollection<Page> m_PagesFiltered;

        public UserControlPagesTable()
        {
            InitializeComponent();
            sortColumn = -1;
            m_PagesFiltered = new FacebookObjectCollection<Page>();
            PagesDataChanged += new Action(PagesChangedCallback);
            ServiceLogin.LoginOccured += new Action(retrivePages);
        }

        private void retrivePages()
        {
            new Thread(retrivePagesThread).Start();
        }

        private void retrivePagesThread()
        {
            User loggedUser = ServiceLogin.LoggedUser;
            m_Pages = loggedUser.LikedPages;
            m_PagesFiltered.Clear();
            foreach (Page page in m_Pages)
            {
                m_PagesFiltered.Add(page);
            }

            if (PagesDataChanged != null)
            {
                PagesDataChanged();
            }
        }

        private void PagesChangedCallback()
        {
            updateListViewPages();
        }

        private void updateListViewPages()
        {
            new Thread(updateListViewPagesThread).Start();
        }

        private void updateListViewPagesThread()
        {           
            listViewPages.Invoke(new Action(() => 
            {
                listViewPages.Items.Clear();
                foreach (Page page in m_PagesFiltered)
                {
                    ListViewItem item1 = new ListViewItem(page.Name);
                    item1.SubItems.Add(page.Description);
                    item1.SubItems.Add(page.TalkingAboutCount.ToString());
                    item1.SubItems.Add(page.Phone);
                    item1.SubItems.Add(page.URL);
                    listViewPages.Items.Add(item1);
                }
            }));
        }

        private void filterPages()
        {
            if (!string.IsNullOrEmpty(textBoxFilter.Text))
            {
                new Thread(filterPagesThread).Start();
            }
        }

        private void filterPagesThread()
        {
            listViewPages.Invoke(new Action(() => 
            {
                string filterStr = textBoxFilter.Text;
                FacebookObjectCollection<Page> newFilteredPages = new FacebookObjectCollection<Page>();
                foreach (Page page in m_PagesFiltered)
                {
                    if (page.Name.Contains(filterStr) || page.URL.Contains(filterStr))
                    {
                        newFilteredPages.Add(page);
                    }
                }

                m_PagesFiltered.Clear();
                foreach (Page page in newFilteredPages)
                {
                    m_PagesFiltered.Add(page);
                }

                if (PagesDataChanged != null)
                {
                    PagesDataChanged();
                }
            }));
        }

        private void filterPagesClear()
        {
            new Thread(filterPagesClearThread).Start();
        }

        private void filterPagesClearThread()
        {
            m_PagesFiltered.Clear();
            foreach (Page page in m_Pages)
            {
                m_PagesFiltered.Add(page);
            }

            if(PagesDataChanged != null)
            {
                PagesDataChanged();
            }
        }

        private void listViewPages_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                listViewPages.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (listViewPages.Sorting == SortOrder.Ascending)
                {
                    listViewPages.Sorting = SortOrder.Descending;
                }
                else
                {
                    listViewPages.Sorting = SortOrder.Ascending;
                }
            }

            listViewPages.Sort();
            this.listViewPages.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewPages.Sorting);
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            filterPages();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            filterPagesClear();
        }
    }
}
