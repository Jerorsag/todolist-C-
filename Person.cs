public class Person
{
    // Propiedades
    public string Name { get; set; }
    public int Age { get; set; }

    // Metodo Greet
    public void Greet()
    {
        Console.WriteLine($"Hola, mi nomrebre es {Name} y tengo {Age} años.");
    }
}