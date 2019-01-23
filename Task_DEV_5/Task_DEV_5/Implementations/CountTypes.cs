using System.Collections.Generic;
using System.Linq;
using Task_DEV_5.Interfaces;


namespace Task_DEV_5.Implementations
{
    public class CountTypes : ICommand
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            List<string> list = new List<string>();
            foreach (var a in listOfProducts)
            {
                list.Add(a.Mark);
            }
            return list.Distinct().Count();
        }
    }
}
