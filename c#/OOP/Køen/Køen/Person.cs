using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Køen
{
    public class Person
    {
        private string _name;
        private byte _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public byte Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Person(string name, byte age)
        {
            _name = name;
            _age = age;
        }
    }
}
