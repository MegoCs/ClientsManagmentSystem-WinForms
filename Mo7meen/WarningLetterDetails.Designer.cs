namespace Mo7meen
{
    partial class WarningLetterDetails
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outboxNumberTxt = new System.Windows.Forms.TextBox();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.notesTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.clientNameLab = new System.Windows.Forms.Label();
            this.addPhotosButton = new System.Windows.Forms.Button();
            this.letterType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lastLetterNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(26, 366);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(179, 38);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الصادر";
            // 
            // outboxNumberTxt
            // 
            this.outboxNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outboxNumberTxt.Location = new System.Drawing.Point(150, 42);
            this.outboxNumberTxt.Name = "outboxNumberTxt";
            this.outboxNumberTxt.Size = new System.Drawing.Size(88, 24);
            this.outboxNumberTxt.TabIndex = 2;
            this.outboxNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subjectTxt
            // 
            this.subjectTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTxt.Location = new System.Drawing.Point(12, 111);
            this.subjectTxt.Multiline = true;
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.subjectTxt.Size = new System.Drawing.Size(225, 83);
            this.subjectTxt.TabIndex = 4;
            this.subjectTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // notesTxt
            // 
            this.notesTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTxt.Location = new System.Drawing.Point(12, 240);
            this.notesTxt.Multiline = true;
            this.notesTxt.Name = "notesTxt";
            this.notesTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.notesTxt.Size = new System.Drawing.Size(226, 81);
            this.notesTxt.TabIndex = 6;
            this.notesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "الموضوع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(284, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "ملاحظات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "تاريخ الارسال";
            // 
            // letterDatePicker
            // 
            this.letterDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.letterDatePicker.Location = new System.Drawing.Point(12, 72);
            this.letterDatePicker.Name = "letterDatePicker";
            this.letterDatePicker.Size = new System.Drawing.Size(225, 24);
            this.letterDatePicker.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم العضو";
            // 
            // clientNameLab
            // 
            this.clientNameLab.AutoSize = true;
            this.clientNameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNameLab.Location = new System.Drawing.Point(82, 9);
            this.clientNameLab.Name = "clientNameLab";
            this.clientNameLab.Size = new System.Drawing.Size(62, 18);
            this.clientNameLab.TabIndex = 10;
            this.clientNameLab.Text = "اسم العضو";
            // 
            // addPhotosButton
            // 
            this.addPhotosButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPhotosButton.Location = new System.Drawing.Point(12, 327);
            this.addPhotosButton.Name = "addPhotosButton";
            this.addPhotosButton.Size = new System.Drawing.Size(225, 33);
            this.addPhotosButton.TabIndex = 7;
            this.addPhotosButton.Text = "اضافة مستندات";
            this.addPhotosButton.UseVisualStyleBackColor = false;
            this.addPhotosButton.Click += new System.EventHandler(this.addPhotosButton_Click);
            // 
            // letterType
            // 
            this.letterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterType.Location = new System.Drawing.Point(12, 200);
            this.letterType.Name = "letterType";
            this.letterType.Size = new System.Drawing.Size(226, 24);
            this.letterType.TabIndex = 5;
            this.letterType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "نوع البيان";
            // 
            // lastLetterNumber
            // 
            this.lastLetterNumber.AutoSize = true;
            this.lastLetterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLetterNumber.Location = new System.Drawing.Point(26, 42);
            this.lastLetterNumber.Name = "lastLetterNumber";
            this.lastLetterNumber.Size = new System.Drawing.Size(48, 18);
            this.lastLetterNumber.TabIndex = 22;
            this.lastLetterNumber.Text = "15000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 23;
            this.label8.Text = "اخر بيان";
            // 
            // WarningLetterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 424);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lastLetterNumber);
            this.Controls.Add(this.letterType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addPhotosButton);
            this.Controls.Add(this.clientNameLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.letterDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.notesTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outboxNumberTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveBtn);
            this.Name = "WarningLetterDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بيانات الانذار";
            this.Load += new System.EventHandler(this.WarningLetterDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outboxNumberTxt;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.TextBox notesTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker letterDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label clientNameLab;
        private System.Windows.Forms.Button addPhotosButton;
        private System.Windows.Forms.TextBox letterType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lastLetterNumber;
        private System.Windows.Forms.Label label8;
    }
}