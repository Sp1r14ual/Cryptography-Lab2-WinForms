using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_Lab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> sequence = new List<string>();
            List<string> alphabet = new List<string>();
            List<double> p_s = new List<double>();

            try
            {
                //Проверка файла с алфавитом
                if (checkBox1.Checked)
                {
                    using (StreamReader reader = new StreamReader(textBox1.Text))
                    {
                        while (!reader.EndOfStream)
                            alphabet.Add(reader.ReadLine());
                    }
                }
                else
                    alphabet = textBox1.Text.Split(" ").ToList();

                //проверка файла с вероятностями
                if (checkBox2.Checked)
                {
                    using (StreamReader reader = new StreamReader(textBox2.Text))
                    {
                        while (!reader.EndOfStream)
                            p_s.Add(Convert.ToDouble(reader.ReadLine()));
                    }
                }
                else
                    p_s = textBox2.Text.Split(" ").Select(Double.Parse).ToList();

                //проверка файла с последовательностью
                if (checkBox3.Checked)
                {
                    using (StreamReader reader = new StreamReader(richTextBox1.Text))
                    {
                        while (!reader.EndOfStream)
                            sequence.Add(reader.ReadLine());
                    }
                }
                else
                    sequence = richTextBox1.Text.Split(" ").ToList();

                //проверка на пустоту
                if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
                    throw new Exception("Одно или несколько полей пусто");

                //проверка на равенство набора символов и вероятностей
                if (alphabet.Count() != p_s.Count())
                    throw new Exception("Алфавит не соответствует набору вероятностей");

                //проверка алфавита
                foreach (string s in alphabet)
                {
                    if (s.Length > 1 || !Char.IsLetter(Convert.ToChar(s)))
                        throw new Exception("Один или несколько символов алфавита некорректны");
                }

                //проверка поля с последовательностью
                foreach (string s in sequence)
                    foreach (char c in s)
                        if (!(c == '0' || c == '1' || c == ' '))
                            throw new Exception("Один или несколько символов последовательности некорректны");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<KeyValuePair<string, string>> codes = Shannon.generate_shannon_codes(ref alphabet, ref p_s);

            List<string> decoded = Shannon.decode(ref sequence, ref codes);

            richTextBox2.Text = String.Join(" ", decoded);

            MessageBox.Show("Декодированная последовательность сохранена в файл output.txt", "Уведомление",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    private void button2_Click(object sender, EventArgs e)
        {
            List<string> alphabet = new List<string>();
            List<double> p_s = new List<double>();

            try
            {
                //Проверка файла с алфавитом
                if (checkBox1.Checked)
                {
                    using (StreamReader reader = new StreamReader(textBox1.Text))
                    {
                        while (!reader.EndOfStream)
                            alphabet.Add(reader.ReadLine());
                    }
                }
                else
                    alphabet = textBox1.Text.Split(" ").ToList();

                //проверка файла с вероятностями
                if (checkBox2.Checked)
                {
                    using (StreamReader reader = new StreamReader(textBox2.Text))
                    {
                        while (!reader.EndOfStream)
                            p_s.Add(Convert.ToDouble(reader.ReadLine()));
                    }
                }
                else
                    p_s = textBox2.Text.Split(" ").Select(Double.Parse).ToList();

                //проверка на пустоту
                if (alphabet.Count() == 0 || p_s.Count() == 0)
                    throw new Exception("Одно или несколько полей пусто");

                //проверка на равенство набора символов и вероятностей
                if (alphabet.Count() != p_s.Count())
                    throw new Exception("Алфавит не соответствует набору вероятностей");

                //проверка алфавита
                foreach (string s in alphabet)
                {
                    if (s.Length > 1 || !Char.IsLetter(Convert.ToChar(s)))
                        throw new Exception("Один или несколько символов алфавита некорректны");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<KeyValuePair<string, string>> codes = Shannon.generate_shannon_codes(ref alphabet, ref p_s);

            List<KeyValuePair<string, double>> assembly = Shannon.generate_assembly(ref alphabet, ref p_s);

            (int, double, string) props = Shannon.calculate_properties(ref assembly, ref codes);

            string code_words = "";

            foreach (KeyValuePair<string, string> code in codes)
                code_words += code.Key + " - " + code.Value + "\n";

            textBox3.Text = Convert.ToString(props.Item1);
            textBox4.Text = Convert.ToString(props.Item2);
            textBox5.Text = Convert.ToString(props.Item3);
            richTextBox3.Text = code_words;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
