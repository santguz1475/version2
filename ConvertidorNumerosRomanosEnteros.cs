using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version2
{
    public partial class ConvertidorNumerosRomanosEnteros : Form
    {
        public ConvertidorNumerosRomanosEnteros()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string numeroRomano = txtRomano.Text.ToUpper();

            Dictionary<char, int> diccionario = new Dictionary<char, int>();
            diccionario.Add('I', 1);
            diccionario.Add('V', 5);
            diccionario.Add('X', 10);
            diccionario.Add('L', 50);
            diccionario.Add('C', 100);
            diccionario.Add('D', 500);
            diccionario.Add('M', 1000);

            int num = 0;
            int i = 0;

            while (i < numeroRomano.Length)
            {
                int valor1 = diccionario[numeroRomano[i]];
                if (i + 1 < numeroRomano.Length)
                {
                    int valor2 = diccionario[numeroRomano[i + 1]];
                    if (valor1 >= valor2)
                    {
                        num = num + valor1;
                        i = i + 1;
                    }
                    else
                    {
                        num = num + valor2 - valor1;
                        i = i + 2;
                    }
                }
                else
                {
                    num = num + valor1;
                    i = i + 1;
                }
            }

            lblResultado.Text = num.ToString();
        }
    }
}
