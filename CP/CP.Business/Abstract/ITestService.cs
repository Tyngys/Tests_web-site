namespace CP.Business.Abstract
{
    public interface ITestService : IServiceBase
    {
        void GetMarks(int[] marks, string name);
    }
}
