using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimInterf
{
    public class Bat:Animal, IMammal
    {
        public int NumberOfNipples{get;}

        public Bat()
        {
            NumberOfNipples = 5;
        }
        public override string Sound()
        {
            return base.Sound() + "fffff";
        }
    }
}