using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NumberSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            string s1 = "Raqamlari yig'indisi=";
            string s2 = "Raqamlari ko'paytmasi=";

            try
            {
                BigInteger n = BigInteger.Parse(textBox1.Text);
                richTextBox1.Text += (s1 + Sum(n).ToString() + "\n");
                richTextBox1.Text += (s2 + Mul(n).ToString() + "\n");
            }
            catch
            {
                MessageBox.Show("Faqat Son kiritish kerak", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private BigInteger Sum(BigInteger n)
        {
            BigInteger sum = 0;
            string s = n.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i] - '0';
            }
            return sum;
        }
        private BigInteger Mul(BigInteger n)
        {
            BigInteger mul = 1;
            string s = n.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                mul *= s[i] - '0';
            }
            return mul;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
