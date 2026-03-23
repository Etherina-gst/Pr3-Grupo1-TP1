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
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEjerUno_Click(object sender, EventArgs e)
        {
            Formulario2 formulario2 = new Formulario2(this);
            formulario2.Show();
            this.Hide();
        }

        private void btnEjerDos_Click(object sender, EventArgs e)
        {
            Formulario3 formulario3 = new Formulario3(this);
            formulario3.Show();
            this.Hide();
        }

        private void btnEjerTres_Click(object sender, EventArgs e)
        {
        
        }
    }
}
