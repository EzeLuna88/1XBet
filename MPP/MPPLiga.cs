using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using System.Data;

namespace MPP
{
    public class MPPLiga

       
    {

        Acceso acceso;

        public List<BELiga> ListarLigas()
        {
            try
            {
                DataSet ds = new DataSet();
                acceso = new Acceso();
                string consulta = "Select * from Liga order by Nombre asc";
                ds = acceso.Leer(consulta);
                List<BELiga> ListaLigas = new List<BELiga>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        BELiga liga = new BELiga();
                        liga.Codigo = Convert.ToInt32(dr[0]);
                        liga.Nombre = dr[1].ToString();
                        ListaLigas.Add(liga);
                    }
                }
                else
                {
                    ListaLigas = null;
                }
                return ListaLigas;
            }
            catch (Exception)
            {

                throw;
            }
     
        }

        public bool GuardarLiga(BELiga beLiga)
        {
            try
            {
                string consultaSql = string.Empty;
                consultaSql = "Insert into Liga (Liga.Nombre) values ('" + beLiga.Nombre + "')";
                acceso = new Acceso();
                return acceso.Escribir(consultaSql);
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public bool BajaLiga(BELiga beLiga)
        {
            try
            {
                string consultaSQL = "DELETE from Liga where Liga.Codigo = '" + beLiga.Codigo + "'";
                acceso = new Acceso();
                return acceso.Escribir(consultaSQL);
            }
            catch (Exception e)
            {

                throw e;
            }


        }

        public bool BuscarLiga(BELiga beLiga)
        {
            try
            {
                acceso = new Acceso();
                return acceso.LeerScalar("SELECT COUNT(*) FROM Liga WHERE UPPER(Nombre) = '" + beLiga.Nombre + "'");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
