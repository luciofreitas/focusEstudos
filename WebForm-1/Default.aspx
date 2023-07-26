<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="inputMsg" runat="server"></asp:TextBox>
        <input type="text" name="telefone" id="telefone" runat="server" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text=" Mostrar Mensagem" />
        <br />
        <br />
        <br />
        <asp:DropDownList ID="dropDownContatos" runat="server"></asp:DropDownList>
        <br />
        <br />
        <select id="selectManual">
            <%foreach (var valor in contatos)
                { %>
            <option value="<%= valor %>"><%= valor %></option>
            <%}%>
        </select>
        <br />
        <br />
        <div id="selectManual2" runat="server">
        </div>
        <asp:GridView ID="GridView1" runat="server" Style="margin-top: 58px">
        </asp:GridView>
        <p>
            &nbsp; 
        </p>
    </form>
</body>
</html>
