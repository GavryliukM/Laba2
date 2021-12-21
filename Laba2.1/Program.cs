using System;

namespace LB2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new Animal("", "", " ", 0);

            for (int j = 0; j < animals.arr.Length; j++)
            {
                Console.Write("Введiть назву: ");
                string name = Console.ReadLine();
                Console.Write("Введiть групу: ");
                string group = Console.ReadLine();
                Console.Write("Введiть житло: ");
                string country = Console.ReadLine();
                Console.Write("Введiть чисельність: ");
                int population = Convert.ToInt32(Console.ReadLine());
                animals.arr[j] = new Animal(name, group, country, population);
            }

            Animal.count--;

            void MinPop()
            {
                int y = int.MaxValue;
                int r = 0;
                for (int i = 0; i < animals.arr.Length; i++)
                {

                    if (animals.arr[i].population < y)
                    {
                        y = animals.arr[i].population;
                        r = i;
                    }


                }
                Console.WriteLine("Наймолодша популяція " + animals.arr[r].name);
            }

            Console.WriteLine("Об'єкти: " + (Animal.count) + "\n");
            MinPop();
            if (Animal.count < 10)
                Console.WriteLine("Об'єктiв менше граничного значення");
            else if (Animal.count == 10)
                Console.WriteLine("Об'єктiв рiвно граничне значення");
            else if (Animal.count > 10)
                Console.WriteLine("Об'єктiв бiльше граничного значення");
        }
    }

    class Animal
    {
        public Animal[] arr = new Animal[9];
        public static int count = 0;
        public string group;
        public string name;
        public string country;
        public int population;
        public Animal(string name, string group, string country, int population)
        {
            this.group = group;
            this.name = name;
            this.country = country;
            this.population = population;
            count++;
        }
    }
}