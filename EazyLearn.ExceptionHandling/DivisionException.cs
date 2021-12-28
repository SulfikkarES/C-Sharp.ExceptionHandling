using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.ExceptionHandling
{
    public class DivisionException
    {
        public void Division()
        {
            int diviser,dividend, quotient;

            Console.WriteLine("Enter divident");
            dividend = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Enter diviser");
            diviser = Convert.ToInt32(Console.ReadLine());
            try
            {
                quotient = dividend / diviser;
                Console.WriteLine($"Result is :{quotient}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }
    }
}
