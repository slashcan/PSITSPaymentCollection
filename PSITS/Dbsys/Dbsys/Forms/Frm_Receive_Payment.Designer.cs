namespace Dbsys.Forms
{
    partial class Frm_Receive_Payment
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbboxEvent = new System.Windows.Forms.ComboBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.cbboxYrLvl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(131, 73);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(158, 20);
            this.txtuserName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number";
            // 
            // txtidNumber
            // 
            this.txtidNumber.Location = new System.Drawing.Point(131, 113);
            this.txtidNumber.Name = "txtidNumber";
            this.txtidNumber.Size = new System.Drawing.Size(158, 20);
            this.txtidNumber.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Payment For";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(131, 224);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // cbboxEvent
            // 
            this.cbboxEvent.FormattingEnabled = true;
            this.cbboxEvent.Location = new System.Drawing.Point(131, 188);
            this.cbboxEvent.Name = "cbboxEvent";
            this.cbboxEvent.Size = new System.Drawing.Size(158, 21);
            this.cbboxEvent.TabIndex = 4;
            this.cbboxEvent.SelectedIndexChanged += new System.EventHandler(this.cbboxEvent_SelectedIndexChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(117, 266);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(103, 34);
            this.btnConfirmPayment.TabIndex = 5;
            this.btnConfirmPayment.Text = "Confirm";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // cbboxYrLvl
            // 
            this.cbboxYrLvl.FormattingEnabled = true;
            this.cbboxYrLvl.Location = new System.Drawing.Point(131, 150);
            this.cbboxYrLvl.Name = "cbboxYrLvl";
            this.cbboxYrLvl.Size = new System.Drawing.Size(158, 21);
            this.cbboxYrLvl.TabIndex = 6;
            // 
            // Frm_Receive_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 323);
            this.Controls.Add(this.cbboxYrLvl);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.cbboxEvent);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtuserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Receive_Payment";
            this.Text = "Frm_Receive_Payment";
            this.Load += new System.EventHandler(this.Frm_Receive_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbboxEvent;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.ComboBox cbboxYrLvl;
    }
}