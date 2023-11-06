using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace Cryptography_Lab2
{
    internal class Shannon
    {
        public static string toBinary(double n)
        {
            if (n == 0.0)
                return "00000000000";
            if (n >= 1 || n < 0)
                return "ERROR";

            string answer;
            answer = "";

            while (n > 0)
            {
                double b = n * 2;
                if (b >= 1)
                {
                    answer += "1";
                    n = b - 1;
                }
                else
                {
                    answer += "0";
                    n = b;
                }
            }
            return answer;
        }

        public static List<KeyValuePair<string, double>> generate_assembly(ref List<string> alphabet,
            ref List<double> p)
        {
            List<KeyValuePair<string, double>> assembly = new List<KeyValuePair<string, double>>();

            for(int i = 0; i < alphabet.Count(); i++)
                assembly.Add(new KeyValuePair<string, double>(alphabet[i], p[i]));

            return assembly;

        }

        public static List<KeyValuePair<string, string>> generate_shannon_codes(ref List<string> alphabet, ref List<double> p)
        {
            List<KeyValuePair<string, double>> assembly;
            List<KeyValuePair<string, double>> bx = new List<KeyValuePair<string, double>>();
            List<KeyValuePair<string, string>> bins = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, int>> lx = new List<KeyValuePair<string, int>>();
            List<KeyValuePair<string, string>> codes = new List<KeyValuePair<string, string>>();

            assembly = generate_assembly(ref alphabet, ref p);

            assembly.Sort((a, b) => b.Value.CompareTo(a.Value));

            bx.Add(new KeyValuePair<string, double>(alphabet[0], 0.0));

            for (int i = 1; i < assembly.Count(); i++)
            {
                KeyValuePair<string, double> pair_to_be_pushed = new KeyValuePair<string, double>(assembly[i].Key, bx[i - 1].Value + assembly[i - 1].Value);
                bx.Add(pair_to_be_pushed);
            }

            for (int i = 0; i < bx.Count(); i++)
            {
                string bin_repr = toBinary(bx[i].Value);
                KeyValuePair<string, string> pair_to_be_pushed = new KeyValuePair<string, string>(bx[i].Key, bin_repr);
                bins.Add(pair_to_be_pushed);
            }

            for (int i = 0; i < assembly.Count(); i++)
            {
                int l_x = (int) Math.Ceiling(-Math.Log2(assembly[i].Value));
                KeyValuePair<string, int> pair_to_be_pushed = new KeyValuePair<string, int>(assembly[i].Key, l_x);
                lx.Add(pair_to_be_pushed);
            }

            for (int i = 0; i < assembly.Count(); i++)
            {
                string code = bins[i].Value.Substring(0, lx[i].Value);
                KeyValuePair<string, string> pair_to_be_pushed = new KeyValuePair<string, string>(assembly[i].Key, code);
                codes.Add(pair_to_be_pushed);
            }

            return codes;
        }

        public static double calculate_average_code_length(ref List<KeyValuePair<string, string>> codes)
        {
            int sum = 0;
            int n = codes.Count();

            foreach (KeyValuePair<string, string> code in codes)
                sum += code.Value.Length;

            return sum / n;
        }

        public static double entropy(ref List<KeyValuePair<string, double>> assembly)
        {
            double entropy = 0;
            foreach (KeyValuePair<string, double> el in assembly)
                entropy += el.Value * Math.Log2(el.Value);

            entropy = -entropy;
            return entropy;
        }

        public static double redundancy(ref List<KeyValuePair<string, double>> assembly, ref List<KeyValuePair<string, string>> codes)
        {
            double r = calculate_average_code_length(ref codes) - entropy(ref assembly);
            return r;
        }

        public static (bool, double) kraft_mcmillan_inequality_check(ref List<KeyValuePair<string, string>> codes)
        {
            double sum = 0;
            List<int> lx = new List<int>();

            foreach (KeyValuePair<string, string> code in codes)
                lx.Add(code.Value.Length);

            foreach (double l in lx)
                sum += Math.Pow(2, -l);

            return (sum <= 1, sum);
        }

        public static (double, double, string) calculate_properties(ref List<KeyValuePair<string, double>> assembly, ref List<KeyValuePair<string, string>> codes)
        {
            /*
            using (StreamWriter writer = new StreamWriter("properties.txt", false))
            {
                writer.WriteLine("Символ - код:");
                foreach (KeyValuePair<string, string> code in codes)
                    writer.WriteLine(code.Key + " - " + code.Value);
                writer.WriteLine();
                writer.WriteLine("Средняя длина кодового слова: " + calculate_average_code_length(ref codes));
                writer.WriteLine("Избыточность: " + redundancy(ref assembly));
                writer.WriteLine("Неравенство Крафта-Макмиллана " + (kraft_mcmillan_inequality_check(ref codes) ? "выполняется" : "не выполняется"));
            }
            */
            double avg_code_length = calculate_average_code_length(ref codes);
            double redundancy = Shannon.redundancy(ref assembly, ref codes);
            (bool, double) kraft_inequality = kraft_mcmillan_inequality_check(ref codes);
            string kraft_inequality_string = (kraft_inequality.Item1 ? "Выполняется" : "Не выполняется") + ": " + Convert.ToDouble(kraft_inequality.Item2) + (kraft_inequality.Item1 ? " <= 1" : " > 1");

            return (avg_code_length, redundancy, kraft_inequality_string);

        }

        public static List<string> encode(ref List<string> decoded_symbols, ref List<KeyValuePair<string, string>> codes)
        {
            List<string> encoded_symbols = new List<string>();

            foreach (string s in decoded_symbols)
            {
                string code = "";


                foreach (KeyValuePair<string, string> pair in codes)
                    if (pair.Key == s)
                    {
                        code = pair.Value;
                        break;
                    }

                encoded_symbols.Add(code);
            }
            
            using (StreamWriter writer = new StreamWriter("output.txt", false))
            {
                foreach (string s in encoded_symbols)
                    writer.WriteLine(s);
            }

            return encoded_symbols;
        }

        public static List<string> decode(ref List<string> encoded_symbols, ref List<KeyValuePair<string, string>> codes)
        {
            List<string> decoded_symbols = new List<string>();

            foreach (string s in encoded_symbols)
            {
                string symbol = "";

                foreach (KeyValuePair<string, string> pair in codes)
                    if (pair.Value == s)
                    {
                        symbol = pair.Key;
                        break;
                    }

                decoded_symbols.Add(symbol);
            }
            using (StreamWriter writer = new StreamWriter("output.txt", false))
            {
                foreach (string s in decoded_symbols)
                    writer.WriteLine(s);
            }

            return decoded_symbols;
        }
    }
}
