namespace WcfLib
{
    public class TransferObject : ITransferObject
    {
        public int GetSum(int a, int b)
        {
            return a + b;
        }
        public int GetMultiPly(int a, int b)
        {
            return a * b;
        }
    }
}
