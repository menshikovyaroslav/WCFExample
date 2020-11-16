using System.ServiceModel;

namespace WcfLib
{
    [ServiceContract]
    public interface ITransferObject
    {
        [OperationContract]
        int GetSum(int a, int b);
        [OperationContract]
        int GetMultiPly(int a, int b);
    }
}
