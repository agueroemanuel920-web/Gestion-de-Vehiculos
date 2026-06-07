using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al Sistema de Gestion de Vehiculos..");

        System.Console.WriteLine("Ingrese su tipo de Vehiculo");

        System.Console.WriteLine("Opcion 1. Auto");

        System.Console.WriteLine("Opcion 2. Motocicleta");
        

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
            System.Console.WriteLine("Ingrese Marca: ");
            string MarcaAuto = Console.ReadLine();

            System.Console.WriteLine("Igrese Modelo: ");
            string ModeloAuto = Console.ReadLine();

            System.Console.WriteLine("Igrese Velocidad: ");
            int VelocidadAuto = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Igrese Patente: ");
            string PatenteAuto = Console.ReadLine();

            Automotor automotor = new Automotor(MarcaAuto, ModeloAuto, VelocidadAuto, PatenteAuto);

            automotor.MostrarInfo(); 
            break;

            case 2:
            System.Console.WriteLine("Ingrese Marca: ");
            string MarcaMoto = Console.ReadLine();

            System.Console.WriteLine("Igrese Modelo: ");
            string ModeloMoto = Console.ReadLine();

            System.Console.WriteLine("Igrese Velocidad: ");
            int VelocidadMoto = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Igrese Patente: ");
            string PatenteMoto = Console.ReadLine();

            Motocicleta motocicleta = new Motocicleta(MarcaMoto, ModeloMoto, VelocidadMoto, PatenteMoto);
            motocicleta.MostrarInfo();

            break;


            

        }

        
        
        

    }
}
