using System;

namespace six
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public class Detail
        {
            public string firstName;
            public string lastName;
            public string userName;
            string password;

            public Detail(string _firstName, string _lastName, string _userName, string _password)
            {
                firstName = _firstName;
                lastName = _lastName;
                userName = _userName;
                password = _password;
            }
        }
    }
}
