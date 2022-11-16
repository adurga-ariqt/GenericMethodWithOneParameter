using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodWithOneParameter
{
    public  class Generics
    {
        public void Show<TypeOfValue>(TypeOfValue value)
        {
            Console.WriteLine("the variable name of value is:"+value);

        }
    }
}
