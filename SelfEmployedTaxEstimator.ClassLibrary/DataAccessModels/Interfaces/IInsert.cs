using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfEmployedTaxEstimator.ClassLibrary.DataAccessModels.Interfaces
{
    public interface IInsert<T> : IDisposable
    {
        void Insert(T obj);
    }
}
