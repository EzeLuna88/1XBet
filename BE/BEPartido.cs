using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEPartido
    {
        public int Codigo { get; set; }
        public int EquipoLocal { get; set; }
        public int EquipoVisitante { get; set; }
        public DateTime Fecha { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public int TarjetaAmarillaLocal { get; set; }
        public int TarjetaAmarillaVisitante { get; set; }
        public int TarjetaRojaLocal { get; set; }
        public int TarjetaRojaVisitante { get; set; }
        public int SaquesEsquinaLocal { get; set; }
        public int SaquesEsquinaVisitante { get; set; }
        public int CodigoLiga { get; set; }
        public int Jornada { get; set; }

    }
}
