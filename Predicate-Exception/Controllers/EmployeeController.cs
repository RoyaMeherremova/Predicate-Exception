using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Exception.Controllers
{
    internal class EmployeeController
    {
        public void ShowPersonBySalary()
        {
           
            IEmpoyeeService empoyeeService = new EmployeeService();
            empoyeeService.ShowPersonBySalary(1000);


        }
        
    }
}
