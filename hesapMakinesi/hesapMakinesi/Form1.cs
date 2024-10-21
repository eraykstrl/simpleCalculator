using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "+";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cosinus_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "cos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz İşlem" + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text += "tan";
        }

        private void cotanjant_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "cot";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz İşlem" + ex.Message);
            }
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "-";
        }

        private void carpma_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "x";
        }

        private void BOLME_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void sinus_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text += "sin";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz Giriş " + ex.Message);
            }
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            try
            {
                string input = richTextBox1.Text;

                if (!string.IsNullOrWhiteSpace(input) && !"+-*/".Contains(input[input.Length - 1]))
                {
                    // Trigonometrik fonksiyonları hesapla
                    input = TrigonometricFunction(input);

                    // Matematiksel işlemi gerçekleştir
                    string result = Calculate(input);
                    richTextBox1.Text = result;
                }
                else
                {
                    MessageBox.Show("Geçersiz İşlem: Operatörden sonra bir değer girmelisiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz İşlem: " + ex.Message);
            }
        }

        // Trigonometrik fonksiyonları hesaplayan ve girişteki veriyi dönüştüren fonksiyon
        private string TrigonometricFunction(string input)
        {
            // Sinüs hesaplama
            if (input.Contains("sin"))
            {
                input = HandleTrigFunction(input, "sin", Math.Sin);
            }

            // Cosinüs hesaplama
            if (input.Contains("cos"))
            {
                input = HandleTrigFunction(input, "cos", Math.Cos);
            }

            // Tanjant hesaplama
            if (input.Contains("tan"))
            {
                input = HandleTrigFunction(input, "tan", Math.Tan);
            }

            return input;
        }

        private string HandleTrigFunction(string input, string functionName, Func<double, double> trigFunc)
        {
            while (input.Contains(functionName))
            {
                string degreeValue = ExtractValue(input, functionName);
                if (!string.IsNullOrEmpty(degreeValue))
                {
                    double radians = (Math.PI / 180) * Convert.ToDouble(degreeValue);  // Dereceyi radyana çevir
                    double trigResult = trigFunc(radians);  // Trigonometrik sonucu hesapla
                    input = input.Replace(functionName + degreeValue, trigResult.ToString());  // Sonucu input içinde değiştir
                }
            }
            return input;
        }

        // İlgili trigonometrik fonksiyondan sonraki sayıyı ayıkla
        private string ExtractValue(string input, string functionName)
        {
            int index = input.IndexOf(functionName) + functionName.Length;
            string numara = "";

            for (int i = index; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) || input[i] == '.')
                {
                    numara += input[i];
                }
                else
                {
                    break;
                }
            }

            return numara;
        }

        // Hesaplama işlemini gerçekleştir
        private string Calculate(string veriler)
        {
            DataTable table = new DataTable();
            try
            {
                veriler = veriler.Replace("x", "*");  // Çarpma operatörünü düzelt
                var result = table.Compute(veriler, "");
                return result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçersiz İşlem: " + ex.Message);
                return "0";
            }
        }
    }
}
