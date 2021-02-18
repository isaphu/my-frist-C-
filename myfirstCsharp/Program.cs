using System;

namespace myfirstCsharp
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        ReggisteredAirMail = 2,
        Express = 3
    }
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


            var middleName = "Ivanovich";
            var title = "Mr.";

            var fullName = string.Format("You can call me {0} {1}", title, middleName);
            Console.WriteLine(fullName);

            var method = ShippingMethod.Express;
            Console.WriteLine((int)method); //get the shipping method

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId); //convert an enum to and from an integer 

            Console.WriteLine(method.ToString()); //use method toString to convert enum to str

            var methodName = "Express"; //converting str to num by parsing 
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


            var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a,b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1: {0}, array2: {1}", array1[0], array2[0]));


            //conditional statments 
            //if-else
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if ( hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }

            bool isGoldCustomer = true;

            /*
            float price;
            if (isGoldCustomer)
                price = 19.95f;
            else
                price = 29.95f;
            */

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine("You are a gold customer");

            //iteration statment
            
            /*
            for (var i = 0; i <= 10 ; i++)
            {
                if ( i %2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            var name = "Isa Phuyuthanon";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }


            //will have the same output
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);

                i++;
            }

            while (true)
            {
                Console.Write("Type your name");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
            */

            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1,10));
            }

            var numbersss = 0;

            while (numbersss < 5)
            {
                numbersss += 2;
            }


            //array

            var myNums = new[] { 3, 7, 9, 10, 20, 24, 25 };

            //length
            Console.WriteLine("Length: " + myNums.Length);

            //clear 
            Array.Clear(myNums, 0, 2);

            Console.WriteLine("Effect of clear");
            foreach( var n in myNums)
                Console.WriteLine(n);
        }
    }
}


