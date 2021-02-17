using System;

namespace myfirstCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                int b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not convert to a byte");

            }
        }
    }
}

