using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // object initialization

            Student student = new Student()
            {
                Id = 1,
                Name = "A",
                RegNo = "001"

            };

            // array initialization
            int[] numbers = {1, 3, 4, 56, 7};


            // list initialization
            List<Student> studentList = new List<Student>()
            {
                student,
                new Student(){Id = 2, Name = "B", RegNo = "002"},
                new Student(){Id = 3, Name = "C", RegNo = "003"},
            };

            foreach (Student s in studentList)
            {
                Console.WriteLine(s.Id +" "+s.Name+" "+s.RegNo);
            }

            Console.ReadKey();
        }
    }
}
