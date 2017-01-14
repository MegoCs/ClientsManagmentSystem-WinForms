namespace Mo7meen
{
    partial class EditeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditeClient));
            this.national_id = new System.Windows.Forms.TextBox();
            this.client_name = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.Client_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.membershipNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.details_text = new System.Windows.Forms.TextBox();
            this.national_id_new = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.borgNumber = new System.Windows.Forms.TextBox();
            this.unitNumber = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.changeSearch = new System.Windows.Forms.CheckBox();
            this.cust_nameComb = new System.Windows.Forms.ComboBox();
            this.displayPhotos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // national_id
            // 
            this.national_id.Enabled = false;
            this.national_id.Location = new System.Drawing.Point(316, 41);
            this.national_id.Name = "national_id";
            this.national_id.Size = new System.Drawing.Size(152, 20);
            this.national_id.TabIndex = 0;
            this.national_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // client_name
            // 
            this.client_name.Location = new System.Drawing.Point(31, 38);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(152, 20);
            this.client_name.TabIndex = 2;
            this.client_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(31, 96);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(152, 20);
            this.phoneNumber.TabIndex = 3;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Client_address
            // 
            this.Client_address.Location = new System.Drawing.Point(31, 148);
            this.Client_address.Multiline = true;
            this.Client_address.Name = "Client_address";
            this.Client_address.Size = new System.Drawing.Size(152, 55);
            this.Client_address.TabIndex = 5;
            this.Client_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "الرقم القومي";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "الاسم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "رقم التلفون";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "العنوان";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 25);
            this.button2.TabIndex = 10;
            this.button2.Text = "حفظ التعديل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.membershipNum);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.client_name);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.details_text);
            this.groupBox1.Controls.Add(this.Client_address);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.national_id_new);
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Location = new System.Drawing.Point(285, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 300);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعديل البيانات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "رقم العضوية";
            // 
            // membershipNum
            // 
            this.membershipNum.Location = new System.Drawing.Point(31, 122);
            this.membershipNum.Name = "membershipNum";
            this.membershipNum.Size = new System.Drawing.Size(152, 20);
            this.membershipNum.TabIndex = 4;
            this.membershipNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "تفاصيل عن العميل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "الرقم القومى الجديد";
            // 
            // details_text
            // 
            this.details_text.Location = new System.Drawing.Point(31, 212);
            this.details_text.Multiline = true;
            this.details_text.Name = "details_text";
            this.details_text.Size = new System.Drawing.Size(152, 55);
            this.details_text.TabIndex = 6;
            this.details_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // national_id_new
            // 
            this.national_id_new.Location = new System.Drawing.Point(31, 70);
            this.national_id_new.Name = "national_id_new";
            this.national_id_new.Size = new System.Drawing.Size(152, 20);
            this.national_id_new.TabIndex = 3;
            this.national_id_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.borgNumber);
            this.groupBox2.Controls.Add(this.unitNumber);
            this.groupBox2.Location = new System.Drawing.Point(13, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 98);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الاستلام";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "رقم البرج";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "رقم الوحدة";
            // 
            // borgNumber
            // 
            this.borgNumber.Location = new System.Drawing.Point(17, 66);
            this.borgNumber.Name = "borgNumber";
            this.borgNumber.Size = new System.Drawing.Size(128, 20);
            this.borgNumber.TabIndex = 9;
            this.borgNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitNumber
            // 
            this.unitNumber.Location = new System.Drawing.Point(17, 29);
            this.unitNumber.Name = "unitNumber";
            this.unitNumber.Size = new System.Drawing.Size(128, 20);
            this.unitNumber.TabIndex = 8;
            this.unitNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(192, 127);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "بيانات الوحدة";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(30, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "مسح العميل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(518, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "الاسم";
            // 
            // changeSearch
            // 
            this.changeSearch.AutoSize = true;
            this.changeSearch.Location = new System.Drawing.Point(546, 30);
            this.changeSearch.Name = "changeSearch";
            this.changeSearch.Size = new System.Drawing.Size(78, 17);
            this.changeSearch.TabIndex = 14;
            this.changeSearch.Text = "تبديل البحث";
            this.changeSearch.UseVisualStyleBackColor = true;
            this.changeSearch.CheckedChanged += new System.EventHandler(this.changeSearch_CheckedChanged);
            // 
            // cust_nameComb
            // 
            this.cust_nameComb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cust_nameComb.FormattingEnabled = true;
            this.cust_nameComb.Location = new System.Drawing.Point(316, 14);
            this.cust_nameComb.Name = "cust_nameComb";
            this.cust_nameComb.Size = new System.Drawing.Size(152, 21);
            this.cust_nameComb.TabIndex = 15;
            // 
            // displayPhotos
            // 
            this.displayPhotos.Location = new System.Drawing.Point(113, 68);
            this.displayPhotos.Name = "displayPhotos";
            this.displayPhotos.Size = new System.Drawing.Size(166, 53);
            this.displayPhotos.TabIndex = 16;
            this.displayPhotos.Text = "عرض الاصول الورقية";
            this.displayPhotos.UseVisualStyleBackColor = true;
            this.displayPhotos.Click += new System.EventHandler(this.displayPhotos_Click);
            // 
            // EditeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 379);
            this.Controls.Add(this.displayPhotos);
            this.Controls.Add(this.cust_nameComb);
            this.Controls.Add(this.changeSearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.national_id);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditeClient";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بيانات الاعضاء";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox national_id;
        private System.Windows.Forms.TextBox client_name;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox Client_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox membershipNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox borgNumber;
        private System.Windows.Forms.TextBox unitNumber;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox details_text;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox national_id_new;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox changeSearch;
        private System.Windows.Forms.ComboBox cust_nameComb;
        private System.Windows.Forms.Button displayPhotos;
    }
}