namespace AnimalSounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new()
            {
                new Cat() { Name = "Tom"},
                new Dog(){ Name = "Rex"},
                new Chicken() { Name = "Coco" },
                new Bird() { Name = "Tweety" }
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"{animal.Name} ({animal.GetType().Name}) makes sound: {animal.MakeSound()}");
            }
        }
    }
}