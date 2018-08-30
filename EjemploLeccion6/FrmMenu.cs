using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLeccion6
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void mnuCalculo_Click(object sender, EventArgs e)
        {
            frmSalario Formulario = new frmSalario();
            Formulario.Show();
        }

        private void mnuAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayuda no disponible, consulte más tarde");
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
