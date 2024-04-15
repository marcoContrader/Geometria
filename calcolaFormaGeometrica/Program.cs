// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

public interface IFormaGeometrica
{

    double CalcolaArea();
    double CalcolaPerimetro();

}

public class Rettangolo : IFormaGeometrica
{

    public double Base { get; set; }
    public double Altezza { get; set; }


    public Rettangolo(double bas, double altezza)
    {
        Base = bas;
        Altezza = altezza;
    }



    public double CalcolaArea()
    {
        return Base * Altezza;

    }

    public double CalcolaPerimetro()
    {
        return (Base + Altezza) * 2;
    }
}

public class Cerchio : IFormaGeometrica
{
    public double Raggio;
    public double Pi = 3.14;

    public Cerchio(double raggio)
    {
        Raggio = raggio;
    }

    public double CalcolaArea()
    {
        return Raggio * Raggio * Pi;
    }

    public double CalcolaPerimetro()
    {
        return 2 * Pi * Raggio;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scegli la forma geometrica (1 per rettangolo, 2 per cerchio):");
        int scelta = int.Parse(Console.ReadLine());

        switch (scelta)
        {
            case 1:
                Console.WriteLine("Inserisci le dimensioni del rettangolo:");
                Console.Write("Base: ");
                double baseRettangolo = double.Parse(Console.ReadLine());
                Console.Write("Altezza: ");
                double altezzaRettangolo = double.Parse(Console.ReadLine());

                Rettangolo rettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo);

                Console.WriteLine("L'Area e Perimetro del rettangolo sono:");
                Console.WriteLine($"Area: {rettangolo.CalcolaArea()}, Perimetro: {rettangolo.CalcolaPerimetro()}");
                break;

            case 2:
                Console.WriteLine("Inserisci il raggio del cerchio:");
                double raggioCerchio = double.Parse(Console.ReadLine());

                Cerchio cerchio = new Cerchio(raggioCerchio);

                Console.WriteLine("L'Area e Perimetro del cerchio sono:");
                Console.WriteLine($"Area: {cerchio.CalcolaArea()}, Perimetro: {cerchio.CalcolaPerimetro()}");
                break;

            default:
                Console.WriteLine("Scelta non valida.");
                break;
        }
    }
}

