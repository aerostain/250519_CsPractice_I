# C# Practice

## Practica 3
Reemplazar if por Actions usando un Dictionario.
[Link_Copilot.](https://gemini.google.com/app/1415c62094d409c7?hl=es)

```csharp
//Codigo original
decimal total = 1000;
decimal discount = 0;
decimal tax = 0;
if (total < 10)
  {
    tax = total * .2m;
  }
  else if (total >= 10 & total < 100)
  {
    tax = total * .1m;
   }
   else if (total > 100 & total < 1000)
   {
    discount = total * 0.2m;
   }
   else
   {
    discount = total * 0.3m;
   }

   Console.WriteLine($"{total+tax-discount}");
```

```csharp
//Mejorado
  var misActions = new Dictionary<Predicate<decimal>, Action>
        {
            {t=>t<10, ()=>tax=total*.2m},
            {t=>t>=10 & t<100, ()=>tax=total*.1m},
            {t=>t>=100 & t<1000, ()=>discount=total*.2m},
            {t=>t>=1000, ()=>discount=total*.3m}
        };

        foreach (var a in misActions)
        {
            if (a.Key(total)) { a.Value(); break; }
        }        
```

```csharp
// Mejorado todavía más:
// Reemplazar foreach por FirsOrDefault que tambien itera.
        
        misActions
            .FirstOrDefault(pair => pair.Key(total))
            .Value?.Invoke();        
```

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