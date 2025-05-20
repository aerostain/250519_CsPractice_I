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
        mipersonal.Add(new MiPersonal(4, "Liliana", false));
        mipersonal.Add(new MiPersonal(5, "Karen", true));

        List<Region> regiones = new();
        regiones.Add(new Region(1, "Colombia"));
        regiones.Add(new Region(2, "Colombia"));
        regiones.Add(new Region(3, "Colombia"));
        regiones.Add(new Region(4, "Ecuador"));
        regiones.Add(new Region(5, "Peru"));

        Action<MiPersonal> verE = (x) => Console
        .WriteLine($"Id: {x.Id} - Nombre: {x.Nombre}");

        mipersonal.Join(regiones,
        x => x.Id,
        y => y.Id,
        (x, y) => new
        {
            Nombre = x.Nombre,
            Pais = y.Pais
        }).ToList().ForEach(Console.WriteLine);
        
        // mipersonal
        // .GroupBy(x => x.EsFijo)
        // .Select(g => new
        // {
        //     Fijo = g.Key,
        //     Total = g.Count()
        // })
        // .ToList()
        // .ForEach(Console.WriteLine);

        // mipersonal
        // .Select(x => x.Id + 100)
        // .ToList()
        // .ForEach(Console.WriteLine);

        // mipersonal.Select(x => new
        // {
        //     x.Id,
        //     x.EsFijo
        // }).ToList().ForEach(Console.WriteLine);

        // mipersonal
        // .Where(x => (x.Id == 1 | x.EsFijo == false))
        // .ToList()
        // .ForEach(x => Console.WriteLine($"Nombre: {x.Nombre}"));

        // mipersonal
        // .Where(x => x.EsFijo != true)
        // .ToList()
        // .ForEach(verE);

    }

    record MiPersonal(int Id, string Nombre, bool EsFijo);
    record Region(int Id, string Pais);

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