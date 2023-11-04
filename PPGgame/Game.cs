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
                Console.WriteLine("VC - View Comand");
                Console.WriteLine("CC - Create Comand");
                Console.WriteLine("RC - Remove Comand");
                Console.WriteLine("AU - Add Unit");
                Console.WriteLine("RU - Remove Unit");
                Console.WriteLine("/ - Out");

                string str;
                str = Console.ReadLine();

                if (str == "VC")
                {
                    for (int i = 0; i < commands.Count; i++)
                    {
                        Console.WriteLine(i.ToString() + ")");
                        for (int j = 0; j < commands[i].Units.Count; j++)
                        {
                            Console.WriteLine(commands[i].Units[j].Name);
                        }
                    }
                }

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

                if (str == "AU")
                {
                    Console.WriteLine("Вибери команду");
                    int index_c;
                    index_c = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        Console.WriteLine("W1 - Warrior_1");
                        Console.WriteLine("/ - Out");
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
                if (str == "RU")
                {
                    Console.WriteLine("Вибери команду");
                    int index_c;
                    index_c = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        Console.WriteLine("Вибери кого");
                        Console.WriteLine("число < 0 - вийти");
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

