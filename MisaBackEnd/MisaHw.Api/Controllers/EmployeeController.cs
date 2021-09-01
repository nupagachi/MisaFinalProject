using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MisaHw.Application.Interface;
using MisaHw.Data.Entities;

namespace MisaHw.Api.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
		/// <summary>
		/// API hiển thị tất cả các nhân viên
		/// </summary>
		/// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _unitOfWork.Employees.GetAllAsync();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
		/// <summary>
		/// API lấy thông tin nhân viên theo id
		/// </summary>
		/// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var data = await _unitOfWork.Employees.GetByIdAsync(id);
                if (data == null) return Ok();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
		/// <summary>
		/// API thêm mới nhân viên
		/// </summary>
		/// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {
            try
            {
                var data = await _unitOfWork.Employees.AddAsync(employee);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
     
        }
        
		/// <summary>
		/// API xóa nhân viên
		/// </summary>
		/// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var data = await _unitOfWork.Employees.DeleteAsync(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

		/// <summary>
		/// API cập nhập nhân viên
		/// </summary>
		/// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Update(Employee employee)
        {
            try
            {
                var data = await _unitOfWork.Employees.UpdateAsync(employee);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
