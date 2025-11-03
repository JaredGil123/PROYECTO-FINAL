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
    public partial class ECUACIONES_LIN : Form
    {
        public ECUACIONES_LIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EL1 el1 = new EL1();
            el1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EL2 el2 = new EL2();
            el2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EL3 el3 = new EL3();
            el3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EL4 el4 = new EL4();
            el4.Show();
        }

        private void ECUACIONES_LIN_Load(object sender, EventArgs e)
        {
            //  Fondo moderno: degradado gris azulado
            this.BackColor = Color.FromArgb(40, 45, 60);

            //  Propiedades del formulario
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";

            //  Estilo uniforme para todos los botones
            EstiloBoton(button1);
            EstiloBoton(button2);
            EstiloBoton(button3);
            EstiloBoton(button4);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            System.Media.SystemSounds.Asterisk.Play(); // sonido leve de notificación


        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(40, 45, 60),    // tono inicial
                Color.FromArgb(25, 30, 45),    // tono final
                135f))                         // ángulo
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void EstiloBoton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.FromArgb(65, 105, 225); // azul moderno
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.Cursor = Cursors.Hand;

            // Efecto hover visual
            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(100, 149, 237); // tono más claro
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(65, 105, 225); // vuelve al original
            };
        }
    }
}
