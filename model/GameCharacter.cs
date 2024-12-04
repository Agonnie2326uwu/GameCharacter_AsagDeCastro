using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction_to_winsform_application.model
{
    abstract class GameCharacter
    {
       
      
            public string Name { get; set; }
            public int Level { get; set; }
            public int Health { get; set; }
            public int Mana { get; set; }
            public int Strenght { get; set; }
            public int Intelligence { get; set; }

            public GameCharacter(string name, int level, int health, int mana, int strenght, int intelligence)
            {

                Name = name;
                Level = level;
                Health = health;
                Mana = mana;
                Strenght = strenght;
                Intelligence = intelligence;
            }
            public abstract void Attack();
            public abstract void Defend();
            public abstract void LevelUp();

            public override string ToString()
            {
                return $"{Name} - Level: {Level}, Health: {Health}, Mana: {Mana}, Strenght: {Strenght}, Intelligence: {Intelligence}";
            }


        
    }
}
