using System;
using System.Collections.Generic;

namespace wizardNinjaSamurai
{
    public class Samurai : Human
    {
        public int SamHP = 200;
        private static int instances = 0;
        public static int Instances { get {return instances;} }
        public Samurai(string person) : base(person)
        {
            health = SamHP;
            instances ++;
        }
        public void death_blow(Human target)
        {
            if (target.health >= 50)
            {
                attack(target);
            }
            else
            {
                target.health = 0;
            }
        }
        public void meditate()
        {
            this.health = SamHP;
        }
        public int how_many()
        {
            Console.WriteLine($"{Instances}");
            return Instances;
        }
    }
}