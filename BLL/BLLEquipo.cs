using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using MPP;

namespace BLL
{
    public class BLLEquipo
    {
        MPPEquipo mppEquipo;

        public BLLEquipo()
        {
            mppEquipo = new MPPEquipo();
        }

        public bool BuscarEquipo(BEEquipo beEquipo)
        {
            return mppEquipo.BuscarEquipo(beEquipo);
        }

        public bool GuardarEquipo(BEEquipo beEquipo) 
        {
            return mppEquipo.GuardarEquipo(beEquipo);
        }

        public List<BEEquipo> ListarEquipos(BELiga beLiga)
        {
            return mppEquipo.ListarEquipos(beLiga);
        }

        public bool BajaEquipo(BEEquipo beEquipo)
        {
            return mppEquipo.BajaEquipo(beEquipo);
        }

        public int EquipoLocalVictorias (BEEquipo beEquipo)
        {
            return mppEquipo.EquipoLocalVictorias(beEquipo);
        }

        public int EquipoLocalDerrotas(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoLocalDerrotas(beEquipo);
        }

        public int EquipoLocalEmpates(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoLocalEmpates(beEquipo);
        }

        public int EquipoVisitanteVictorias(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoVisitanteVictorias(beEquipo);
        }

        public int EquipoVisitanteDerrotas(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoVisitanteDerrotas(beEquipo);
        }

        public int EquipoVisitanteEmpates(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoVisitanteEmpates(beEquipo);
        }

        public int AmbosAnotanSi(BEEquipo beEquipo)
        {
            return mppEquipo.AmbosAnotanSi(beEquipo);
        }
        public int AmbosAnotanNo(BEEquipo beEquipo)
        {
            return mppEquipo.AmbosAnotanNo(beEquipo);
        }

        public int MasDeDosPuntoCincoGolesSi(BEEquipo equipo)
        {
            return mppEquipo.MasDeDosPuntoCincoGolesSi(equipo);
        }

        public int MasDeDosPuntoCincoGolesNo(BEEquipo equipo)
        {
            return mppEquipo.MasDeDosPuntoCincoGolesNo(equipo);
        }

        public int EquipoLocalUltimasVictorias(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoLocalUltimasVictorias(beEquipo);
        }

        public int EquipoLocalUltimasDerrotas(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoLocalUltimasDerrotas(beEquipo);
        }

        public int EquipoLocalUltimosEmpates(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoLocalUltimosEmpates(beEquipo);
        }

        public int AmbosAnotanSiUltimos (BEEquipo beEquipo)
        {
            return mppEquipo.AmbosAnotanSiUltimos(beEquipo);
        }

        public int AmbosAnotanNoUltimos(BEEquipo beEquipo)
        {
            return mppEquipo.AmbosAnotanNoUltimos(beEquipo);
        }

        public int MasDeDosPuntoCincoGolesSiUltimos(BEEquipo equipo)
        {
            return mppEquipo.MasDeDosPuntoCincoGolesSiUltimos(equipo);
        }

        public int MasDeDosPuntoCincoGolesNoUltimos(BEEquipo equipo)
        {
            return mppEquipo.MasDeDosPuntoCincoGolesNoUltimos(equipo);
        }

        public int EquipoVisitanteUltimasVictorias(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoVisitanteUltimasVictorias(beEquipo);
        }

        public int EquipoVisitanteUltimasDerrotas(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoVisitanteUltimasDerrotas(beEquipo);
        }

        public int EquipoVisitanteUltimosEmpates(BEEquipo beEquipo)
        {
            return mppEquipo.EquipoVisitanteUltimosEmpates(beEquipo);
        }
    }
}
