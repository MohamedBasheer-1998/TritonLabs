using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBRBL.DataBase;
using WebApplicationBRBL.IBR;
using WebApplicationBRBL.Model;
using WebApplicationBRBL.Response;

namespace WebApplicationBRBL.BR
{
    public class EmpBR : IEmpBR
    {
        private readonly EmpDbContext empDbContext;
        public EmpBR(EmpDbContext iempDbContext)
        {
            empDbContext = iempDbContext;
        }

        public async Task<string>CreateEmployee(Employee employee)
        {
            await empDbContext.Employee.AddAsync(employee);
            empDbContext.SaveChanges();
            return $"Successfully{employee.Id}"; 
        }
        public async Task<List<EmpResponse>>GetAllEmployee()
        {
            return await (from emp in empDbContext.Employee
                          select new EmpResponse
                          {
                              EmpId = emp.Id,
                              City = emp.City,
                              Country = emp.Country,
                              PostalCode = emp.PostalCode
                          }).ToListAsync();
                           
        }
        public async Task<List<EmpResponse>> GetEmployeeById(int id)
        {
            return await (from b in empDbContext.Employee
                          where b.Id == id
                          select new EmpResponse
                          {
                              EmpId = b.Id,
                              City = b.City,
                              PostalCode = b.PostalCode,
                              Country = b.Country

                          }).ToListAsync();
        }
    }
}
