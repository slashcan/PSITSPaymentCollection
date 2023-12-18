namespace Dbsys.Forms
{
    partial class Frm_Per_Yr_LvL_Event_Applicant
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
            this.dgvYearLevel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYearLevel)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Year Level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Event Applicants";
            // 
            // dgvYearLevel
            // 
            this.dgvYearLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYearLevel.Location = new System.Drawing.Point(91, 114);
            this.dgvYearLevel.Name = "dgvYearLevel";
            this.dgvYearLevel.Size = new System.Drawing.Size(622, 306);
            this.dgvYearLevel.TabIndex = 5;
            // 
            // Frm_Per_Yr_LvL_Event_Applicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbboxYrLvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvYearLevel);
            this.Name = "Frm_Per_Yr_LvL_Event_Applicant";
            this.Text = "Frm_Per_Yr_LvL_Event_Applicant";
            this.Load += new System.EventHandler(this.Frm_Per_Yr_LvL_Event_Applicant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYearLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbboxYrLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYearLevel;
    }
}