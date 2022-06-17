using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBRBL.BR;
using WebApplicationBRBL.IBL;
using WebApplicationBRBL.Model;
using WebApplicationBRBL.Request;
using WebApplicationBRBL.Response;

namespace WebApplicationBRBL.BL
{
    public class EmpBL : IEmpBL
    {
        private readonly EmpBR empBR;
        public EmpBL(EmpBR iempBR)
        {
            empBR = iempBR;
        }

        public async Task<string>CreateEmployee(EmpRequest empRequest)
        {
          
                Employee employee = new Employee()
                {
                    Id = empRequest.Id,
                    Name = empRequest.Name,
                    DoorNo = empRequest.DoorNo,
                    StreetName = empRequest.StreetName,
                    City = empRequest.City,
                    PostalCode = empRequest.PostalCode,
                    Country = empRequest.Country
                };
           await empBR.CreateEmployee(employee);
            return "Created";

        }
        public async Task<List<EmpResponse>>GetAllEmployee()
        {
            return await empBR.GetAllEmployee();                       
        }
        public async Task<List<EmpResponse>> GetEmployeeById(int id)
        {
            return await empBR.GetEmployeeById(id);
        }

    }

}
