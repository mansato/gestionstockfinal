using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CRUDSProduit
    {
        
        public static List<Produit> listeProduit()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Produit> listeProduit = new List<Produit>();
                        Produit P;
                        cmd.CommandText = "select * from lst_prod_fou_fami";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P = new Produit();
                                P.fam.famille = dr["nom_famille"].ToString();
                                P.codart = dr["id_produit"].ToString();
                                P.libelle = dr["libelle"].ToString();                                
                                P.pri_uni = (decimal)dr["prix_unitaire"];
                                P.qte_stock = (int)dr["qte"];
                                P.stock_ale = (int)dr["qte_stock_alerte"];
                                P.fournisseur.nom_fournisseur = dr["nom_fournis"].ToString();
                                P.tva.montant = (decimal)dr["montant"];
                                listeProduit.Add(P);
                            }
                        }
                        return listeProduit;
                    }

                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


           
        }

        public static List<Produit> getProduittva(Produit code)
        {
            try
            {
                
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Produit> listeProduittva = new List<Produit>();
                        Model.Produit P;
                        cmd.CommandText = "aff_tva_art();";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@ref", SqlDbType.NVarChar)).Value = code.tva.montant;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P =new Model.Produit();
                                P.tva.montant = (int)dr["montant"];

                            }
                        }
                        return listeProduittva;
                    }
                   
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }



        public static void AjoutProduit(Produit produit)
        {
            try
                 {

          using (SqlConnection co = ConnexionDB.getConnection())
                    {
                        using (SqlCommand cmd = co.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "add_produit";
                            SqlParameter produit_famille = new SqlParameter("@famille", SqlDbType.NVarChar);
                            produit_famille.Direction = ParameterDirection.Input;
                            produit_famille.Value = produit.fam.famille;
                            cmd.Parameters.Add(produit_famille);
                            SqlParameter produit_ref = new SqlParameter("@ref", SqlDbType.NVarChar);
                            produit_ref.Direction = ParameterDirection.Input;
                            produit_ref.Value = produit.codart;
                            cmd.Parameters.Add(produit_ref);
                            SqlParameter produit_libelle = new SqlParameter("@libelle", SqlDbType.NVarChar);
                            produit_libelle.Direction = ParameterDirection.Input;
                            produit_libelle.Value = produit.libelle;
                            cmd.Parameters.Add(produit_libelle);
                            SqlParameter produit_frounisseur = new SqlParameter("@fourni", SqlDbType.NVarChar);
                            produit_frounisseur.Direction = ParameterDirection.Input;
                            produit_frounisseur.Value = produit.fournisseur.nom_fournisseur;
                            cmd.Parameters.Add(produit_frounisseur);
                            SqlParameter produit_prixu = new SqlParameter("@prixu", SqlDbType.Decimal);
                            produit_prixu.Direction = ParameterDirection.Input;
                            produit_prixu.Value = produit.pri_uni;
                            cmd.Parameters.Add(produit_prixu);
                            SqlParameter produit_qte = new SqlParameter("@qte", SqlDbType.Int);
                            produit_qte.Direction = ParameterDirection.Input;
                            produit_qte.Value =  produit.qte_stock;
                            cmd.Parameters.Add(produit_qte);
                            SqlParameter produit_qta = new SqlParameter("@qta", SqlDbType.Int);
                            produit_qta.Direction = ParameterDirection.Input;
                            produit_qta.Value = produit.stock_ale;
                            cmd.Parameters.Add(produit_qta);
                            SqlParameter produit_tva = new SqlParameter("@tva", SqlDbType.Decimal);
                            produit_tva.Direction = ParameterDirection.Input;
                            produit_tva.Value = produit.tva.montant;
                            cmd.Parameters.Add(produit_tva);
                            cmd.Connection = co;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

          
        }

        public static void ModifierProduit(Produit produit)
        {
            try
            {

                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "mod_produit";
                        SqlParameter produit_famille = new SqlParameter("@famille", SqlDbType.NVarChar);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = produit.fam.famille;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter produit_ref = new SqlParameter("@ref", SqlDbType.NVarChar);
                        produit_ref.Direction = ParameterDirection.Input;
                        produit_ref.Value = produit.codart;
                        cmd.Parameters.Add(produit_ref);
                        SqlParameter produit_libelle = new SqlParameter("@libelle", SqlDbType.NVarChar);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = produit.libelle;
                        cmd.Parameters.Add(produit_libelle);
                        SqlParameter produit_frounisseur = new SqlParameter("@fourni", SqlDbType.NVarChar);
                        produit_frounisseur.Direction = ParameterDirection.Input;
                        produit_frounisseur.Value = produit.fournisseur.nom_fournisseur;
                        cmd.Parameters.Add(produit_frounisseur);
                        SqlParameter produit_prixu = new SqlParameter("@prixu", SqlDbType.Decimal);
                        produit_prixu.Direction = ParameterDirection.Input;
                        produit_prixu.Value = produit.pri_uni;
                        cmd.Parameters.Add(produit_prixu);
                        SqlParameter produit_qta = new SqlParameter("@qta", SqlDbType.Int);
                        produit_qta.Direction = ParameterDirection.Input;
                        produit_qta.Value = produit.stock_ale;
                        cmd.Parameters.Add(produit_qta);
                        SqlParameter produit_tva = new SqlParameter("@tva", SqlDbType.Decimal);
                        produit_tva.Direction = ParameterDirection.Input;
                        produit_tva.Value = produit.tva.montant;
                        cmd.Parameters.Add(produit_tva);
                        cmd.Connection = co;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public static void deleteProduit(string prod)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "del_produit";
 
                    SqlParameter produit_ref = new SqlParameter("@ref", SqlDbType.NVarChar);
                    produit_ref.Direction = ParameterDirection.Input;
                    produit_ref.Value = prod;
                    cmd.Parameters.Add(produit_ref);                   
                    cmd.Connection = co;
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Produit> lectureProduit(string prod)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    List<Produit> listeProduit = new List<Produit>();
                    Produit P;
                    cmd.CommandText = prod;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            P = new Produit();
                            P.fam.famille = dr["nom_famille"].ToString();
                            P.codart = dr["id_produit"].ToString();
                            P.libelle = dr["libelle"].ToString();
                            P.pri_uni = (decimal)dr["prix_unitaire"];
                            P.qte_stock = (int)dr["qte"];
                            P.stock_ale = (int)dr["qte_stock_alerte"];
                            P.fournisseur.nom_fournisseur = dr["nom_fournis"].ToString();
                            P.tva.montant = (decimal)dr["montant"];
                            listeProduit.Add(P);
                        }
                    }
                    return listeProduit;
                }

            }

        }

    }

}
