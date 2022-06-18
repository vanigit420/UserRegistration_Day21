using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Day21
{
    public class UserException : Exception
    {
        //Exception types
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_PASSWORD,
            INVALID_MOBILE
        }
        private ExceptionType type;
        //Constructor to initialize types
        public UserException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}