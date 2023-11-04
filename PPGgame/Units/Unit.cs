using PPGgame.Actions;
using System.Collections.Generic;

namespace PPGgame.Units
{
    public class Warrior_1 : Warrior
    {

        public Warrior_1()
        {
            Max_hp = 100;
            Hp = 100;
            Protection = 100;
            Attak = 10;
        }
    }
    public class Warrior : Unit
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
        int attak;
        List<Effect> effects = new List<Effect>();
        List<Action> actions = new List<Action>();



        public int Max_hp { get => max_hp; set => max_hp = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Protection { get => protection; set => protection = value; }
        public int Attak { get => attak; set => attak = value; }
    }

}
