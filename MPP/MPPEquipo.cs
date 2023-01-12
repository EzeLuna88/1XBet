using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class MPPEquipo
    {
        Acceso acceso;

        public bool BuscarEquipo(BEEquipo beEquipo)
        {
            try
            {
                acceso = new Acceso();
                return acceso.LeerScalar("SELECT COUNT(*) FROM Equipo WHERE UPPER(Equipo) = '" + beEquipo.Nombre + "' and Codigo_liga = '" + beEquipo.CodigoLiga + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool GuardarEquipo(BEEquipo beEquipo)
        {
            try
            {
                string consultaSql = string.Empty;
                consultaSql = "Insert into Equipo (Equipo, Codigo_liga) values ('" + beEquipo.Nombre + "', '" + beEquipo.CodigoLiga + "')";
                acceso = new Acceso();
                return acceso.Escribir(consultaSql);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public List<BEEquipo> ListarEquipos(BELiga beLiga)
        {
            try
            {
                DataSet ds = new DataSet();
                acceso = new Acceso();
                string consulta = "Select * from Equipo where Codigo_liga = '" + beLiga.Codigo + "' order by Equipo asc";
                ds = acceso.Leer(consulta);
                List<BEEquipo> ListaEquipos = new List<BEEquipo>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BEEquipo equipo = new BEEquipo();
                        equipo.Codigo = Convert.ToInt32(dr[0]);
                        equipo.Nombre = dr[1].ToString();
                        equipo.CodigoLiga = Convert.ToInt32(dr[2]);
                        ListaEquipos.Add(equipo);
                    }
                }
                else
                {
                    ListaEquipos = null;
                }
                return ListaEquipos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool BajaEquipo(BEEquipo beEquipo)
        {
            try
            {
                string consultaSQL = "DELETE from Equipo where Equipo.Codigo = '" + beEquipo.Codigo + "'";
                acceso = new Acceso();
                return acceso.Escribir(consultaSQL);
            }
            catch (Exception e)
            {

                throw e;
            }


        }

        public int EquipoLocalVictorias(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_local = '" + equipo.Codigo + "' and Goles_local > Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoLocalUltimasVictorias(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_local = '" + equipo.Codigo + "' and Goles_local > Goles_visitante order by fecha DESC limit 5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoLocalDerrotas(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_local = '" + equipo.Codigo + "' and Goles_local < Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoLocalUltimasDerrotas(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_local = '" + equipo.Codigo + "' and Goles_local < Goles_visitante order by fecha DESC limit 5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoLocalEmpates(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_local = '" + equipo.Codigo + "' and Goles_local = Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoLocalUltimosEmpates(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_local = '" + equipo.Codigo + "' and Goles_local = Goles_visitante order by fecha DESC limit 5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoVisitanteVictorias(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_visitante = '" + equipo.Codigo + "' and Goles_local > Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoVisitanteDerrotas(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_visitante = '" + equipo.Codigo + "' and Goles_local < Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EquipoVisitanteEmpates(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE Equipo_visitante = '" + equipo.Codigo + "' and Goles_local = Goles_visitante";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AmbosAnotanSi(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE (Equipo_local = '" + equipo.Codigo + "' or Equipo_visitante = '" + equipo.Codigo + "') and (Goles_local > 0 and Goles_visitante > 0)";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int AmbosAnotanNo(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE (Equipo_local = '" + equipo.Codigo + "' or Equipo_visitante =  '" + equipo.Codigo + "') and not (Goles_local > 0 and Goles_visitante > 0)";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public int MasDeDosPuntoCincoGolesSi(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE (Equipo_local = '" + equipo.Codigo + "' or Equipo_visitante = '" + equipo.Codigo + "') and Goles_local + Goles_visitante > 2.5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int MasDeDosPuntoCincoGolesNo(BEEquipo equipo)
        {
            try
            {
                acceso = new Acceso();
                string consulta = "Select Count (*) FROM partido WHERE (Equipo_local = '" + equipo.Codigo + "' or Equipo_visitante = '" + equipo.Codigo + "') and Goles_local + Goles_visitante < 2.5";
                return acceso.RetornarScalar(consulta);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
