using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Products : FactoryInterface
    {
        public string addItem()
        {
            return "Dodaje produkt";
        }

        public string deleteItem()
        {
            return "Usuwam produkt";
        }

        public string listItems()
        {
            return "Lista produktów";
        }

        public string sortItems()
        {
            return "Sortuje produkty";
        }
    }
}
