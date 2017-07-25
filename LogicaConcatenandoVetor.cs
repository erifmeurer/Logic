using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] retornaVetor()
        {
            string[] A = { "1", "2", "3" };
            return A;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] B = { "5", "6", "7", "8", "9" };
            string[] resultado = new string[B.Length + retornaVetor().Length];
            //var resultado = retornaVetor().Concat(B); //Forma mais usual

            for (int i = 0;i < resultado.Length;i++)
            {
                if (i < retornaVetor().Length)
                    resultado[i] = retornaVetor()[i];
                else if (i >= retornaVetor().Length)
                    resultado[i] = B[i - retornaVetor().Length];
            }
            foreach(string str in resultado)
            {
                Console.Text += str;
            }
        }
    }
}
