using System;

namespace myfirstCsharp
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int BirthDate;
        public int Age;
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

    }

}


