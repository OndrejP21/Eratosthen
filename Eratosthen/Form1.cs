using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Eratosthen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnGo_Click(object sender, EventArgs e)
        {
            Eratosthen eratosthen = new Eratosthen();
            List<string> primes = eratosthen.GetPrimes((int)_numMax.Value);

            string numbers = string.Empty;

            for (int i = 0; i < primes.Count; i++)
            {
                numbers += primes[i] + " ";
            }

            MessageBox.Show(numbers);
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {


            if (File.Exists("primes.txt"))
            {
                File.Delete("primes.txt");

            }

            var s = File.Create("primes.txt");
            s.Close();
            Eratosthen eratosthen = new Eratosthen();
            List<string> primes = eratosthen.GetPrimes((int)_numMax.Value);

            File.WriteAllLines("primes.txt", primes.ToArray());

            MessageBox.Show("Vše v pořádku!");


        }
    }
}
