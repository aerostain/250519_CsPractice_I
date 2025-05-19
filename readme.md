# C# Practice

## Practica 2
Func y Actions básico

```csharp

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