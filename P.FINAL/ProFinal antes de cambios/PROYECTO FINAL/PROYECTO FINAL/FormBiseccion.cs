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
    public partial class FormBiseccion : Form
    {
        public string seleccion;
        public FormBiseccion()
        {
            InitializeComponent();
        }


        private void btnAceptar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted ha seleccionado la ecuación " + seleccion, "Información",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("A continuación, se le pedirá ingresar los datos correspondientes",
            "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Datos Datos = new Datos();
            Datos2 Datos2 = new Datos2();
            Datos3 Datos3 = new Datos3();
            //Oculta el programa principal
            this.Hide();
            //Valida que grado se realizará
            if (rbtnGrado4.Checked)
                Datos.Show();
            else if (rbtnGrado3.Checked)
                Datos2.Show();
            else if (rbtnGrado2.Checked)
                Datos3.Show();
        }

        private void imgGrado4_Click(object sender, EventArgs e)
        {
            rbtnGrado4.Checked = true;
            seleccion = "Grado 4";
        }

        private void imgGrado3_Click(object sender, EventArgs e)
        {
            rbtnGrado3.Checked = true;
            seleccion = "Grado 3";
        }

        private void imgGrado2_Click(object sender, EventArgs e)
        {
            rbtnGrado2.Checked = true;
            seleccion = "Grado 2";
        }
    }
}
