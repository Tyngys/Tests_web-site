using System.Collections.Generic;
using CP.Data.Models;

namespace CP.Business.Abstract
{
    public interface ITestOneService : IServiceBase
    {
        void GetMarks(int[] marks, string name);
    }
}
