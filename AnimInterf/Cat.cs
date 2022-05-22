using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimInterf
{
    public class Cat:Animal, IMammal
    {
        public int NumberOfNipples{get;}

        public Cat()
        {
            NumberOfNipples = 8;
        }
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}