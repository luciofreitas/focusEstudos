using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using FocusHealthSolutionsTeste2.Models;

namespace FocusHealthSolutionsTeste2.Data
{
    public class BancoContext
    {
        public object Planilha { get;  set; }

        static void Main(string[] args)
        {

            string connectionString = "Server=./;Database=FocusHealthSolutions2;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                PlanilhaModel planilha = new PlanilhaModel();

                connection.Open();
                // Perform your database operations here!

                // Exemplo de inserção
                const string insertQuery = "INSERT INTO Planilha (Agendado_Em, Ficha, Parceiro, Colaborador, Natureza, Agendado_Para, Conf, Pres, ASO_Up, ASO_Prot, Pend, Tem_Av, Tem_Res) " +
                    "VALUES (@Agendado_Em, @Ficha, @Parceiro, @Colaborador, @Natureza, @Agendado_Para, @Conf, @Pres, @ASO_Up, @ASO_Prot, @Pend, @Tem_Av, @Tem_Res)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Agendado_Em", planilha.Agendado_Em);
                    command.Parameters.AddWithValue("@Ficha", planilha.Ficha);
                    command.Parameters.AddWithValue("@Parceiro", planilha.Parceiro);
                    command.Parameters.AddWithValue("@Colaborador", planilha.Colaborador);
                    command.Parameters.AddWithValue("@Natureza", planilha.Natureza);
                    command.Parameters.AddWithValue("@Agendado_Para", planilha.Agendado_Para);
                    command.Parameters.AddWithValue("@Conf", planilha.Conf);
                    command.Parameters.AddWithValue("@Pres", planilha.Pres);
                    command.Parameters.AddWithValue("@ASO_Up", planilha.ASO_Up);
                    command.Parameters.AddWithValue("@ASO_Prot", planilha.ASO_Prot);
                    command.Parameters.AddWithValue("@Pend", planilha.Pend);
                    command.Parameters.AddWithValue("@Tem_Av", planilha.Tem_Av);
                    command.Parameters.AddWithValue("@Tem_Res", planilha.Tem_Res);

                    command.ExecuteNonQuery();
                }


                const string updateQuery = "UPDATE Planilha SET Agendado_Em = @Agendado_Em," +
                    "Ficha = @Ficha, Parceiro = @Parceiro, Colaborador = @Colaborador, Natureza = @Natureza, Agendado_Para = @Agendado_Para" +
                    "Conf = @Conf, Pres = @Pres, ASO_Up = @ASO_Up, ASO_Prot = @ASO_Prot, Pend = @Pend, Tem_Av = @Tem_Av, Tem_Res = @Tem_Res" +
                    "WHERE Ficha = @Ficha";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Agendado_Em", planilha.Agendado_Em);
                    command.Parameters.AddWithValue("@Ficha", planilha.Ficha);
                    command.Parameters.AddWithValue("@Parceiro", planilha.Parceiro);
                    command.Parameters.AddWithValue("@Colaborador", planilha.Colaborador);
                    command.Parameters.AddWithValue("@Natureza", planilha.Natureza);
                    command.Parameters.AddWithValue("@Agendado_Para", planilha.Agendado_Para);
                    command.Parameters.AddWithValue("@Conf", planilha.Conf);
                    command.Parameters.AddWithValue("@Pres", planilha.Pres);
                    command.Parameters.AddWithValue("@ASO_Up", planilha.ASO_Up);
                    command.Parameters.AddWithValue("@ASO_Prot", planilha.ASO_Prot);
                    command.Parameters.AddWithValue("@Pend", planilha.Pend);
                    command.Parameters.AddWithValue("@Tem_Av", planilha.Tem_Av);
                    command.Parameters.AddWithValue("@Tem_Res", planilha.Tem_Res);

                    command.ExecuteNonQuery();
                }


                const string deleteQuery = "DELETE FROM Planilha WHERE Ficha = @Ficha";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Ficha", planilha.Ficha);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            Console.WriteLine("Database operations complete! Insertion, update, and deletion have been performed successfully!");
            Console.ReadKey();
        }
    }
}
