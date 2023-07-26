using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroWebForm.Entities
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarLista();
        }

        private void mostrarLista()
        {
            pnlCamposCadastro.Visible = false;
            pnlResultado.Visible = true;
            gridResultado.DataSource = Usuario.Lista;
            gridResultado.DataBind();
        }       
        private void mostrarCadastro()
        {
            pnlCamposCadastro.Visible = true;
            pnlResultado.Visible = false;
            

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            mostrarCadastro();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Salvar();

            txtNome.Text = "";
            txtTelefone.Text = "";

            mostrarLista();
        }

        protected void gridResultado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}