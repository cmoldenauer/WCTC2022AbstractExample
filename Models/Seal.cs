using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Seal : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Arf Arf Arf");
        }

        public override void Sleep()
        {
            Console.WriteLine("ZZzzZZ");
        }
    }
}
