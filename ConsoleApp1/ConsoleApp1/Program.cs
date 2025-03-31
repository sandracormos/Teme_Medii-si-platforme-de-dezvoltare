namespace AnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal> { new Cat(), new Dog(), new Chicken(), new Bird() };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.AnimalType} makes sound: {animal.MakeSound()}");
            }

        }
    }
}