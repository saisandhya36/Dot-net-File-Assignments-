
namespace WinFormsAppDem
{
    partial class calculator
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
            this.lblfirst = new System.Windows.Forms.Label();
            this.lblsecond = new System.Windows.Forms.Label();
            this.lblMsg1 = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Location = new System.Drawing.Point(83, 70);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(42, 25);
            this.lblfirst.TabIndex = 0;
            this.lblfirst.Text = "first";
            // 
            // lblsecond
            // 
            this.lblsecond.AutoSize = true;
            this.lblsecond.Location = new System.Drawing.Point(83, 120);
            this.lblsecond.Name = "lblsecond";
            this.lblsecond.Size = new System.Drawing.Size(69, 25);
            this.lblsecond.TabIndex = 1;
            this.lblsecond.Text = "second";
            // 
            // lblMsg1
            // 
            this.lblMsg1.Location = new System.Drawing.Point(234, 67);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(366, 31);
            this.lblMsg1.TabIndex = 2;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(234, 120);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(366, 31);
            this.lblMsg.TabIndex = 3;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.lblsecond);
            this.Controls.Add(this.lblfirst);
            this.Name = "calculator";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lblsecond;
        private System.Windows.Forms.TextBox lblMsg1;
        private System.Windows.Forms.TextBox lblMsg;
    }
}