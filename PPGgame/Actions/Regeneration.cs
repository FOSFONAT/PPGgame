using System.Collections.Generic;
using PPGgame.Units;

namespace PPGgame.Actions
{
    public class Regeneration : Effect
    {
        public Regeneration() //Регенерація
        {
            Hp = 10;
        }
    }
    public class Effect //Ефект
    {
        int hp = 0;
        int protection = 0;
        int attack = 0;
        int duration = 1;


        public int Hp { get => hp; set => hp = value; }
        public int Protection { get => protection; set => protection = value; }
        public int Attack { get => attack; set => attack = value; }
    }
    public class Interaction //Взаємодія
    {
        int magic_damage = 0;
        int hp_damage = 0;
        int magic_protected = 0;
        int hp_protected = 0;

        public int Magic_damage { get => magic_damage; set => magic_damage = value; }
        public int Hp_damage { get => hp_damage; set => hp_damage = value; }
        public int Magic_protected { get => magic_protected; set => magic_protected = value; }
        public int Hp_protected { get => hp_protected; set => hp_protected = value; }


    }
    public class Action //Дії
    {
        List<Interaction> interactions = new List<Interaction>();
        List<Effect> effects = new List<Effect>();

        public List<Interaction> Interactions { get => interactions; }
        public List<Effect> Effects { get => effects; }

        public void AddInteraction(Interaction interaction)
        {
            interactions.Add(interaction);
        }
        public void AddEffect(Effect effect)
        {
            effects.Add(effect);
        }
    }
}

