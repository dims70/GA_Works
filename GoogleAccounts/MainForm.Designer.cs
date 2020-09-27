namespace GoogleAccounts
{
    partial class GACC
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSeeAcc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.checkExternal = new System.Windows.Forms.CheckBox();
            this.btnCheckIP = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipBox
            // 
            this.ipBox.Enabled = false;
            this.ipBox.Location = new System.Drawing.Point(196, 32);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(138, 22);
            this.ipBox.TabIndex = 0;
            this.ipBox.Text = "ожидание...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP адрес:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(61, 112);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 22);
            this.loginBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Почта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(234, 112);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 22);
            this.passBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер телефона:";
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(457, 112);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(100, 22);
            this.numBox.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 182);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSeeAcc
            // 
            this.btnSeeAcc.Location = new System.Drawing.Point(366, 32);
            this.btnSeeAcc.Name = "btnSeeAcc";
            this.btnSeeAcc.Size = new System.Drawing.Size(181, 22);
            this.btnSeeAcc.TabIndex = 9;
            this.btnSeeAcc.Text = "Просмотр списка акк.";
            this.btnSeeAcc.UseVisualStyleBackColor = true;
            this.btnSeeAcc.Click += new System.EventHandler(this.btnSeeAcc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(399, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 45);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить данные";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // checkExternal
            // 
            this.checkExternal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkExternal.Location = new System.Drawing.Point(26, 174);
            this.checkExternal.Name = "checkExternal";
            this.checkExternal.Size = new System.Drawing.Size(160, 60);
            this.checkExternal.TabIndex = 11;
            this.checkExternal.Text = "* Запись с внешнего без учета  IP";
            this.checkExternal.UseVisualStyleBackColor = true;
            // 
            // btnCheckIP
            // 
            this.btnCheckIP.Location = new System.Drawing.Point(12, 30);
            this.btnCheckIP.Name = "btnCheckIP";
            this.btnCheckIP.Size = new System.Drawing.Size(69, 22);
            this.btnCheckIP.TabIndex = 12;
            this.btnCheckIP.Text = "Был ли IP ";
            this.btnCheckIP.UseVisualStyleBackColor = true;
            this.btnCheckIP.Click += new System.EventHandler(this.btnCheckIP_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(196, 60);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 22);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GACC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 253);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCheckIP);
            this.Controls.Add(this.checkExternal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSeeAcc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GACC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GACC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSeeAcc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox checkExternal;
        private System.Windows.Forms.Button btnCheckIP;
        private System.Windows.Forms.Button btnRefresh;
    }
}

