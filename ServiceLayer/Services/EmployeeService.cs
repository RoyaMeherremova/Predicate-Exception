using DomainLayer.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class EmployeeService : IEmpoyeeService
    {

        public void GetPersonBySalary(int salary)
        {
            var persons = GetAll();
            var res = persons.FindAll(m => m.Salary > salary);
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Name}-{item.SurName}-{item.Address}");
            }
        }
        public void ShowPersonBySalary(int num)
        {
            var list = GetAll();
            GetPerson(m =>m.Salary > num, list);
        }
        public void GetPerson(Predicate<Person>func,List<Person>persons)
        {
           
            foreach (var item in persons)
            {
                if (func(item))
                {
                    Console.WriteLine($"{item.Name}-{item.SurName}-{item.Address}");
                }
            }
            
        }
        private List<Person> GetAll()
        {
            List<Person> list = new List<Person>();
            Person person1 = new Person()
            {
                Name = "Mirze",
                SurName = "Celilov",
                Address = "Baku",
                Salary = 1000

            }; 
            Person person2 = new Person()
            {
                Name = "Cavad",
                SurName = "Kerimov",
                Address = "Sumqayit",
                Salary = 2500

            }; Person person3 = new Person()
            {
                Name = "Kerim",
                SurName = "Yusifli",
                Address = "Xetai",
                Salary = 2800

            }; Person person4 = new Person()
            {
                Name = "Eli",
                SurName = "Eliyev",
                Address = "Xetai",
                Salary = 900

            };
            list.Add(person1);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);
            return list;
        }
    }
}
