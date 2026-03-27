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
    }
}
