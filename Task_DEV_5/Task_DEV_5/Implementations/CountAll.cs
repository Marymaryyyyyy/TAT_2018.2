using System.Collections.Generic;
using System.Linq;
using Task_DEV_5.Interfaces;


namespace Task_DEV_5.Implementations
{
    public class CountAll : ICommand
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            return listOfProducts.Count();
        }
    }
}
