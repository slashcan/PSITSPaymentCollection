namespace Dbsys.Forms
{
    partial class Frm_Total_Sales_Events
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
            this.dgvEventSales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEventSales
            // 
            this.dgvEventSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventSales.Location = new System.Drawing.Point(74, 74);
            this.dgvEventSales.Name = "dgvEventSales";
            this.dgvEventSales.Size = new System.Drawing.Size(622, 306);
            this.dgvEventSales.TabIndex = 0;
            this.dgvEventSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Sales For Events";
            // 
            // Frm_Total_Sales_Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventSales);
            this.Name = "Frm_Total_Sales_Events";
            this.Text = "Frm_Total_Sales_Events";
            this.Load += new System.EventHandler(this.Frm_Total_Sales_Events_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEventSales;
        private System.Windows.Forms.Label label1;
    }
}