using System;

namespace myfirstCsharp
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public string BirthDate = "02/06/1994";
        public int Age = 1994;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }

}

