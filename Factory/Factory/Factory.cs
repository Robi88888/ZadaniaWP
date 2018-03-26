using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Factory
    {
        public FactoryInterface GetObject(String nazwa)
        {
            if (nazwa.Equals("users"))
            {
                return new Users();
            }

            if (nazwa.Equals("privileges"))
            {
                return new Priviledges();
            }

            if (nazwa.Equals("products"))
            {
                return new Products();
            }

            throw new Exception("Nie znaleziono " + nazwa);
        }
    }
}
