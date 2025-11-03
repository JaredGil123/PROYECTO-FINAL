using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NCalc;
using System.Drawing.Drawing2D;

namespace NewRapshon
{
    public partial class FormNewton : Form
    {
        public FormNewton()
        {
            InitializeComponent();
            Tabla();
            data.AllowUserToAddRows = false;

        }

        private void Tabla()
        {
            data.Columns.Clear();
            data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "i", HeaderText = "i" });
            data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "fxo", HeaderText = "f(x0)" });
            data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "fdxo", HeaderText = "f'(x0)" });
            data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "xi", HeaderText = "xi" });
            data.Columns.Add(new DataGridViewTextBoxColumn() { Name = "err", HeaderText = "Error (%)" });
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtfx.Text) ||
                    string.IsNullOrWhiteSpace(txtxo.Text) ||
                    string.IsNullOrWhiteSpace(txterror.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de calcular.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Los datos son correctos?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                double xo = double.Parse(txtxo.Text);
                double errord = Math.Abs(double.Parse(txterror.Text));
                string fxog = txtfx.Text;

                string fx = LeerFuncion(fxog);

                if (string.IsNullOrEmpty(fx))
                {
                    MessageBox.Show("La función ingresada no es válida. Verifica la ecuación.", "Error en función", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                data.Rows.Clear();

                double xi_anterior = xo;
                double xi = xo;
                double er = 100;
                int i = 0;

                while (er > errord && i < 100)
                {
                    double fxo = Evaluar(fx, xi_anterior);
                    double fdxo = Derivar(fx, xi_anterior);

                    if (fdxo == 0 || double.IsNaN(fxo) || double.IsNaN(fdxo) || double.IsInfinity(fxo) || double.IsInfinity(fdxo))
                    {
                        MessageBox.Show("Error: Derivada cero o valores no válidos. Revisa la función o el valor inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }

                    xi = xi_anterior - fxo / fdxo;

                   
                    er = Math.Abs((xi - xi_anterior) / xi);

                    data.Rows.Add(
                        (i + 1).ToString(),
                        Math.Round(fxo, 3).ToString("F3"),
                        Math.Round(fdxo, 3).ToString("F3"),
                        Math.Round(xi, 3).ToString("F3"),
                        Math.Round(er, 3).ToString("F3")
                    );

                    xi_anterior = xi;
                    i++;
                }

                MessageBox.Show($"Raíz aproximada: {xi:F3} después de {i} iteraciones", "Resultado");
                if (data.Rows.Count > 0)
                {
                    int ultimaFila = data.Rows.Count - 1;
                    var celda = data.Rows[ultimaFila].Cells["xi"];
                    celda.Style.BackColor = Color.LightGreen;
                    celda.Style.ForeColor = Color.Black;
                    celda.Style.Font = new Font(data.Font, FontStyle.Bold);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtfx.Clear();
            txtxo.Clear();
            txterror.Clear();
            data.Rows.Clear();
        }

        private string LeerFuncion(string fx)
        {
            if (string.IsNullOrWhiteSpace(fx)) return "";

            fx = fx.Replace(" ", "");

            fx = Regex.Replace(fx, @"(^|(?<=[+\-*/(]))-(x|\()", "$1(-1)*$2");

            fx = Regex.Replace(fx, @"(\d)(x)", "$1*$2");
            fx = Regex.Replace(fx, @"(x)\(", "$1*(");
            fx = Regex.Replace(fx, @"\)(\d|x)", ")*$1");

            // Potencias              fx = Regex.Replace(fx, @"\(([^)]+)\)\^(\d+(\.\d+)?)", "Pow(($1),$2)");
            fx = Regex.Replace(fx, @"x\^(\d+(\.\d+)?)", "Pow(x,$1)");

            return fx;
        }

        private double Evaluar(string fx, double x)
        {
            Expression e = new Expression(fx);
            e.Parameters["x"] = x;
            object result = e.Evaluate();
            return Convert.ToDouble(result);
        }

        private double Derivar(string fx, double x)
        {
            double h = 1e-6;
            return (Evaluar(fx, x + h) - Evaluar(fx, x - h)) / (2 * h);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                
        }

       

        private void FormNewton_Load(object sender, EventArgs e)
        {
            Font fuenteElegante = new Font("Segoe UI Semilight", 11F, FontStyle.Regular);

            this.BackColor = Color.FromArgb(230, 240, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            EstiloBoton(btnLimpiar);
            EstiloBoton(btncalcular);

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
    }
    }

