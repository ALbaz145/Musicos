class Musico
{
    public string nombre{get; set;}
    public Musico()
    {

    }
    public void Saluda()
    {
        Console.WriteLine("Hola soy {0}",nombre);
    }
    public virtual void Toca()
    {
        Console.WriteLine($"{nombre} esta tocando su instrumento");
    }

}
class Bajista:Musico
{
    public string bajo {get;set;}
    public Bajista(string n, string b)
    {

    }
    public override void Toca()
    {
        Console.WriteLine($"{nombre} esta tocando su {bajo}");
    }

}
internal class Program
{
        private static void Main(string[] args)
    {
        List<Musico> grupo = new List<Musico>();
        grupo.Add(new Bajista("Joe"));
        foreach (var m in grupo)
            m.Saluda();
        foreach (var m in grupo)
            m.Toca();

    }
}