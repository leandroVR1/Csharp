namespace consoleProject
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Saludo()
        {
            Console.WriteLine($"Hola {Name}, tengo {Age} años.");
        }
    }
}
