using System;
using System.Collections.Generic;

namespace wizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            // Human newHuman = new Human("Scott");
            // Ninja newWizard = new Ninja("Scott");
            Samurai newWizard = new Samurai("Scott");
            Samurai newHuman = new Samurai("Bob");
            // newWizard.steal(newHuman);
            // newWizard.get_away();
            newHuman.death_blow(newWizard);
            // newHuman.death_blow(newWizard);
            newHuman.meditate();
            newWizard.how_many();
            Console.WriteLine(newHuman.name + " " + newHuman.strength + " " + newHuman.intelligence + " " + newHuman.dexterity + " "  + newHuman.health);
            Console.WriteLine(newWizard.health);
            
        }
    }
}
