namespace Mo7meen
{
    partial class NewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewItem));
            this.button1 = new System.Windows.Forms.Button();
            this.area_text = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.Qest_type_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "أضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // area_text
            // 
            this.area_text.Location = new System.Drawing.Point(17, 27);
            this.area_text.Margin = new System.Windows.Forms.Padding(4);
            this.area_text.Name = "area_text";
            this.area_text.Size = new System.Drawing.Size(132, 22);
            this.area_text.TabIndex = 1;
            this.area_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(17, 57);
            this.price_txt.Margin = new System.Windows.Forms.Padding(4);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(132, 22);
            this.price_txt.TabIndex = 2;
            this.price_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Qest_type_text
            // 
            this.Qest_type_text.Location = new System.Drawing.Point(17, 87);
            this.Qest_type_text.Margin = new System.Windows.Forms.Padding(4);
            this.Qest_type_text.Name = "Qest_type_text";
            this.Qest_type_text.Size = new System.Drawing.Size(132, 22);
            this.Qest_type_text.TabIndex = 3;
            this.Qest_type_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "المساحة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "السعر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "نوع القسط";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.price_txt);
            this.groupBox1.Controls.Add(this.area_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Qest_type_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(296, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الوحده الجديدة";
            // 
            // NewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 185);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوع وحده جديده";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox area_text;
        private System.Windows.Forms.TextBox price_txt;
        private System.Windows.Forms.TextBox Qest_type_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}