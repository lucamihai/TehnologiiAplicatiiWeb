<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Catalogs.aspx.cs" Inherits="WebApplication1.Catalogs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catalogs</title>
</head>
<body>
    
    <form id="formUpdateCatalog" runat="server">
        <p>Existing catalogs</p>
        <asp:Button runat="server" id="buttonUpdateCatalogsTable" Text="Update catalogs table" OnClick="ButtonUpdateCatalogsTableClick"/>
        
        <br/>

        <p>
            Id
            <asp:TextBox runat="server" id="textBoxCatalogId"></asp:TextBox>
        </p>
        <p>
            First name
            <asp:TextBox runat="server" id="textBoxCatalogFirstName"></asp:TextBox>
        </p>
        <p>
            Last name
            <asp:TextBox runat="server" id="textBoxCatalogLastName"></asp:TextBox>
        </p>
        <p>
            Mark
            <asp:TextBox runat="server" id="textBoxCatalogMark"></asp:TextBox>
        </p>
        <p>
            First grade
            <asp:TextBox runat="server" id="textBoxCatalogFirstGrade"></asp:TextBox>
        </p>
        <p>
            Second grade
            <asp:TextBox runat="server" id="textBoxCatalogSecondGrade"></asp:TextBox>
        </p>
        <asp:Button runat="server" id="buttonUpdateCatalog" Text="Update" OnClick="ButtonUpdateCatalogClick"/>
    </form>    

    <asp:Table ID="catalogsTable" BorderStyle="Solid" runat="server">
        
    </asp:Table>

    
</body>
</html>
