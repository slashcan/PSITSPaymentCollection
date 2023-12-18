namespace Dbsys.Forms
{
    partial class Frm_Total_Applicants
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEventSales = new System.Windows.Forms.DataGridView();
            this.cbboxYrLvl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventSales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Event Applicants";
            // 
            // dgvEventSales
            // 
            this.dgvEventSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventSales.Location = new System.Drawing.Point(91, 108);
            this.dgvEventSales.Name = "dgvEventSales";
            this.dgvEventSales.Size = new System.Drawing.Size(622, 306);
            this.dgvEventSales.TabIndex = 2;
            // 
            // cbboxYrLvl
            // 
            this.cbboxYrLvl.FormattingEnabled = true;
            this.cbboxYrLvl.Location = new System.Drawing.Point(91, 75);
            this.cbboxYrLvl.Name = "cbboxYrLvl";
            this.cbboxYrLvl.Size = new System.Drawing.Size(121, 21);
            this.cbboxYrLvl.TabIndex = 4;
            this.cbboxYrLvl.SelectedIndexChanged += new System.EventHandler(this.cbboxEvent_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event Name";
            // 
            // Frm_Total_Applicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbboxYrLvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEventSales);
            this.Name = "Frm_Total_Applicants";
            this.Text = "Frm_Total_Applicants";
            this.Load += new System.EventHandler(this.Frm_Total_Applicants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEventSales;
        private System.Windows.Forms.ComboBox cbboxYrLvl;
        private System.Windows.Forms.Label label2;
    }
}