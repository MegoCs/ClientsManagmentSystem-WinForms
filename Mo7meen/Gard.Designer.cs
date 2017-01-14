namespace Mo7meen
{
    partial class Gard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gard));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.custNumperUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t5ses = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNumber = new System.Windows.Forms.TextBox();
            this.mo2damat = new System.Windows.Forms.TextBox();
            this.aqsat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.availUnitsTxt = new System.Windows.Forms.TextBox();
            this.availUnitsCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.availUnitsCombo);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.availUnitsTxt);
            this.groupBox1.Controls.Add(this.custNumperUnit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.t5ses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clientNumber);
            this.groupBox1.Controls.Add(this.mo2damat);
            this.groupBox1.Controls.Add(this.aqsat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نتائج عملية الجرد";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // custNumperUnit
            // 
            this.custNumperUnit.Enabled = false;
            this.custNumperUnit.Location = new System.Drawing.Point(46, 141);
            this.custNumperUnit.Name = "custNumperUnit";
            this.custNumperUnit.Size = new System.Drawing.Size(64, 20);
            this.custNumperUnit.TabIndex = 7;
            this.custNumperUnit.Text = "0";
            this.custNumperUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "اعضاء الوحدات ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "اجمالي مبالغ التخصيص";
            // 
            // t5ses
            // 
            this.t5ses.Enabled = false;
            this.t5ses.Location = new System.Drawing.Point(46, 112);
            this.t5ses.Name = "t5ses";
            this.t5ses.Size = new System.Drawing.Size(151, 20);
            this.t5ses.TabIndex = 4;
            this.t5ses.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "عدد الاعضاء المسجلين";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "أجمالي المقدمات";
            // 
            // clientNumber
            // 
            this.clientNumber.Enabled = false;
            this.clientNumber.Location = new System.Drawing.Point(46, 19);
            this.clientNumber.Name = "clientNumber";
            this.clientNumber.Size = new System.Drawing.Size(151, 20);
            this.clientNumber.TabIndex = 3;
            this.clientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mo2damat
            // 
            this.mo2damat.Enabled = false;
            this.mo2damat.Location = new System.Drawing.Point(46, 48);
            this.mo2damat.Name = "mo2damat";
            this.mo2damat.Size = new System.Drawing.Size(151, 20);
            this.mo2damat.TabIndex = 3;
            this.mo2damat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aqsat
            // 
            this.aqsat.Enabled = false;
            this.aqsat.Location = new System.Drawing.Point(46, 79);
            this.aqsat.Name = "aqsat";
            this.aqsat.Size = new System.Drawing.Size(151, 20);
            this.aqsat.TabIndex = 2;
            this.aqsat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "أجمالي الاقساط";
            // 
            // availUnitsTxt
            // 
            this.availUnitsTxt.Enabled = false;
            this.availUnitsTxt.Location = new System.Drawing.Point(46, 167);
            this.availUnitsTxt.Name = "availUnitsTxt";
            this.availUnitsTxt.Size = new System.Drawing.Size(64, 20);
            this.availUnitsTxt.TabIndex = 7;
            this.availUnitsTxt.Text = "0";
            this.availUnitsTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // availUnitsCombo
            // 
            this.availUnitsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availUnitsCombo.FormattingEnabled = true;
            this.availUnitsCombo.Location = new System.Drawing.Point(116, 167);
            this.availUnitsCombo.Name = "availUnitsCombo";
            this.availUnitsCombo.Size = new System.Drawing.Size(80, 21);
            this.availUnitsCombo.TabIndex = 8;
            this.availUnitsCombo.SelectedIndexChanged += new System.EventHandler(this.availUnitsCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "الوحدات المتاحة";
            // 
            // Gard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 230);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جرد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aqsat;
        private System.Windows.Forms.TextBox mo2damat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t5ses;
        private System.Windows.Forms.TextBox custNumperUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox availUnitsCombo;
        private System.Windows.Forms.TextBox availUnitsTxt;
        private System.Windows.Forms.Label label6;
    }
}