using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisaHw.Application.Interface
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
    }
}
