namespace SecurityPissaris
{
    partial class frmSHA1
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Give some data:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(150, 45);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 1;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(150, 92);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(100, 20);
            this.txtHash.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(286, 72);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmSHA1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SecurityPissaris.Properties.Resources.cyber_security;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label1);
            this.Name = "frmSHA1";
            this.Text = "SHA1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button btnGo;
    }
}