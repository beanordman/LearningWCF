using System.ServiceModel;

namespace Client
{
    [ServiceContract(Namespace = "http://iainb.com/2012")]
    public interface IHelloIndigoService
    {
        [OperationContract]
        string HelloIndigo();
    }

    class ServiceProxy
    {
    }
}
