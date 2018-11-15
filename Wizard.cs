using System;
using System.Collections.Generic;

namespace wizardNinjaSamurai
{
    public class Wizard : Human
    {
        public int WizHP = 50;
        public int WizInt = 25;
        Random rand = new Random();
        public Wizard(string person) : base(person)
        {
            intelligence = WizInt;
            health = WizHP;
        }
        public void heal()
        {
            this.health = 10 * this.intelligence;
        }
        public void fireball(Human target)
        {
            target.health -= rand.Next(20,51);
        }
    }
}