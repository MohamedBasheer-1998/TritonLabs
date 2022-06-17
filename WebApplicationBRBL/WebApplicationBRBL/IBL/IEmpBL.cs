using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBRBL.BL;
using WebApplicationBRBL.Request;
using WebApplicationBRBL.Response;

namespace WebApplicationBRBL.IBL
{
    public interface IEmpBL
    {
        Task<string> CreateEmployee(EmpRequest empRequest);
        Task<List<EmpResponse>> GetAllEmployee();
    }
}
