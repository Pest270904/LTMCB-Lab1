namespace bt
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputNum2TB = new System.Windows.Forms.TextBox();
            this.inputNum1TB = new System.Windows.Forms.TextBox();
            this.ansTB = new System.Windows.Forms.TextBox();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ hai:";
            // 
            // inputNum2TB
            // 
            this.inputNum2TB.Location = new System.Drawing.Point(454, 58);
            this.inputNum2TB.Name = "inputNum2TB";
            this.inputNum2TB.Size = new System.Drawing.Size(96, 22);
            this.inputNum2TB.TabIndex = 2;
            // 
            // inputNum1TB
            // 
            this.inputNum1TB.Location = new System.Drawing.Point(105, 58);
            this.inputNum1TB.Name = "inputNum1TB";
            this.inputNum1TB.Size = new System.Drawing.Size(96, 22);
            this.inputNum1TB.TabIndex = 3;
            // 
            // ansTB
            // 
            this.ansTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ansTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ansTB.Location = new System.Drawing.Point(278, 248);
            this.ansTB.Name = "ansTB";
            this.ansTB.ReadOnly = true;
            this.ansTB.Size = new System.Drawing.Size(100, 22);
            this.ansTB.TabIndex = 4;
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXoa.Location = new System.Drawing.Point(105, 144);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(96, 37);
            this.buttonXoa.TabIndex = 5;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonTinh
            // 
            this.buttonTinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTinh.Location = new System.Drawing.Point(278, 144);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(96, 37);
            this.buttonTinh.TabIndex = 6;
            this.buttonTinh.Text = "Tính";
            this.buttonTinh.UseVisualStyleBackColor = false;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThoat.Location = new System.Drawing.Point(454, 144);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(96, 37);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(615, 333);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.ansTB);
            this.Controls.Add(this.inputNum1TB);
            this.Controls.Add(this.inputNum2TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tính tổng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputNum2TB;
        private System.Windows.Forms.TextBox inputNum1TB;
        private System.Windows.Forms.TextBox ansTB;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label3;
    }
}

