using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess.Interfaces
{
    public interface IInsert<T>
    {
        void Insert(T obj);
    }
}
