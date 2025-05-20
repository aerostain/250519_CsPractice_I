using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Csharp_Practice;

class Program
{
    static void Main(string[] args)
    {

        List<MiPersonal> mipersonal = new();
        mipersonal.Add(new MiPersonal(1, "Sandra", true));
        mipersonal.Add(new MiPersonal(2, "Susana", false));
        mipersonal.Add(new MiPersonal(3, "Sonia", true));

        Action<MiPersonal> verE = (x)=>Console
        .WriteLine($"Id: {x.Id} - Nombre: {x.Nombre}");

        mipersonal
        .Where(x => x.EsFijo != true)
        .ToList()
        .ForEach(verE);

    }

    record MiPersonal(int Id, string Nombre, bool EsFijo);

    // Func es un delegado: encapsula un metodo con retorno.
    static Func<int, double> myFunc = (x) => x * Math.PI;

    // Action es un delegado: encapsula un metodo void.
    static Action<string> myAct = (x) =>
        Console.WriteLine($"Este es un Action y dice: {x}");

    public class Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public void VerEmpleados() => Console.WriteLine($"Id: {Id} - Nombre: {Nombre}");
        public Empleados(int id, string nomb)
        {
            this.Id = id;
            this.Nombre = nomb;
        }
    }
}