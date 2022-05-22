using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimInterf
{
    public class Dog:Animal, IMammal
    {
        public int NumberOfNipples{get;}

        public Dog()
        {
            NumberOfNipples = 9;
        }
        public override string Sound()
        {
            return base.Sound() + "Woof";
        }
    }
}