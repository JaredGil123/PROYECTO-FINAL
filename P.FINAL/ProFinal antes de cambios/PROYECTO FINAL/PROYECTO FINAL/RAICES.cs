using MSecante;
using BISECCION;
using NewRapshon;
using Regula_falsi;
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
    public partial class RAICES : Form
    {
        public RAICES()
        {
            InitializeComponent();
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

        private void btnRf_Click(object sender, EventArgs e)
        {
            FormRegulaF RfForm = new FormRegulaF();
            RfForm.Show();

        }

        private void btnNewton_Click(object sender, EventArgs e)
        {
            FormNewton newtonForm = new FormNewton();
            newtonForm.Show();
        }

        private void btnBiseccion_Click(object sender, EventArgs e)
        {
            FormBiseccion biseccionForm = new FormBiseccion();
            biseccionForm.Show();
        }

        private void btnSecante_Click(object sender, EventArgs e)
        {
            Secante secanteForm = new Secante();
            secanteForm.Show();
        }

        private void RAICES_Load(object sender, EventArgs e)
        {
            //  Fondo moderno: degradado gris azulado
            this.BackColor = Color.FromArgb(40, 45, 60);

            //  Propiedades del formulario
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MENÚ PRINCIPAL";

            //  Estilo uniforme para todos los botones
            EstiloBoton(btnBi);
            EstiloBoton(btnSe);
            EstiloBoton(btnNr);
            EstiloBoton(btnRf);







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
