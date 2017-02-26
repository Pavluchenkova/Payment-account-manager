namespace Client
{
    partial class Form1
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
            this.AccountNumber = new System.Windows.Forms.TextBox();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.SearchByAccountNumber = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Balance = new System.Windows.Forms.TextBox();
            this.ValidationDate = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.TextBox();
            this.ModificationDate = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelValidTillDate = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelNotes = new System.Windows.Forms.Label();
            this.labelModificationdate = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountNumber
            // 
            this.AccountNumber.Location = new System.Drawing.Point(133, 12);
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Size = new System.Drawing.Size(123, 20);
            this.AccountNumber.TabIndex = 0;
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.Location = new System.Drawing.Point(28, 15);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(85, 13);
            this.labelAccountNumber.TabIndex = 1;
            this.labelAccountNumber.Text = "Account number";
            // 
            // SearchByAccountNumber
            // 
            this.SearchByAccountNumber.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SearchByAccountNumber.Location = new System.Drawing.Point(180, 47);
            this.SearchByAccountNumber.Name = "SearchByAccountNumber";
            this.SearchByAccountNumber.Size = new System.Drawing.Size(75, 23);
            this.SearchByAccountNumber.TabIndex = 2;
            this.SearchByAccountNumber.Text = "OK";
            this.SearchByAccountNumber.UseVisualStyleBackColor = true;
            this.SearchByAccountNumber.Click += new System.EventHandler(this.SearchByAccountNumber_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(133, 93);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(122, 20);
            this.UserName.TabIndex = 3;
            // 
            // Balance
            // 
            this.Balance.Location = new System.Drawing.Point(133, 127);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(122, 20);
            this.Balance.TabIndex = 5;
            // 
            // ValidationDate
            // 
            this.ValidationDate.Location = new System.Drawing.Point(133, 153);
            this.ValidationDate.Name = "ValidationDate";
            this.ValidationDate.ReadOnly = true;
            this.ValidationDate.Size = new System.Drawing.Size(122, 20);
            this.ValidationDate.TabIndex = 6;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(133, 177);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(122, 20);
            this.Phone.TabIndex = 7;
            // 
            // Notes
            // 
            this.Notes.Location = new System.Drawing.Point(133, 203);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(122, 20);
            this.Notes.TabIndex = 8;
            // 
            // ModificationDate
            // 
            this.ModificationDate.Location = new System.Drawing.Point(134, 229);
            this.ModificationDate.Name = "ModificationDate";
            this.ModificationDate.ReadOnly = true;
            this.ModificationDate.Size = new System.Drawing.Size(122, 20);
            this.ModificationDate.TabIndex = 9;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 96);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(28, 130);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 11;
            this.labelBalance.Text = "Balance";
            // 
            // labelValidTillDate
            // 
            this.labelValidTillDate.AutoSize = true;
            this.labelValidTillDate.Location = new System.Drawing.Point(28, 156);
            this.labelValidTillDate.Name = "labelValidTillDate";
            this.labelValidTillDate.Size = new System.Drawing.Size(51, 13);
            this.labelValidTillDate.TabIndex = 12;
            this.labelValidTillDate.Text = "Valid thru";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(28, 180);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(38, 13);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Phone";
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(28, 206);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(35, 13);
            this.labelNotes.TabIndex = 14;
            this.labelNotes.Text = "Notes";
            // 
            // labelModificationdate
            // 
            this.labelModificationdate.AutoSize = true;
            this.labelModificationdate.Location = new System.Drawing.Point(28, 232);
            this.labelModificationdate.Name = "labelModificationdate";
            this.labelModificationdate.Size = new System.Drawing.Size(65, 13);
            this.labelModificationdate.TabIndex = 15;
            this.labelModificationdate.Text = "Modificated ";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Enabled = false;
            this.SaveChanges.Location = new System.Drawing.Point(179, 270);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(75, 23);
            this.SaveChanges.TabIndex = 16;
            this.SaveChanges.Text = "Save";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 311);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.labelModificationdate);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelValidTillDate);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.ModificationDate);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.ValidationDate);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SearchByAccountNumber);
            this.Controls.Add(this.labelAccountNumber);
            this.Controls.Add(this.AccountNumber);
            this.Name = "Form1";
            this.Text = "Account Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountNumber;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Button SearchByAccountNumber;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Balance;
        private System.Windows.Forms.TextBox ValidationDate;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Notes;
        private System.Windows.Forms.TextBox ModificationDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelValidTillDate;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.Label labelModificationdate;
        private System.Windows.Forms.Button SaveChanges;
    }
}

