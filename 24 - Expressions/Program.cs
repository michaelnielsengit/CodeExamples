using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module12.Slide24
{




    public class Person
    {
        public string FirstName { get; set; } = "Jens";
        public string LastName { get; set; } = "Jensen";
        public int Age { get; set; } = 0;
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString() =>
        $"{FullName} is {Age} year{(Age == 1 ? "" : "s")} old";
    }


    class Program
    {
      

        static void Main( string[] args )
        {
            Person mig = new Person();
            mig.FirstName = "Michael";
      

            Console.WriteLine(mig.ToString());





            Console.ReadLine();
        }
    }
}
