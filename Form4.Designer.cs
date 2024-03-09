namespace bt
{
    partial class Form4
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
            this.base2CB = new System.Windows.Forms.ComboBox();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.ansTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.base1CB = new System.Windows.Forms.ComboBox();
            this.buttonThucHien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // base2CB
            // 
            this.base2CB.FormattingEnabled = true;
            this.base2CB.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.base2CB.Location = new System.Drawing.Point(421, 77);
            this.base2CB.Name = "base2CB";
            this.base2CB.Size = new System.Drawing.Size(174, 24);
            this.base2CB.TabIndex = 1;
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(137, 50);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(458, 22);
            this.inputTB.TabIndex = 3;
            // 
            // ansTB
            // 
            this.ansTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ansTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ansTB.Location = new System.Drawing.Point(166, 258);
            this.ansTB.Name = "ansTB";
            this.ansTB.ReadOnly = true;
            this.ansTB.Size = new System.Drawing.Size(458, 22);
            this.ansTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập một số:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sang:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả:";
            // 
            // base1CB
            // 
            this.base1CB.FormattingEnabled = true;
            this.base1CB.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.base1CB.Location = new System.Drawing.Point(137, 77);
            this.base1CB.Name = "base1CB";
            this.base1CB.Size = new System.Drawing.Size(174, 24);
            this.base1CB.TabIndex = 10;
            // 
            // buttonThucHien
            // 
            this.buttonThucHien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThucHien.Location = new System.Drawing.Point(137, 127);
            this.buttonThucHien.Name = "buttonThucHien";
            this.buttonThucHien.Size = new System.Drawing.Size(458, 32);
            this.buttonThucHien.TabIndex = 11;
            this.buttonThucHien.Text = "Thực hiện";
            this.buttonThucHien.UseVisualStyleBackColor = false;
            this.buttonThucHien.Click += new System.EventHandler(this.buttonThucHien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonThucHien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.base1CB);
            this.groupBox1.Controls.Add(this.base2CB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 198);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXoa.Location = new System.Drawing.Point(209, 299);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(104, 45);
            this.buttonXoa.TabIndex = 14;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThoat.Location = new System.Drawing.Point(362, 299);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(104, 45);
            this.buttonThoat.TabIndex = 15;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(706, 375);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.ansTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form4";
            this.Text = "Convert Bin, Dec, Hex";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox base2CB;
        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.TextBox ansTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox base1CB;
        private System.Windows.Forms.Button buttonThucHien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
    }
}