
namespace BaBot
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.captureScreenBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mouseXLabel = new System.Windows.Forms.Label();
            this.mouseYLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // captureScreenBtn
            // 
            this.captureScreenBtn.Location = new System.Drawing.Point(338, 33);
            this.captureScreenBtn.Name = "captureScreenBtn";
            this.captureScreenBtn.Size = new System.Drawing.Size(109, 26);
            this.captureScreenBtn.TabIndex = 0;
            this.captureScreenBtn.Text = "จับภาพหน้าจอ";
            this.captureScreenBtn.UseVisualStyleBackColor = true;
            this.captureScreenBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 26);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 124);
            this.button1.TabIndex = 3;
            this.button1.Text = "B";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 124);
            this.button2.TabIndex = 4;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 26);
            this.button3.TabIndex = 5;
            this.button3.Text = "Auto click";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mouseXLabel
            // 
            this.mouseXLabel.AutoSize = true;
            this.mouseXLabel.Location = new System.Drawing.Point(59, 118);
            this.mouseXLabel.Name = "mouseXLabel";
            this.mouseXLabel.Size = new System.Drawing.Size(0, 19);
            this.mouseXLabel.TabIndex = 6;
            // 
            // mouseYLabel
            // 
            this.mouseYLabel.AutoSize = true;
            this.mouseYLabel.Location = new System.Drawing.Point(156, 118);
            this.mouseYLabel.Name = "mouseYLabel";
            this.mouseYLabel.Size = new System.Drawing.Size(45, 19);
            this.mouseYLabel.TabIndex = 7;
            this.mouseYLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.mouseYLabel);
            this.Controls.Add(this.mouseXLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captureScreenBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button captureScreenBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label mouseXLabel;
        private System.Windows.Forms.Label mouseYLabel;
    }
}

