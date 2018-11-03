using System;
using System.Collections.Generic;
using Task_DEV_5.Interfaces;
using Task_DEV_5.Implementations;

namespace Task_DEV_5
{
    /// <summary>
    /// This class is the entry point to the program
    /// </summary>
    class EntryPoint
    {
        static void Main()
        {
           var products = new List<Product>();
            var key = new ConsoleKeyInfo();

            do
            {
                var product = new Product();

                try
                {
                    Console.WriteLine(" Input car mark.");
                    product.Mark = Console.ReadLine();

                    Console.WriteLine(" Input car model.");
                    product.Model = Console.ReadLine();

                    Console.WriteLine(" Input the quontity.");
                    product.Quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Input the cost of one product.");
                    product.Cost = Convert.ToDecimal(Console.ReadLine());

                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                Console.WriteLine("\n Do you want continue to input products?");
                Console.WriteLine("Yes [A]|No[B]");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.B);

            do
            {
                Console.WriteLine("\n Input command:" +
                    "\n1) count types\n" +
                    "2) count all\n" +
                    "3) average price (all types)\n" +
                    "4) average price (type)\n" +
                    "5) exit");
                string data = Console.ReadLine();
                if (data == "5")
                {
                    return;
                }

                SwitchCommand(products, data);

                Console.WriteLine("\n Do you want continue to input commands?");
                Console.WriteLine("Yes [A]| No[B]");
                key = Console.ReadKey();
            }
            while (key.Key != ConsoleKey.B);

        }

        static void SwitchCommand(List<Product> products, string data)
        {
            switch (data)
            {
                case "1":
                    Console.WriteLine(Invoker.Invoke(new CountTypes(), products, "count of car marks"));
                    break;
                case "2":
                    Console.WriteLine(Invoker.Invoke(new CountAll(), products, "total count of cars"));
                    break;
                case "3":
                    Console.WriteLine(Invoker.Invoke(new AveragePrice(), products, "average price of car"));
                    break;
                case "4":
                    Console.WriteLine("Input mark: ");
                    var mark = Console.ReadLine();
                    Console.WriteLine(Invoker.Invoke(new AveragePriceType(), products, mark));
                    break;

            }

            Builder inputString = new Builder(Console.ReadLine());
            Console.WriteLine(inputString.FindSequenceOfEvenIndex());
        }


    }
}
