using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona(2004);
            Console.WriteLine(p.CalcolaEta());
            Console.ReadLine();
        }
    }
}
