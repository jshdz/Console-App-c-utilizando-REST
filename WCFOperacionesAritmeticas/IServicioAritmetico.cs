using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFOperacionesAritmeticas
{
    
    [ServiceContract]
    public interface IServicioAritmetico
    {
        
        [OperationContract]
        [WebGet(UriTemplate = "/procesar/{ptipoOperacion}/{pvalor1}/{pvalor2}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        double procesar(string ptipoOperacion, string pvalor1, string pvalor2);

        double procesar(Operacion op);
  
        double sumar(double pvalor1, double pvalor2);
        
        double restar(double pvalor1, double pvalor2);

        double multiplicar(double pvalor1, double pvalor2);
        
        double dividir(double pvalor1, double pvalor2);
    }

}
