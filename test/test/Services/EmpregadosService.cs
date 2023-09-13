using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using Nest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using test.DTOs;

namespace test.Services
{
    public class EmpregadosService
    {
        public static List<EmpregadosDTO> InserirEmpregado(EmpregadosDTO empregados)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            List<EmpregadosDTO> list = new List<EmpregadosDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql =
                    @"INSERT INTO Empregados (CPF, Empresa_ID, Nome, RGPassaporte, MatriculaESocial, NitPisPasep, NomeMae, Nacionalidade, Data_Nascimento, Ultimo_ASO, Email, Celular, Sexo, TipoSanguineo, Cod_Categoria_eSocial, Ativo, Funcao_ID, Setor_ID)
                    VALUES(@CPF, @Empresa_ID, @Nome, @RGPassaporte, @MatriculaESocial, @NitPisPasep, @NomeMae, @Nacionalidade, @Data_Nascimento, @Ultimo_ASO, @Email, @Celular, @Sexo, @TipoSanguineo, @Cod_Categoria_eSocial, @Ativo, @Funcao_ID, @Setor_ID)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@CPF", (object)empregados.CPF ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Empresa_ID", (object)empregados.Empresa ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Nome", (object)empregados.Nome ?? DBNull.Value);
                    command.Parameters.AddWithValue("@RGPassaporte", (object)empregados.RGPassaporte ?? DBNull.Value);
                    command.Parameters.AddWithValue("@MatriculaESocial", (object)empregados.MatriculaESocial ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NitPisPasep", (object)empregados.NitPisPasep ?? DBNull.Value);
                    command.Parameters.AddWithValue("@NomeMae", (object)empregados.NomeMae ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Nacionalidade", (object)empregados.Nacionalidade ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Data_Nascimento", (object)empregados.DataNascimento ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Ultimo_ASO", (object)empregados.UltimoASO ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Email", (object)empregados.Email ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Celular", (object)empregados.Celular ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Sexo", (object)empregados.Sexo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@TipoSanguineo", (object)empregados.TipoSanguineo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Cod_Categoria_eSocial", (object)empregados.CodCategoriaeSocial ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Ativo", (object)empregados.Ativo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Funcao_ID", (object)empregados.NomeFuncao ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Setor_ID", (object)empregados.NomeSetor ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return list;
        }
        public static void EditarEmpregado(EmpregadosDTO empregados)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"sp_editarDadosEmpregados";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmpregadoID", empregados.ID);
                    command.Parameters.AddWithValue("@Nome", empregados.Nome);
                    command.Parameters.AddWithValue("@Empresa", empregados.Empresa);
                    command.Parameters.AddWithValue("@CPF", empregados.CPF);
                    command.Parameters.AddWithValue("@RGPassaporte", empregados.RGPassaporte);
                    command.Parameters.AddWithValue("@Data_Nascimento", empregados.DataNascimento);
                    command.Parameters.AddWithValue("@Ultimo_ASO", empregados.UltimoASO);
                    command.Parameters.AddWithValue("@Funcao", empregados.NomeFuncao);
                    command.Parameters.AddWithValue("@Setor", empregados.NomeSetor);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void DeletarEmpregado(int empregadoID)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"DELETE FROM Empregados WHERE ID = @EmpregadoID";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@EmpregadoID", empregadoID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static EmpregadosDTO ObterEmpregado(int id)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM Empregados WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        EmpregadosDTO empregado = new EmpregadosDTO();
                        empregado.ID = id;
                        empregado.CPF = reader["CPF"].ToString();
                        empregado.Empresa = reader["Empresa_ID"].ToString();
                        empregado.Nome = reader["Nome"].ToString();
                        empregado.RGPassaporte = reader["RGPassaporte"].ToString();
                        empregado.DataNascimento = DateTime.Parse(reader["Data_Nascimento"].ToString());
                        empregado.UltimoASO = DateTime.Parse(reader["Ultimo_ASO"].ToString());
                        empregado.NomeFuncao = reader["Funcao_ID"].ToString();
                        empregado.NomeSetor = reader["Setor_ID"].ToString();

                        return empregado;
                    }
                }
            }
        }
        public static List<EmpregadosDTO> ObterEmpregados(int? empresaID)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            List<EmpregadosDTO> list = new List<EmpregadosDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = $"sp_obterDadosEmpregados @EmpresaID = {empresaID}";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (empresaID.HasValue)
                    {
                        command.Parameters.AddWithValue("@EmpresaID", empresaID);
                    }
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpregadosDTO empregados = new EmpregadosDTO();
                            empregados.ID = int.Parse(reader["ID"].ToString());
                            empregados.Empresa = reader["EmpresaID"].ToString();
                            empregados.Nome = reader["Nome"].ToString();
                            empregados.CPF = reader["CPF"].ToString();
                            empregados.RGPassaporte = reader["RGPassaporte"].ToString();
                            empregados.DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString());
                            empregados.UltimoASO = DateTime.Parse(reader["DataUltimoASO"].ToString());
                            empregados.NomeSetor = reader["NomeSetor"].ToString();
                            empregados.NomeSetorIngles = reader["NomeSetorIngles"].ToString();
                            empregados.NomeFuncao = reader["NomeFuncao"].ToString();
                            empregados.NomeFuncaoIngles = reader["NomeFuncaoIngles"].ToString();
                            empregados.RazaoSocial = reader["Empresa"].ToString();
                            empregados.CNPJ = reader["CNPJ"].ToString();
                            empregados.AtividadeEconomica = reader["AtividadeEconomica"].ToString();
                            empregados.Cidade = reader["Cidade"].ToString();
                            empregados.Estado = reader["Estado"].ToString();

                            list.Add(empregados);
                        }
                    }
                }
            }
            return list;
        }
        public static List<EmpregadosDTO> MultiEmpresaObterEmpregados(int[] empresaID)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            List<EmpregadosDTO> list = new List<EmpregadosDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var empresaIDList = string.Join(",", empresaID);

                string sql = $"SELECT * FROM view_multiEmpresaObterDadosEmpregados WHERE EmpresaID IN ({empresaIDList})";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpregadosDTO empregados = new EmpregadosDTO
                            {
                                ID = int.Parse(reader["ID"].ToString()),
                                Empresa = reader["EmpresaID"].ToString(),
                                Nome = reader["Nome"].ToString(),
                                CPF = reader["CPF"].ToString(),
                                RGPassaporte = reader["RGPassaporte"].ToString(),
                                DataNascimento = DateTime.Parse(reader["DataNascimento"].ToString()),
                                UltimoASO = DateTime.Parse(reader["DataUltimoASO"].ToString()),
                                NomeSetor = reader["NomeSetor"].ToString(),
                                NomeSetorIngles = reader["NomeSetorIngles"].ToString(),
                                NomeFuncao = reader["NomeFuncao"].ToString(),
                                NomeFuncaoIngles = reader["NomeFuncaoIngles"].ToString(),
                                RazaoSocial = reader["Empresa"].ToString(),
                                CNPJ = reader["CNPJ"].ToString(),
                                AtividadeEconomica = reader["AtividadeEconomica"].ToString(),
                                Cidade = reader["Cidade"].ToString(),
                                Estado = reader["Estado"].ToString()
                            };

                            list.Add(empregados);
                        }
                    }
                }
            }
            return list;
        }
    }
}

