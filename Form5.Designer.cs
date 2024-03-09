namespace bt
{
    partial class Form5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.avgTB = new System.Windows.Forms.TextBox();
            this.maxScoreTB = new System.Windows.Forms.TextBox();
            this.minScoreTB = new System.Windows.Forms.TextBox();
            this.finalTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.failTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm quản lý điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách điểm:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(556, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(600, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Xuất";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 210);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(681, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách môn học và điểm";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(17, 27);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(644, 269);
            this.textBox2.TabIndex = 0;
            // 
            // avgTB
            // 
            this.avgTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.avgTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avgTB.Location = new System.Drawing.Point(36, 544);
            this.avgTB.Name = "avgTB";
            this.avgTB.Size = new System.Drawing.Size(339, 20);
            this.avgTB.TabIndex = 1;
            // 
            // maxScoreTB
            // 
            this.maxScoreTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.maxScoreTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxScoreTB.Location = new System.Drawing.Point(36, 582);
            this.maxScoreTB.Name = "maxScoreTB";
            this.maxScoreTB.Size = new System.Drawing.Size(339, 20);
            this.maxScoreTB.TabIndex = 11;
            // 
            // minScoreTB
            // 
            this.minScoreTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.minScoreTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minScoreTB.Location = new System.Drawing.Point(36, 626);
            this.minScoreTB.Name = "minScoreTB";
            this.minScoreTB.Size = new System.Drawing.Size(339, 20);
            this.minScoreTB.TabIndex = 12;
            // 
            // finalTB
            // 
            this.finalTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.finalTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalTB.Location = new System.Drawing.Point(379, 544);
            this.finalTB.Name = "finalTB";
            this.finalTB.Size = new System.Drawing.Size(339, 20);
            this.finalTB.TabIndex = 13;
            // 
            // passTB
            // 
            this.passTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.passTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTB.Location = new System.Drawing.Point(379, 582);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(339, 20);
            this.passTB.TabIndex = 14;
            // 
            // failTB
            // 
            this.failTB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.failTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.failTB.Location = new System.Drawing.Point(379, 626);
            this.failTB.Name = "failTB";
            this.failTB.Size = new System.Drawing.Size(339, 20);
            this.failTB.TabIndex = 15;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(778, 710);
            this.Controls.Add(this.failTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.finalTB);
            this.Controls.Add(this.minScoreTB);
            this.Controls.Add(this.maxScoreTB);
            this.Controls.Add(this.avgTB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Quản lý điểm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox avgTB;
        private System.Windows.Forms.TextBox maxScoreTB;
        private System.Windows.Forms.TextBox minScoreTB;
        private System.Windows.Forms.TextBox finalTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox failTB;
    }
}