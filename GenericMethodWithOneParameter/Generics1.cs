using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethodWithOneParameter
{
   public  class Generics1
    {
         public void Mymethod()
        {
            var exo = new Generics();
            var value1 = 246;
            exo.Show(value1);
            var value2 = "Durga";
            exo.Show(value2);
            var value3 = 'd';
            exo.Show(value3);
            var value4 = 34.67;
            exo.Show(value4);
            Console.ReadLine();
        }
    }
}
