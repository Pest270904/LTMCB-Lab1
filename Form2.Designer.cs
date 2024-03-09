namespace bt
{
    partial class Form2
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
            this.inputNum1TB = new System.Windows.Forms.TextBox();
            this.inputNum2TB = new System.Windows.Forms.TextBox();
            this.inputNum3TB = new System.Windows.Forms.TextBox();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.minTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTim = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNum1TB
            // 
            this.inputNum1TB.Location = new System.Drawing.Point(118, 73);
            this.inputNum1TB.Name = "inputNum1TB";
            this.inputNum1TB.Size = new System.Drawing.Size(108, 22);
            this.inputNum1TB.TabIndex = 0;
            // 
            // inputNum2TB
            // 
            this.inputNum2TB.Location = new System.Drawing.Point(343, 73);
            this.inputNum2TB.Name = "inputNum2TB";
            this.inputNum2TB.Size = new System.Drawing.Size(108, 22);
            this.inputNum2TB.TabIndex = 1;
            // 
            // inputNum3TB
            // 
            this.inputNum3TB.Location = new System.Drawing.Point(563, 73);
            this.inputNum3TB.Name = "inputNum3TB";
            this.inputNum3TB.Size = new System.Drawing.Size(108, 22);
            this.inputNum3TB.TabIndex = 2;
            // 
            // maxTB
            // 
            this.maxTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.maxTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxTB.Location = new System.Drawing.Point(229, 272);
            this.maxTB.Name = "maxTB";
            this.maxTB.ReadOnly = true;
            this.maxTB.Size = new System.Drawing.Size(100, 22);
            this.maxTB.TabIndex = 3;
            // 
            // minTB
            // 
            this.minTB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.minTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minTB.Location = new System.Drawing.Point(466, 272);
            this.minTB.Name = "minTB";
            this.minTB.ReadOnly = true;
            this.minTB.Size = new System.Drawing.Size(100, 22);
            this.minTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số thứ nhất:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số thứ hai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số thứ ba:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lớn nhất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số nhỏ nhất:";
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTim.Location = new System.Drawing.Point(118, 156);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(108, 50);
            this.buttonTim.TabIndex = 10;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonXoa.Location = new System.Drawing.Point(343, 156);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(108, 50);
            this.buttonXoa.TabIndex = 11;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonThoat.Location = new System.Drawing.Point(563, 156);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(108, 50);
            this.buttonThoat.TabIndex = 12;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(789, 378);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minTB);
            this.Controls.Add(this.maxTB);
            this.Controls.Add(this.inputNum3TB);
            this.Controls.Add(this.inputNum2TB);
            this.Controls.Add(this.inputNum1TB);
            this.Name = "Form2";
            this.Text = "Tìm số lớn nhất, nhỏ nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNum1TB;
        private System.Windows.Forms.TextBox inputNum2TB;
        private System.Windows.Forms.TextBox inputNum3TB;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThoat;
    }
}