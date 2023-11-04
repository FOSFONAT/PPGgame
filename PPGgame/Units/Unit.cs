using PPGgame.Actions;
using System.Collections.Generic;

namespace PPGgame.Units
{
    public class Warrior_1 : Warrior
    {

        public Warrior_1() //Воїн 1 рівня
        {
            Max_hp = 100;
            Hp = 100;
            Protection = 100;
            Damage = 10;
            Name = nameof(Warrior_1);
        }
    }
    public class Warrior : Unit //Група классів "Воїн"
    {
        public Warrior() 
        {

        }
    }
    public class Unit
    {
        int max_hp;
        int hp;
        int protection;
        int damage;
        List<Effect> effects = new List<Effect>();
        List<Action> actions = new List<Action>();
        string name;


        public int Max_hp { get => max_hp; set => max_hp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Protection { get => protection; set => protection = value; }
        public int Damage { get => damage; set => damage = value; }
        public string Name { get => name; set => name = value; }
    }

}
