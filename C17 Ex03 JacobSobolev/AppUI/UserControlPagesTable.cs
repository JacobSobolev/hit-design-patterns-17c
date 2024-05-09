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

namespace AppUI
{
    public partial class UserControlPagesTable : SmartUserControl
    {
        private readonly string[] r_ColumnsString = { "Name", "Description", "Talking About", "Phone", "URL" };
        private int m_SortColumn;
        private DataTable m_DataTablePages;
        private DataView m_DataViewPages;
        private ListViewItemComparer m_sortingStrategy;

        public UserControlPagesTable() : base()
        {
            InitializeComponent();
            m_SortColumn = -1;
            initListViewAndDataTableAndView();
            m_sortingStrategy = new ListViewItemComparer();
            listViewPages.ListViewItemSorter = m_sortingStrategy;
        }

        protected override void AddCallbackToEvents()
        {
            AppService.Instance.AddToEventPagesDataChanged(updateListViewPages);
        }

        private void initListViewAndDataTableAndView()
        {
            listViewPages.View = View.Details;
            listViewPages.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            m_DataTablePages = new DataTable();

            foreach (string columnStr in r_ColumnsString)
            {
                listViewPages.Columns.Add(columnStr, 130);
                m_DataTablePages.Columns.Add(columnStr);
            }
        }

        private void updateListViewPages(FacebookObjectCollection<Page> i_UserPages)
        {
            Thread threadPopulateDataTable = new Thread(() => populateDataTable(i_UserPages));
            threadPopulateDataTable.Start();
            threadPopulateDataTable.Join();
            m_DataViewPages = new DataView(m_DataTablePages);
            Thread threadPopulateListView = new Thread(() => populateListView(m_DataViewPages));
            threadPopulateListView.Start();
        }

        private void populateListView(DataView i_DataView)
        {
            listViewPages.Invoke(new Action(() =>
            {
                listViewPages.Items.Clear();
                foreach (DataRow row in i_DataView.ToTable().Rows)
                {
                    listViewPages.Items.Add(new ListViewItem(new string[] 
                    {
                        row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString()
                    }));
                }
            }));
        }

        private void populateDataTable(FacebookObjectCollection<Page> i_UserPages)
        {
            foreach (Page page in i_UserPages)
            {
                m_DataTablePages.Rows.Add(page.Name, page.Description, page.TalkingAboutCount.ToString(), page.Phone, page.URL);
            }
        }
        
        private void filterDataViewBasedOnInputText(object sender, EventArgs e)
        {
            m_DataViewPages.RowFilter = string.Format("Name LIke '%{0}%'", textBoxFilter.Text);
            Thread thread = new Thread(() => populateListView(m_DataViewPages));
            thread.Start();
        }

        private void listViewPages_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != m_SortColumn)
            {
                m_SortColumn = e.Column;
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

            m_sortingStrategy.SortOrder = listViewPages.Sorting;
            m_sortingStrategy.ColomnNum = e.Column;
            listViewPages.Sort();
        }
    }
}
