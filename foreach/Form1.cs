using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @foreach
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;   
        int num3;
        List<int> numeros = new List<int>();
        int mayor = 0;
       public Form1()
        {
            InitializeComponent();
        }
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txt_num1.Text);
            numeros.Add(num1);
            num2 = Convert.ToInt32(txt_num2.Text);
            numeros.Add(num2);
            num3 = Convert.ToInt32(txt_num3.Text);
            numeros.Add(num3);

            mayor = numeros[1];

            foreach (int i in numeros)
            {
                if (i > mayor)
                {
                    mayor = i; 
                }
            }   
            
            txt_mayor.Text = mayor.ToString();
        }
    }
}
