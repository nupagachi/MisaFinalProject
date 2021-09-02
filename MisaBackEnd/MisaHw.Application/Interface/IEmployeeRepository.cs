using MisaHw.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisaHw.ViewModels.Pager;

namespace MisaHw.Application.Interface
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}
