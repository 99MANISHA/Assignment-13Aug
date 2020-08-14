<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebOperations.aspx.cs" Inherits="ConnectedObjects1.WebOperations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" Height="154px" Width="277px">
        </asp:GridView>
        <p>
            EmpId :
            <asp:TextBox ID="txtEmpId" runat="server" OnTextChanged="txtEmpId_TextChanged"></asp:TextBox>
        </p>
        <p>
            EmpName :
            <asp:TextBox ID="txtEmpName" runat="server" OnTextChanged="txtEmpName_TextChanged"></asp:TextBox>
        </p>
        <p>
            EmpSal :
            <asp:TextBox ID="txtEmpSal" runat="server" OnTextChanged="txtEmpSal_TextChanged"></asp:TextBox>
        </p>
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <asp:Button ID="btnDeletPar" runat="server" OnClick="btnDeletPar_Click" Text="DeletePar" />
        <p>
            <asp:Button ID="btnSp_Insert" runat="server" Text="Sp_Insert" OnClick="btnSp_Insert_Click" />
            <asp:Button ID="btnSp_Update" runat="server" Text="Sp_Update" OnClick="btnSp_Update_Click" />
            <asp:Button ID="btnSp_Delete" runat="server" Text="Sp_Delete" OnClick="btnSp_Delete_Click" />
        </p>
    </form>
    
</body>
</html>
