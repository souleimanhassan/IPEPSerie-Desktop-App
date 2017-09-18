namespace IPEPSerie.WinForms
{
    partial class FLogin
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
            this.btnHello = new System.Windows.Forms.Button();
            this.tbHello = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(12, 265);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(352, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say hello to IPEPS !";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // tbHello
            // 
            this.tbHello.Enabled = false;
            this.tbHello.Location = new System.Drawing.Point(12, 126);
            this.tbHello.Name = "tbHello";
            this.tbHello.Size = new System.Drawing.Size(352, 20);
            this.tbHello.TabIndex = 1;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 300);
            this.Controls.Add(this.tbHello);
            this.Controls.Add(this.btnHello);
            this.Name = "FLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox tbHello;
    }
}

