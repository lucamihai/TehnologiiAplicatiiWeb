<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="WebApplication1.StartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

<form runat="server" id="mainForm" >
    <p>
        Life Cycle
        <asp:TextBox runat="server" id="textBoxLifeCycle" ReadOnly="True"></asp:TextBox>
    </p> 
    <p>
        Controls 
        <asp:TextBox runat="server" id="textBoxControls" ReadOnly="True"></asp:TextBox>
    </p>
    
    <p>
        <asp:Button runat="server" OnClick="ButtonClick" Text="Click"/>
    </p>
</form>
         
    
</body>
</html>
