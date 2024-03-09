namespace bt
{
    partial class Menu
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
            this.buttonForm1 = new System.Windows.Forms.Button();
            this.buttonForm2 = new System.Windows.Forms.Button();
            this.buttonForm3 = new System.Windows.Forms.Button();
            this.buttonForm4 = new System.Windows.Forms.Button();
            this.buttonForm5 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForm1
            // 
            this.buttonForm1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonForm1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm1.Location = new System.Drawing.Point(51, 50);
            this.buttonForm1.Name = "buttonForm1";
            this.buttonForm1.Size = new System.Drawing.Size(154, 63);
            this.buttonForm1.TabIndex = 0;
            this.buttonForm1.Text = "Bài 1";
            this.buttonForm1.UseVisualStyleBackColor = false;
            this.buttonForm1.Click += new System.EventHandler(this.buttonForm1_Click);
            // 
            // buttonForm2
            // 
            this.buttonForm2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonForm2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm2.Location = new System.Drawing.Point(311, 111);
            this.buttonForm2.Name = "buttonForm2";
            this.buttonForm2.Size = new System.Drawing.Size(154, 63);
            this.buttonForm2.TabIndex = 1;
            this.buttonForm2.Text = "Bài 2";
            this.buttonForm2.UseVisualStyleBackColor = false;
            this.buttonForm2.Click += new System.EventHandler(this.buttonForm2_Click);
            // 
            // buttonForm3
            // 
            this.buttonForm3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonForm3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm3.Location = new System.Drawing.Point(568, 50);
            this.buttonForm3.Name = "buttonForm3";
            this.buttonForm3.Size = new System.Drawing.Size(154, 63);
            this.buttonForm3.TabIndex = 2;
            this.buttonForm3.Text = "Bài 3";
            this.buttonForm3.UseVisualStyleBackColor = false;
            this.buttonForm3.Click += new System.EventHandler(this.buttonForm3_Click);
            // 
            // buttonForm4
            // 
            this.buttonForm4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonForm4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm4.Location = new System.Drawing.Point(99, 218);
            this.buttonForm4.Name = "buttonForm4";
            this.buttonForm4.Size = new System.Drawing.Size(154, 63);
            this.buttonForm4.TabIndex = 3;
            this.buttonForm4.Text = "Bài 4";
            this.buttonForm4.UseVisualStyleBackColor = false;
            this.buttonForm4.Click += new System.EventHandler(this.buttonForm4_Click);
            // 
            // buttonForm5
            // 
            this.buttonForm5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonForm5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForm5.Location = new System.Drawing.Point(503, 218);
            this.buttonForm5.Name = "buttonForm5";
            this.buttonForm5.Size = new System.Drawing.Size(154, 63);
            this.buttonForm5.TabIndex = 4;
            this.buttonForm5.Text = "Bài 5";
            this.buttonForm5.UseVisualStyleBackColor = false;
            this.buttonForm5.Click += new System.EventHandler(this.buttonForm5_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(311, 328);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(153, 80);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonForm5);
            this.Controls.Add(this.buttonForm4);
            this.Controls.Add(this.buttonForm3);
            this.Controls.Add(this.buttonForm2);
            this.Controls.Add(this.buttonForm1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonForm1;
        private System.Windows.Forms.Button buttonForm2;
        private System.Windows.Forms.Button buttonForm3;
        private System.Windows.Forms.Button buttonForm4;
        private System.Windows.Forms.Button buttonForm5;
        private System.Windows.Forms.Button buttonExit;
    }
}