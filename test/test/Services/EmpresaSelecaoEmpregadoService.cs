using System.Collections.Generic;
using System.Data.SqlClient;
using test.DTOs;
namespace test.Services
{
    public class EmpresaSelecaoEmpregadoService
    {
        public static List<EmpresaDTO> ObterEmpresaSelecaoEmpregado()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EmpresaDTO> list = new List<EmpresaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, RazaoSocial, Ativa FROM Empresa";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpresaDTO empresa = new EmpresaDTO();

                            empresa.ID = int.Parse(reader["ID"].ToString());
                            empresa.RazaoSocial = reader["RazaoSocial"].ToString();
                            empresa.Ativo = bool.Parse(reader["Ativa"].ToString());
                            list.Add(empresa);
                        }
                    }
                }
            }
            return list;
        }
    }
}