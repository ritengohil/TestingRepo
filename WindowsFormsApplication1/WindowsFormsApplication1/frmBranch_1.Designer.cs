namespace WindowsFormsApplication1
{
    partial class frmBranch_1
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.btCloseBranch1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(9, 36);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(276, 20);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "This form is added with Branch-1.";
            // 
            // btCloseBranch1
            // 
            this.btCloseBranch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCloseBranch1.Location = new System.Drawing.Point(13, 120);
            this.btCloseBranch1.Name = "btCloseBranch1";
            this.btCloseBranch1.Size = new System.Drawing.Size(75, 28);
            this.btCloseBranch1.TabIndex = 1;
            this.btCloseBranch1.Text = "Close";
            this.btCloseBranch1.UseVisualStyleBackColor = true;
            this.btCloseBranch1.Click += new System.EventHandler(this.btCloseBranch1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Test label";
            // 
            // frmBranch_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCloseBranch1);
            this.Controls.Add(this.lblMessage);
            this.Name = "frmBranch_1";
            this.Text = "frmBranch_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btCloseBranch1;
        private System.Windows.Forms.Label label1;
    }
}