using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimInterf
{
    public class Dog:Animal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof";
        }
    }
}