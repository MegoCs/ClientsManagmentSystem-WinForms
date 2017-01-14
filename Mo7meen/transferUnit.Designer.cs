namespace Mo7meen
{
    partial class TransferUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferUnit));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.nationalIdText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.thePaidMoney = new System.Windows.Forms.TextBox();
            this.unitType = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.currentUnitState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "الرقم القومي";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(297, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "نوع الوحدة المحول إليها";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "المبلغ المدفوع";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // transferButton
            // 
            this.transferButton.Location = new System.Drawing.Point(48, 167);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(180, 23);
            this.transferButton.TabIndex = 1;
            this.transferButton.Text = "إجراء عملية التحويل";
            this.transferButton.UseVisualStyleBackColor = true;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // nationalIdText
            // 
            this.nationalIdText.Location = new System.Drawing.Point(86, 12);
            this.nationalIdText.Name = "nationalIdText";
            this.nationalIdText.Size = new System.Drawing.Size(121, 20);
            this.nationalIdText.TabIndex = 2;
            this.nationalIdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(86, 44);
            this.nameText.Name = "nameText";
            this.nameText.ReadOnly = true;
            this.nameText.Size = new System.Drawing.Size(121, 20);
            this.nameText.TabIndex = 2;
            this.nameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thePaidMoney
            // 
            this.thePaidMoney.Location = new System.Drawing.Point(86, 102);
            this.thePaidMoney.Name = "thePaidMoney";
            this.thePaidMoney.ReadOnly = true;
            this.thePaidMoney.Size = new System.Drawing.Size(121, 20);
            this.thePaidMoney.TabIndex = 2;
            this.thePaidMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unitType
            // 
            this.unitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitType.FormattingEnabled = true;
            this.unitType.Location = new System.Drawing.Point(86, 128);
            this.unitType.Name = "unitType";
            this.unitType.Size = new System.Drawing.Size(121, 21);
            this.unitType.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(5, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "بحث";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "نوع الوحدة الحالية ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentUnitState
            // 
            this.currentUnitState.Location = new System.Drawing.Point(86, 76);
            this.currentUnitState.Name = "currentUnitState";
            this.currentUnitState.ReadOnly = true;
            this.currentUnitState.Size = new System.Drawing.Size(121, 20);
            this.currentUnitState.TabIndex = 2;
            this.currentUnitState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TransferUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 202);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.unitType);
            this.Controls.Add(this.thePaidMoney);
            this.Controls.Add(this.currentUnitState);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nationalIdText);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransferUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل نوع الوحدة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.TextBox nationalIdText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox thePaidMoney;
        private System.Windows.Forms.ComboBox unitType;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currentUnitState;

    }
}