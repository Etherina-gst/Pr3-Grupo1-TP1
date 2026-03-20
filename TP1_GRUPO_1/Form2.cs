using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_1
{
    public partial class Formulario2 : Form
    {
        Formulario1 formulario1;
        public Formulario2(Formulario1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }

        private void Formulario2_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private bool verificarRepetidos(String nombreIngresado)
        {
            foreach(String nombre in lstNombresIngresados.Items)
                if (nombre.ToLower() == nombreIngresado.ToLower())
                    return false;
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "" && verificarRepetidos(txtNombre.Text.Trim()))
            {
                lstNombresIngresados.Items.Add(txtNombre.Text.Trim());
                txtNombre.Text = "";
            }
            else if (!verificarRepetidos(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Debe ingresar un nombre nuevo para agregarlo a la lista");
                txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre para agregarlo a la lista");
                txtNombre.Text = "";
            }
        }

        private void btnPasarUnNombre_Click(object sender, EventArgs e)
        {
            if (lstNombresIngresados.SelectedIndex != -1)
            {
                string item = lstNombresIngresados.SelectedItem.ToString();
                lstNombresGuardados.Items.Add(item);
                lstNombresIngresados.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un ítem de la lista");
            }
        }
    }
}
