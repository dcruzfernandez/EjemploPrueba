using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace EjemploLeccion6
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            IniciarControles();
        }
        public void IniciarControles()
        {
            txttotal.Text = string.Empty;
            txtsalarioNeto.Text = string.Empty;
            TxtSalarioBase.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkAsociacion.Checked = false;
            chkCCSS.Checked = false;
            chkRenta.Checked = false;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            ClsSalario vlo_Calculos = new ClsSalario();
            double vln_Total = 0, vln_Salario = 0;
            if (!string.IsNullOrEmpty(TxtSalarioBase.Text))
            {
                if (double.TryParse(TxtSalarioBase.Text, out vln_Salario))
                {
                    vlo_Calculos.SalarioBruo = double.Parse(TxtSalarioBase.Text);
                     
                    if (chkCCSS.Checked == true)
                    {
                        //vlo_Calculos.CalcularCaja();
                        vlo_Calculos.CalcularCaja(vln_Salario);
                    }
                    if (chkAsociacion.Checked == true)
                    {
                        vlo_Calculos.CalcularAso();
                    }
                    if (chkRenta.Checked == true)
                    {
                        vlo_Calculos.CalcularRenta();
                    }
                    vln_Total = vlo_Calculos.CalcularTotal();
                    txttotal.Text = vln_Total.ToString();
                    vln_Salario = vlo_Calculos.SalarioBruo - vln_Total;
                    txtsalarioNeto.Text = vln_Salario.ToString("¢#,##0.00");
                    MessageBox.Show("renta"+vlo_Calculos.Renta.ToString());
                    MessageBox.Show("CCSS" + vlo_Calculos.CCSS.ToString());
                    MessageBox.Show("Asociacion" + vlo_Calculos.Asociacion.ToString());
                    
                }
                else
                {
                    MessageBox.Show("El salario debe almacenar un valor numérico");
                }
            }
            else {
                MessageBox.Show("El salario no se ha indicado.");
            }
        }
    }///clase
}//namespace
