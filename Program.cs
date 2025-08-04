class Program
{
    static void Main(string[] args)
    {
        // Crear objetos de la clase Person 
        Person person1 = new Person();
        person1.Name = "Juan";
        person1.Age = 30;

        person1.Greet();

        Person person2 = new Person();
        person2.Name = "Ana";
        person2.Age = 25;

        person2.Greet();
    }
}