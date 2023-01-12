using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLPartido
    {
        MPPPartido mppPartido;
        public BLLPartido() 
        { 
        mppPartido= new MPPPartido();
        }

        public bool GuardarPartido(BEPartido bePartido)
        {
            return mppPartido.GuardarPartido(bePartido);
        }

        public int Local (BELiga beLiga)
        {
            return mppPartido.Local(beLiga);
        }

        public int Empate(BELiga beLiga) { return mppPartido.Empate(beLiga); }

        public int Visitante(BELiga beLiga) { return mppPartido.Visitante(beLiga); }

        public int AmbosAnotanSi(BELiga beLiga) { return mppPartido.AmbosAnotanSi(beLiga); }
        public int AmbosAnotanNo(BELiga beLiga) { return mppPartido.AmbosAnotanNo(beLiga); }

        public int MasDeDosPuntoCincoGolesSi(BELiga beLiga) { return mppPartido.MasDeDosPuntoCincoGolesSi(beLiga); }

        public int MasDeDosPuntoCincoGolesNo(BELiga beLiga) { return mppPartido.MasDeDosPuntoCincoGolesNo(beLiga); }

        public DataSet ListarPartidos(BELiga beLiga)
        {
            return mppPartido.ListarPartidos(beLiga);
        }

        public DataSet ListarPartidosEquipo (BEEquipo beEquipo)
        {
            return mppPartido.ListarPartidosEquipo(beEquipo);
        }

        public bool EquiposEnJornada(int jornada, BEEquipo beEquipoLocal, BEEquipo beEquipoVisitante)
        {
            return mppPartido.EquiposEnJornada(jornada, beEquipoLocal, beEquipoVisitante);
        }
    }
}
