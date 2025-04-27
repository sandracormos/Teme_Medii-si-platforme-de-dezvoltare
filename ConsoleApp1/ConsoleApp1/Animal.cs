using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AnimalSounds
{
    public abstract class Animal
    {
        private string _name;
        public string Name
        {
            get => _name;
            internal set  { _name = value; }
        }

        public abstract string MakeSound();
    }
}
