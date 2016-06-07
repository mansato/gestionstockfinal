using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;


namespace BusinessLayer
{
    public class SortieRepository
    {
        public static List<Sortie> listeSort()
        {
            try
            {
                List<Sortie> listSor = new List<Sortie>();
                listSor = CRUDSortie.listesortie();
                return listSor;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    

        public static void sortieproduit(Sortie sort)
        {
            try
            {
                CRUDSortie.AjoutSortie(sort);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void deleteSortie(Sortie sort)
        {
            CRUDSortie.DeleteSortie(sort);
        }
        public static List<Sortie> liredatsort(string date1, string date2)
        {
            return CRUDSortie.lecturedatesort(date1, date2);
        }

    }
}
