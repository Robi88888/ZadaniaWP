using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface FactoryInterface
    {
        String addItem();
        String deleteItem();
        String listItems();
        String sortItems();
    }
}