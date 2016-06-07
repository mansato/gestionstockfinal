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
    public class CRUDSTva
    {
        public static List<TVA> listeTva()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<TVA> listeTva = new List<TVA>();
                        TVA T;
                        cmd.CommandText = "select * from tva";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                T = new TVA();
                                T.id_tva = (int)dr["id_tva"];
                                T.montant = (decimal)dr["montant"];
                                listeTva.Add(T);
                            }
                        }
                        return listeTva;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public static List<TVA> listeTvaart(string art)
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<TVA> listeTva = new List<TVA>();
                        TVA T;
                        cmd.CommandText = "select * from tva";
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                T = new TVA();
                                T.id_tva = (int)dr["id_tva"];
                                T.montant = (decimal)dr["montant"];
                                listeTva.Add(T);
                            }
                        }
                        return listeTva;
                    }

                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public static void AjoutTVA(Model.TVA tva)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "insert into tva values (@idtva,@montant)";
                        cmd.Parameters.Add(new SqlParameter("@idtva", SqlDbType.Int)).Value = tva.id_tva;
                        cmd.Parameters.Add(new SqlParameter("@montant", SqlDbType.Decimal)).Value = tva.montant;

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

        public static Model.TVA LectureTVA(int idTVA)
        {
            Model.TVA tva = new Model.TVA();

            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "select * from tva where id_tva = @idtva ";
                        cmd.Parameters.Add(new SqlParameter("@idtva", SqlDbType.Int)).Value = idTVA;
                        cmd.Connection = co;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                tva.id_tva = (int)dr["id_tva"];
                                tva.montant = (decimal)dr["montant"];
                            }
                        }
                        return tva;
                    }
                    catch (Exception ex)
                    {

                        throw new Exception(ex.Message);
                    }

                }
            }

        }

        public static void DeleteTVA(int idTVA)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = " delete from tva where id_tva = @idtva";
                        cmd.Parameters.Add(new SqlParameter("@idtva", SqlDbType.Int)).Value = idTVA;

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

        public static void modifierTVA(Model.TVA tva)
        {
            using (SqlConnection co = ConnexionDB.getConnection())
            {
                using (SqlCommand cmd = co.CreateCommand())
                {
                    try
                    {
                        cmd.CommandText = "update tva set id_tva = @idtva, montant = @montant where id_tva = @idtva";
                        cmd.Parameters.Add(new SqlParameter("@idtva", SqlDbType.Int)).Value = tva.id_tva;
                        cmd.Parameters.Add(new SqlParameter("@montant", SqlDbType.Decimal)).Value = tva.montant;

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

        public static int countidtva()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        cmd.CommandText = "select max (id_tva) as  'a' from tva";
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
