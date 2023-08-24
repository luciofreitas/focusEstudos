﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.Controllers;
namespace test.Services
{
    public class SetorService
    {
        public static List<SetorModel> ObterSetores()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<SetorModel> list = new List<SetorModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, Nome FROM Setor";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SetorModel setor = new SetorModel();

                            setor.Id = int.Parse(reader["ID"].ToString());
                            setor.Nome = reader["Nome"].ToString();


                            list.Add(setor);
                        }
                    }
                }
            }
            return list;
        }
    }

}