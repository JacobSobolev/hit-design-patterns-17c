namespace AppUI
{
    public partial class UserControlPagesTable
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPageList = new System.Windows.Forms.Label();
            this.listViewPages = new System.Windows.Forms.ListView();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPageList
            // 
            this.labelPageList.AutoSize = true;
            this.labelPageList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelPageList.Location = new System.Drawing.Point(13, 41);
            this.labelPageList.Name = "labelPageList";
            this.labelPageList.Size = new System.Drawing.Size(91, 25);
            this.labelPageList.TabIndex = 0;
            this.labelPageList.Text = "Page List";
            // 
            // listViewPages
            // 
            this.listViewPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPages.GridLines = true;
            this.listViewPages.HoverSelection = true;
            this.listViewPages.Location = new System.Drawing.Point(15, 66);
            this.listViewPages.Margin = new System.Windows.Forms.Padding(3, 0, 15, 15);
            this.listViewPages.Name = "listViewPages";
            this.listViewPages.Size = new System.Drawing.Size(725, 415);
            this.listViewPages.TabIndex = 1;
            this.listViewPages.UseCompatibleStateImageBehavior = false;
            this.listViewPages.View = System.Windows.Forms.View.Details;
            this.listViewPages.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewPages_ColumnClick);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(69, 15);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(15);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(671, 20);
            this.textBoxFilter.TabIndex = 4;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.filterDataViewBasedOnInputText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter";
            // 
            // UserControlPagesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.listViewPages);
            this.Controls.Add(this.labelPageList);
            this.Name = "UserControlPagesTable";
            this.Size = new System.Drawing.Size(755, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPageList;
        private System.Windows.Forms.ListView listViewPages;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label1;
    }
}
