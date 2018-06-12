namespace BigBucksBank
{
    partial class frmReceipt
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbTType = new System.Windows.Forms.Label();
            this.lbCkecking = new System.Windows.Forms.Label();
            this.lbSavings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Location = new System.Drawing.Point(44, 33);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(129, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name NAme";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAccount
            // 
            this.lbAccount.Location = new System.Drawing.Point(179, 33);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(126, 23);
            this.lbAccount.TabIndex = 1;
            this.lbAccount.Text = "12345678";
            this.lbAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTType
            // 
            this.lbTType.Location = new System.Drawing.Point(6, 32);
            this.lbTType.Name = "lbTType";
            this.lbTType.Size = new System.Drawing.Size(151, 23);
            this.lbTType.TabIndex = 2;
            this.lbTType.Text = "Withdrawl:";
            this.lbTType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCkecking
            // 
            this.lbCkecking.Location = new System.Drawing.Point(165, 35);
            this.lbCkecking.Name = "lbCkecking";
            this.lbCkecking.Size = new System.Drawing.Size(98, 23);
            this.lbCkecking.TabIndex = 3;
            this.lbCkecking.Text = "$100.00";
            this.lbCkecking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSavings
            // 
            this.lbSavings.Location = new System.Drawing.Point(165, 80);
            this.lbSavings.Name = "lbSavings";
            this.lbSavings.Size = new System.Drawing.Size(98, 23);
            this.lbSavings.TabIndex = 4;
            this.lbSavings.Text = "$100.00";
            this.lbSavings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Checking:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Savings:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbSavings);
            this.groupBox1.Controls.Add(this.lbCkecking);
            this.groupBox1.Location = new System.Drawing.Point(42, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balance";
            // 
            // lbAmount
            // 
            this.lbAmount.Location = new System.Drawing.Point(163, 32);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(98, 23);
            this.lbAmount.TabIndex = 8;
            this.lbAmount.Text = "$100.00";
            this.lbAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbAmount);
            this.groupBox2.Controls.Add(this.lbTType);
            this.groupBox2.Location = new System.Drawing.Point(44, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 74);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Type";
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(204, 304);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(101, 40);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // frmReceipt
            // 
            this.AcceptButton = this.btOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceipt";
            this.Text = "Receipt - BBB";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbTType;
        private System.Windows.Forms.Label lbCkecking;
        private System.Windows.Forms.Label lbSavings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btOk;
    }
}