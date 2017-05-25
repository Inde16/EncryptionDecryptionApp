namespace SecurityPissaris
{
    partial class frmRSA
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtEncryptData = new System.Windows.Forms.TextBox();
            this.txtDecryptData = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Encrypted plain text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decrypted plain text:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(64, 33);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(170, 20);
            this.txtData.TabIndex = 3;
            // 
            // txtEncryptData
            // 
            this.txtEncryptData.Location = new System.Drawing.Point(134, 75);
            this.txtEncryptData.Name = "txtEncryptData";
            this.txtEncryptData.Size = new System.Drawing.Size(210, 20);
            this.txtEncryptData.TabIndex = 4;
            // 
            // txtDecryptData
            // 
            this.txtDecryptData.Location = new System.Drawing.Point(134, 115);
            this.txtDecryptData.Name = "txtDecryptData";
            this.txtDecryptData.Size = new System.Drawing.Size(210, 20);
            this.txtDecryptData.TabIndex = 5;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(257, 31);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(126, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encryption/Decryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecurityPissaris.Properties.Resources.cyber_security;
            this.ClientSize = new System.Drawing.Size(419, 203);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtDecryptData);
            this.Controls.Add(this.txtEncryptData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRSA";
            this.Text = "frmRSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtEncryptData;
        private System.Windows.Forms.TextBox txtDecryptData;
        private System.Windows.Forms.Button btnEncrypt;
    }
}