# C# Practice

## Practica 3


## Practica 2
Func y Actions básico:

```csharp
static void Main(string[] args)
    {
        Console.WriteLine($"{myFunc(100)}");
        myAct("Hola");
    }

    // Func es un delegado: encapsula un metodo con retorno.
    static Func<int, double> myFunc = (x) => x * Math.PI;

    // Action es un delegado: encapsula un metodo void.
    static Action<string> myAct = (x) =>
        Console.WriteLine($"Este es un Action y dice: {x}");

```

## Practica 1
Crear una clase con metodo void y una lista de objectos y usar foreach:

```csharp
class Program
{
    static void Main(string[] args)
    {
        List<Empleados> empleados = new();
        empleados.Add(new Empleados(1, "Vanessa"));
        empleados.Add(new Empleados(2, "Cynthia"));
        empleados.Add(new Empleados(3, "Amelia"));

        empleados.ForEach(x => x.VerEmpleados());
    }

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
```