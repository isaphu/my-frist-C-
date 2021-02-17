using System;

namespace myfirstCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var isa = new Person();
            isa.FirstName = "Isa";
            isa.LastName = "Phuyuthanon";
            isa.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 3);
            Console.WriteLine(result);

            Age age = new Age();
            var dob = age.CalculateForBOD(2021, 1994);
            Console.WriteLine(dob);

            var numbers = new int[5];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] { "Isa", "Jack", "John" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);

        }
    }

}


