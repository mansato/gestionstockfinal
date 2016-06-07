using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CRUDEntree
    {
        public static List<Entree> listeentree()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Entree> listeentree = new List<Entree>();
                        Entree P;
                        cmd.CommandText = "select * from entree";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P = new Entree();
                                P.qte_entree = (int)dr["qte_entree"];
                                P.date_entree = (DateTime)dr["date_entree"];
                                P.id_prod = dr["id_produit"].ToString();
                                listeentree.Add(P);
                            }
                        }
                        return listeentree;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public static void Ajoutentree(Entree Entree)
        {
            try
            {

                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "maj_add_qstock_prod";
                        SqlParameter produit_famille = new SqlParameter("@monproduitid", SqlDbType.NVarChar);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = Entree.id_prod;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter produit_libelle = new SqlParameter("@qte_entree", SqlDbType.Int);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = Entree.qte_entree;
                        cmd.Parameters.Add(produit_libelle);
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
        public static void DeleteEntree(Entree ent)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "del_add_qstock_prod";
                        SqlParameter produit_famille = new SqlParameter("@monproduitid", SqlDbType.NVarChar);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = ent.id_prod;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter produit_libelle = new SqlParameter("@qte_entree", SqlDbType.Int);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = ent.qte_entree;
                        cmd.Parameters.Add(produit_libelle);
                        SqlParameter entree_date = new SqlParameter("@date", SqlDbType.DateTime);
                        entree_date.Direction = ParameterDirection.Input;
                        entree_date.Value = ent.date_entree;
                        cmd.Parameters.Add(entree_date);
                        cmd.Connection = co;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                }
            }
        }
        public static List<Entree> lecturedate(string date1,string date2)
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Entree> listeentree = new List<Entree>();
                        Entree P;
                        cmd.CommandText = "select * from entree  where date_entree BETWEEN '"+date1+"' AND '"+date2+"'";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P = new Entree();
                                P.qte_entree = (int)dr["qte_entree"];
                                P.date_entree = (DateTime)dr["date_entree"];
                                P.id_prod = dr["id_produit"].ToString();
                                listeentree.Add(P);
                            }
                        }
                        return listeentree;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
    }
}
