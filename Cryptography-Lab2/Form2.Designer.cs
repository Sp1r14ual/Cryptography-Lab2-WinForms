namespace Cryptography_Lab2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            label4 = new Label();
            richTextBox2 = new RichTextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label8 = new Label();
            richTextBox3 = new RichTextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(106, 61);
            label1.Name = "label1";
            label1.Size = new Size(359, 28);
            label1.TabIndex = 0;
            label1.Text = "Символы алфавита (через пробел)";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(106, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "a b c d e f";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(106, 182);
            label2.Name = "label2";
            label2.Size = new Size(506, 28);
            label2.TabIndex = 2;
            label2.Text = "Вероятности появления символов (через пробел)";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(106, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(266, 34);
            textBox2.TabIndex = 3;
            textBox2.Text = "0,10 0,20 0,10 0,10 0,35 0,15";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1032, 61);
            label3.Name = "label3";
            label3.Size = new Size(349, 28);
            label3.TabIndex = 5;
            label3.Text = "Текст, подлежащий кодированию";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(934, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(511, 174);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(934, 313);
            button1.Name = "button1";
            button1.Size = new Size(141, 40);
            button1.TabIndex = 7;
            button1.Text = "Закодировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1075, 429);
            label4.Name = "label4";
            label4.Size = new Size(238, 28);
            label4.TabIndex = 8;
            label4.Text = "Закодированный текст";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(934, 469);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(511, 174);
            richTextBox2.TabIndex = 9;
            richTextBox2.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(106, 402);
            label5.Name = "label5";
            label5.Size = new Size(319, 28);
            label5.TabIndex = 10;
            label5.Text = "Средняя длина кодового слова";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(106, 433);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(319, 27);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(106, 487);
            label6.Name = "label6";
            label6.Size = new Size(153, 28);
            label6.TabIndex = 12;
            label6.Text = "Избыточность";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(106, 518);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(319, 27);
            textBox4.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(106, 571);
            label7.Name = "label7";
            label7.Size = new Size(217, 28);
            label7.TabIndex = 14;
            label7.Text = "Неравенство Крафта";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox5.Location = new Point(106, 602);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(319, 27);
            textBox5.TabIndex = 15;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(106, 313);
            button2.Name = "button2";
            button2.Size = new Size(217, 40);
            button2.TabIndex = 16;
            button2.Text = "Вычислить характеристики";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(329, 313);
            button3.Name = "button3";
            button3.Size = new Size(141, 40);
            button3.TabIndex = 17;
            button3.Text = "Сброс";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(1081, 313);
            button4.Name = "button4";
            button4.Size = new Size(141, 40);
            button4.TabIndex = 18;
            button4.Text = "Сброс";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(106, 668);
            label8.Name = "label8";
            label8.Size = new Size(163, 28);
            label8.TabIndex = 19;
            label8.Text = "Кодовые слова";
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox3.Location = new Point(106, 699);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(511, 174);
            richTextBox3.TabIndex = 20;
            richTextBox3.Text = "";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(106, 142);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Ввод из файла";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(106, 260);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(132, 24);
            checkBox2.TabIndex = 22;
            checkBox2.Text = "Ввод из файла";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(934, 282);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 24);
            checkBox3.TabIndex = 23;
            checkBox3.Text = "Ввод из файла";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 953);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(richTextBox3);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(richTextBox2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Закодировать сообщение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Label label4;
        private RichTextBox richTextBox2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label8;
        private RichTextBox richTextBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}