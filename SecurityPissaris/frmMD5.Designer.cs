namespace SecurityPissaris
{
    partial class frmMD5
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
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnMD5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hash:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(77, 35);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(191, 20);
            this.txtPass.TabIndex = 2;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(77, 112);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(191, 20);
            this.txtHash.TabIndex = 3;
            // 
            // btnMD5
            // 
            this.btnMD5.Location = new System.Drawing.Point(324, 72);
            this.btnMD5.Name = "btnMD5";
            this.btnMD5.Size = new System.Drawing.Size(75, 23);
            this.btnMD5.TabIndex = 4;
            this.btnMD5.Text = "Go";
            this.btnMD5.UseVisualStyleBackColor = true;
            this.btnMD5.Click += new System.EventHandler(this.btnMD5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Simply write your Password and you will see the Hash";
            // 
            // frmMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecurityPissaris.Properties.Resources.cyber_security;
            this.ClientSize = new System.Drawing.Size(440, 218);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMD5);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMD5";
            this.Text = "frmMD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnMD5;
        private System.Windows.Forms.Label label3;
    }
}