using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3, nota4;
            double promedio;

            nota1 = int.Parse(txtNota1.Text);
            nota2= int.Parse(txtNota2.Text);    
            nota3 = int.Parse(txtNota3.Text);
            nota4 = int.Parse(txtNota4.Text);

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            txtPromedio.Text = promedio.ToString();
            
        }
    }
}
