using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_winsform_application.model
{
    public class Mage : GameCharacter
    {
        public int SpellPower { get; set; }


        public Mage(string name, int level, int health, int mana, int intelligence)
            : base(name, level, health, mana, 0, intelligence)
        {
            SpellPower = 10;
        }


        public override void Attack()
        {
            Random random = new Random();
            int magicDamage = Intelligence * 3 + SpellPower;
            bool burningEffect = random.Next(0, 100) < 25;


            Console.WriteLine($"{Name} cast a spell dealing {magicDamage} magic damage. {(burningEffect ? "Burning effect applied!" : "No burning effect.")}");
        }


        public override void Defend()
        {
            Random random = new Random();
            int damageReduction = Mana / 4;
            bool evaded = random.Next(0, 100) < 20;


            Console.WriteLine(evaded ? $"{Name} evaded the attack!" : $"{Name} reduced the damage by {damageReduction}.");
        }


        public override void LevelUp()
        {
            Level++;
            Intelligence += 5;
            Mana += 15;
            SpellPower += 3;


            Console.WriteLine($"{Name} leveled up! Now at Level {Level}. Intelligence increased by 5, Mana by 15, and Spell Power by 3.");
        }
    }
}