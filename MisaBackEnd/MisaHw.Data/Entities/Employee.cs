using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisaHw.Data.Entities
{
    public class Employee
    {
        #region Property

        /// <summary>
        /// Khóa chính
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public string Gender { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }
        /// <summary>
        /// Chứng minh nhân dân
        /// </summary>
        public int? CMND { get; set; }
        /// <summary>
        /// Vị trí công việc
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Phòng ban
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string STK { get; set; }
        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        public string BankName { get; set; }
        /// <summary>
        /// Chi nhánh ngân hàng
        /// </summary>
        public string ChiNhanhNH { get; set; }
        #endregion
    }
}
