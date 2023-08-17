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
        public static List<EmpregadosFullDTO> InserirEmpregado(EmpregadosFullDTO empregados)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            List<EmpregadosFullDTO> list = new List<EmpregadosFullDTO>();

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
                    command.Parameters.AddWithValue("@Data_Nascimento", (object)empregados.Data_Nascimento ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Ultimo_ASO", (object)empregados.Ultimo_ASO ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Email", (object)empregados.Email ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Celular", (object)empregados.Celular ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Sexo", (object)empregados.Sexo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@TipoSanguineo", (object)empregados.TipoSanguineo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Cod_Categoria_eSocial", (object)empregados.Cod_Categoria_eSocial ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Ativo", (object)empregados.Ativo ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Funcao_ID", (object)empregados.Funcao ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Setor_ID", (object)empregados.Setor ?? DBNull.Value);

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
                    command.Parameters.AddWithValue("@RGPassaporte", empregados.RG_Passaport);
                    command.Parameters.AddWithValue("@Data_Nascimento", empregados.Data_Nascimento);
                    command.Parameters.AddWithValue("@Ultimo_ASO", empregados.Ultimo_ASO);
                    command.Parameters.AddWithValue("@Funcao", empregados.Nome_Funcao);
                    command.Parameters.AddWithValue("@Setor", empregados.Nome_Setor);
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
                        empregado.RG_Passaport = reader["RGPassaporte"].ToString();
                        empregado.Data_Nascimento = DateTime.Parse(reader["Data_Nascimento"].ToString());
                        empregado.Ultimo_ASO = DateTime.Parse(reader["Ultimo_ASO"].ToString());
                        empregado.Nome_Funcao = reader["Funcao_ID"].ToString();
                        empregado.Nome_Setor = reader["Setor_ID"].ToString();

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
                            empregados.RG_Passaport = reader["RGPassaporte"].ToString();
                            empregados.Data_Nascimento = DateTime.Parse(reader["DataNascimento"].ToString());
                            empregados.Ultimo_ASO = DateTime.Parse(reader["DataUltimoASO"].ToString());
                            empregados.Nome_Setor = reader["NomeSetor"].ToString();
                            empregados.Nome_Setor_Ingles = reader["NomeSetorIngles"].ToString();
                            empregados.Nome_Funcao = reader["NomeFuncao"].ToString();
                            empregados.Nome_Funcao_Ingles = reader["NomeFuncaoIngles"].ToString();
                            empregados.Razao_Social = reader["Empresa"].ToString();
                            empregados.CNPJ = reader["CNPJ"].ToString();
                            empregados.Atividade_Economica = reader["AtividadeEconomica"].ToString();
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

                string sql = $"select * from view_multiEmpresaObterDadosEmpregados WHERE EmpresaID IN ({empresaIDList})";

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
                                RG_Passaport = reader["RGPassaporte"].ToString(),
                                Data_Nascimento = DateTime.Parse(reader["DataNascimento"].ToString()),
                                Ultimo_ASO = DateTime.Parse(reader["DataUltimoASO"].ToString()),
                                Nome_Setor = reader["NomeSetor"].ToString(),
                                Nome_Setor_Ingles = reader["NomeSetorIngles"].ToString(),
                                Nome_Funcao = reader["NomeFuncao"].ToString(),
                                Nome_Funcao_Ingles = reader["NomeFuncaoIngles"].ToString(),
                                Razao_Social = reader["Empresa"].ToString(),
                                CNPJ = reader["CNPJ"].ToString(),
                                Atividade_Economica = reader["AtividadeEconomica"].ToString(),
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

