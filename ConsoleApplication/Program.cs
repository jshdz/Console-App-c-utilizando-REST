using System;
using System.Runtime.Serialization.Json;
using System.Net;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacionSeleccionada;

            Console.WriteLine("Seleccione la operación que desea realizar: " + "\n" +
                               "1.Sumar" + "\n" +
                               "2.Restar" + "\n" +
                               "3.Multiplicar" + "\n" +
                               "4.Dividir" + "\n");

            operacionSeleccionada = Int32.Parse(Console.ReadLine());

            switch (operacionSeleccionada)
            {
                case 1:
                    procesarOperacion("sumar");
                    Console.ReadLine();
                    break;
                case 2:
                    procesarOperacion("restar");
                    Console.ReadLine();
                    break;
                case 3:
                    procesarOperacion("multiplicar");
                    Console.ReadLine();
                    break;
                case 4:
                    procesarOperacion("dividir");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opción Inválida" + "\n");
                    Console.ReadLine();
                    break;
            }
        }

        private static void procesarOperacion(string ptipoOperacion)
        {
            string valor1, valor2;

            Console.WriteLine("\n" + "Digite el valor número 1");
            valor1 = Console.ReadLine();

            Console.WriteLine("\n" + "Digite el valor número 2");
            valor2 = Console.ReadLine();

            string uri = "http://localhost:65171/ServicioAritmetico.svc/procesar/" + ptipoOperacion + "/" + valor1 + "/" + valor2 ;
            WebClient proxy = new WebClient();

            proxy.DownloadStringCompleted += Proxy_DownloadStringCompleted;
            proxy.DownloadStringAsync(new Uri(uri));

        }

        private static void Proxy_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            Stream stream = new MemoryStream(Encoding.Unicode.GetBytes(e.Result));
            DataContractJsonSerializer DtJsonSerial = new DataContractJsonSerializer(typeof(double));
            double resul = Convert.ToDouble(DtJsonSerial.ReadObject(stream).ToString());
            Console.WriteLine("\n" + "El resultado de la operación es: " + resul + "\n");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadLine();
        }
    }
}
