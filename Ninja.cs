using System;
using System.Collections.Generic;

namespace wizardNinjaSamurai
{
    public class Ninja : Human
    {
        public int NinDex = 175;
        public Ninja(string person) : base(person)
        {
            dexterity = NinDex;
        }
        public void steal(Human target)
        {
            attack(target);
            this.health += 10;
        }
        public void get_away()
        {
            this.health -= 15;
        }

    }
}