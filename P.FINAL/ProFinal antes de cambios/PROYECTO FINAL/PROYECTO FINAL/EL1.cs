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
    public partial class EL1 : Form
    {
        public EL1()
        {
            InitializeComponent();
        }
        tresportres1 objTres = new tresportres1();
        Operaciones objCalculos = new Operaciones();
        public double a11, a12, a21, a22;
        public double DetMatriz2x2;
        public double newA11, newA21, newA12, newA22, xT, yT, xxt, yyt;
        //matriz 3x3
        public double b11, b12, b13, b21, b22, b23, b31, b32, b33;

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            b11 = Convert.ToDouble(txt11.Text);
            b12 = Convert.ToDouble(txt12.Text);
            b13 = Convert.ToDouble(txt13.Text);
            b21 = Convert.ToDouble(txt21.Text);
            b22 = Convert.ToDouble(txt22.Text);
            b23 = Convert.ToDouble(txt23.Text);
            b31 = Convert.ToDouble(txt31.Text);
            b32 = Convert.ToDouble(txt32.Text);
            b33 = Convert.ToDouble(txt33.Text);

            objTres.Matriz(b11, b12, b13, b21, b22, b23, b31, b32, b33);
            DetMat3x3 = objTres.CalDet();

            N11 = Convert.ToDouble(txtC1.Text);
            N21 = Convert.ToDouble(txtC2.Text);
            N31 = Convert.ToDouble(txtC3.Text);

            double Dx = (N11 * (b22 * b33 - b23 * b32))
                      - (b12 * (N21 * b33 - b23 * N31))
                      + (b13 * (N21 * b32 - b22 * N31));

            double Dy = (b11 * (N21 * b33 - b23 * N31))
                      - (N11 * (b21 * b33 - b23 * b31))
                      + (b13 * (b21 * N31 - N21 * b31));


            double Dz = (b11 * (b22 * N31 - N21 * b32))
                      - (b12 * (b21 * N31 - N21 * b31))
                      + (N11 * (b21 * b32 - b22 * b31));

            X1 = Dx / DetMat3x3;
            X2 = Dy / DetMat3x3;
            X3 = Dz / DetMat3x3;


            MessageBox.Show("El valor de X1 es " + X1 + "\n " + "El valor de X2 es: " + X2 + "\n" + "El valor de X3 es: " + "\n" + X3);
            txt11.Text = string.Empty;
            txt12.Text = string.Empty;
            txt13.Text = string.Empty;
            txt21.Text = string.Empty;
            txt22.Text = string.Empty;
            txt23.Text = string.Empty;
            txt31.Text = string.Empty;
            txt32.Text = string.Empty;
            txt33.Text = string.Empty;
            txtC2.Text = string.Empty;
            txtC1.Text = string.Empty;
            txtC3.Text = string.Empty;
            //xd
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
     
            panel1.Visible = true;
            panel2.Visible = false;
            txt11.Text = string.Empty;
            txt12.Text = string.Empty;
            txt13.Text = string.Empty;
            txt21.Text = string.Empty;
            txt22.Text = string.Empty;
            txt23.Text = string.Empty;
            txt31.Text = string.Empty;
            txt32.Text = string.Empty;
            txt33.Text = string.Empty;
            txtC2.Text = string.Empty;
            txtC1.Text = string.Empty;
            txtC3.Text = string.Empty;
            //xd
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            C1.Text = string.Empty;
            C2.Text = string.Empty;
        }

      

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel1.Visible = false;
            txt11.Text = string.Empty;
            txt12.Text = string.Empty;
            txt13.Text = string.Empty;
            txt21.Text = string.Empty;
            txt22.Text = string.Empty;
            txt23.Text = string.Empty;
            txt31.Text = string.Empty;
            txt32.Text = string.Empty;
            txt33.Text = string.Empty;
            txtC2.Text = string.Empty;
            txtC1.Text = string.Empty;
            txtC3.Text = string.Empty;
            //xd
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            C1.Text = string.Empty;
            C2.Text = string.Empty;

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

     
        public double DetMat3x3;
        public double N11, N21, N31;
        public double X1, X2, X3;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      
     

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            System.Media.SystemSounds.Asterisk.Play(); // sonido leve de notificación


        }
        private void button2_Click(object sender, EventArgs e)
        {
            a11 = Convert.ToDouble(textBox1.Text);
            a12 = Convert.ToDouble(textBox3.Text);
            a21 = Convert.ToDouble(textBox2.Text);
            a22 = Convert.ToDouble(textBox4.Text);
            objCalculos.casillas(a11, a12, a21, a22);
            DetMatriz2x2 = objCalculos.ReturnDelta();

            //para x1 testada
            newA11 = Convert.ToDouble(C1.Text);
            newA21 = Convert.ToDouble(C2.Text);
            xT = (newA11 * a22) - (newA21 * a12);
            xxt = xT / DetMatriz2x2;


            //para x2 testada
            newA12 = Convert.ToDouble(C1.Text);
            newA22 = Convert.ToDouble(C2.Text);
            yT = (a11 * newA22) - (a21 * newA12);
            yyt = yT / DetMatriz2x2;
            MessageBox.Show("el valor de X1 es: " + xxt + "\n  el valor de X2 es " + yyt);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            C1.Text = string.Empty;
            C2.Text = string.Empty;
        }

        private void EL1_Load(object sender, EventArgs e)
        {
            Font fuenteElegante = new Font("Segoe UI Semilight", 11F, FontStyle.Regular);

            this.BackColor = Color.FromArgb(230, 240, 255);
            this.StartPosition = FormStartPosition.CenterScreen;

            EstiloBoton(button1);
            EstiloBoton(button2);

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
