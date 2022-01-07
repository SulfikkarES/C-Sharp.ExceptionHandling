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
#endregion Copyright EazyLearn

#region Included namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

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
