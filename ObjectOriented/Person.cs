using System;

namespace ObjectOriented
{
    public class Person
    {
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }

        public string MiddleName
        {
            get; set;
        }

        public DateTime DOB
        {
            get; set;
        }

        public int GetAge()
        {
            TimeSpan age = DateTime.Now - DOB;
            return age.Days / 365;
        }

        public string GetName() =>
             $"{FirstName} {LastName}";
    }
}