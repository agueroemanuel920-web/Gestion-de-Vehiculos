using System;

public abstract class Vehiculo
{
    private string marca;

    private string modelo;

    private int velocidad;


    public string Marca{get {return this.marca;} set{this.marca = value;}}

    public string Modelo{get {return this.modelo;} set{this.modelo = value;}}

    public int Velocidad{get {return this.velocidad;} set{this.velocidad = value;}}

    public Vehiculo(string marca, string modelo, int velocidad)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.velocidad = velocidad;
    }

    public abstract void MostrarInfo();
    
    public abstract int Frenar();

    public abstract int Acelerar();
}