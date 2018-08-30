using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ClsSalario
    {
        #region Atributos
            private double vlnSalarioBruto;
            private double vlnSalarioNeto;
            private double vlnCCSS;
            private double vlnRenta;
            private double vlnAsociacion;
            private double vlnTotalDeduccciones;
            private string vlcNombre;
        #endregion


        #region Propiedades
            public double SalarioBruo
            {
                get
                {
                    return vlnSalarioBruto;
                }
                set
                {
                    vlnSalarioBruto = value;
                }
            }
            public double SalarioNeto
            {
                get
                {
                    return vlnSalarioNeto;
                }
            }

            public double CCSS
            {
                get
                {
                    return vlnCCSS;
                }
            }

            public double Renta
            {
                get
                {
                    return vlnRenta;
                }
            }
            public double Asociacion
            {
                get
                {
                    return vlnAsociacion;
                }
            }

            public string NombreEmpleado
            {
                get
                {
                    return vlcNombre;
                }
                set
                {
                    vlcNombre = value;
                }
            }
            public double TotalDeducciones
            {
                get
                {
                    return vlnTotalDeduccciones;
                }
            }

        #endregion

        #region Constantes
            private const double PorcenCCSS = 0.09;
            private const double PorcenASO = 0.05;
        #endregion

        #region Metodos
            public double CalcularCaja()
            {
                vlnCCSS = vlnSalarioBruto * PorcenCCSS;
                return vlnCCSS;
            }

            public double CalcularCaja(double pvnSalario)
            {
                vlnCCSS = pvnSalario * PorcenCCSS;
                return vlnCCSS;
            }
        //**************************************
        public double CalcularAso()
            {
                vlnAsociacion = vlnSalarioBruto * PorcenASO;
                return vlnAsociacion;
            }
            //**************************************
            public double CalcularRenta()
            {
                double vln_PrimerTope = 0, vln_SegundoTope = 0;
                if (vlnSalarioBruto < 799000)
                {
                    vlnRenta = 0;
                }
                else if (vlnSalarioBruto >= 799000 && vlnSalarioBruto < 1199000)
                {
                    vln_PrimerTope = vlnSalarioBruto - 799000;
                    vlnRenta = vln_PrimerTope * 0.1;
                }
                else {
                    vln_PrimerTope = 1199000 - 799000;
                    vln_SegundoTope = vlnSalarioBruto - 1199000;
                    vlnRenta = (vln_PrimerTope * 0.1) + (vln_SegundoTope * 0.15);
                }

                return vlnRenta;
            }

            public double CalcularTotal()
            {
                vlnTotalDeduccciones = vlnCCSS + vlnRenta + vlnAsociacion;
                return vlnTotalDeduccciones;
            }
        #endregion
    }//clase
}//namespace
