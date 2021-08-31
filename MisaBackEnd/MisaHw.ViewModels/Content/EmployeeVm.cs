using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisaHw.ViewModels.Content
{
    public class EmployeeVm
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? CMND { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string STK { get; set; }
        public string BankName { get; set; }
        public string ChiNhanhNH { get; set; }
    }
}
