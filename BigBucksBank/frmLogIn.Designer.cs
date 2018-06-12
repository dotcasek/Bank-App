namespace BigBucksBank
{
    partial class frmLogIn
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
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btQuit = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btRelease = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "PIN:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(149, 67);
            this.tbUserName.MaxLength = 25;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(129, 26);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.Tag = "Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(149, 116);
            this.tbPassword.MaxLength = 4;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(129, 26);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Tag = "PIN";
            // 
            // tbMessage
            // 
            this.tbMessage.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMessage.Cursor = System.Windows.Forms.Cursors.No;
            this.tbMessage.Location = new System.Drawing.Point(12, 230);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(328, 130);
            this.tbMessage.TabIndex = 4;
            this.tbMessage.TabStop = false;
            // 
            // btQuit
            // 
            this.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btQuit.Location = new System.Drawing.Point(65, 186);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(101, 31);
            this.btQuit.TabIndex = 2;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(177, 186);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(101, 31);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "Log In";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btRelease
            // 
            this.btRelease.Location = new System.Drawing.Point(177, 186);
            this.btRelease.Name = "btRelease";
            this.btRelease.Size = new System.Drawing.Size(101, 31);
            this.btRelease.TabIndex = 5;
            this.btRelease.Text = "Release";
            this.btRelease.UseVisualStyleBackColor = true;
            this.btRelease.Click += new System.EventHandler(this.btRelease_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(65, 186);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(101, 31);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // frmLogIn
            // 
            this.AcceptButton = this.btSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btQuit;
            this.ClientSize = new System.Drawing.Size(352, 372);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btRelease);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmLogIn";
            this.Text = "Log In - BBB";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btRelease;
        private System.Windows.Forms.Button btClear;
    }
}

