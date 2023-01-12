using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace MPP
{
    public class MPPPartido
    {

        Acceso acceso;

        public bool GuardarPartido(BEPartido bePartido)
        {
            try
            {
                string consultaSql = string.Empty;
                consultaSql = "Insert into Partido (Equipo_local, Equipo_visitante, Fecha, Goles_local, Goles_visitante, " +
                    "Tarjeta_amarilla_local, Tarjeta_amarilla_visitante, Tarjeta_roja_local, Tarjeta_roja_visitante, " +
                    "Saques_esquina_local, Saques_esquina_visitante, Codigo_liga, Jornada) " +
                    "values ('" + bePartido.EquipoLocal + "', '" + bePartido.EquipoVisitante + "', '" + bePartido.Fecha + "', '" + bePartido.GolesLocal + "', '" + bePartido.GolesVisitante + "', '" + bePartido.TarjetaAmarillaLocal + "', '" + bePartido.TarjetaAmarillaVisitante + "', " +
                    " '" + bePartido.TarjetaRojaLocal + "', '" + bePartido.TarjetaRojaVisitante + "', '" + bePartido.SaquesEsquinaLocal + "', " +
                    "'" + bePartido.SaquesEsquinaVisitante + "', '" + bePartido.CodigoLiga + "', '" + bePartido.Jornada + "')";
                acceso = new Acceso();
                return acceso.Escribir(consultaSql);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int Local(BELiga beLiga)
        {
            try
            {
                
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and Goles_local > Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int Empate(BELiga beLiga)
        {
            try
            {

                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and Goles_local = Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int Visitante(BELiga beLiga)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and Goles_visitante > Goles_local";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int AmbosAnotanSi(BELiga beLiga)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and Goles_local > 0 and Goles_visitante > 0";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int AmbosAnotanNo(BELiga beLiga)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and (Goles_local = 0 or Goles_visitante = 0)";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int MasDeDosPuntoCincoGolesSi(BELiga beLiga)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and Goles_local + Goles_visitante > 2.5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int MasDeDosPuntoCincoGolesNo(BELiga beLiga)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Codigo_liga = '" + beLiga.Codigo + "' and Goles_local + Goles_visitante < 2.5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet ListarPartidos(BELiga beLiga)
        {
            try
            {
                DataSet ds = new DataSet();
                acceso = new Acceso();
                string consulta = "Select Jornada, e1.Equipo as Equipo_local, e2.Equipo as Equipo_visitante, Fecha, " +
                    "Goles_local, Goles_visitante, Tarjeta_amarilla_local, Tarjeta_amarilla_visitante, " +
                    "Tarjeta_roja_local, Tarjeta_roja_visitante, Saques_esquina_local, " +
                    "Saques_esquina_visitante FROM Partido INNER JOIN Equipo AS e1 ON " +
                    "Partido.Equipo_local = e1.Codigo INNER JOIN Equipo AS e2 ON Partido.Equipo_visitante = " +
                    "e2.Codigo WHERE Partido.Codigo_liga = '" + beLiga.Codigo + "'";
                ds = acceso.Leer(consulta);
                
                return ds;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool EquiposEnJornada(int jornada, BEEquipo beEquipoLocal, BEEquipo beEquipoVisitante)
        {
            try
            {
                acceso = new Acceso();
                return acceso.LeerScalar("Select Count(*) from Partido where Jornada = '" + jornada + "' and (Equipo_local = '" + beEquipoLocal.Codigo + "' or Equipo_visitante = '" + beEquipoVisitante.Codigo + "')");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
