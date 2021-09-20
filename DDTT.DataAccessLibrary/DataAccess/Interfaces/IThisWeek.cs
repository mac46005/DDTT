using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTT.DataAccessLibrary.DataAccess.Interfaces
{
    public interface IThisWeek : IDisposable
    {
        decimal ThisWeek();
    }
}
