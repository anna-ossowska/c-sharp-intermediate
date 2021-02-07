using System;

namespace AccessModifiers
{
    public class Person
    {
        // Due to the private keyword we cannot access the _birthday field outside of the Person class
        private DateTime _birthday;

        // To set or get the birthday we need public methods
        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return _birthday;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthday(new DateTime(1995, 2, 16));
            Console.WriteLine(person.GetBirthday());
        }
    }
}
