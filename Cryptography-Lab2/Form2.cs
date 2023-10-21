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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> sequence = richTextBox1.Text.Split(" ").ToList();
            List<string> alphabet = textBox1.Text.Split(" ").ToList();
            List<double> p_s = textBox2.Text.Split(" ").Select(Double.Parse).ToList();

            List<KeyValuePair<string, string>> codes = Shannon.generate_shannon_codes(ref alphabet, ref p_s);

            List<string> encoded = Shannon.encode(ref sequence, ref codes);

            richTextBox2.Text = String.Join(" ", encoded);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<string> alphabet = textBox1.Text.Split(" ").ToList();
            List<double> p_s = textBox2.Text.Split(" ").Select(Double.Parse).ToList();

            List<KeyValuePair<string, string>> codes = Shannon.generate_shannon_codes(ref alphabet, ref p_s);

            List<KeyValuePair<string, double>> assembly = Shannon.generate_assembly(ref alphabet, ref p_s);

            (int, double, string) props = Shannon.calculate_properties(ref assembly, ref codes);

            textBox3.Text = Convert.ToString(props.Item1);
            textBox4.Text = Convert.ToString(props.Item2);
            textBox5.Text = Convert.ToString(props.Item3);

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
