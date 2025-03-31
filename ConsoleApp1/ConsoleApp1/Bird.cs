using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSounds
{
    internal class Bird : Animal
    {
        public override AnimalType AnimalType => AnimalType.Bird;

        public override string MakeSound()
        {
            return "Chipchirip";
        }
    }
}
