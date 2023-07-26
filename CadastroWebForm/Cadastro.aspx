<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="CadastroWebForm.Entities.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="pnlCamposCadastro" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Nome: "></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>            
            <br />
            <asp:Label ID="Label2" runat="server" Text="Telefone: "></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        </asp:Panel>
        <asp:Panel ID="pnlResultado" runat="server">
            <asp:Button ID="btnCadastro" runat="server" Text="Novo Cadastro" OnClick="btnCadastro_Click" />
            <br />
            <br />
            <asp:GridView ID="gridResultado" runat="server" OnSelectedIndexChanged="gridResultado_SelectedIndexChanged">
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
