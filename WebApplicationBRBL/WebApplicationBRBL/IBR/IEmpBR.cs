using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBRBL.BR;
using WebApplicationBRBL.Model;
using WebApplicationBRBL.Response;

namespace WebApplicationBRBL.IBR
{
    public interface IEmpBR 
    {
        Task<string> CreateEmployee(Employee employee);
        Task<List<EmpResponse>> GetAllEmployee();
    }
}
