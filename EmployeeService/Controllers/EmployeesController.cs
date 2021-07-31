using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDataAccess;

namespace EmployeeService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public IEnumerable<employee> Get()
        {
            using(happyEntities entities = new happyEntities())
            {
                 return entities.employee.ToString;
            }
        }

        public employee Get(int id)
        {
            using (happyEntities entities = new happyEntities())
            {
                return entities.employee.FirstOrdefault(e => e.ID == id);
            }
        }
    }
}
