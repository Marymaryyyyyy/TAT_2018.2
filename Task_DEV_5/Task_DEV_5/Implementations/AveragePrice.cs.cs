using System.Collections.Generic;
using System.Linq;
using Task_DEV_5.Interfaces;

namespace Task_DEV_5.Implementations
{
    public class AveragePrice : ICommand
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            List<decimal> list = new List<decimal>();
            foreach (var a in listOfProducts)
            {
                list.Add(a.Cost);
            }
            return (double)list.Average();
        }
    }
}
