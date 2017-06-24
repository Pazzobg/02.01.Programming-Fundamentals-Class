namespace _08.PersonalException
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NegativeValueInputException : System.Exception
    {
        public NegativeValueInputException() : base()
        {

        }

        public NegativeValueInputException(string message) : base(message)
        {
            int number = 0;
            if (number < 0)
            {
                ;
            }
        }



        public override string Message
        {
            get
            {
                return "My first exception is awesome!!!";
            }
        }
    }
}
