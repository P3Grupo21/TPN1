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
    public partial class FormularioPrincipal: Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            var ejercicio1 = new Ejercicio1();
            this.Hide();
            ejercicio1.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
