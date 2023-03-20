using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public enum Agrupacion
    {
        Colla, Banda
    }

    internal class Acto
    {
        int PorcentajeBanda = 25;
        public string Nombre;
        public DateTime Fecha;
        public Musico[] Musicos;
        public int DineroCobrado;
        public int DineroAsociacion;
        public int DineroMusicos;
        public int GastosContratados;
        public int TotalRepartir;
        public int TotalMusicos;
        public int TotalPorMusico;
        public Agrupacion Agrupacion;
    }
}
