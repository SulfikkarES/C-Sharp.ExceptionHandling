using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.ExceptionHandling
{
    public class Numeric
    {
        int number;

        public void Acceptnumber()
        {
            Console.WriteLine("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            {
                throw new CheckValueException("Number is greater than 10");
            }
            else
            {
                Console.WriteLine($"The number entered is : {number}");
            }
        }
    }

    public class CheckValueException : Exception
    {
        public CheckValueException(string message) : base(message)
        {

        }
    }
}


       
       
       