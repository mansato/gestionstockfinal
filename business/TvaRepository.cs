using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class TvaRepository
    {    
        public static List<TVA> listeTva()
        {
            try
            {
                List<TVA> listTva = new List<TVA>();
                listTva = CRUDSTva.listeTva();
                return listTva;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void ajoutTVA(TVA tva)
        {
            try
            {
                CRUDSTva.AjoutTVA(tva);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void deletetva(int tva)
        {
            CRUDSTva.DeleteTVA(tva);
        }
    }
}
