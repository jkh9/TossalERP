using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public enum Instrumento
    {
        Flauta, Saxo, Dulzaina, Clarinete, Oboe,Tuba, Trombon, Trompa,Percu
    }
    public class Musico
    {
        public string Nombre;
        public Instrumento Instrumento;
        public int DineroCobrar;
    }
}
