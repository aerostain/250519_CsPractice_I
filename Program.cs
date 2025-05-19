using System.Security.Cryptography.X509Certificates;

namespace Csharp_Practice;

class Program
{
    static void Main(string[] args)
    {
        decimal total = 1000;
        decimal discount = 0;
        decimal tax = 0;

        var misActions = new Dictionary<Predicate<decimal>, Action>
        {
            {t=>t<10,()=>tax=total*.2m},
            {t=>t>=10&t<100,()=>tax=total*.1m},
            {t=>t>=100&t<1000,()=>discount=total*.2m},
            {t=>t>=1000,()=>discount=total*.3m}
        };

        // foreach (var a in misActions)
        // {
        //     if (a.Key(total)) { a.Value(); break; }
        // }

        misActions
            .FirstOrDefault(pair => pair.Key(total))
            .Value?.Invoke();

        Console.WriteLine($"{total + tax - discount}");
    }

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