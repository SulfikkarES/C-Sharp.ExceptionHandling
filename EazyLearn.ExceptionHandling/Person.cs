using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace EazyLearn.ExceptionHandling
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
        readonly string Adult = "Adult";
        readonly string Birthday = "Happy Birthday";

        public Person()
        {
            Console.WriteLine("Enter FirstName");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter EmailAddress");
            EmailAddress = Console.ReadLine();
            Console.WriteLine("Enter DateOfBirth in the format 'dd-mm-yyyy'");
            DateOfBirth = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
        }
       
        public void FindFuture()
        {
            Console.WriteLine(DateOfBirth);
            try
            {
                if (DateOfBirth.Year > DateTime.Now.Year)
                    throw new Exception("Invalid Date");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void FindPast()
        {
            Console.WriteLine(DateOfBirth);
            try
            {
                if (DateOfBirth.Year  < Convert.ToDateTime("01/01/1950").Year)
                {
                    {
                       throw new DateOfBirthInPastException("Entered date of birth is too far");
                    }
                }
    
            }
            catch (DateOfBirthInPastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void FindIsAdult()
        {
            try
            {
                if (DateOfBirth.Year - DateTime.Now.Year >= 18)
                {
                    Console.WriteLine(Adult);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FindIsBirthday()
        {
            try
            {
                if (DateOfBirth.Month == DateTime.Now.Month && DateOfBirth.Day == DateTime.Now.Day)
                {
                    Console.WriteLine(Birthday);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void ValidateEmail()
        {
            try
            {
                Console.WriteLine($"email id is {EmailAddress}");
                var mail = new MailAddress(EmailAddress);
                bool isValidEmail = mail.Host.Contains(".");
                if(!isValidEmail)
                {
                    Console.WriteLine("Invalid Email ID");
                }
                else
                {
                    Console.WriteLine("Email ID is Valid");
                }
                Console.ReadLine();
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid Email ID");
                Console.ReadLine();
            }
        }
       
    }

    [Serializable]
    internal class DateOfBirthInPastException : Exception
    {
        public DateOfBirthInPastException()
        {
        }

        public DateOfBirthInPastException(string message) : base(message)
        {
        }

        public DateOfBirthInPastException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateOfBirthInPastException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
