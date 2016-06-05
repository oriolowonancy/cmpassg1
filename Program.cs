using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diffvarconvrsns
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt;
            double myDouble;
            string myString;

            myInt = 20;

            myDouble = myInt;
            Console.WriteLine("myDouble is {0}.", myDouble);

            myDouble = 10.5;
            myInt = myDouble; //a double can't be converted to int(not without casting)
            Console.WriteLine(myInt);

            myInt = (int)myDouble; //i could write it as: myInt = (int)10.5
            Console.WriteLine("After casting, myInt = {0}.", myInt);

            myString = myDouble.ToString();
            Console.WriteLine("myDouble as a string: {0}", myString);

            Console.Write("Please enter a number: ");
            myString = Console.ReadLine();

            Console.WriteLine("myString converted to double: {0}", Convert.ToDouble(myString));
            Console.ReadLine();

        }
    }
}
