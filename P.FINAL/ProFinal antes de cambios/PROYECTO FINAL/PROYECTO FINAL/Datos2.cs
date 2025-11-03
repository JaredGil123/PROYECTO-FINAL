using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BISECCION
{
    public partial class Datos2 : Form
    {
        public Datos2()
        {
            InitializeComponent();
        }

        private void btnAceptar11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtXA.Text) || string.IsNullOrEmpty(txtYB.Text))
            {
                MessageBox.Show("No se pueden dejar campos vacios en las coordenadas",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            double d = double.Parse(txtD.Text);

            double x = double.Parse(txtXA.Text);
            double y = double.Parse(txtYB.Text);

            double error = double.Parse(txtValorI.Text);
            double fa, fb, xi, fxi, errorAct = 10;
            double xiAnte = 0;
            int iteracion = 0, maxItera = 30;

            string resultado = "Iteración | x | y | xi | f(xi) | Error\n";
            resultado += "------------------------------------------------\n";


            DialogResult Resultado = MessageBox.Show("¿Ha revisado ya los datos ingresados?", "Verificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == DialogResult.Yes)
            {

                while (errorAct > error)
                {
                    fa = (a * Math.Pow(x, 3)) + (b * Math.Pow(x, 2)) + (c * x) + d; //(a * Math.Pow(x, 2)) + (b * x) + c;
                    fb = (a * Math.Pow(y, 3)) + (b * Math.Pow(y, 2)) + (c * y) + d;

                    if (fa * fb > 0)
                    {
                        MessageBox.Show("Los valores f(x) y f(y) tienen el mismo signo.\n" +
        "El método de bisección NO puede encontrar una raiz en este intervalo.\n\n" +
        "Por favor, ingrese un intervalo donde f(x) y f(y) tengan signos opuestos.",
        "Error: Intervalo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    xi = (x + y) / 2;

                    fxi = (a * Math.Pow(xi, 3)) + (b * Math.Pow(xi, 2)) + (c * xi) + d;

                    if (iteracion > 0)
                    {
                        errorAct = Math.Abs((xi - xiAnte) / xi);
                    }

                    double ActX = x;
                    double ActY = y;

                    if (fa * fxi < 0)
                    {
                        y = xi;
                    }
                    else
                    {
                        x = xi;
                    }

                    xiAnte = xi;
                    iteracion++;

                    if (iteracion > maxItera)
                    {
                        MessageBox.Show("SE SUPERO EL NUMERO DE INTERACIONES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    resultado += $"\n═══════════════════════════════════════════════\n";
                    resultado += $"RAÍZ APROXIMADA: {xi:F8}\n";
                    resultado += $"ERROR FINAL: {errorAct:F10}\n";
                    resultado += $"ITERACIONES: {iteracion}";

                    MessageBox.Show(resultado, "Resultados del Método de Bisección",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form menu = new FormBiseccion();
            MessageBox.Show("Regresando al menú principal", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            menu.Show();
        }
    }
}
