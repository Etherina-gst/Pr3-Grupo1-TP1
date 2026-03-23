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
    public partial class Formulario3 : Form
    {
        Formulario1 formulario1;
        public Formulario3(Formulario1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }

        private void Formulario3_Load(object sender, EventArgs e)
        {
  
        }

        private void Formulario3_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text + " " + txtApellido.Text;
            lsbElementos.Items.Add(Nombre);
            txtNombre.Clear();
            txtApellido.Clear();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lsbElementos.SelectedIndex != -1)
            {
                lsbElementos.Items.Remove(lsbElementos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nombre a borrar", "Advertencia");
            }
        }
    }
}
