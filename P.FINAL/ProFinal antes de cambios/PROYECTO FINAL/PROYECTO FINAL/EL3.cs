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
    public partial class EL3 : Form
    {
        public EL3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            System.Media.SystemSounds.Asterisk.Play(); // sonido leve de notificación


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
           txtX1.Text = string.Empty;
            txtX2.Text = string.Empty;
            txtA1.Text = string.Empty;
            txtA2.Text = string.Empty;
            txtB1.Text = string.Empty;
            txtB2.Text = string.Empty;
            txtC1.Text = string.Empty;
            txtC2.Text = string.Empty;
            txtC3.Text = string.Empty;
            txtX3.Text = string.Empty;
            txtA3.Text = string.Empty;
            txtB3.Text = string.Empty;



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            inal11.Text = string.Empty;
            inal12.Text = string.Empty;
            inal21.Text = string.Empty;
            inal22.Text = string.Empty;
            Txt11.Text = string.Empty;
            Txt22.Text = string.Empty;

        }

        private void EL3_Load(object sender, EventArgs e)
        {
            Font fuenteElegante = new Font("Segoe UI Semilight", 11F, FontStyle.Regular);

            this.BackColor = Color.FromArgb(230, 240, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            EstiloBoton(button1);
            EstiloBoton(btnEnviar);

     


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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show
                 ("¿Ha verificado bien sus datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Resultado == DialogResult.No)
                return;
            else
            {
                MessageBox.Show("Datos registrados exitosamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            string resultado = "";

            double a11 = double.Parse(txtA1.Text);
            double a12 = double.Parse(txtA2.Text);
            double a13 = double.Parse(txtA3.Text);
            double a21 = double.Parse(txtB1.Text);
            double a22 = double.Parse(txtB2.Text);
            double a23 = double.Parse(txtB3.Text);
            double a31 = double.Parse(txtC1.Text);
            double a32 = double.Parse(txtC2.Text);
            double a33 = double.Parse(txtC3.Text);

            double det = a11 * (a22 * a33 - a23 * a32) -
                         a12 * (a21 * a33 - a23 * a31) +
                         a13 * (a21 * a32 - a22 * a31);

            if (det == 0)
            {
                MessageBox.Show("La determinante es igual a cero, por lo tanto el sistema no tiene solucion");
                return;
            }
            if (a11 == 0)
            {
                MessageBox.Show("Intercambie la fila con valor 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string determinantes = det.ToString();
            MessageBox.Show("Determinante: " + determinantes);

            // Matriz identidad inicial
            double i11 = 1, i12 = 0, i13 = 0;
            double i21 = 0, i22 = 1, i23 = 0;
            double i31 = 0, i32 = 0, i33 = 1;

            MessageBox.Show("Matriz inicial: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            double a = a11, aa = a12, aaa = a13, b = a21, bb = a22, bbb = a23, c = a31, cc = a32, ccc = a33;

            // PASO 1: Hacer que a11 = 1 (dividir primera fila por a11)
            double divisor1 = a11;
            a12 = a12 / divisor1;
            a13 = a13 / divisor1;
            i11 = i11 / divisor1;
            i12 = i12 / divisor1;
            i13 = i13 / divisor1;
            a11 = a11 / divisor1;

            MessageBox.Show("Paso 1 - Hacer a11 = 1: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            // PASO 2: Hacer que a21 = 0 (restar a21 veces la primera fila de la segunda)
            double mult1 = a21;
            a22 = a22 - (mult1 * a12);
            a23 = a23 - (mult1 * a13);
            i21 = i21 - (mult1 * i11);
            i22 = i22 - (mult1 * i12);
            i23 = i23 - (mult1 * i13);
            a21 = a21 - (mult1 * a11); //0

            MessageBox.Show("Paso 2 - Hacer a21 = 0: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            // PASO 3: Hacer que a31 = 0 (restar a31 veces la primera fila de la tercera)
            double mult2 = a31;
            a32 = a32 - (mult2 * a12);
            a33 = a33 - (mult2 * a13);
            i31 = i31 - (mult2 * i11);
            i32 = i32 - (mult2 * i12);
            i33 = i33 - (mult2 * i13);
            a31 = a31 - (mult2 * a11); // 0

            MessageBox.Show("Paso 3 - Hacer a31 = 0: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            // PASO 4: Hacer que a22 = 1 (dividir segunda fila por a22)
            double divisor2 = a22;
            a21 = a21 / divisor2; // Ya es 0
            a23 = a23 / divisor2;
            i21 = i21 / divisor2;
            i22 = i22 / divisor2;
            i23 = i23 / divisor2;
            a22 = a22 / divisor2; // 1

            MessageBox.Show("Paso 4 - Hacer a22 = 1: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            // PASO 5: Hacer que a12 = 0 (restar a12 veces la segunda fila de la primera)
            double mult3 = a12;
            a11 = a11 - (mult3 * a21); // Ya es 1
            a13 = a13 - (mult3 * a23);
            i11 = i11 - (mult3 * i21);
            i12 = i12 - (mult3 * i22);
            i13 = i13 - (mult3 * i23);
            a12 = a12 - (mult3 * a22); // 0

            MessageBox.Show("Paso 5 - Hacer a12 = 0: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            // PASO 6: Hacer que a32 = 0 (restar a32 veces la segunda fila de la tercera)
            double mult4 = a32;
            a31 = a31 - (mult4 * a21); // Ya es 0
            a33 = a33 - (mult4 * a23);
            i31 = i31 - (mult4 * i21);
            i32 = i32 - (mult4 * i22);
            i33 = i33 - (mult4 * i23);
            a32 = a32 - (mult4 * a22);

            MessageBox.Show("Paso 6 - Hacer a32 = 0: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            double divisor3 = a33;
            a31 = a31 / divisor3;
            a32 = a32 / divisor3;
            i31 = i31 / divisor3;
            i32 = i32 / divisor3;
            i33 = i33 / divisor3;
            a33 = a33 / divisor3;

            MessageBox.Show("Paso 7 - Hacer a33 = 1: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            double mult5 = a13;
            a11 = a11 - (mult5 * a31);
            a12 = a12 - (mult5 * a32);
            i11 = i11 - (mult5 * i31);
            i12 = i12 - (mult5 * i32);
            i13 = i13 - (mult5 * i33);
            a13 = a13 - (mult5 * a33);

            MessageBox.Show("Paso 8 - Hacer a13 = 0: " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);

            double mult6 = a23;
            a21 = a21 - (mult6 * a31);
            a22 = a22 - (mult6 * a32);
            i21 = i21 - (mult6 * i31);
            i22 = i22 - (mult6 * i32);
            i23 = i23 - (mult6 * i33);
            a23 = a23 - (mult6 * a33);

            MessageBox.Show("Matriz final (Inversa): " + "\n" +
                a11 + " " + a12 + " " + a13 + " | " + i11 + " " + i12 + " " + i13 + "\n" +
                a21 + " " + a22 + " " + a23 + " | " + i21 + " " + i22 + " " + i23 + "\n" +
                a31 + " " + a32 + " " + a33 + " | " + i31 + " " + i32 + " " + i33);


            double ind1 = double.Parse(txtX1.Text), ind2 = double.Parse(txtX2.Text), ind3 = double.Parse(txtX3.Text);
            double x1 = (i11 * ind1) + (i12 * ind2) + (i13 * ind3);
            double x2 = (i21 * ind1) + (i22 * ind2) + (i23 * ind3);
            double x3 = (i31 * ind1) + (i32 * ind2) + (i33 * ind3);

            double com1 = (a * x1) + (aa * x2) + (aaa * x3);
            double com2 = (b * x1) + (bb * x2) + (bbb * x3);
            double com3 = (c * x1) + (cc * x2) + (ccc * x3);

            string comp = "Primer resultado: " + com1 + "\n" + "Segundo: " + com2 + "\n" + "Tercera: " + com3;

            resultado = "x1 = " + x1 + "\n" +
                        "x2 = " + x2 + "\n" +
                        "x3 = " + x3;
            MessageBox.Show(resultado);
            MessageBox.Show("Comprobacion: " + comp);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            double a1 = double.Parse(inal11.Text);
            double a2 = double.Parse(inal12.Text);
            double b1 = double.Parse(inal21.Text);
            double b2 = double.Parse(inal22.Text);

            double det = (a1 * b2) - (a2 * b1);
            DialogResult Resultado = MessageBox.Show("¿Ha verificado bien sus datos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (det == 0)
            {
                MessageBox.Show("La determinante es igual a cero, por lo tanto el sistema no tiene solución");
                return;
            }

            if (a1 == 0)
            {
                MessageBox.Show("Intercambie la fila con valor 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            string determinantes = det.ToString();
            MessageBox.Show("Determinante: " + determinantes);

            double i1 = 1, i2 = 0, i3 = 0, i4 = 1;

            MessageBox.Show("Matriz inicial: " + "\n" +
                a1 + " " + a2 + " | " + i1 + " " + i2 + "\n" +
                b1 + " " + b2 + " | " + i3 + " " + i4);
            double a = a1, aa = a2, b = b1, bb = b2;
            double divisor1 = a1;
            if (divisor1 != 0)
            {
                a2 = a2 / divisor1;
                i1 = i1 / divisor1;
                i2 = i2 / divisor1;
                a1 = a1 / divisor1;
            }

            MessageBox.Show("Después del paso 1: " + "\n" +
                a1 + " " + a2 + " | " + i1 + " " + i2 + "\n" +
                b1 + " " + b2 + " | " + i3 + " " + i4);

            double multiplicador1 = b1;
            b2 = b2 - (multiplicador1 * a2);
            i3 = i3 - (multiplicador1 * i1);
            i4 = i4 - (multiplicador1 * i2);
            b1 = b1 - (multiplicador1 * a1);

            MessageBox.Show("Después del paso 2: " + "\n" +
                a1 + " " + a2 + " | " + i1 + " " + i2 + "\n" +
                b1 + " " + b2 + " | " + i3 + " " + i4);

            double divisor2 = b2;
            if (divisor2 != 0)
            {
                i3 = i3 / divisor2;
                i4 = i4 / divisor2;
                b1 = b1 / divisor2;
                b2 = b2 / divisor2;
            }

            MessageBox.Show("Después del paso 3: " + "\n" +
                a1 + " " + a2 + " | " + i1 + " " + i2 + "\n" +
                b1 + " " + b2 + " | " + i3 + " " + i4);

            double multiplicador2 = a2;
            a1 = a1 - (multiplicador2 * b1);
            i1 = i1 - (multiplicador2 * i3);
            i2 = i2 - (multiplicador2 * i4);
            a2 = a2 - (multiplicador2 * b2);

            MessageBox.Show("Matriz final (Inversa): " + "\n" +
                a1 + " " + a2 + " | " + i1 + " " + i2 + "\n" +
                b1 + " " + b2 + " | " + i3 + " " + i4);

            double ind1 = Double.Parse(Txt11.Text), ind2 = Double.Parse(Txt22.Text);

            double x1 = (i1 * ind1) + (i2 * ind2);
            double x2 = (i3 * ind1) + (i4 * ind2);
            resultado = "x1 = " + x1 + "\n" + "x2 = " + x2;


            double com1 = (a * x1) + (aa * x2);
            double com2 = (b * x1) + (bb * x2);
            string comprobacion = "Primer resultado: " + com1 + "\n" + "Segundo resultado: " + com2;


            MessageBox.Show(resultado);
            MessageBox.Show(comprobacion);
        }

        private void lblMenu2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
