namespace Lab1v8
{
    class Animal
    {
        private string species;
        private string nickname;
        private int age;

        public int Age
        {
            get => age;
            set
            {
                if (value < 0)
                    throw new System.ArgumentOutOfRangeException(nameof(Age), "Вік не може бути від’ємним!");
                age = value;
            }
        }

        public Animal(string species, string nickname, int age)
        {
            this.species = species;
            this.nickname = nickname;
            Age = age;
        }

        public void Speak()
        {
            string lower = species.ToLower();
            string sound =
                (lower == "dog") ? "Гав!" :
                (lower == "cat") ? "Мяу!" :
                (lower == "parrot") ? "Привіт!" : "...";

            System.Console.WriteLine($"{nickname} ({species}) каже: {sound}");
        }

        public override string ToString()
        {
            return $"Вид: {species}, Кличка: {nickname}, Вік: {Age}";
        }

        ~Animal() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("=== Lab1 Variant 8: Клас Animal ===");

            var dog = new Animal("Dog", "Бім", 3);
            var cat = new Animal("Cat", "Мурчик", 2);
            var parrot = new Animal("Parrot", "Кеша", 1);

            System.Console.WriteLine(dog);
            System.Console.WriteLine(cat);
            System.Console.WriteLine(parrot);

            dog.Speak();
            cat.Speak();
            parrot.Speak();

            System.Console.WriteLine("Готово!");
        }
    }
}
