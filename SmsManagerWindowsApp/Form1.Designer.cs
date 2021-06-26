
namespace SmsManagerWindowsApp
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
            this.ReadSmsServiceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StopReadServiceButton = new System.Windows.Forms.Button();
            this.ReadSmsServiceStatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadSmsServiceButton
            // 
            this.ReadSmsServiceButton.Location = new System.Drawing.Point(6, 22);
            this.ReadSmsServiceButton.Name = "ReadSmsServiceButton";
            this.ReadSmsServiceButton.Size = new System.Drawing.Size(188, 23);
            this.ReadSmsServiceButton.TabIndex = 0;
            this.ReadSmsServiceButton.Text = "اجرا ی سرویس";
            this.ReadSmsServiceButton.UseVisualStyleBackColor = true;
            this.ReadSmsServiceButton.Click += new System.EventHandler(this.ReadSmsServiceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StopReadServiceButton);
            this.groupBox1.Controls.Add(this.ReadSmsServiceStatusLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ReadSmsServiceButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سرویس خواندن اس ام اس";
            // 
            // StopReadServiceButton
            // 
            this.StopReadServiceButton.Location = new System.Drawing.Point(6, 51);
            this.StopReadServiceButton.Name = "StopReadServiceButton";
            this.StopReadServiceButton.Size = new System.Drawing.Size(188, 23);
            this.StopReadServiceButton.TabIndex = 3;
            this.StopReadServiceButton.Text = "توقف سرویس";
            this.StopReadServiceButton.UseVisualStyleBackColor = true;
            this.StopReadServiceButton.Click += new System.EventHandler(this.StopReadServiceButton_Click);
            // 
            // ReadSmsServiceStatusLabel
            // 
            this.ReadSmsServiceStatusLabel.AutoSize = true;
            this.ReadSmsServiceStatusLabel.Location = new System.Drawing.Point(29, 97);
            this.ReadSmsServiceStatusLabel.Name = "ReadSmsServiceStatusLabel";
            this.ReadSmsServiceStatusLabel.Size = new System.Drawing.Size(12, 15);
            this.ReadSmsServiceStatusLabel.TabIndex = 3;
            this.ReadSmsServiceStatusLabel.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "وضعیت اجرا";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadSmsServiceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ReadSmsServiceStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopReadServiceButton;
    }
}

