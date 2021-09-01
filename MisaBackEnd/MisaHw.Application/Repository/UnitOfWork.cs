using MisaHw.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisaHw.Application.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IEmployeeRepository employeeRepository)
        {
            Employees = employeeRepository;
        }
        public IEmployeeRepository Employees { get; }
    }
}
