using System;

namespace AnimInterf
{
    class Program
    {
        static void Main(string[] args)
        {
            Bat bat1 = new Bat();
            Bat bat2 = new Bat();
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Bee bee1 = new Bee();
            Bee bee2 = new Bee();
            Bee bee3 = new Bee();
            
            Animal[] animals = new Animal[10]
            {bat1,bat2,dog1,dog2,dog3,cat1,cat2,bee1,bee2,bee3};

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Sound());
                
                if(animal is IMammal)
                {
                    Console.WriteLine(((IMammal) animal).NumberOfNipples);

                     
                }
                else if(animal is ICanFly)
                {
                    Console.WriteLine(((ICanFly) animal).NumberOfWings);
                }
            }
            
           
        }
    }
}
