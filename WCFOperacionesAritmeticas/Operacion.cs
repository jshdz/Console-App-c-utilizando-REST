using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFOperacionesAritmeticas
{

    public class Operacion
    {
        public string TipoOperacion { get; set; }

        public double Valor1 { get; set; }

        public double Valor2 { get; set; }

        public double Resultado { get; set; }

        public Operacion(string ptipoOperacion, double pvalor1, double pvalor2)
        {
            TipoOperacion = ptipoOperacion;
            Valor1 = pvalor1;
            Valor2 = pvalor2;
            Resultado = 0;
        }
    }
}