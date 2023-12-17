namespace number4
{
    class Player
    {
        public string Name { get; set; }
        public string Skill { get; set; }

        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            while (true)
            {
                Console.WriteLine("Выберите действие: 0 - ввод игрока, 1 - просмотр команды, 2 - кол-во игроков по ампула, -1 - выход из программы");
                int n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        Console.Write("Name = ");
                        string playerName = Console.ReadLine();
                        Console.Write("Skill = ");
                        string playerSkill = Console.ReadLine();
                        Console.Write("Age = ");
                        int playerAge = int.Parse(Console.ReadLine());
                        players.Add(new Player { Name = playerName, Skill = playerSkill, Age = playerAge });
                        break;
                    case 1:
                        Console.WriteLine("Состав команды:");
                        foreach (var item in players)
                        {
                            Console.WriteLine($"Name = {item.Name}, Skill = {item.Skill}, Age = {item.Age}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Укажите ампула игрока");
                        string ampula = Console.ReadLine();
                        int count = 0;
                        int countAge = 0;
                        foreach (var item in players)
                        {
                            if (item.Skill == ampula)
                            {
                                count++;
                            }
                            if (item.Age >= 18)
                            {
                                countAge++;
                            }
                        }
                        Console.WriteLine($"Кол-во игроков ампула {ampula} = {count}");
                        Console.WriteLine($"Кол-во игроков старше 18 лет = {countAge}");
                        break;
                    case -1:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}
