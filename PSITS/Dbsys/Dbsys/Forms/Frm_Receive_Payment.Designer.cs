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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eventRadio = new System.Windows.Forms.RadioButton();
            this.miscRadio = new System.Windows.Forms.RadioButton();
            this.cbboxMisc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.paymentDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtuserName
            // 
            this.txtuserName.Location = new System.Drawing.Point(35, 92);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(229, 20);
            this.txtuserName.TabIndex = 3;
            this.txtuserName.TextChanged += new System.EventHandler(this.txtuserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Number";
            // 
            // txtidNumber
            // 
            this.txtidNumber.Location = new System.Drawing.Point(35, 137);
            this.txtidNumber.Name = "txtidNumber";
            this.txtidNumber.Size = new System.Drawing.Size(229, 20);
            this.txtidNumber.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Year Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Payment For";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(34, 396);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(229, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // cbboxEvent
            // 
            this.cbboxEvent.FormattingEnabled = true;
            this.cbboxEvent.Location = new System.Drawing.Point(35, 292);
            this.cbboxEvent.Name = "cbboxEvent";
            this.cbboxEvent.Size = new System.Drawing.Size(229, 21);
            this.cbboxEvent.TabIndex = 4;
            this.cbboxEvent.Visible = false;
            this.cbboxEvent.SelectedIndexChanged += new System.EventHandler(this.cbboxEvent_SelectedIndexChanged);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(88, 437);
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
            this.cbboxYrLvl.Location = new System.Drawing.Point(35, 186);
            this.cbboxYrLvl.Name = "cbboxYrLvl";
            this.cbboxYrLvl.Size = new System.Drawing.Size(229, 21);
            this.cbboxYrLvl.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.miscRadio);
            this.groupBox1.Controls.Add(this.eventRadio);
            this.groupBox1.Location = new System.Drawing.Point(35, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // eventRadio
            // 
            this.eventRadio.AutoSize = true;
            this.eventRadio.Location = new System.Drawing.Point(6, 10);
            this.eventRadio.Name = "eventRadio";
            this.eventRadio.Size = new System.Drawing.Size(53, 17);
            this.eventRadio.TabIndex = 0;
            this.eventRadio.TabStop = true;
            this.eventRadio.Text = "Event";
            this.eventRadio.UseVisualStyleBackColor = true;
            this.eventRadio.CheckedChanged += new System.EventHandler(this.eventRadio_CheckedChanged);
            // 
            // miscRadio
            // 
            this.miscRadio.AutoSize = true;
            this.miscRadio.Location = new System.Drawing.Point(6, 28);
            this.miscRadio.Name = "miscRadio";
            this.miscRadio.Size = new System.Drawing.Size(47, 17);
            this.miscRadio.TabIndex = 0;
            this.miscRadio.TabStop = true;
            this.miscRadio.Text = "Misc";
            this.miscRadio.UseVisualStyleBackColor = true;
            this.miscRadio.CheckedChanged += new System.EventHandler(this.miscRadio_CheckedChanged);
            // 
            // cbboxMisc
            // 
            this.cbboxMisc.FormattingEnabled = true;
            this.cbboxMisc.Location = new System.Drawing.Point(35, 292);
            this.cbboxMisc.Name = "cbboxMisc";
            this.cbboxMisc.Size = new System.Drawing.Size(229, 21);
            this.cbboxMisc.TabIndex = 4;
            this.cbboxMisc.Visible = false;
            this.cbboxMisc.SelectedIndexChanged += new System.EventHandler(this.cbboxEvent_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date";
            // 
            // paymentDay
            // 
            this.paymentDay.Location = new System.Drawing.Point(34, 341);
            this.paymentDay.Name = "paymentDay";
            this.paymentDay.Size = new System.Drawing.Size(229, 20);
            this.paymentDay.TabIndex = 8;
            // 
            // Frm_Receive_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 502);
            this.Controls.Add(this.paymentDay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbboxYrLvl);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.cbboxMisc);
            this.Controls.Add(this.cbboxEvent);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label7);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton miscRadio;
        private System.Windows.Forms.RadioButton eventRadio;
        private System.Windows.Forms.ComboBox cbboxMisc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker paymentDay;
    }
}