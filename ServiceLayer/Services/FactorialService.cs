using ServiceLayer.Exceptions;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class FactorialService : IFactorialService
    {
        public void Factorial(int num)
        {
            int multiple = 1;
            try
            {
                if (num>0)
                {
                    for (int i = 0; i <= num; i++)
                    {
                        multiple *= i;
                    }
                    Console.WriteLine(multiple);

                }
                else
                {
                    throw new InvalidNumException("Number is wrong");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}
