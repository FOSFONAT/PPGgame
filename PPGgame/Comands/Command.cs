using System.Collections.Generic;
using PPGgame.Units;

namespace PPGgame.Actions
{
    class Command
    {
        List<Unit> units = new List<Unit>();

        public List<Unit> Units { get => units;}

        public void AddWarrior1()
        {
            units.Add(new Warrior_1());
        }
    }
}
