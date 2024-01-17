using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Persona
{
    internal class Persona
    {
        public int AnnoDiNascita { get; set; }
        public Persona(int annodinascita)
        {
            AnnoDiNascita = annodinascita;
        }
        public int CalcolaEta()
        {
            int Anno=DateTime.Now.Year;
            return (Anno - AnnoDiNascita);
        }
    }
}
