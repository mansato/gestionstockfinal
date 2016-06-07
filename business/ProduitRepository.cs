using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataLayer;

namespace BusinessLayer
{
    public class ProduitRepository
    {        
        public static List<Produit> listeProduit()
        {
            try
            {
                List<Produit> listProduit = new List<Produit>();
                listProduit = CRUDSProduit.listeProduit();                
                return listProduit;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static List<Produit> listeProduittva(Produit refe)
        {
            try
            {
                return CRUDSProduit.getProduittva(refe);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public static void ajoutProduit(Produit produit)
        {
            try
            {
                CRUDSProduit.AjoutProduit(produit);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public static void updateproduit(Produit produit)
        {
            CRUDSProduit.ModifierProduit(produit);
        }
        public static void deleteproduit(string prod)
        {
            CRUDSProduit.deleteProduit(prod);
        }
        public static List<Produit> lireproduit(string prod)
        {
            return CRUDSProduit.lectureProduit(prod);
        }
        public static List<Produit> ordreproduit(string prod)
        {
            return CRUDSProduit.lectureProduit(prod);
        }
    }
}
