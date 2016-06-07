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
    public class CRUDSortie
    {
        public static List<Sortie> listesortie()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Sortie> listesortie = new List<Sortie>();
                        Sortie P;
                        cmd.CommandText = "select * from sortie";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P = new Sortie();
                                P.qte_sortie = (int)dr["qte_sortie"];
                                P.date_sortie = (DateTime)dr["date_sortie"];
                                P.id_prod = dr["id_produit"].ToString();
                                listesortie.Add(P);
                            }
                        }
                        return listesortie;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public static void AjoutSortie(Sortie Sortie)
        {
            try
            {

                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "maj_sous_qstock_prod";
                        SqlParameter produit_famille = new SqlParameter("@monproduitid", SqlDbType.NVarChar);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = Sortie.id_prod;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter produit_libelle = new SqlParameter("@qte_stocksortie", SqlDbType.Int);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = Sortie.qte_sortie;
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
        public static void DeleteSortie(Sortie sort)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "del_sous_qstock_prod";
                        SqlParameter produit_famille = new SqlParameter("@monproduitid", SqlDbType.NVarChar);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = sort.id_prod;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter produit_libelle = new SqlParameter("@qte_sortie", SqlDbType.Int);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = sort.qte_sortie;
                        cmd.Parameters.Add(produit_libelle);
                        SqlParameter sortie_date = new SqlParameter("@date", SqlDbType.DateTime);
                        sortie_date.Direction = ParameterDirection.Input;
                        sortie_date.Value = sort.date_sortie;
                        cmd.Parameters.Add(sortie_date);
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
        public static List<Sortie> lecturedatesort(string date1, string date2)
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Sortie> listesortie = new List<Sortie>();
                        Sortie P;
                        cmd.CommandText = "select * from sortie  where date_sortie BETWEEN '" + date1 + "' AND '" + date2 + "'";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P = new Sortie();
                                P.qte_sortie = (int)dr["qte_sortie"];
                                P.date_sortie = (DateTime)dr["date_sortie"];
                                P.id_prod = dr["id_produit"].ToString();
                                listesortie.Add(P);
                            }
                        }
                        return listesortie;
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
