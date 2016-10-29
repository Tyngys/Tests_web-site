using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP.Data.Models;

namespace CP.Business.Abstract
{
    public interface ISecondTestService : IServiceBase
    {
        void GetMark(int mark, string name);
    }
}
