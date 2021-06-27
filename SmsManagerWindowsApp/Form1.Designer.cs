
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
            this.ReaderServiceCurrentOpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReaderServiceErrorTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.StopReadServiceButton = new System.Windows.Forms.Button();
            this.ReadSmsServiceStatusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PortsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QueueNoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SentPhoneEditText = new System.Windows.Forms.TextBox();
            this.SentBodyEditText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadSmsServiceButton
            // 
            this.ReadSmsServiceButton.Location = new System.Drawing.Point(376, 20);
            this.ReadSmsServiceButton.Name = "ReadSmsServiceButton";
            this.ReadSmsServiceButton.Size = new System.Drawing.Size(188, 23);
            this.ReadSmsServiceButton.TabIndex = 0;
            this.ReadSmsServiceButton.Text = "اجرای سرویس";
            this.ReadSmsServiceButton.UseVisualStyleBackColor = true;
            this.ReadSmsServiceButton.Click += new System.EventHandler(this.ReadSmsServiceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReaderServiceCurrentOpLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ReaderServiceErrorTextBox);
            this.groupBox1.Controls.Add(this.Label4);
            this.groupBox1.Controls.Add(this.StopReadServiceButton);
            this.groupBox1.Controls.Add(this.ReadSmsServiceStatusLabel);
            this.groupBox1.Controls.Add(this.ReadSmsServiceButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(570, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "سرویس اس ام اس";
            // 
            // ReaderServiceCurrentOpLabel
            // 
            this.ReaderServiceCurrentOpLabel.Location = new System.Drawing.Point(6, 101);
            this.ReaderServiceCurrentOpLabel.Name = "ReaderServiceCurrentOpLabel";
            this.ReaderServiceCurrentOpLabel.Size = new System.Drawing.Size(336, 92);
            this.ReaderServiceCurrentOpLabel.TabIndex = 4;
            this.ReaderServiceCurrentOpLabel.Text = "-";
            this.ReaderServiceCurrentOpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(348, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 92);
            this.label2.TabIndex = 4;
            this.label2.Text = "عملیات فعلی";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReaderServiceErrorTextBox
            // 
            this.ReaderServiceErrorTextBox.Location = new System.Drawing.Point(6, 196);
            this.ReaderServiceErrorTextBox.Multiline = true;
            this.ReaderServiceErrorTextBox.Name = "ReaderServiceErrorTextBox";
            this.ReaderServiceErrorTextBox.Size = new System.Drawing.Size(336, 67);
            this.ReaderServiceErrorTextBox.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(348, 196);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(216, 67);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "خطا";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StopReadServiceButton
            // 
            this.StopReadServiceButton.Enabled = false;
            this.StopReadServiceButton.Location = new System.Drawing.Point(376, 49);
            this.StopReadServiceButton.Name = "StopReadServiceButton";
            this.StopReadServiceButton.Size = new System.Drawing.Size(188, 23);
            this.StopReadServiceButton.TabIndex = 3;
            this.StopReadServiceButton.Text = "توقف سرویس";
            this.StopReadServiceButton.UseVisualStyleBackColor = true;
            this.StopReadServiceButton.Click += new System.EventHandler(this.StopReadServiceButton_Click);
            // 
            // ReadSmsServiceStatusLabel
            // 
            this.ReadSmsServiceStatusLabel.Location = new System.Drawing.Point(6, 21);
            this.ReadSmsServiceStatusLabel.Name = "ReadSmsServiceStatusLabel";
            this.ReadSmsServiceStatusLabel.Size = new System.Drawing.Size(364, 51);
            this.ReadSmsServiceStatusLabel.TabIndex = 3;
            this.ReadSmsServiceStatusLabel.Text = "متوقف";
            this.ReadSmsServiceStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PortsTextBox);
            this.groupBox2.Location = new System.Drawing.Point(588, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(200, 269);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "پورت های موجود";
            // 
            // PortsTextBox
            // 
            this.PortsTextBox.Location = new System.Drawing.Point(6, 21);
            this.PortsTextBox.Multiline = true;
            this.PortsTextBox.Name = "PortsTextBox";
            this.PortsTextBox.Size = new System.Drawing.Size(188, 242);
            this.PortsTextBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SentBodyEditText);
            this.groupBox3.Controls.Add(this.SentPhoneEditText);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.QueueNoLabel);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(18, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(770, 132);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "افزودن پیام جهت ارسال";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "پیام های در صف";
            // 
            // QueueNoLabel
            // 
            this.QueueNoLabel.AutoSize = true;
            this.QueueNoLabel.Location = new System.Drawing.Point(631, 34);
            this.QueueNoLabel.Name = "QueueNoLabel";
            this.QueueNoLabel.Size = new System.Drawing.Size(13, 15);
            this.QueueNoLabel.TabIndex = 1;
            this.QueueNoLabel.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "افزودن";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "شماره :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "متن :";
            // 
            // SentPhoneEditText
            // 
            this.SentPhoneEditText.Location = new System.Drawing.Point(87, 20);
            this.SentPhoneEditText.Name = "SentPhoneEditText";
            this.SentPhoneEditText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SentPhoneEditText.Size = new System.Drawing.Size(249, 23);
            this.SentPhoneEditText.TabIndex = 5;
            this.SentPhoneEditText.Text = "+98";
            this.SentPhoneEditText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SentBodyEditText
            // 
            this.SentBodyEditText.Location = new System.Drawing.Point(87, 50);
            this.SentBodyEditText.Multiline = true;
            this.SentBodyEditText.Name = "SentBodyEditText";
            this.SentBodyEditText.Size = new System.Drawing.Size(249, 76);
            this.SentBodyEditText.TabIndex = 6;
            this.SentBodyEditText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "برنامه مدیریت اس ام اس";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReadSmsServiceButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ReadSmsServiceStatusLabel;
        private System.Windows.Forms.Button StopReadServiceButton;
        private System.Windows.Forms.TextBox ReaderServiceErrorTextBox;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox PortsTextBox;
        private System.Windows.Forms.Label ReaderServiceCurrentOpLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label QueueNoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SentBodyEditText;
        private System.Windows.Forms.TextBox SentPhoneEditText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

