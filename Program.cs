using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Csharp_Practice;

class Program
{
    static void Main(string[] args)
    {
        string x = "hola";
        string y = "adios";
        if(x.Length != y.Length) throw new Exception("Alerta :)");
    }
}