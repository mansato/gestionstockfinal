using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
   public class FamilleRepository
    {
        public static List<Famille> listeFama()
        {
            try
            {
                List<Famille> listFam = new List<Famille>();
                listFam = CRUDFamille.listefamille();
                return listFam;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void ajoutfamille(Famille Famille)
        {
            try
            {
                CRUDFamille.AjoutFamille(Famille);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void updatefamille(Famille Famille,string fam)
        {
            CRUDFamille.modifierFamille(Famille,fam);
        }
        public static void deletetva(string fam)
        {
            CRUDFamille.DeleteFamille(fam);
        }
    }
}
