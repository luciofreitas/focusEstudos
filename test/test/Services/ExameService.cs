using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using test.DTOs;
namespace test.Services
{
    public class ExameService
    {
        public static List<ExameDTO> ObterExames()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<ExameDTO> list = new List<ExameDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $@"SELECT ID, Nome_Exame, Nome_Exame_Ingles, Tipo, Masculino, Feminino, Exib_Ficha,
                    Exib_ASO, Ativo, Nome_Laboratorial, Cod_ESocial,Unidade_Medida, MNE_Solicitacao FROM Exames";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExameDTO exame = new ExameDTO();

                            exame.ID = int.Parse(reader["ID"].ToString());
                            exame.Nome_Exame = reader["Nome_Exame"].ToString();
                            exame.Nome_Exame_Ingles = reader["Nome_Exame_Ingles"].ToString();
                            exame.Nome_Laboratorial = reader["Nome_Laboratorial"].ToString();
                            exame.Cod_Categoria_eSocial = reader["Cod_ESocial"].ToString();
                            exame.Unidade_Medida = reader["Unidade_Medida"].ToString();
                            exame.MNE_Solicitacao = reader["MNE_Solicitacao"].ToString();
                            exame.Tipo = bool.Parse(reader["Tipo"].ToString());
                            exame.Masculino = bool.Parse(reader["Masculino"].ToString());
                            exame.Feminino = bool.Parse(reader["Feminino"].ToString());
                            exame.ExibFicha = bool.Parse(reader["Exib_Ficha"].ToString());
                            exame.ExibASO = bool.Parse(reader["Exib_ASO"].ToString());
                            exame.Ativo = bool.Parse(reader["Ativo"].ToString());

                            list.Add(exame);
                        }
                    }
                }
            }
            return list;
        }
        public static ExameDTO ObterExame(int id)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Exames WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        ExameDTO exame = new ExameDTO();
                        reader.Read();
                        {
                            exame.ID = id;
                            exame.Nome_Exame = reader["Nome_Exame"].ToString();
                            exame.Nome_Exame_Ingles = reader["Nome_Exame_Ingles"].ToString();
                            exame.Nome_Laboratorial = reader["Nome_Laboratorial"].ToString();
                            exame.Cod_Categoria_eSocial = reader["Cod_ESocial"].ToString();
                            exame.Unidade_Medida = reader["Unidade_Medida"].ToString();
                            exame.MNE_Solicitacao = reader["MNE_Solicitacao"].ToString();
                            exame.Tipo = bool.Parse(reader["Tipo"].ToString());
                            exame.Masculino = bool.Parse(reader["Masculino"].ToString());
                            exame.Feminino = bool.Parse(reader["Feminino"].ToString());
                            exame.ExibFicha = bool.Parse(reader["Exib_Ficha"].ToString());
                            exame.ExibASO = bool.Parse(reader["Exib_ASO"].ToString());
                            exame.Ativo = bool.Parse(reader["Ativo"].ToString());
                        }
                        return exame;
                    }
                }
            }
        }
        public static List<ExameDTO> InserirExame(ExameDTO exame)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            List<ExameDTO> list = new List<ExameDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"INSERT INTO Exames (Nome_Exame, Nome_Exame_Ingles, Masculino, Feminino, Tipo, Exib_Ficha, Exib_ASO, Ativo, Nome_Laboratorial, Cod_ESocial, Unidade_Medida, MNE_Solicitacao)
                               VALUES(@Nome_Exame, @Nome_Exame_Ingles, @Masculino, @Feminino, @Tipo, @Exib_Ficha, @Exib_ASO, @Ativo, @Nome_Laboratorial, @Cod_ESocial, @Unidade_Medida, @MNE_Solicitacao)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome_Exame", DbNullHelper.CheckNullity(exame.Nome_Exame));
                    command.Parameters.AddWithValue("@Nome_Exame_Ingles", DbNullHelper.CheckNullity(exame.Nome_Exame_Ingles));
                    command.Parameters.AddWithValue("@Tipo", DbNullHelper.CheckNullity(exame.Tipo));
                    command.Parameters.AddWithValue("@Masculino", DbNullHelper.CheckNullity(exame.Masculino));
                    command.Parameters.AddWithValue("@Feminino", DbNullHelper.CheckNullity(exame.Feminino));
                    command.Parameters.AddWithValue("@Exib_Ficha", DbNullHelper.CheckNullity(exame.ExibFicha));
                    command.Parameters.AddWithValue("@Exib_ASO", DbNullHelper.CheckNullity(exame.ExibASO));
                    command.Parameters.AddWithValue("@Ativo", DbNullHelper.CheckNullity(exame.Ativo));
                    command.Parameters.AddWithValue("@Nome_Laboratorial", DbNullHelper.CheckNullity(exame.Nome_Laboratorial));
                    command.Parameters.AddWithValue("@Cod_ESocial", DbNullHelper.CheckNullity(exame.Cod_Categoria_eSocial));
                    command.Parameters.AddWithValue("@Unidade_Medida", DbNullHelper.CheckNullity(exame.Unidade_Medida));
                    command.Parameters.AddWithValue("@MNE_Solicitacao", DbNullHelper.CheckNullity(exame.MNE_Solicitacao));


                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return list;
        }
        public static void EditarExame(ExameDTO exame)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"sp_editarExames";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ExameID", exame.ID);
                    command.Parameters.AddWithValue("@Nome_Exame", exame.Nome_Exame);
                    command.Parameters.AddWithValue("@Nome_Exame_Ingles", exame.Nome_Exame_Ingles);
                    command.Parameters.AddWithValue("@Nome_Laboratorial", exame.Nome_Laboratorial);
                    command.Parameters.AddWithValue("@Cod_ESocial", exame.Cod_Categoria_eSocial);
                    command.Parameters.AddWithValue("@Unidade_Medida", exame.Unidade_Medida);
                    command.Parameters.AddWithValue("@MNE_Solicitacao", exame.MNE_Solicitacao);
                    command.Parameters.AddWithValue("@Tipo", exame.Tipo);
                    command.Parameters.AddWithValue("@Masculino", exame.Masculino);
                    command.Parameters.AddWithValue("@Feminino", exame.Feminino);
                    command.Parameters.AddWithValue("@Exib_Ficha", exame.ExibFicha);
                    command.Parameters.AddWithValue("@Exib_ASO", exame.ExibASO);
                    command.Parameters.AddWithValue("@Ativo", exame.Ativo);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void DeletarExame(int exameID)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"DELETE FROM Exames WHERE ID = @ExameID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@ExameID", exameID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}

