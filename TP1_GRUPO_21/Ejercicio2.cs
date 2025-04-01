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
    public partial class Ejercicio2: Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un elemento para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstPersonas.Items.Remove(lstPersonas.SelectedItem);
        }
    }
}
