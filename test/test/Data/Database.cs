using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using test.Models;

namespace test.Data
{
    public class Database
    {
        public string sqlConn()
        {
            return ConfigurationManager.AppSettings["SqlConnection"];
        }
        public DataTable List()
        {
            using (SqlConnection con = new SqlConnection(sqlConn()))
            {
                //EmpresaModel empresa = new EmpresaModel();
                //EmpregadosModel empregado = new EmpregadosModel();

                //con.Open();

                //string updateEmpresa = "UPDATE Empresa SET AtividadeEconomica = @AtividadeEconomica, RazaoSocial = @RazaoSocial, Ativo = @Ativo";
                //using (SqlCommand command = new SqlCommand(updateEmpresa, con))
                
                //{
                //    command.Parameters.AddWithValue("@AtividadeEconomica", empresa.AtividadeEconomica);
                //    command.Parameters.AddWithValue("@RazaoSocial", empresa.RazaoSocial);
                //    command.Parameters.AddWithValue("@Ativo", empregado.Ativo);
                //}
                string spString = "";
                SqlCommand command = new SqlCommand(spString, con);

                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}