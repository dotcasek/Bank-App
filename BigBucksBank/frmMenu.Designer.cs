namespace BigBucksBank
{
    partial class frmMenu
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
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdrawl = new System.Windows.Forms.RadioButton();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.btSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDeposit
            // 
            this.rbDeposit.Location = new System.Drawing.Point(6, 20);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbDeposit.Size = new System.Drawing.Size(182, 24);
            this.rbDeposit.TabIndex = 0;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Make a Deposit";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // rbWithdrawl
            // 
            this.rbWithdrawl.Location = new System.Drawing.Point(6, 65);
            this.rbWithdrawl.Name = "rbWithdrawl";
            this.rbWithdrawl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbWithdrawl.Size = new System.Drawing.Size(182, 24);
            this.rbWithdrawl.TabIndex = 1;
            this.rbWithdrawl.TabStop = true;
            this.rbWithdrawl.Text = "Make a Withdrawl";
            this.rbWithdrawl.UseVisualStyleBackColor = true;
            // 
            // rbBalance
            // 
            this.rbBalance.Location = new System.Drawing.Point(6, 110);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbBalance.Size = new System.Drawing.Size(182, 24);
            this.rbBalance.TabIndex = 2;
            this.rbBalance.TabStop = true;
            this.rbBalance.Text = "Check Balance";
            this.rbBalance.UseVisualStyleBackColor = true;
            // 
            // rbTransfer
            // 
            this.rbTransfer.Location = new System.Drawing.Point(6, 155);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbTransfer.Size = new System.Drawing.Size(182, 24);
            this.rbTransfer.TabIndex = 3;
            this.rbTransfer.TabStop = true;
            this.rbTransfer.Text = "Transfer Funds";
            this.rbTransfer.UseVisualStyleBackColor = true;
            // 
            // rbExit
            // 
            this.rbExit.Location = new System.Drawing.Point(6, 200);
            this.rbExit.Name = "rbExit";
            this.rbExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbExit.Size = new System.Drawing.Size(182, 24);
            this.rbExit.TabIndex = 4;
            this.rbExit.TabStop = true;
            this.rbExit.Text = "Exit";
            this.rbExit.UseVisualStyleBackColor = true;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(167, 309);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(111, 37);
            this.btSubmit.TabIndex = 2;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make a Selection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDeposit);
            this.groupBox1.Controls.Add(this.rbWithdrawl);
            this.groupBox1.Controls.Add(this.rbBalance);
            this.groupBox1.Controls.Add(this.rbExit);
            this.groupBox1.Controls.Add(this.rbTransfer);
            this.groupBox1.Location = new System.Drawing.Point(72, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AcceptButton = this.btSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 372);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSubmit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Main Menu - BBB";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.RadioButton rbWithdrawl;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}