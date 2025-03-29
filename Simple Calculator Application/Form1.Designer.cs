namespace Simple_Calculator_Application
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
            this.txtnumber1 = new System.Windows.Forms.NumericUpDown();
            this.txtnumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(710, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "عدد اول:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "عدد دوم:";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(105, 37);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(570, 28);
            this.txtnumber1.TabIndex = 1;
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(105, 83);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(570, 28);
            this.txtnumber2.TabIndex = 1;
            // 
            // btnplus
            // 
            this.btnplus.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnplus.Location = new System.Drawing.Point(134, 138);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(124, 51);
            this.btnplus.TabIndex = 2;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnminus
            // 
            this.btnminus.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnminus.Location = new System.Drawing.Point(263, 138);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(124, 51);
            this.btnminus.TabIndex = 2;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnmultiple
            // 
            this.btnmultiple.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnmultiple.Location = new System.Drawing.Point(392, 138);
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.Size = new System.Drawing.Size(124, 51);
            this.btnmultiple.TabIndex = 2;
            this.btnmultiple.Text = "*";
            this.btnmultiple.UseVisualStyleBackColor = true;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // btndivide
            // 
            this.btndivide.ForeColor = System.Drawing.Color.DarkBlue;
            this.btndivide.Location = new System.Drawing.Point(521, 138);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(124, 51);
            this.btndivide.TabIndex = 2;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = true;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(886, 231);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ماشین حساب من";
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtnumber1;
        private System.Windows.Forms.NumericUpDown txtnumber2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Button btndivide;
    }
}

