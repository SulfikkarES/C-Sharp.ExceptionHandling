#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : C#ExceptionHandling.cs
// Purpose         : To practice exception handling in c# 
// Creation Date   : 07-10-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright 

#region Included namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

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


       
       
       