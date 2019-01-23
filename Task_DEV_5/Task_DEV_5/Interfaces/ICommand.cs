using System.Collections.Generic;

namespace Task_DEV_5.Interfaces
{
    public interface ICommand
    {
        double Command(List<Product> products, string data);

    }
}
