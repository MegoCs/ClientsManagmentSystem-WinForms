namespace Mo7meen
{
    partial class WarningLettersManager
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.subjectTxt = new System.Windows.Forms.TextBox();
            this.deleteLetterBtn = new System.Windows.Forms.Button();
            this.attchmentsBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.letterNumberTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notesTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.replyTxt = new System.Windows.Forms.TextBox();
            this.saveUpdateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LetterType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(13, 13);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(153, 50);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // subjectTxt
            // 
            this.subjectTxt.Location = new System.Drawing.Point(213, 135);
            this.subjectTxt.Margin = new System.Windows.Forms.Padding(4);
            this.subjectTxt.Multiline = true;
            this.subjectTxt.Name = "subjectTxt";
            this.subjectTxt.Size = new System.Drawing.Size(226, 78);
            this.subjectTxt.TabIndex = 2;
            this.subjectTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deleteLetterBtn
            // 
            this.deleteLetterBtn.Enabled = false;
            this.deleteLetterBtn.Location = new System.Drawing.Point(11, 309);
            this.deleteLetterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteLetterBtn.Name = "deleteLetterBtn";
            this.deleteLetterBtn.Size = new System.Drawing.Size(153, 48);
            this.deleteLetterBtn.TabIndex = 3;
            this.deleteLetterBtn.Text = "مسح الخطاب";
            this.deleteLetterBtn.UseVisualStyleBackColor = true;
            this.deleteLetterBtn.Click += new System.EventHandler(this.deleteLetterBtn_Click);
            // 
            // attchmentsBtn
            // 
            this.attchmentsBtn.Enabled = false;
            this.attchmentsBtn.Location = new System.Drawing.Point(11, 233);
            this.attchmentsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.attchmentsBtn.Name = "attchmentsBtn";
            this.attchmentsBtn.Size = new System.Drawing.Size(153, 49);
            this.attchmentsBtn.TabIndex = 4;
            this.attchmentsBtn.Text = "الاصول الورقية";
            this.attchmentsBtn.UseVisualStyleBackColor = true;
            this.attchmentsBtn.Click += new System.EventHandler(this.attchmentsBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "البيان";
            // 
            // letterNumberTxt
            // 
            this.letterNumberTxt.Location = new System.Drawing.Point(213, 13);
            this.letterNumberTxt.Margin = new System.Windows.Forms.Padding(4);
            this.letterNumberTxt.Name = "letterNumberTxt";
            this.letterNumberTxt.Size = new System.Drawing.Size(226, 24);
            this.letterNumberTxt.TabIndex = 1;
            this.letterNumberTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "رقم البيان";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "ملاحظات";
            // 
            // notesTxt
            // 
            this.notesTxt.Location = new System.Drawing.Point(214, 233);
            this.notesTxt.Margin = new System.Windows.Forms.Padding(4);
            this.notesTxt.Multiline = true;
            this.notesTxt.Name = "notesTxt";
            this.notesTxt.Size = new System.Drawing.Size(226, 63);
            this.notesTxt.TabIndex = 7;
            this.notesTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(456, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "تسجيل الرد على البيان";
            // 
            // replyTxt
            // 
            this.replyTxt.Location = new System.Drawing.Point(211, 321);
            this.replyTxt.Margin = new System.Windows.Forms.Padding(4);
            this.replyTxt.Multiline = true;
            this.replyTxt.Name = "replyTxt";
            this.replyTxt.Size = new System.Drawing.Size(226, 117);
            this.replyTxt.TabIndex = 9;
            this.replyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saveUpdateBtn
            // 
            this.saveUpdateBtn.Enabled = false;
            this.saveUpdateBtn.Location = new System.Drawing.Point(11, 388);
            this.saveUpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveUpdateBtn.Name = "saveUpdateBtn";
            this.saveUpdateBtn.Size = new System.Drawing.Size(153, 50);
            this.saveUpdateBtn.TabIndex = 11;
            this.saveUpdateBtn.Text = "حفظ التعديل";
            this.saveUpdateBtn.UseVisualStyleBackColor = true;
            this.saveUpdateBtn.Click += new System.EventHandler(this.saveUpdateBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "نوع البيان";
            // 
            // LetterType
            // 
            this.LetterType.Location = new System.Drawing.Point(211, 82);
            this.LetterType.Margin = new System.Windows.Forms.Padding(4);
            this.LetterType.Name = "LetterType";
            this.LetterType.Size = new System.Drawing.Size(226, 24);
            this.LetterType.TabIndex = 12;
            this.LetterType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "تاريخ البيان";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // WarningLettersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 463);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LetterType);
            this.Controls.Add(this.saveUpdateBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.replyTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notesTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attchmentsBtn);
            this.Controls.Add(this.deleteLetterBtn);
            this.Controls.Add(this.letterNumberTxt);
            this.Controls.Add(this.subjectTxt);
            this.Controls.Add(this.searchBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WarningLettersManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادارة خطابات الانذارات";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox subjectTxt;
        private System.Windows.Forms.Button deleteLetterBtn;
        private System.Windows.Forms.Button attchmentsBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox letterNumberTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox notesTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox replyTxt;
        private System.Windows.Forms.Button saveUpdateBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LetterType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}