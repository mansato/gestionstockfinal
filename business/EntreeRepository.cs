using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class EntreeRepository
    {
        public static List<Entree> listeent()
        {
            try
            {
                List<Entree> listent = new List<Entree>();
                listent = CRUDEntree.listeentree();
                return listent;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void EntreeProduit(Entree ent)
        {
            try
            {
                CRUDEntree.Ajoutentree(ent);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void deleteEntree(Entree ent)
        {
            CRUDEntree.DeleteEntree(ent);
        }
        public static List<Entree> liredatent (string date1,string date2)
        {
            return CRUDEntree.lecturedate(date1,date2);
        }
    }
}
