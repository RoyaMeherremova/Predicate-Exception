using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Exception.Controllers
{
    public class FactorialController
    {
        public void Factorial()
        {
            Console.WriteLine("Add number:");
            int num=int.Parse(Console.ReadLine());
            IFactorialService factorialService = new FactorialService();
            factorialService.Factorial(num);
        }
        
        
       
    }
}
