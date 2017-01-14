namespace Mo7meen
{
    partial class PayQest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayQest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.agentNameText = new System.Windows.Forms.TextBox();
            this.qestValueText = new System.Windows.Forms.TextBox();
            this.nationalIdtext = new System.Windows.Forms.TextBox();
            this.receivingAccountText = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addPhotosButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.detailsTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "قيمة القسط";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "الرقم القومي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "التاريخ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "الحساب المستلم";
            // 
            // agentNameText
            // 
            this.agentNameText.Enabled = false;
            this.agentNameText.Location = new System.Drawing.Point(6, 47);
            this.agentNameText.Name = "agentNameText";
            this.agentNameText.ReadOnly = true;
            this.agentNameText.Size = new System.Drawing.Size(175, 20);
            this.agentNameText.TabIndex = 5;
            this.agentNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qestValueText
            // 
            this.qestValueText.Location = new System.Drawing.Point(266, 80);
            this.qestValueText.Name = "qestValueText";
            this.qestValueText.Size = new System.Drawing.Size(133, 20);
            this.qestValueText.TabIndex = 6;
            this.qestValueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nationalIdtext
            // 
            this.nationalIdtext.Location = new System.Drawing.Point(266, 45);
            this.nationalIdtext.Name = "nationalIdtext";
            this.nationalIdtext.Size = new System.Drawing.Size(133, 20);
            this.nationalIdtext.TabIndex = 7;
            this.nationalIdtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // receivingAccountText
            // 
            this.receivingAccountText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receivingAccountText.FormattingEnabled = true;
            this.receivingAccountText.Location = new System.Drawing.Point(266, 106);
            this.receivingAccountText.Name = "receivingAccountText";
            this.receivingAccountText.Size = new System.Drawing.Size(133, 21);
            this.receivingAccountText.TabIndex = 9;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(6, 73);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(175, 20);
            this.datePicker.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 149);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 42);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "حفظ";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.detailsTxt);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.addPhotosButton);
            this.groupBox1.Controls.Add(this.nationalIdtext);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.receivingAccountText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.qestValueText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.agentNameText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // addPhotosButton
            // 
            this.addPhotosButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addPhotosButton.Location = new System.Drawing.Point(6, 113);
            this.addPhotosButton.Name = "addPhotosButton";
            this.addPhotosButton.Size = new System.Drawing.Size(175, 33);
            this.addPhotosButton.TabIndex = 19;
            this.addPhotosButton.Text = "اضافة مستندات";
            this.addPhotosButton.UseVisualStyleBackColor = false;
            this.addPhotosButton.Click += new System.EventHandler(this.addPhotosButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "بحث";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "تفاصيل الدفع";
            // 
            // detailsTxt
            // 
            this.detailsTxt.Location = new System.Drawing.Point(266, 133);
            this.detailsTxt.Multiline = true;
            this.detailsTxt.Name = "detailsTxt";
            this.detailsTxt.Size = new System.Drawing.Size(133, 58);
            this.detailsTxt.TabIndex = 21;
            // 
            // PayQest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 218);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PayQest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "دفع قسط";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox agentNameText;
        private System.Windows.Forms.TextBox qestValueText;
        private System.Windows.Forms.TextBox nationalIdtext;
        private System.Windows.Forms.ComboBox receivingAccountText;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button addPhotosButton;
        private System.Windows.Forms.TextBox detailsTxt;
        private System.Windows.Forms.Label label6;
    }
}