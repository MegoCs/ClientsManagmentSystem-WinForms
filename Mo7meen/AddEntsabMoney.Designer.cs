﻿namespace Mo7meen
{
    partial class AddEntsabMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEntsabMoney));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addTransBtn = new System.Windows.Forms.Button();
            this.nationalIdtext = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.banksCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paidValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.custNameText = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.detailsTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detailsTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addTransBtn);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.nationalIdtext);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.banksCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paidValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.custNameText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 188);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // addTransBtn
            // 
            this.addTransBtn.Location = new System.Drawing.Point(133, 75);
            this.addTransBtn.Name = "addTransBtn";
            this.addTransBtn.Size = new System.Drawing.Size(188, 23);
            this.addTransBtn.TabIndex = 5;
            this.addTransBtn.Text = "اضافه مستندات";
            this.addTransBtn.UseVisualStyleBackColor = true;
            this.addTransBtn.Click += new System.EventHandler(this.addTransBtn_Click);
            // 
            // nationalIdtext
            // 
            this.nationalIdtext.Location = new System.Drawing.Point(410, 23);
            this.nationalIdtext.Name = "nationalIdtext";
            this.nationalIdtext.Size = new System.Drawing.Size(146, 20);
            this.nationalIdtext.TabIndex = 0;
            this.nationalIdtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(22, 23);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(81, 26);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "بحث";
            this.searchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(133, 49);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(188, 20);
            this.datePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "قيمة المدفوعة";
            // 
            // banksCombo
            // 
            this.banksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banksCombo.FormattingEnabled = true;
            this.banksCombo.Location = new System.Drawing.Point(410, 85);
            this.banksCombo.Name = "banksCombo";
            this.banksCombo.Size = new System.Drawing.Size(147, 21);
            this.banksCombo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "الرقم القومي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "التاريخ";
            // 
            // paidValue
            // 
            this.paidValue.Location = new System.Drawing.Point(410, 53);
            this.paidValue.Name = "paidValue";
            this.paidValue.Size = new System.Drawing.Size(146, 20);
            this.paidValue.TabIndex = 2;
            this.paidValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "الحساب المستلم";
            // 
            // custNameText
            // 
            this.custNameText.Enabled = false;
            this.custNameText.Location = new System.Drawing.Point(133, 23);
            this.custNameText.Name = "custNameText";
            this.custNameText.Size = new System.Drawing.Size(188, 20);
            this.custNameText.TabIndex = 5;
            this.custNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(133, 120);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(188, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "حفظ";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // detailsTxt
            // 
            this.detailsTxt.Location = new System.Drawing.Point(410, 122);
            this.detailsTxt.Multiline = true;
            this.detailsTxt.Name = "detailsTxt";
            this.detailsTxt.Size = new System.Drawing.Size(147, 60);
            this.detailsTxt.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "تفاصيل الدفع";
            // 
            // AddEntsabMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 212);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEntsabMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفع مصاريف ادارية للمنتسبين";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nationalIdtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox banksCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paidValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox custNameText;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addTransBtn;
        private System.Windows.Forms.TextBox detailsTxt;
        private System.Windows.Forms.Label label6;
    }
}