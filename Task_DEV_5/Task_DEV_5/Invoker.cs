using System.Collections.Generic;
using Task_DEV_5.Interfaces;

namespace Task_DEV_5
{
    public class Invoker
    {
        public static double Invoke(ICommand chooseCommand, List<Product> products, string data)
        {
            return chooseCommand.Command(products, data);
        }

    }
}
