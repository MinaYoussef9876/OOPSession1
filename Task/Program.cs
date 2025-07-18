namespace Task
{
    internal class Program
    {
        static Zoo GetZooWithMaxAnimalCount(Zoo[] zoos)
        {
            Zoo zooWithMaxAnimalCount = new Zoo();
            int maxAnimalCount = zoos[0].AnimalCount;

            for (int i = 1; i < zoos.Length; i++)
            {
                if (zoos[i].AnimalCount > maxAnimalCount)
                    zooWithMaxAnimalCount = zoos[i];
            }
            return zooWithMaxAnimalCount;
        }

        static void Main(string[] args)
        {
            Zoo[] zoos = new Zoo[3];

            Console.WriteLine("Enter 3 Zoos \n");
            for (int i = 0; i < zoos.Length; i++)
            {
                Console.WriteLine($"Enter Zoo number {i+1}: ");
                
                Console.Write("Enter its name: ");
                zoos[i].Name = Console.ReadLine();

                Console.Write("Enter its Animal Count: ");
                if(int.TryParse(Console.ReadLine(), out int animalCount))
                {
                    zoos[i].AnimalCount = animalCount;
                }
                Console.WriteLine();
            }

            Console.WriteLine(GetZooWithMaxAnimalCount(zoos));
        }
    }
}
