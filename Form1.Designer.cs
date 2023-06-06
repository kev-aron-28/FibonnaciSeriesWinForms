namespace Series
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SetStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(200, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get next in Fibonacci";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(200, 246);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(168, 39);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 4;
            // 
            // SetStart
            // 
            this.SetStart.Location = new System.Drawing.Point(200, 132);
            this.SetStart.Name = "SetStart";
            this.SetStart.Size = new System.Drawing.Size(168, 40);
            this.SetStart.TabIndex = 5;
            this.SetStart.Text = "Set Start of Series";
            this.SetStart.UseVisualStyleBackColor = true;
            this.SetStart.Click += new System.EventHandler(this.SetStartSeries);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SetStart;
    }
}