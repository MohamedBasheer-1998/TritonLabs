using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationBRBL.BL;
using WebApplicationBRBL.IBL;
using WebApplicationBRBL.Model;
using WebApplicationBRBL.Request;

namespace WebApplicationBRBL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly EmpBL EmpBL;
        public EmpController(EmpBL mEmpBL)
        {
            EmpBL = mEmpBL;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateEmployee([FromBody] EmpRequest empRequest)
        {
           var response = await EmpBL.CreateEmployee(empRequest);
            if (response == null)
            {
                return NoContent();
            }
            return Ok(response);
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllEmployee()
        {
            var res = await EmpBL.GetAllEmployee();
            if(res != null)
            {
                return Ok(res);

            }
            return NoContent();
        }
        [HttpGet("getById")]
        public async Task<IActionResult>GetEmployeeById(int id)
        {
            var resp = await EmpBL.GetEmployeeById(id);
            return Ok(resp);

        }
    }
}
