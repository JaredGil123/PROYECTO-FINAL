using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class EL2 : Form
    {
        public EL2()
        {

        

            InitializeComponent();
            GP2x2.Hide();
            GB3x3.Hide();
            rd2x2.Checked = false;
            rd3x3.Checked = false;
            txtResultados.Enabled = false;

            txtA11.TextChanged += Validartxt;
            txtA12.TextChanged += Validartxt;
            txtA21.TextChanged += Validartxt;
            txtA22.TextChanged += Validartxt;
            txtb1.TextChanged += Validartxt;
            txtb2.TextChanged += Validartxt;
            txtA11_3x3.TextChanged += Validartxt;
            txtA12_3x3.TextChanged += Validartxt;
            txtA13.TextChanged += Validartxt;
            txtA21_3x3.TextChanged += Validartxt;
            txtA22_3x3.TextChanged += Validartxt;
            txtA23.TextChanged += Validartxt;
            txtA31.TextChanged += Validartxt;
            txtA32.TextChanged += Validartxt;
            txtA33.TextChanged += Validartxt;
            txtb1_3x3.TextChanged += Validartxt;
            txtb2_3x3.TextChanged += Validartxt;
            txtb3.TextChanged += Validartxt;


            Font fuenteElegante = new Font("Segoe UI Semilight", 11F, FontStyle.Regular);

            this.BackColor = Color.FromArgb(230, 240, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            EstiloBoton(btnCeros);
            EstiloBoton(btnCalcular);
            EstiloBoton(btnBorrar);


            System.Media.SystemSounds.Asterisk.Play(); // sonido leve de notificación

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;

        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(235, 245, 255),  // azul muy claro
                Color.FromArgb(255, 255, 255),  // blanco
                120f))                          // ángulo del degradado
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void EstiloBoton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(80, 170, 255);  // celeste suave
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;

            // Efecto hover (al pasar el mouse)
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(120, 190, 255); // tono más claro
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(80, 170, 255); // vuelve al original
            };
        }
        private bool Esnumero(string valor)
        {
            if (valor == "-")
                return true;
            double resultado;
            return double.TryParse(valor, out resultado);
        }
        private bool Borrado = false;
        private void Validartxt(object sender, EventArgs e)
        {
            if (Borrado) return;
            TextBox txtbox = (TextBox)sender;
            if (!Esnumero(txtbox.Text))
            {
                MessageBox.Show("Ingrese un valor valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EL2_Load(object sender, EventArgs e)
        {

        }

        private void rd3x3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd3x3.Checked)
            {
                GB3x3.Show();
                GP2x2.Hide();
                txtResultados.Clear();
            }
        }


        private void rd2x2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2x2.Checked)
            {
                GP2x2.Show();
                GB3x3.Hide();
                txtResultados.Clear();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrado = true;
            if (rd2x2.Checked)
            {
                txtResultados.Clear();
                txtA11.Clear();
                txtA12.Clear();
                txtA21.Clear();
                txtA22.Clear();
                txtb1.Clear();
                txtb2.Clear();
            }
            else if (rd3x3.Checked)
            {
                txtResultados.Clear();
                txtA11_3x3.Clear();
                txtA12_3x3.Clear();
                txtA13.Clear();
                txtA21_3x3.Clear();
                txtA22_3x3.Clear();
                txtA23.Clear();
                txtA31.Clear();
                txtA32.Clear();
                txtA33.Clear();
                txtb1_3x3.Clear();
                txtb2_3x3.Clear();
                txtb3.Clear();
            }

        }

        private void btnCeros_Click(object sender, EventArgs e)
        {
            if (rd2x2.Checked)
            {
                LlenarCeros(txtA11, e);
                LlenarCeros(txtA12, e);
                LlenarCeros(txtA21, e);
                LlenarCeros(txtA22, e);
                LlenarCeros(txtb1, e);
                LlenarCeros(txtb2, e);
            }
            else if (rd3x3.Checked)
            {
                LlenarCeros(txtA11_3x3, e);
                LlenarCeros(txtA12_3x3, e);
                LlenarCeros(txtA13, e);
                LlenarCeros(txtA21_3x3, e);
                LlenarCeros(txtA22_3x3, e);
                LlenarCeros(txtA23, e);
                LlenarCeros(txtA31, e);
                LlenarCeros(txtA32, e);
                LlenarCeros(txtA33, e);
                LlenarCeros(txtb1_3x3, e);
                LlenarCeros(txtb2_3x3, e);
                LlenarCeros(txtb3, e);
            }
        }
        private void LlenarCeros(object sender, EventArgs e)
        {

            TextBox txtbox = (TextBox)sender;
            if (string.IsNullOrEmpty(txtbox.Text))
            {
                txtbox.Text = "0";
            }
        }
        //Calcular Det 2x2 y 3x3
        private static double CalcularDet2x2(double[][] m)
        {
            return
                (m[0][0] * m[1][1]
                - m[0][1] * m[1][0]);

        }
        private static double CalcularDet3x3(double[][] m)
        {

            var a = m[0][0];
            var b = m[0][1];
            var c = m[0][2];


            var efhi = new double[][]
            {
                new double [] {m[1][1], m[1][2] },
                new double [] { m[2][1], m[2][2] }
            };
            var dfgi = new double[][]
         {
                new double [] {m[1][0], m[1][2] },
                new double [] { m[2][0], m[2][2] }
         };
            var degh = new double[][]
         {
                new double [] {m[1][0], m[1][1] },
                new double [] { m[2][0], m[2][1] }
         };
            double det = (
                a * CalcularDet2x2(efhi)
                - b * CalcularDet2x2(dfgi)
                + c * CalcularDet2x2(degh));
            return det;

        }

        //Calcular los resulatados de Xn
        private void Resultados2x2()
        {
            if (Det2x2() != 0)
            {

                double[,] arre1 = new double[2, 2];
                //Matriz aumentada
                arre1[0, 0] = +double.Parse(txtA22.Text);
                arre1[0, 1] = -double.Parse(txtA21.Text);
                arre1[1, 0] = -double.Parse(txtA12.Text);
                arre1[1, 1] = +double.Parse(txtA11.Text);
                double[,] arre2 = new double[2, 2];
                double[,] Mresultados = new double[2, 1];
                Mresultados[0, 0] = double.Parse(txtb1.Text);
                Mresultados[1, 0] = double.Parse(txtb2.Text);
                double[,] arreResultado = new double[2, 1];

                //transpuesta
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        arre2[j, i] = arre1[i, j];
                    }
                }

                /*
                 * Imprimir transpuesta
                 * 
                string arregloT = "";
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        arregloT += arre2[i, j].ToString() + " ";
                    }
                    arregloT += Environment.NewLine;
                }
                MessageBox.Show(arregloT.Trim());
                */

                //Multiplicar transpuesta
                for (int i = 0; i < 2; i++)
                {

                    arreResultado[i, 0] =
                    (arre2[i, 0] * Mresultados[0, 0] +
                    arre2[i, 1] * Mresultados[1, 0]) / Det2x2();
                }
                string arregloB = "";
                for (int i = 0; i < 2; i++)
                {

                    arregloB += $"x{i + 1}= " + arreResultado[i, 0].ToString("F2") + Environment.NewLine;


                }
                txtResultados.Text = arregloB.Trim();
                MessageBox.Show(arregloB.Trim(), "Resultados", MessageBoxButtons.OK);
            }

        }
        private void Resultados3x3()
        {
            if (Det3x3() != 0)
            {
                double[,] arre1 = new double[3, 3];
                double[,] arre2 = new double[3, 3];
                double[,] arreT = new double[3, 3];
                double[,] arreb = new double[3, 1];
                double[,] arreResultados = new double[3, 1];

                //Matriz aumentada
                arre1[0, 0] = double.Parse(txtA11_3x3.Text);
                arre1[0, 1] = double.Parse(txtA12_3x3.Text);
                arre1[0, 2] = double.Parse(txtA13.Text);
                arre1[1, 0] = double.Parse(txtA21_3x3.Text);
                arre1[1, 1] = double.Parse(txtA22_3x3.Text);
                arre1[1, 2] = double.Parse(txtA23.Text);
                arre1[2, 0] = double.Parse(txtA31.Text);
                arre1[2, 1] = double.Parse(txtA32.Text);
                arre1[2, 2] = double.Parse(txtA33.Text);

                //Matriz de resultados
                arreb[0, 0] = double.Parse(txtb1_3x3.Text);
                arreb[1, 0] = double.Parse(txtb2_3x3.Text);
                arreb[2, 0] = double.Parse(txtb3.Text);

                //cofactores
                var efhi = new double[][]
               {
                new double [] {arre1[1,1], arre1[1,2] },
                new double [] { arre1[2,1], arre1[2,2] }
               };
                var dfgi = new double[][]
             {
                new double [] {arre1[1,0], arre1[1,2] },
                new double [] { arre1[2,0], arre1[2,2] }
             };
                var degh = new double[][]
             {
                new double [] {arre1[1,0], arre1[1,1] },
                new double [] { arre1[2,0], arre1[2,1] }
             };
                var bchi = new double[][]
             {
                new double [] {arre1[0,1], arre1[0,2] },
                new double [] { arre1[2,1], arre1[2,2] }
             };
                var acgi = new double[][]
             {
                new double [] {arre1[0,0], arre1[0,2] },
                new double [] { arre1[2,0], arre1[2,2] }
             };
                var abgh = new double[][]
             {
                new double [] {arre1[0,0], arre1[0,1] },
                new double [] { arre1[2,0], arre1[2,1] }
             };
                var bcef = new double[][]
             {
                new double [] {arre1[0,1], arre1[0,2] },
                new double [] { arre1[1,1], arre1[1,2] }
             };
                var acdf = new double[][]
             {
                new double [] {arre1[0,0], arre1[0,2] },
                new double [] { arre1[1,0], arre1[1,2] }
             };
                var abde = new double[][]
             {
                new double [] {arre1[0,0], arre1[0,1] },
                new double [] { arre1[1,0], arre1[1,1] }
             };
                arre2[0, 0] = +CalcularDet2x2(efhi);
                arre2[0, 1] = -CalcularDet2x2(dfgi);
                arre2[0, 2] = +CalcularDet2x2(degh);
                arre2[1, 0] = -CalcularDet2x2(bchi);
                arre2[1, 1] = +CalcularDet2x2(acgi);
                arre2[1, 2] = -CalcularDet2x2(abgh);
                arre2[2, 0] = +CalcularDet2x2(bcef);
                arre2[2, 1] = -CalcularDet2x2(acdf);
                arre2[2, 2] = +CalcularDet2x2(abde);

                //transpuesta
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arreT[j, i] = arre2[i, j];
                    }
                }
                /*
                 * Imprimir transpuesta
                 * 
                string arregloT = "";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arregloT += arreT[i, j].ToString() + " ";
                    }
                    arregloT += Environment.NewLine;
                }
                MessageBox.Show(arregloT.Trim());
                */

                //Multiplicar transpuesta
                for (int i = 0; i < 3; i++)
                {

                    arreResultados[i, 0] =
                    (arreT[i, 0] * arreb[0, 0] +
                    arreT[i, 1] * arreb[1, 0] +
                    arreT[i, 2] * arreb[2, 0]) / Det3x3();
                }
                string arregloB = "";
                for (int i = 0; i < 3; i++)
                {

                    arregloB += $"x{i + 1}= " + arreResultados[i, 0].ToString("F2") + Environment.NewLine;


                }
                txtResultados.Text = arregloB.Trim();
                MessageBox.Show(arregloB.Trim(), "Resultados", MessageBoxButtons.OK);
            }

        }
        //Recibir parametros para el resultado de los DET
        private double Det2x2()
        {
            double[][] m = new double[2][];
            m[0] = new double[2];
            m[1] = new double[2];

            m[0][0] = double.Parse(txtA11.Text);
            m[0][1] = double.Parse(txtA12.Text);
            m[1][0] = double.Parse(txtA21.Text);
            m[1][1] = double.Parse(txtA22.Text);

            double det = CalcularDet2x2(m);
            if (det != 0)
            {
                //txtResultados.Text = det.ToString();
                //MessageBox.Show("Determinante = " + det.ToString()); 
            }
            else
            {
                MessageBox.Show("No tiene solucion Determinante = " + det.ToString(), "Sin solucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return det;
        }
        private double Det3x3()
        {
            double[][] m = new double[3][];
            m[0] = new double[3];
            m[1] = new double[3];
            m[2] = new double[3];
            m[0][0] = double.Parse(txtA11_3x3.Text);
            m[0][1] = double.Parse(txtA12_3x3.Text);
            m[0][2] = double.Parse(txtA13.Text);
            m[1][0] = double.Parse(txtA21_3x3.Text);
            m[1][1] = double.Parse(txtA22_3x3.Text);
            m[1][2] = double.Parse(txtA23.Text);
            m[2][0] = double.Parse(txtA31.Text);
            m[2][1] = double.Parse(txtA32.Text);
            m[2][2] = double.Parse(txtA33.Text);

            double det = CalcularDet3x3(m);
            if (det != 0)
            {
                //MessageBox.Show("Determinante = " + det.ToString());
            }
            else
            {
                MessageBox.Show("No tiene solucion Determinante = " + det.ToString(), "Sin solucion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return det;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rd2x2.Checked != false || rd3x3.Checked != false)
            {
                if (rd2x2.Checked && tbM2x2.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Ingrese todos los datos del 2x2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtResultados.Clear();
                if (rd3x3.Checked && tbM3x3.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    MessageBox.Show("Ingrese todos los datos del 3x3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                else
                {
                    var ms = MessageBox.Show("Antes de continuar compruebe dos veces", "Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rd2x2.Checked)
                    {

                        txtResultados.Text = "";
                        if (ms == DialogResult.Yes)
                        {
                            Resultados2x2();

                        }

                    }
                    if (rd3x3.Checked)
                    {
                        txtResultados.Text = "";
                        if (ms == DialogResult.Yes)
                        {
                            Resultados3x3();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una opcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
