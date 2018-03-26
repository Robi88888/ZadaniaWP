using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Users : FactoryInterface
    {
        public string addItem()
        {
            return "Dodaje usera";
        }

        public string deleteItem()
        {
            return "Usuwam usera";
        }

        public string listItems()
        {
            return "Lista userów";
        }

        public string sortItems()
        {
            return "Sortuje userów";
        }
    }
}
