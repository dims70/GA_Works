namespace GoogleAccounts
{
    partial class AccForm
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
            this.listAcc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listAcc
            // 
            this.listAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAcc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listAcc.FormattingEnabled = true;
            this.listAcc.ItemHeight = 21;
            this.listAcc.Location = new System.Drawing.Point(0, 0);
            this.listAcc.Name = "listAcc";
            this.listAcc.Size = new System.Drawing.Size(457, 295);
            this.listAcc.TabIndex = 0;
            // 
            // AccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 295);
            this.Controls.Add(this.listAcc);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр аккаунтов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAcc;
    }
}