using PPGgame.Actions;
using PPGgame.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPGgame
{
    class Game
    {
        List<Command> commands = new List<Command>();

        public void Start()
        {
            List<Command> commands = new List<Command>();
            while (true)
            {
                string str;
                str = Console.ReadLine();

                if (str == "CC")
                {
                    commands.Add(new Command());
                }

                if (str == "RC")
                {
                    int index;
                    index = Convert.ToInt32(Console.ReadLine());
                    if (index > 0)
                    {
                        commands.RemoveAt(index);
                    }
                }

                if (str == "A")
                {
                    int index_c;
                    index_c = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        str = Console.ReadLine();
                        if (str == "W1")
                        {
                            commands[index_c].AddWarrior1();
                        }
                        if (str == "/")
                        {
                            str = " ";
                            break;
                        }
                    }
                }
                if (str == "R")
                {
                    int index_c;
                    index_c = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        int index;
                        index = Convert.ToInt32(Console.ReadLine());
                        
                        if (index < 0)
                        {
                            break;
                        }
                    }
                }

                if (str == "/")
                {
                    break;
                }

            }

            while (true)
            {

                for (int i = 0; i < commands.Count; i++)
                {
                    foreach (Unit item in commands[i].Units)
                    {

                    }


                }
            }

        }

    }
}

