using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
   public class FournisseurRepository
    {
        public static List<Fournisseur> listefourni()
        {
            try
            {
                List<Fournisseur> listefourni = new List<Fournisseur>();
                listefourni = CRUDFournisseur.listefournisseur();
                return listefourni;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static List<Fournisseur> listefour(Fournisseur four)
        {
            try
            {
                List<Fournisseur> listefourni = new List<Fournisseur>();
                listefourni = CRUDFournisseur.listefourni(four);
                return listefourni;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void ajoutfourni(Fournisseur four)
        {
            try
            {
                CRUDFournisseur.ajoutfournis(four);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void updatefourni(Fournisseur four)
        {
            CRUDFournisseur.modiffournis(four);
        }
        public static void deletefourni(Fournisseur four)
        {
            CRUDFournisseur.delfournis(four);
        }
        public static List<Fournisseur> lirerouni(string four)
        {
            return CRUDFournisseur.lecturefournisseur(four);
        }
    }
}
