namespace SecurityPissaris
{
    partial class frmAES
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
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Round Trip:";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(102, 29);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(166, 20);
            this.txtOrigin.TabIndex = 2;
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(102, 142);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(166, 20);
            this.txtRound.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(292, 27);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Go";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Encrypted Data:";
            // 
            // txtEncry
            // 
            this.txtEncry.Location = new System.Drawing.Point(130, 88);
            this.txtEncry.Name = "txtEncry";
            this.txtEncry.Size = new System.Drawing.Size(266, 20);
            this.txtEncry.TabIndex = 6;
            // 
            // frmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecurityPissaris.Properties.Resources.cyber_security;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.txtEncry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAES";
            this.Text = "frmAES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncry;
    }
}