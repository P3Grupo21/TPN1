using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace TP1_GRUPO_21
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text.Trim();

            if (!string.IsNullOrWhiteSpace(nombre) && nombre != "Ingrese un nombre")
            {
                string nombreNormalizado = nombre.ToLower();
                bool existe = false;
                foreach (string item in lbNombresIz.Items)
                {
                    if (item.ToLower() == nombreNormalizado)
                    {
                        existe = true; break;
                    }
                }
                if (!existe)
                {
                    lbNombresIz.Items.Add(nombre);
                }
                else
                {
                    MessageBox.Show("El nombre ya ha sido agregado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbNombresIz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if (lbNombresIz.SelectedItem != null)
            {
            string nombreSeleccionado =lbNombresIz.SelectedItem.ToString();

                lbMover.Items.Add(nombreSeleccionado);
                lbNombresIz.Items.Remove(nombreSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}