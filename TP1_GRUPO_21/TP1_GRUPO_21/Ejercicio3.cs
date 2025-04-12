using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_21
{
    public partial class Ejercicio3: Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            if (rbFemenino.Checked)
            {
                sexo = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                sexo = "Masculino";
            }

            lblResultado.Text = $"Usted seleccionó los siguientes elementos:\nSexo: {sexo}\n";
        }
    }
}
