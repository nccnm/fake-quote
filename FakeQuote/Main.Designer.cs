namespace FakeQuote
{
    partial class Main
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
            this.copyToClipboad = new System.Windows.Forms.Button();
            this.uxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxTimestamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.useCurrent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // copyToClipboad
            // 
            this.copyToClipboad.Location = new System.Drawing.Point(497, 256);
            this.copyToClipboad.Name = "copyToClipboad";
            this.copyToClipboad.Size = new System.Drawing.Size(233, 40);
            this.copyToClipboad.TabIndex = 0;
            this.copyToClipboad.Text = "Copy To Clipboad";
            this.copyToClipboad.UseVisualStyleBackColor = true;
            this.copyToClipboad.Click += new System.EventHandler(this.copyToClipboad_Click);
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(129, 12);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(600, 22);
            this.uxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // uxTimestamp
            // 
            this.uxTimestamp.Location = new System.Drawing.Point(129, 40);
            this.uxTimestamp.Name = "uxTimestamp";
            this.uxTimestamp.Size = new System.Drawing.Size(457, 22);
            this.uxTimestamp.TabIndex = 3;
            this.uxTimestamp.Text = "2017-12-28 10:55:11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Timestamp";
            // 
            // uxMessage
            // 
            this.uxMessage.Location = new System.Drawing.Point(128, 68);
            this.uxMessage.Multiline = true;
            this.uxMessage.Name = "uxMessage";
            this.uxMessage.Size = new System.Drawing.Size(601, 167);
            this.uxMessage.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // useCurrent
            // 
            this.useCurrent.Location = new System.Drawing.Point(592, 39);
            this.useCurrent.Name = "useCurrent";
            this.useCurrent.Size = new System.Drawing.Size(137, 23);
            this.useCurrent.TabIndex = 7;
            this.useCurrent.Text = "Use Current";
            this.useCurrent.UseVisualStyleBackColor = true;
            this.useCurrent.Click += new System.EventHandler(this.useCurrent_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 312);
            this.Controls.Add(this.useCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxTimestamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.copyToClipboad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "FakeQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyToClipboad;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxTimestamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button useCurrent;
    }
}

