using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPLabIII_CSNet
{
    public class Animal
    {
        private int _edad;

        public int Edad
        {
            get { return _edad;  }
            set { _edad = value; }
        }
        public Animal()
        { }
        public Animal(int edad)
            : this()
        {
            _edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Edad: "+ Edad);

            return sb.ToString();
        }
    }
}
