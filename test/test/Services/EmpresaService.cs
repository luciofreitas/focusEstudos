using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.Controllers;
using test.DTOs;
namespace test.Services
{
    public class EmpresaService
    {
        public static List<EmpresaDTO> ObterEmpresa()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EmpresaDTO> list = new List<EmpresaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, RazaoSocial FROM Empresa";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpresaDTO empresa = new EmpresaDTO();

                            empresa.ID = int.Parse(reader["ID"].ToString());
                            empresa.RazaoSocial = reader["RazaoSocial"].ToString();

                            list.Add(empresa);
                        }
                    }
                }
            }
            return list;
        }
        public static List<EmpresaDTO> ObterEmpresaSelecionadas(int[] empresaID)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EmpresaDTO> list = new List<EmpresaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var empSelecionada = string.Join(",", empresaID);

                string sql = $"SELECT ID, RazaoSocial FROM Empresa WHERE ID IN ({empSelecionada}) ";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpresaDTO empresa = new EmpresaDTO();

                            empresa.ID = int.Parse(reader["ID"].ToString());
                            empresa.RazaoSocial = reader["RazaoSocial"].ToString();

                            list.Add(empresa);
                        }
                    }
                }
            }
            return list;
        }
        public static List<EmpresaDTO> InserirEmpresa(EmpresaDTO empresa)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EmpresaDTO> list = new List<EmpresaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                const string sql = 
                    @"INSERT INTO Empresa(RazaoSocial, NumeroEmpregados, CNAE, Data_Cadastro, Observacao, CNPJ, Endereco, Complemento, Bairro, CEP, Atividade_Economica_ID, Cidade_ID, Ativa) 
                      VALUES(@RazaoSocial, @NumeroEmpregados, @CNAE, @Data_Cadastro, @Observacao, @CNPJ, @Endereco, @Complemento, @Bairro, @CEP, @Atividade_Economica_ID, @Cidade_ID, @Ativa);";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial);
                    command.Parameters.AddWithValue("@NumeroEmpregados", empresa.NumeroEmpregados);
                    command.Parameters.AddWithValue("@CNAE", empresa.CNAE);
                    command.Parameters.AddWithValue("@Data_Cadastro", empresa.Data_Cadastro);
                    command.Parameters.AddWithValue("@Observacao", empresa.Observacao);
                    command.Parameters.AddWithValue("@CNPJ", empresa.CNPJ);
                    command.Parameters.AddWithValue("@Endereco", empresa.Endereco);
                    command.Parameters.AddWithValue("@Complemento", empresa.Complemento);
                    command.Parameters.AddWithValue("@Bairro", empresa.Bairro);
                    command.Parameters.AddWithValue("@CEP", empresa.CEP);
                    command.Parameters.AddWithValue("@Atividade_Economica_ID", empresa.Atividade_Economica);
                    command.Parameters.AddWithValue("@Cidade_ID", empresa.Cidade);
                    command.Parameters.AddWithValue("@Ativa", empresa.Ativa);


                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return list;
        }
    }

}