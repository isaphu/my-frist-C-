using System;

namespace myfirstCsharp
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var isa = new Person();
            isa.FirstName = "Isa";
            isa.LastName = "Phuyuthanon";
            isa.Introduce();

        }
    }

}


