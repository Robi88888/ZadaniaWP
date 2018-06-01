using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memento
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        //Przywraca poprzedni stan obiektu
        public void SetMemento(Memento memento)
        {
            this._age = memento.Age;
            this._firstName = memento.FirstName;
            this._lastName = memento.LastName;
        }

        //Zapisuje aktualny stan obiektu
        public Memento CreateMemento()
        {
            return new Memento(_firstName, _lastName, _age);
        }
    }
}