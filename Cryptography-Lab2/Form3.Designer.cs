﻿namespace Cryptography_Lab2
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button4 = new Button();
            label4 = new Label();
            richTextBox2 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 61);
            label1.Name = "label1";
            label1.Size = new Size(359, 28);
            label1.TabIndex = 1;
            label1.Text = "Символы алфавита (через пробел)";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(106, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 34);
            textBox1.TabIndex = 2;
            textBox1.Text = "a b c d e f";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(106, 176);
            label2.Name = "label2";
            label2.Size = new Size(506, 28);
            label2.TabIndex = 3;
            label2.Text = "Вероятности появления символов (через пробел)";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(106, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 30);
            textBox2.TabIndex = 4;
            textBox2.Text = "0,10 0,20 0,10 0,10 0,35 0,15";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(106, 283);
            button2.Name = "button2";
            button2.Size = new Size(217, 40);
            button2.TabIndex = 17;
            button2.Text = "Вычислить характеристики";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(329, 283);
            button3.Name = "button3";
            button3.Size = new Size(141, 40);
            button3.TabIndex = 18;
            button3.Text = "Сброс";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(106, 402);
            label5.Name = "label5";
            label5.Size = new Size(319, 28);
            label5.TabIndex = 19;
            label5.Text = "Средняя длина кодового слова";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(106, 433);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(106, 487);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 21;
            label6.Text = "Избыточность";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(106, 518);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(319, 27);
            textBox4.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(106, 571);
            label7.Name = "label7";
            label7.Size = new Size(217, 28);
            label7.TabIndex = 23;
            label7.Text = "Неравенство Крафта";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(106, 602);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(319, 27);
            textBox5.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(874, 61);
            label3.Name = "label3";
            label3.Size = new Size(372, 28);
            label3.TabIndex = 25;
            label3.Text = "Текст, подлежащий декодированию";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(778, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(511, 174);
            richTextBox1.TabIndex = 26;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(874, 283);
            button1.Name = "button1";
            button1.Size = new Size(141, 40);
            button1.TabIndex = 27;
            button1.Text = "Декодировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1021, 283);
            button4.Name = "button4";
            button4.Size = new Size(141, 40);
            button4.TabIndex = 28;
            button4.Text = "Сброс";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(923, 382);
            label4.Name = "label4";
            label4.Size = new Size(243, 28);
            label4.TabIndex = 29;
            label4.Text = "Декодированный текст";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(778, 433);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(511, 174);
            richTextBox2.TabIndex = 30;
            richTextBox2.Text = "";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 753);
            Controls.Add(richTextBox2);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Декодировать сообщение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button4;
        private Label label4;
        private RichTextBox richTextBox2;
    }
}