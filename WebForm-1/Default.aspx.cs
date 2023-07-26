using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm_1
{
    public partial class Default : System.Web.UI.Page
    {
        public List<string> contatos = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            contatos.Add("Lucio");
            contatos.Add("Danilo");
            contatos.Add("Pedro");
            contatos.Add("Marcos");
            contatos.Add("Paulo");

            dropDownContatos.DataSource = contatos;
            dropDownContatos.DataBind();

            GridView1.DataSource = contatos;
            GridView1.DataBind();

            selectManual2.InnerHtml = "<select>";
            foreach (var valor in contatos)
            {
                selectManual2.InnerHtml += "<option value='" + valor + "'>" + valor + "</ option >";
            }
            selectManual2.InnerHtml += "</select>";
        }
        protected void btnOk_Click(object sender, EventArgs e)
        {
            Response.Write("Olá, meu nome é " + inputMsg.Text + "<br>");
            Response.Write("Olá, meu nome é " + Request["inputMsg"] + "<br>");
            Response.Write("Telefone " + Request["telefone"]);
        }
    }
}