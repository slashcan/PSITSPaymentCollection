namespace Dbsys.Forms
{
    partial class Frm_Student_Status
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusDgv = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.customReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalSalesForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resiteredStudentsForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.statusDgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusDgv
            // 
            this.statusDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDgv.Location = new System.Drawing.Point(21, 73);
            this.statusDgv.Name = "statusDgv";
            this.statusDgv.Size = new System.Drawing.Size(720, 378);
            this.statusDgv.TabIndex = 0;
            this.statusDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(19, 41);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(69, 38);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(174, 20);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // customReportsToolStripMenuItem
            // 
            this.customReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalSalesForToolStripMenuItem,
            this.studentSearchToolStripMenuItem,
            this.resiteredStudentsForToolStripMenuItem});
            this.customReportsToolStripMenuItem.Name = "customReportsToolStripMenuItem";
            this.customReportsToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.customReportsToolStripMenuItem.Text = "Custom Reports";
            // 
            // totalSalesForToolStripMenuItem
            // 
            this.totalSalesForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.totalSalesForToolStripMenuItem.Name = "totalSalesForToolStripMenuItem";
            this.totalSalesForToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.totalSalesForToolStripMenuItem.Text = "Total Sales for..";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventsToolStripMenuItem.Text = "Events";
            this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // studentSearchToolStripMenuItem
            // 
            this.studentSearchToolStripMenuItem.Name = "studentSearchToolStripMenuItem";
            this.studentSearchToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.studentSearchToolStripMenuItem.Text = "Student Search";
            // 
            // resiteredStudentsForToolStripMenuItem
            // 
            this.resiteredStudentsForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem1});
            this.resiteredStudentsForToolStripMenuItem.Name = "resiteredStudentsForToolStripMenuItem";
            this.resiteredStudentsForToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.resiteredStudentsForToolStripMenuItem.Text = "Resitered Students for..";
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eventsToolStripMenuItem1.Text = "Events";
            // 
            // Frm_Student_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 501);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.statusDgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Student_Status";
            this.Text = "Frm_Student_Status";
            this.Load += new System.EventHandler(this.Frm_Student_Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statusDgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statusDgv;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem customReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalSalesForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resiteredStudentsForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
    }
}