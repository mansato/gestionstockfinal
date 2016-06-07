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
    public class CRUDFamille
    {
        public static List<Famille> listefamille()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Famille> listeFam = new List<Famille>();
                        Famille Fa;
                        cmd.CommandText = "select * from famille";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                Fa = new Famille();
                                Fa.id_famille = (int)dr["id_famille"];
                                Fa.famille = dr["nom_famille"].ToString();
                                Fa.description = dr["descrip"].ToString();
                                listeFam.Add(Fa);
                            }
                        }
                        return listeFam;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }



        }

        public static void AjoutFamille(Famille famille)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "insert into famille values (@nomfam,@descrip)";
                        cmd.Parameters.Add(new SqlParameter("@nomfam", SqlDbType.NVarChar)).Value = famille.famille;
                        cmd.Parameters.Add(new SqlParameter("@descrip", SqlDbType.NVarChar)).Value = famille.description;

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

        public static Model.Famille LectureFamille(int idFam)
        {
            Model.Famille famille = new Model.Famille();

            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "select * from famille where id_famille = @idfam ";
                        cmd.Parameters.Add(new SqlParameter("@idfam", SqlDbType.Int)).Value = idFam;
                        cmd.Connection = co;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                famille.id_famille = (int)dr["id_famille"];
                                famille.famille = dr["nom_famille"].ToString();
                            }
                        }
                        return famille;
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                }
            }

        }

        public static void DeleteFamille(string idFam)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = " delete from famille where nom_famille = @idfam";
                        cmd.Parameters.Add(new SqlParameter("@idfam", SqlDbType.NVarChar)).Value = idFam;

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

        public static void modifierFamille(Model.Famille famille,string fam)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "update famille set nom_famille = @nomfam, descrip = @descrip where nom_famille = @fam";
                        cmd.Parameters.Add(new SqlParameter("@fam", SqlDbType.NVarChar)).Value = fam;
                        cmd.Parameters.Add(new SqlParameter("@nomfam", SqlDbType.NVarChar)).Value = famille.famille;
                        cmd.Parameters.Add(new SqlParameter("@descrip", SqlDbType.NVarChar)).Value = famille.description;

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

        public static int countidfamille()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandText = "select max (id_famille) as  'a' from famille";
                        cmd.Connection = co;
                        return (int)cmd.ExecuteScalar();
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
