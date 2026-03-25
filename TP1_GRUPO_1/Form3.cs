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
            string Nombre = txtNombre.Text.Trim();
            string Apellido = txtApellido.Text.Trim();

            if (Nombre.Length > 0 && Apellido.Length > 0)
            {
                string NombreCompleto = Nombre + " " + Apellido;

                if (VerificarRepetido(NombreCompleto))
                {
                    return;
                }
                lsbElementos.Items.Add(NombreCompleto);
                txtNombre.Clear();
                txtApellido.Clear();
            }
            else
            {
                MessageBox.Show("Deben completarse ambos campos, tanto el de nombre como el de apellido!!", "ATENCION" );
            }
            

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

        private bool VerificarRepetido(string NombreCompleto)
        {
            string Nuevo = NombreCompleto.Trim().ToUpper();

            foreach (string Persona in lsbElementos.Items)
            {
                if (Persona.ToUpper() == Nuevo)
                {
                    return true;
                }

            }

            return false;
        }

    }
}
