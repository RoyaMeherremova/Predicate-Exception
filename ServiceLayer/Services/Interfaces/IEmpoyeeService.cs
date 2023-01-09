using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmpoyeeService
    {
        void GetPersonBySalary(int num);
        void GetPerson(Predicate<Person> func, List<Person> persons);
        void ShowPersonBySalary(int num);
     } 
}
