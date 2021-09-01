using Dapper;
using Microsoft.Extensions.Configuration;
using MisaHw.Application.Interface;
using MisaHw.Data.Entities;
using MisaHw.Utilities.Constants;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MisaHw.Application.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _configuration;
        public EmployeeRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> AddAsync(Employee entity)
        {
            var sql = "Insert into Employees (Name,Code,Gender,DateOfBirth,CMND,Position,Department,STK,BankName,ChiNhanhNH) VALUES (@Name,@Code,@Gender,@DateOfBirth,@CMND,@Position,@Department,@STK,@BankName,@ChiNhanhNH)";
            var parameters = new
            {
                Name = entity.Name.Trim(),
                Code = entity.Code.Trim(),
                Gender = entity.Gender.Trim(),
                DateOfBirth = entity.DateOfBirth?.ToString("yyyy-MM-dd HH:mm:ss"),
                CMND = entity.CMND,
                Position = entity.Position.Trim(),
                Department = entity.Department.Trim(),
                STK = entity.STK.Trim(),
                BankName = entity.BankName.Trim(),
                ChiNhanhNH = entity.ChiNhanhNH.Trim(),
            };
            using (var conn = new MySqlConnection(_configuration.GetConnectionString(CommonConstants.DefaultConnection)))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var result = await conn.ExecuteAsync(sql, parameters);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Employees WHERE Id = @Id";
            using (var conn = new MySqlConnection(_configuration.GetConnectionString(CommonConstants.DefaultConnection)))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var result = await conn.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IReadOnlyList<Employee>> GetAllAsync()
        {
            var sql = "SELECT * FROM Employees";
            using (var conn = new MySqlConnection(_configuration.GetConnectionString(CommonConstants.DefaultConnection)))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var result = await conn.QueryAsync<Employee>(sql);
                return result.ToList();
            }
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Employees WHERE Id = @Id";
            using (var conn = new MySqlConnection(_configuration.GetConnectionString(CommonConstants.DefaultConnection)))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }

                var result = await conn.QuerySingleOrDefaultAsync<Employee>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Employee entity)
        {
            var sql = "UPDATE Employees SET Name = @Name,Code = @Code,Gender = @Gender,DateOfBirth = @DateOfBirth,CMND = @CMND,Position =@Position,Department = @Department,STK=@STK,BankName=@BankName,ChiNhanhNH=@ChiNhanhNH WHERE Id = @Id";

            using (var conn = new MySqlConnection(_configuration.GetConnectionString(CommonConstants.DefaultConnection)))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    await conn.OpenAsync();
                }
                var parameters = new
                {
                    Id = entity.Id,
                    Name = entity.Name.Trim(),
                    Code = entity.Code.Trim(),
                    Gender = entity.Gender.Trim(),
                    DateOfBirth = entity.DateOfBirth?.ToString("yyyy-MM-dd HH:mm:ss"),
                    CMND = entity.CMND,
                    Position = entity.Position.Trim(),
                    Department = entity.Department.Trim(),
                    STK = entity.STK.Trim(),
                    BankName = entity.BankName.Trim(),
                    ChiNhanhNH = entity.ChiNhanhNH.Trim(),
                };
                var result = await conn.ExecuteAsync(sql, parameters);
                return result;
            }
        }
    }
}
