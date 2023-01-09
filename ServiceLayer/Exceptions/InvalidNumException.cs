using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Exceptions
{
    public class InvalidNumException:Exception
    {
        public InvalidNumException(string str):base(str) { }
       
    }
}
