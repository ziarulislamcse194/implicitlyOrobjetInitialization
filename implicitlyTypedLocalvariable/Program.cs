using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedCSharp;

namespace implicitlyTypedLocalvariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 32;
            string name = "abcd";

            var number2 = 25;
            var name2 = "efgh";


            //number2 = "dsaw";
            //name2 = 353;

            var student = new Student();
            var students = new LinkedList<Student>();

        }
    }
}
