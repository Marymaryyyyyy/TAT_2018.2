using System.Collections.Generic;
using System.Linq;
using Task_DEV_5.Interfaces;


namespace Task_DEV_5.Implementations
{
    public class AveragePriceType : ICommand
    {
        public double Command(List<Product> listOfProducts, string data)
        {
            var listOfOneMark = listOfProducts.Where(product => product.Mark == data);
            var listOfPrice = new List<decimal>();
            foreach (var a in listOfOneMark)
            {
                listOfPrice.Add(a.Cost);
            }
            return (double)listOfPrice.Average();
        }
    }
}
