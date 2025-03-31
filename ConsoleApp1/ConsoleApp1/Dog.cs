using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Dog : Animal
    {
        public override AnimalType AnimalType => AnimalType.Dog;

        public override string MakeSound()
        {
            return "woof woof";
        }
    }
}