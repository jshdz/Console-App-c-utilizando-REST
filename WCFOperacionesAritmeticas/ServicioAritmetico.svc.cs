using System;

namespace WCFOperacionesAritmeticas
{

    public class ServicioAritmetico : IServicioAritmetico
    {
        public double procesar(string ptipoOperacion, string pvalor1, string pvalor2)
        {
            double valor1, valor2;

            valor1 = Convert.ToDouble(pvalor1);
            valor2 = Convert.ToDouble(pvalor2);
            double resul = procesar(new Operacion(ptipoOperacion, valor1, valor2));
           
            return resul;
        }

        public double procesar(Operacion op)
        {
            switch (op.TipoOperacion)
            {
                case "sumar":
                    op.Resultado = sumar(op.Valor1, op.Valor2);
                    break;
                case "restar":
                    op.Resultado = restar(op.Valor1, op.Valor2);
                    break;
                case "multiplicar":
                    op.Resultado = multiplicar(op.Valor1, op.Valor2);
                    break;
                case "dividir":
                    op.Resultado = dividir(op.Valor1, op.Valor2);
                    break;
                default:
                    Console.WriteLine("Operación Inválida");
                    break;
            }

            return op.Resultado;
        }

        public double restar(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 - pvalor2;

            return resultado;
        }

        public double sumar(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 + pvalor2;

            return resultado;
        }

        public double dividir(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 / pvalor2;

            return resultado;
        }

        public double multiplicar(double pvalor1, double pvalor2)
        {
            double resultado = pvalor1 * pvalor2;

            return resultado;
        }
    }
}
