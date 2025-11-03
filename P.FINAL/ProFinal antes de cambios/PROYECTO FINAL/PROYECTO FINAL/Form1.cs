using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PROYECTO_FINAL
{
    public partial class Form1 : Form
    {

        

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if ((int)m.Result == HTCLIENT)
                {
                    m.Result = (IntPtr)HTCAPTION;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
            System.Media.SystemSounds.Asterisk.Play(); // sonido leve de notificación

            this.ControlBox = false;
            this.Text = ""; // Quita el título si quieres un look más moderno
            this.FormBorderStyle = FormBorderStyle.None;



        }

        private void button1_Click(object sender, EventArgs e)
        {

            ECUACIONES_LIN ecuaciones = new ECUACIONES_LIN();
            ecuaciones.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RAICES raices = new RAICES();
            raices.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Fondo moderno: degradado gris azulado
            this.BackColor = Color.FromArgb(40, 45, 60);

            //  Propiedades del formulario
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";

            //  Estilo uniforme para todos los botones
            EstiloBoton(button1);
            EstiloBoton(button2);


            // Quitar la barra del sistema
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";
            this.BackColor = Color.FromArgb(245, 245, 245);

            // Fondo degradado suave
            this.DoubleBuffered = true;

            // Botón personalizado de cierre
            Button btnCerrar = new Button();
            btnCerrar.Text = "✖";
            btnCerrar.ForeColor = Color.White;
            btnCerrar.BackColor = Color.FromArgb(220, 20, 60);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btnCerrar.Size = new Size(35, 35);
            btnCerrar.Location = new Point(this.Width - 45, 10);
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.MouseEnter += (s, ev) => btnCerrar.BackColor = Color.FromArgb(255, 69, 0);
            btnCerrar.MouseLeave += (s, ev) => btnCerrar.BackColor = Color.FromArgb(220, 20, 60);
            btnCerrar.Click += (s, ev) => Application.Exit();

            this.Controls.Add(btnCerrar);
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

       



    }
}
