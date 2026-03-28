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
    public partial class Formulario4 : Form
    {
        Formulario1 formulario1;
        public Formulario4(Formulario1 formulario1)
        {
            this.formulario1 = formulario1;
            InitializeComponent();
        }

        private void Formulario4_FormClosed(object sender, FormClosedEventArgs e)
        {
            formulario1.Show();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            string sexo = "";
            string estadoCivil = "";
            string oficios = "";

            if (rbFemenino.Checked)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }

            if (rbCasado.Checked)
            {
                estadoCivil = "Casado";
            }
            else
            {
                estadoCivil = "Soltero";
            }

            if(clbOficios.CheckedItems.Count >0) 
            {

                foreach (object item in clbOficios.CheckedItems)
                {
                    oficios = oficios + "\r\n " + "-" + item.ToString();
                }

                lblResultado.Text = "Usted selecciono los siguientes elementos:" + "\r\n" + 
                    "Sexo: " + sexo + "\r\n" +
                    "Estado Civil: " + estadoCivil + "\r\n" +
                    "Oficio: " + oficios; 

            }
            else 
            {
                MessageBox.Show("Por favor, seleccione al menos un oficio!", "ADVERTENCIA!"); 
            }

            
            

        }
    }
}
