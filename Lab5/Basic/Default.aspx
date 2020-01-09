<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab5.Basic.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>This is Default.aspx</h3>
            This page has been displayed <%: GetCounter() %> time(s).<br />
            <div>
                <input type="radio" name="choice"
                    value="redirect302" checked="checked" />Redirect
            </div>
            <div>
                <input type="radio" name="choice" value="redirect301" />Redirect Permanent
            </div>
            <div>
                <input type="radio" name="choice" value="transferpage" />Transfer Page
            </div>
            <p>
                <button type="submit">Submit</button></p>
        </div>
    </form>
</body>
</html>
