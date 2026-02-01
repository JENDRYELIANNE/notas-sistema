using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notas_sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limpiarbtm_Click(object sender, EventArgs e)
        {
            n1txt.Clear();
            n2txt.Clear();
            n3txt.Clear();
            n4txt.Clear();
            extratxt.Clear();
            extratxt.Enabled = false;
            completxt.Clear();
            completxt.Enabled = false;
            respuestatxt.Clear();
            prometxt.Clear();
            prometxt.Enabled = false;
            respuestatxt.Enabled = false;
        }

        private void calcularbtm_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(n1txt.Text);
            double n2 = double.Parse(n2txt.Text);
            double n3 = double.Parse(n3txt.Text);
            double n4 = double.Parse(n4txt.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;
            prometxt.Text = promedio.ToString("0.00");

            if (promedio > 69)
            {
                respuestatxt.Text = "Aprobado 👍";
                return;
            }
            // complectivo operacion---//
            respuestatxt.Text = "estas en complectivo !";
            completxt.Enabled = true;

            if (string.IsNullOrWhiteSpace(completxt.Text)) return;

            double notaCompletivo = double.Parse(completxt.Text);
            double resultadoCompletivo =
            (promedio * 0.50) + (notaCompletivo * 0.50);


            if (resultadoCompletivo > 69)
            {
                respuestatxt.Text = "Aprobado por Completivo 😊";
                return;
            }
            // extraurdinado--///
            respuestatxt.Text = "Debe ir a Extraordinario❗";
            extratxt.Enabled = true;

            if (string.IsNullOrWhiteSpace(extratxt.Text)) return;

            double notaExtra = double.Parse(extratxt.Text);
            double resultadoExtra = (promedio * 0.30) + (notaExtra * 0.70);

            if (resultadoExtra > 69)
                respuestatxt.Text = "Aprobado por Extraordinario";
            else
                respuestatxt.Text = "Reprobado";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            completxt.Enabled = false;
            extratxt.Enabled = false;
            prometxt.ReadOnly = true;
            respuestatxt.ReadOnly = true;
        }

        private void prometxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void respuestatxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
