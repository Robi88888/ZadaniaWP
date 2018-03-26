using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Priviledges : FactoryInterface
    {
        public string addItem()
        {
            return "Dodaje uprawnienia";
        }

        public string deleteItem()
        {
            return "Usuwa uprawnienia";
        }

        public string listItems()
        {
            return "Lista uprawnień";
        }

        public string sortItems()
        {
            return "Sortuj uprawnienia";
        }
    }
}
