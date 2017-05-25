namespace SecurityPissaris
{
    partial class frmStart
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
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.btnAES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbout
            // 
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.Location = new System.Drawing.Point(164, 207);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(97, 23);
            this.btnAbout.TabIndex = 0;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(164, 12);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(97, 23);
            this.btnMD5.TabIndex = 1;
            this.btnMD5.Text = "MD5 Encryption";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Location = new System.Drawing.Point(140, 71);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(152, 23);
            this.btnRSA.TabIndex = 2;
            this.btnRSA.Text = "RSA Encrypt/Decrypt";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // btnAES
            // 
            this.btnAES.Location = new System.Drawing.Point(164, 121);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(97, 23);
            this.btnAES.TabIndex = 3;
            this.btnAES.Text = "AES Encryption";
            this.btnAES.UseVisualStyleBackColor = true;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecurityPissaris.Properties.Resources.cyber_security;
            this.ClientSize = new System.Drawing.Size(427, 295);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.btnAbout);
            this.Name = "frmStart";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Button btnAES;
    }
}

