using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces
{
    public interface IGetByDate<T> : IDisposable
    {
        T GetByDate(DateTime date);
    }
}
