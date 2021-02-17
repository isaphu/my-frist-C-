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
        }
    }

}


