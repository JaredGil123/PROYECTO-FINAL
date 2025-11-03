using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using NCalc; // LIBRERÍA QUE PERMTE EVALUAR EXPRESIONES EN TIEMPO REAL, INTERPRETA POTENCIAS, Y OPERACIONES ARIMETICAS

namespace Regula_falsi
{
    public partial class FormRegulaF : Form
    {
        public FormRegulaF()
        {
            //validaciones
            InitializeComponent();
            txtValorA.Click += validarA;
            tbValorb.Click += validarB;
            txtError.Click += validarError;
            txtin1.Click += validarnumero;
        }

        private void validarnumero(object sender, EventArgs e)
        {
            txtin1.Focus();
            TextBox textformatoadecuado = (TextBox)sender;
            if (!Double.TryParse(textformatoadecuado.Text, out double Formatoadecuado))
                MessageBox.Show("Querido usuario, el formato para escribir una potencia es así, ejemplo: (2x^2) se escribe así: (2 * x * x)");
        
        }
        private void validarA(object sender, EventArgs e)
        {
            TextBox textValorA = (TextBox)sender;

            if (!double.TryParse(textValorA.Text, out double valorA))
            {
                MessageBox.Show("Por favor, asegurate de escribir un número válido en A.");
                return;
            }
        }

        private void validarB(object sender, EventArgs e)
        {
            TextBox textValorB = (TextBox)sender;

            if (!double.TryParse(textValorB.Text, out double valorB))
            {
                MessageBox.Show("Por favor, asegurate escribir un número válidos en B.");
                return;
            }
        }

        private void validarError(object sender, EventArgs e)
        {
            TextBox textValorError = (TextBox)sender;

            if (!double.TryParse(textValorError.Text, out double ValorError))
            {
                MessageBox.Show("Por favor, ingresa un número válido en A.");
                return;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            //limpiar los campos
            txtValorA.Clear();
            tbValorb.Clear();
            txtError.Clear();
            txtin1.Clear();

            DGV1.Rows.Clear();

            lblespa.Text = "-";

        }

        private double Funcion(double x)
        {
            try
            {
                string funcion = txtin1.Text.Trim();

                // Asegurar que se usa el formato que NCalc entiende
                funcion = funcion.Replace("^", "Pow"); // NCalc usa Pow(base, exponente)

                // Reemplaza potencias escritas tipo x*x*x por el mismo formato, pero mejor definido
                // (esto es opcional, solo limpia espacios dobles)
                funcion = Regex.Replace(funcion, @"\s+", " ");

                Expression e = new Expression(funcion);

                // Definir variable x
                e.Parameters["x"] = x;

                // Evaluar expresión
                object resultado = e.Evaluate();

                // Si el resultado no es numérico
                if (resultado == null || double.IsNaN(Convert.ToDouble(resultado)))
                    throw new Exception("La función no pudo evaluarse correctamente.");

                return Convert.ToDouble(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al evaluar la función:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return double.NaN;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //valor a, b y error. convertir los valores de entrada a double
            double a = double.Parse(txtValorA.Text);
            double b = double.Parse(tbValorb.Text);
            double errorDeseado = double.Parse(txtError.Text);

            //valores de xi, xi previo, error e iteracion
            double xi = 0;
            double xiprevio = 0;
            double error = 1;
            int iteracion = 0;

            do
            {
                //el valor de la funcion la evaluamos en a y b
                double fa = Funcion(a);
                double fb = Funcion(b);


                // Usamos la fórmula correcta
                xi = b - (fb * (b - a)) / (fb - fa);
                //y ahora la evaluamos en xi
                double fxi = Funcion(xi);

                //calcular error
                if (iteracion > 0)
                {
                    error = Math.Abs((xi - xiprevio) / xi);
                }

                //se agregan las filas a la datagrind
                DGV1.Rows.Add(iteracion + 1, a, b, fa, fb, xi, fxi, error.ToString("0.00000"));

                //compara el signo de f(xi) con f(a) y f(b)
                //si f(a) y f(B) tienen signos opuestos entonces si existe una raíz
                if (fa * fxi < 0)
                {
                    b = xi;

                }
                else
                    a = xi;

                xiprevio = xi;
                iteracion++;

            }
            //el programa se seguira ejecutando hasta que el error actual ya no sea mayor que el deseado
            while (error > errorDeseado);

            MessageBox.Show($"La iaíz aproximada es: {xi}");
            lblespa.Text = xi.ToString();
        }
    }
}



