abstract class Musico     //Las clases abstrctas no pueden hecerse objetos
{
    public string Nombre {get; set;}

    public Musico(string nombre)
    {
        Nombre = nombre;
    } 

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre} ");
    } 
    

    /*public virtual void Tocar()
    {
        Console.WriteLine($"{Nombre} está tocando su instrumento");
    } */
    public abstract void Tocar();      //Metodos abstarctos son heredados obligatoriamente
}

class Baterista:Musico
{
    public string Bateria {get; set;}

    public Baterista(string nombre, string bateria):base(nombre)
    {
        Bateria = bateria;
    } 

    public override void Tocar()
    {
        Console.WriteLine($"{Nombre} está tocando su {Bateria}");
    } 
}

class Bajista:Musico 
{
    public string Bajo {get; set;}

    public Bajista(string nombre, string bajo):base(nombre)
    {
        Bajo = bajo;
    } 

    public override void Tocar()
    {
        Console.WriteLine($"Hola soy{Nombre} y soy bajista");
    } 
   
}

class Program
{
    static void Main()
    {
       List<Musico> Metallica = new List<Musico>();

       /*Metallica.Add(new Musico("James Hetfield"));*/
       Metallica.Add(new Bajista("Chango", "Ibanez"));
       Metallica.Add(new Baterista("Lars Ulrich", "Tama")); 
       
       foreach(var m in Metallica) m.Saludar();
                  
       foreach(var m in Metallica) m.Tocar(); //esto se llama Polimorfismo
    }
}