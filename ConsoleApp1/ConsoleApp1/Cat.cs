using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Cat : Animal
    {
        public override AnimalType AnimalType =>AnimalType.Cat;

        public override string MakeSound()
        {
            return "Miau Maiu";
        }
    }
}
