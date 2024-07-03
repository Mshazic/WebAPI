using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAdminPortal.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeAdminPortal.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        // GET: api/values
        [HttpGet]
        public IActionResult GetAllEmployees()
        {

            var allEmployees = dbContext.Employees.ToList();
            return Ok(allEmployees);
        }

       
    }
}

