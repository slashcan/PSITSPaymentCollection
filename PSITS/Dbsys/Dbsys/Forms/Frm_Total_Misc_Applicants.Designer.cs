namespace Dbsys.Forms
{
    partial class Frm_Total_Misc_Applicants
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
            this.cbboxYrLvl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMiscSales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiscSales)).BeginInit();
            this.SuspendLayout();
            // 
            // cbboxYrLvl
            // 
            this.cbboxYrLvl.FormattingEnabled = true;
            this.cbboxYrLvl.Location = new System.Drawing.Point(91, 81);
            this.cbboxYrLvl.Name = "cbboxYrLvl";
            this.cbboxYrLvl.Size = new System.Drawing.Size(121, 21);
            this.cbboxYrLvl.TabIndex = 8;
            this.cbboxYrLvl.SelectedIndexChanged += new System.EventHandler(this.cbboxYrLvl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Misc Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Buyers";
            // 
            // dgvMiscSales
            // 
            this.dgvMiscSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiscSales.Location = new System.Drawing.Point(91, 114);
            this.dgvMiscSales.Name = "dgvMiscSales";
            this.dgvMiscSales.Size = new System.Drawing.Size(622, 306);
            this.dgvMiscSales.TabIndex = 5;
            // 
            // Frm_Total_Misc_Applicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbboxYrLvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMiscSales);
            this.Name = "Frm_Total_Misc_Applicants";
            this.Text = "Frm_Total_Misc_Applicants";
            this.Load += new System.EventHandler(this.Frm_Total_Misc_Applicants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiscSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbboxYrLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMiscSales;
    }
}