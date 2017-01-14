namespace Mo7meen
{
    partial class TkhcesForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TkhcesForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t5sesTypeCombo = new System.Windows.Forms.ComboBox();
            this.t5sesValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.displayHideBtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T5SES_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.T5sesUsers = new Mo7meen.T5sesUsers();
            this.T5SES_TableAdapter = new Mo7meen.T5sesUsersTableAdapters.T5SES_TableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.T5sesUsersValid = new Mo7meen.T5sesUsersValid();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new Mo7meen.T5sesUsersValidTableAdapters.DataTable1TableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T5SES_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T5sesUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T5sesUsersValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t5sesTypeCombo);
            this.groupBox1.Controls.Add(this.t5sesValue);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات عملية التخصيص";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "وحدات التخصيص";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "مبلغ التخصيص";
            // 
            // t5sesTypeCombo
            // 
            this.t5sesTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t5sesTypeCombo.FormattingEnabled = true;
            this.t5sesTypeCombo.Location = new System.Drawing.Point(117, 22);
            this.t5sesTypeCombo.Name = "t5sesTypeCombo";
            this.t5sesTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.t5sesTypeCombo.TabIndex = 2;
            // 
            // t5sesValue
            // 
            this.t5sesValue.Location = new System.Drawing.Point(411, 26);
            this.t5sesValue.Name = "t5sesValue";
            this.t5sesValue.Size = new System.Drawing.Size(121, 20);
            this.t5sesValue.TabIndex = 1;
            this.t5sesValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "بدا العملية";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayHideBtn
            // 
            this.displayHideBtn.Location = new System.Drawing.Point(708, 12);
            this.displayHideBtn.Name = "displayHideBtn";
            this.displayHideBtn.Size = new System.Drawing.Size(114, 46);
            this.displayHideBtn.TabIndex = 7;
            this.displayHideBtn.Text = "مجتاز و غير مجتاز";
            this.displayHideBtn.UseVisualStyleBackColor = true;
            this.displayHideBtn.Click += new System.EventHandler(this.displayHideBtn_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "T5sesDataSet";
            reportDataSource1.Value = this.T5SES_TableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mo7meen.T5sesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 79);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(666, 540);
            this.reportViewer1.TabIndex = 8;
            this.reportViewer1.Visible = false;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // T5SES_TableBindingSource
            // 
            this.T5SES_TableBindingSource.DataMember = "T5SES_Table";
            this.T5SES_TableBindingSource.DataSource = this.T5sesUsers;
            // 
            // T5sesUsers
            // 
            this.T5sesUsers.DataSetName = "T5sesUsers";
            this.T5sesUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T5SES_TableAdapter
            // 
            this.T5SES_TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Mo7meen.T5sesReportValid.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 95);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(666, 524);
            this.reportViewer2.TabIndex = 9;
            this.reportViewer2.Visible = false;
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // T5sesUsersValid
            // 
            this.T5sesUsersValid.DataSetName = "T5sesUsersValid";
            this.T5sesUsersValid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.T5sesUsersValid;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // TkhcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 631);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.displayHideBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TkhcesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية التخصيص";
            this.Load += new System.EventHandler(this.TkhcesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T5SES_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T5sesUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T5sesUsersValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox t5sesTypeCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t5sesValue;
        private System.Windows.Forms.Button displayHideBtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource T5SES_TableBindingSource;
        private T5sesUsers T5sesUsers;
        private T5sesUsersTableAdapters.T5SES_TableAdapter T5SES_TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private T5sesUsersValid T5sesUsersValid;
        private T5sesUsersValidTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}