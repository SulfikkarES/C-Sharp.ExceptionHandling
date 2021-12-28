using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace EazyLearn.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n\t *** Menu ***\n");
                Console.WriteLine("1 :Divided by zero" +
                    "\n 2 : Person Details " +
                    "\n 3 : Accept Value");
                Console.WriteLine("\nPlease Select Any Option : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1 :Divided by zero\n\t*******\n");
                        CreateDivision();
                        break;
                    case 2:
                        Console.WriteLine("2 : Person Details\n\n\t*****\n");
                        CreatePersonDetails();
                        break;
                    case 3:
                        Console.WriteLine("3 : Accept Value\n\t*****\n");
                        AcceptNumber();
                        break;
                    default:
                        Console.WriteLine(" Invalid Option Is Selected "); break;
                }
            } while (choice != 0);
            Console.Read();
        } //main end here

        static void CreateDivision()
        {
            DivisionException obj = new DivisionException();
            obj.Division();
            Console.ReadLine();
        } // End of CreateDivision()

        static void CreatePersonDetails()
        {
            Person obj1 = new Person();
            obj1.FindFuture();
            try
            {
                obj1.FindPast();
            }
            catch (DateOfBirthInPastException e)
            {
                Console.WriteLine(e.Message);
            }
            
            obj1.FindIsAdult();
            obj1.FindIsBirthday();
            obj1.ValidateEmail();
            Console.ReadLine();
        } // End of CreatePersonDetails()
        static void AcceptNumber()
        {
            Numeric obj = new Numeric();
            try
            {
                obj.Acceptnumber();
            }
            catch (CheckValueException e)
            {

                Console.WriteLine(e.Message);
                
            }
            Console.ReadLine();
        } // End of AcceptNumber()

    }
}
    

