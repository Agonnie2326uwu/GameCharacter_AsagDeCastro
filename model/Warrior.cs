using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_winsform_application.model
{
   
        public class Warrior : GameCharacter
        {
            public int Armor { get; set; }


            public Warrior(string name, int level, int health, int strength)
                : base(name, level, health, 0, strength, 0)
            {
                Armor = 10;
            }


            public override void Attack()
            {
                Random random = new Random();
                int baseDamage = Strength * 2;
                bool critHit = random.Next(0, 100) < 20;
                int finalDamage = critHit ? baseDamage * 2 : baseDamage;


                Console.WriteLine($"{Name} dealt {finalDamage} damage. {(critHit ? "Critical Hit!" : "Normal Hit")}");
            }


            public override void Defend()
            {
                Random random = new Random();
                int damageReduction = Armor / 2;
                bool blocked = random.Next(0, 100) < 15;


                Console.WriteLine(blocked ? $"{Name} blocked the attack completely!" : $"{Name} reduced the damage by {damageReduction}.");
            }


            public override void LevelUp()
            {
                Level++;
                Strength += 5;
                Health += 20;
                Armor += 2;


                Console.WriteLine($"{Name} leveled up! Now at Level {Level}. Strength increased by 5, Health by 20, and Armor by 2.");
            }
        }
    
}
