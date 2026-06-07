using System;

public class Motocicleta : Vehiculo
{
    private string tipo;

    private string patente;

    public string Tipo{get {return this.tipo;} set{this.tipo = value;}}

    public string Patente{get {return this.patente;} set{this.patente = value;}}

    public Motocicleta(string marca, string modelo, int velocidad, string patente) : base (marca, modelo, velocidad)
    {
        this.patente = patente;
    }

    public override int Acelerar()
    {
        Random rnd = new Random();

        int acelerar = rnd.Next(1, 49);

        return this.Velocidad + acelerar;
    }

    public override int Frenar()
    {
        Random rnd = new Random();

        int frenar = rnd.Next(1, 49);

        return this.Velocidad - frenar;
    }

    public override void MostrarInfo()
    {
        System.Console.WriteLine("------------------------------");

        System.Console.WriteLine($"Motocicleta: {this.Marca} {this.Modelo}");

        System.Console.WriteLine($"Velocidad actual: {this.Velocidad}");

        System.Console.WriteLine("Acelerando...");

        System.Console.WriteLine($"Velocidad actual: {Acelerar()}");

        System.Console.WriteLine("Frenando...");

        System.Console.WriteLine($"Velocidad Actual: {Frenar()}");

        System.Console.WriteLine("------------------------------");


    }

}