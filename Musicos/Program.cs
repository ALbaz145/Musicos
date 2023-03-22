
internal class Program
{
    class Musico
    {
    public string nombre{get; set;}
    public Musico
    {

    }
    public void Saluda() 
    {
        Console.WriteLine("Hola soy {0}",nombre);

    }
    public virtual void Toca()
    {
        Console.WriteLine($"{Nombre} esta tocando su intrumento");
    }

}
class Bajista:Musico
{
    public string bajo {get; set;}
    public Bajista(string n, string b):base(n)
    {
        bajo = b;
    }
    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {bajo}")
    } 
}
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}