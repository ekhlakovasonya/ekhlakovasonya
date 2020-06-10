using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hacking
{
    public partial class Form1 : Form
    {
        private int p { get; set; }
        private int g { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        public Form1()
        {
            InitializeComponent();
            InitKeys();
        }

       

        private void InputedText_TextChanged(object sender, EventArgs e)
        {
            FillFields();
        }

        private void Crypt(int p, int g, int y, string strIn) //Шифрование
        {
            
            CryptedText.Text = "";


            var sb = new StringBuilder();

            foreach (var t in strIn)
            {
                
              var m = Convert.ToInt32(t);
               if (m <= 0) continue;
                
                var k = Numbers.Rand(1, p - 1);
                var a = Numbers.Power(g, k, p);
                var b = Numbers.Mul(Numbers.Power(y, k, p), m, p);
                
                sb.Append($"{a} {b} ");
            }
            
            CryptedText.Text = sb.ToString();
        }

        private void Decrypt(int p, int x, string strIn)    //дешифрование 
        {
           

            DecryptedText.Text = "";
            if (strIn.Length > 0)
            {
                var sb = new StringBuilder();
                var crypted = strIn.Trim().Split(' ').Select(int.Parse).ToArray();

                for (var i = 0; i < crypted.Length - 1; i += 2)
                {
                    var a = crypted[i];
                    var b = crypted[i + 1];

                    if ((a == 0) || (b == 0)) continue;

                    var deM = Numbers.Mul(b, Numbers.Power(a, p - 1 - x, p),p); // m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p - трудно было  найти нормальную формулу, в ней вся загвоздка
                    Console.WriteLine(deM);
                    sb.Append(Convert.ToChar(deM));
                }

                DecryptedText.Text = sb.ToString();
                return;
            }

            DecryptedText.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            if (checkBox1.Checked)
            {
                CryptedText.Text = fileText;
            }
            else
            {
               InputedText.Text = fileText;
            }
            
            MessageBox.Show("Файл открыт");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            if (checkBox1.Checked)
            {
                System.IO.File.WriteAllText(filename, DecryptedText.Text);
            }
            else    // сохраняем текст в файл
            { System.IO.File.WriteAllText(filename, CryptedText.Text); }
            MessageBox.Show("Файл сохранен");
        }

        private void CryptedText_TextChanged(object sender, EventArgs e)
        {
            var strOut = CryptedText.Text;
            Decrypt(p, x, strOut);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitKeys();
        }

        private void InitKeys()
        {
            p = Numbers.GetNextPrimeAfter(1423,2000);
            g = Numbers.GetPRoot(p);
            x = Numbers.Rand(1, p - 1);
            y = Numbers.Power(g, x, p);

            txtBPublicKey.Text = $"Открытый ключ (p,g,y) = ( {p}, {g}, {y})";
            txtBSecretKey.Text = $"Закрытый ключ x = {x}";

            FillFields();
        }

        private void FillFields()
        {
            var strIn = InputedText.Text;
            Crypt(p, g, y, strIn);
            var strOut = CryptedText.Text;
            Decrypt(p, x, strOut);
        }

    }
}