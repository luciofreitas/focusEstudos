using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
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
                    command.Parameters.AddWithValue("@CPF", empregados.CPF);
                    command.Parameters.AddWithValue("@Empresa_ID", empregados.Empresa);
                    command.Parameters.AddWithValue("@Nome", empregados.Nome);
                    command.Parameters.AddWithValue("@RGPassaporte", empregados.RGPassaporte);
                    command.Parameters.AddWithValue("@MatriculaESocial", empregados.MatriculaESocial);
                    command.Parameters.AddWithValue("@NitPisPasep", empregados.NitPisPasep);
                    command.Parameters.AddWithValue("@NomeMae", empregados.NomeMae);
                    command.Parameters.AddWithValue("@Nacionalidade", empregados.Nacionalidade);
                    command.Parameters.AddWithValue("@Data_Nascimento", empregados.Data_Nascimento);
                    command.Parameters.AddWithValue("@Ultimo_ASO", empregados.Ultimo_ASO);
                    command.Parameters.AddWithValue("@Email", empregados.Email);
                    command.Parameters.AddWithValue("@Celular", empregados.Celular);
                    command.Parameters.AddWithValue("@Sexo", empregados.Sexo);
                    command.Parameters.AddWithValue("@TipoSanguineo", empregados.TipoSanguineo);
                    command.Parameters.AddWithValue("@Cod_Categoria_eSocial", empregados.Cod_Categoria_eSocial);
                    command.Parameters.AddWithValue("@Ativo", empregados.Ativo);
                    command.Parameters.AddWithValue("@Funcao_ID", empregados.Funcao);
                    command.Parameters.AddWithValue("@Setor_ID", empregados.Setor);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return list;
        }
    }
}