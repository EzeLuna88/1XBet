using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;

namespace BLL
{
    public class BLLLiga
    {
        MPPLiga mPPLiga;

        public BLLLiga()
        {
            mPPLiga = new MPPLiga();
        }

        public List<BELiga> ListarLigas()
        {
            return mPPLiga.ListarLigas();
        }

        public bool GuardarLiga(BELiga beLiga)
        {
            return mPPLiga.GuardarLiga(beLiga);
        }

        public bool BajaLiga(BELiga beLiga) 
        {
            return mPPLiga.BajaLiga(beLiga);
        }

        public bool BuscarLiga(BELiga beLiga) 
        { 
            return mPPLiga.BuscarLiga(beLiga) ;
        }
    }
}
