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
  public class CRUDFournisseur
    {
        public static List<Fournisseur> listefournisseur()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Fournisseur> listefour = new List<Fournisseur>();
                        Fournisseur four;
                        cmd.CommandText = "select * from lst_fournis";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                four = new Fournisseur();
                                four.nom_fournisseur = dr["nom_fournis"].ToString();
                                four.coordonnee.adresse.num_rue = (int)dr["num_rue"];
                                four.coordonnee.adresse.rue = dr["rue"].ToString();
                                four.coordonnee.adresse.ville = dr["ville"].ToString();
                                four.coordonnee.adresse.code_postal = dr["cp"].ToString();
                                four.coordonnee.mail.mail = dr["mail"].ToString();
                                four.coordonnee.tel.telephone = dr["telephone"].ToString();
                                listefour.Add(four);
                            }
                        }
                        return listefour;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }
        public static List<Fournisseur> listefourni(Fournisseur fourni)
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Fournisseur> listefour = new List<Fournisseur>();
                        Fournisseur four;
                        cmd.CommandText = "select id_fournis,nom_fournis,coordonnee.id_coordonnee,id_adresse,id_telephone,id_mail from fournisseur join coordonnee on coordonnee.id_coordonnee = fournisseur.id_coordonnee where nom_fournis=@nomfour";
                        cmd.Parameters.Add(new SqlParameter("@nomfour", SqlDbType.NVarChar)).Value = fourni.nom_fournisseur;
                        cmd.Connection = co;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                four = new Fournisseur();
                                four.id_fournisseur = (int)dr["id_fournis"];
                                four.nom_fournisseur = dr["nom_fournis"].ToString();
                                four.coordonnee.id_coordonnee= (int)dr["id_coordonnee"];
                                four.coordonnee.adresse.id_adresse = (int)dr["id_adresse"];
                                four.coordonnee.mail.id_mail = (int)dr["id_mail"];
                                four.coordonnee.tel.id_tel = (int)dr["id_telephone"];
                                listefour.Add(four);
                            }
                        }
                        return listefour;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public static void ajoutfournis(Fournisseur fournis)
        {
            try
            {

                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "add_fournisseur";
                        SqlParameter produit_famille = new SqlParameter("@num", SqlDbType.Int);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = fournis.coordonnee.adresse.num_rue;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter produit_ref = new SqlParameter("@rue", SqlDbType.NVarChar);
                        produit_ref.Direction = ParameterDirection.Input;
                        produit_ref.Value = fournis.coordonnee.adresse.rue;
                        cmd.Parameters.Add(produit_ref);
                        SqlParameter produit_libelle = new SqlParameter("@ville", SqlDbType.NVarChar);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = fournis.coordonnee.adresse.ville;
                        cmd.Parameters.Add(produit_libelle);
                        SqlParameter produit_frounisseur = new SqlParameter("@cp", SqlDbType.NVarChar);
                        produit_frounisseur.Direction = ParameterDirection.Input;
                        produit_frounisseur.Value = fournis.coordonnee.adresse.code_postal;
                        cmd.Parameters.Add(produit_frounisseur);
                        SqlParameter produit_prixu = new SqlParameter("@tel", SqlDbType.NVarChar);
                        produit_prixu.Direction = ParameterDirection.Input;
                        produit_prixu.Value = fournis.coordonnee.tel.telephone;
                        cmd.Parameters.Add(produit_prixu);
                        SqlParameter produit_qte = new SqlParameter("@mail", SqlDbType.NVarChar);
                        produit_qte.Direction = ParameterDirection.Input;
                        produit_qte.Value = fournis.coordonnee.mail.mail;
                        cmd.Parameters.Add(produit_qte);
                        SqlParameter produit_qta = new SqlParameter("@fournis", SqlDbType.NVarChar);
                        produit_qta.Direction = ParameterDirection.Input;
                        produit_qta.Value = fournis.nom_fournisseur;
                        cmd.Parameters.Add(produit_qta);
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

        public static void modiffournis(Fournisseur fournis)
        {
            try
            {

                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "mod_fournisseur";
                        SqlParameter produit_famille = new SqlParameter("@num", SqlDbType.Int);
                        produit_famille.Direction = ParameterDirection.Input;
                        produit_famille.Value = fournis.coordonnee.adresse.num_rue;
                        cmd.Parameters.Add(produit_famille);
                        SqlParameter fourniseur_id_fournis = new SqlParameter("@id_four", SqlDbType.Int);
                        fourniseur_id_fournis.Direction = ParameterDirection.Input;
                        fourniseur_id_fournis.Value = fournis.id_fournisseur;
                        cmd.Parameters.Add(fourniseur_id_fournis);
                        SqlParameter fourniseur_id_adresse = new SqlParameter("@id_add", SqlDbType.Int);
                        fourniseur_id_adresse.Direction = ParameterDirection.Input;
                        fourniseur_id_adresse.Value = fournis.coordonnee.adresse.id_adresse;
                        cmd.Parameters.Add(fourniseur_id_adresse);
                        SqlParameter fourniseur_id_tel = new SqlParameter("@id_tel", SqlDbType.Int);
                        fourniseur_id_tel.Direction = ParameterDirection.Input;
                        fourniseur_id_tel.Value = fournis.coordonnee.tel.id_tel;
                        cmd.Parameters.Add(fourniseur_id_tel);
                        SqlParameter fourniseur_id_mail = new SqlParameter("@id_mail", SqlDbType.Int);
                        fourniseur_id_mail.Direction = ParameterDirection.Input;
                        fourniseur_id_mail.Value = fournis.coordonnee.mail.id_mail;
                        cmd.Parameters.Add(fourniseur_id_mail);
                        SqlParameter produit_ref = new SqlParameter("@rue", SqlDbType.NVarChar);
                        produit_ref.Direction = ParameterDirection.Input;
                        produit_ref.Value = fournis.coordonnee.adresse.rue;
                        cmd.Parameters.Add(produit_ref);
                        SqlParameter produit_libelle = new SqlParameter("@ville", SqlDbType.NVarChar);
                        produit_libelle.Direction = ParameterDirection.Input;
                        produit_libelle.Value = fournis.coordonnee.adresse.ville;
                        cmd.Parameters.Add(produit_libelle);
                        SqlParameter produit_frounisseur = new SqlParameter("@cp", SqlDbType.NVarChar);
                        produit_frounisseur.Direction = ParameterDirection.Input;
                        produit_frounisseur.Value = fournis.coordonnee.adresse.code_postal;
                        cmd.Parameters.Add(produit_frounisseur);
                        SqlParameter produit_prixu = new SqlParameter("@tel", SqlDbType.NVarChar);
                        produit_prixu.Direction = ParameterDirection.Input;
                        produit_prixu.Value = fournis.coordonnee.tel.telephone;
                        cmd.Parameters.Add(produit_prixu);
                        SqlParameter produit_qte = new SqlParameter("@mail", SqlDbType.NVarChar);
                        produit_qte.Direction = ParameterDirection.Input;
                        produit_qte.Value = fournis.coordonnee.mail.mail;
                        cmd.Parameters.Add(produit_qte);
                        SqlParameter produit_qta = new SqlParameter("@fournis", SqlDbType.NVarChar);
                        produit_qta.Direction = ParameterDirection.Input;
                        produit_qta.Value = fournis.nom_fournisseur;
                        cmd.Parameters.Add(produit_qta);
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
        public static void delfournis(Fournisseur fournis)
        {
            try
            {

                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "del_fournisseur";
                        SqlParameter fourniseur_id_fournis = new SqlParameter("@id_four", SqlDbType.Int);
                        fourniseur_id_fournis.Direction = ParameterDirection.Input;
                        fourniseur_id_fournis.Value = fournis.id_fournisseur;
                        cmd.Parameters.Add(fourniseur_id_fournis);
                        SqlParameter fourniseur_id_adresse = new SqlParameter("@id_add", SqlDbType.Int);
                        fourniseur_id_adresse.Direction = ParameterDirection.Input;
                        fourniseur_id_adresse.Value = fournis.coordonnee.adresse.id_adresse;
                        cmd.Parameters.Add(fourniseur_id_adresse);
                        SqlParameter fourniseur_id_tel = new SqlParameter("@id_tel", SqlDbType.Int);
                        fourniseur_id_tel.Direction = ParameterDirection.Input;
                        fourniseur_id_tel.Value = fournis.coordonnee.tel.id_tel;
                        cmd.Parameters.Add(fourniseur_id_tel);
                        SqlParameter fourniseur_id_mail = new SqlParameter("@id_mail", SqlDbType.Int);
                        fourniseur_id_mail.Direction = ParameterDirection.Input;
                        fourniseur_id_mail.Value = fournis.coordonnee.mail.id_mail;
                        cmd.Parameters.Add(fourniseur_id_mail);
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
        public static List<Fournisseur> lecturefournisseur(string prod)
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Fournisseur> listefour = new List<Fournisseur>();
                        Fournisseur four;
                        cmd.CommandText = prod;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                four = new Fournisseur();
                                four.nom_fournisseur = dr["nom_fournis"].ToString();
                                four.coordonnee.adresse.num_rue = (int)dr["num_rue"];
                                four.coordonnee.adresse.rue = dr["rue"].ToString();
                                four.coordonnee.adresse.ville = dr["ville"].ToString();
                                four.coordonnee.adresse.code_postal = dr["cp"].ToString();
                                four.coordonnee.mail.mail = dr["mail"].ToString();
                                four.coordonnee.tel.telephone = dr["telephone"].ToString();
                                listefour.Add(four);
                            }
                        }
                        return listefour;
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
