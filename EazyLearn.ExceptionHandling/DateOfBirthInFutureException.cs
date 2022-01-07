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
using System.Runtime.Serialization;
#endregion 

namespace EazyLearn.ExceptionHandling
{
    [Serializable]
    internal class DateOfBirthInFutureException : Exception
    {
        public DateOfBirthInFutureException()
        {
        }

        public DateOfBirthInFutureException(string message) : base(message)
        {
        }

        public DateOfBirthInFutureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateOfBirthInFutureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}