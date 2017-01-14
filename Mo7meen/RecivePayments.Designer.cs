namespace Mo7meen
{
    partial class RecivePayments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.nationalIdtext = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qestValueText = new System.Windows.Forms.TextBox();
            this.agentNameText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.nationalIdtext);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.qestValueText);
            this.groupBox1.Controls.Add(this.agentNameText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 132);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "البيانات";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(6, 80);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 42);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "حفظ";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nationalIdtext
            // 
            this.nationalIdtext.Location = new System.Drawing.Point(266, 45);
            this.nationalIdtext.Name = "nationalIdtext";
            this.nationalIdtext.Size = new System.Drawing.Size(133, 20);
            this.nationalIdtext.TabIndex = 7;
            this.nationalIdtext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label2.Location = new System.Drawing.Point(413, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "قيمة المدفوع";
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
            // qestValueText
            // 
            this.qestValueText.Location = new System.Drawing.Point(266, 80);
            this.qestValueText.Name = "qestValueText";
            this.qestValueText.Size = new System.Drawing.Size(133, 20);
            this.qestValueText.TabIndex = 6;
            this.qestValueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // RecivePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 154);
            this.Controls.Add(this.groupBox1);
            this.Name = "RecivePayments";
            this.Text = "RecivePayments";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox nationalIdtext;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qestValueText;
        private System.Windows.Forms.TextBox agentNameText;
    }
}