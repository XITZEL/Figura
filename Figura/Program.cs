abstract class Figura 
{
    //Propiedades 
    public int X{get;set;}
    public int Y{get;set;}
    public string Color{get;set;}
    public int Altura{get;set;}
    public int Ancho{get;set;}

    //Constructor 
    public Figura(){}
    public Figura (int x, int y, string color, int altura, int ancho)
    {
        this.X=x;
        this.Y=y;
        this.Color=color;
        this.Altura= altura;
        this.Ancho= ancho;
    }

    public abstract void Dibuja();
    public abstract double Area();
}
class Rectangulo:Figura
{
  //Propiedades
  //Metodo a heredar
     public Rectangulo (int x, int y, string color, int altura, int ancho):base(x,y,color,altura,ancho)
    {
       
    }

    //Metodos
    public override double Area()
    {
        return(Ancho*Altura);
    }
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un Rectangulo");
    }
}
class Circulo: Figura 
{
    //Propiedades 
    public double Diametro{get;set;}
    //Constructor a heredar
    public Circulo(){}
    public Circulo(int x, int y, string color, int altura, int ancho,double diametro)/*:base( x, y, color)*/
    {
        this.Diametro= diametro;
    }
    //Metodos a heredar
     public override double Area()
    {
        return Math.PI*(Diametro/2);

    }
    public override void Dibuja()
    {
        Console.WriteLine("Se dibuja un Circulo");
    }

}
class Triangulo{}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}