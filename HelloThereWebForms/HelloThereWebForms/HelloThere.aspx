<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HelloThere.aspx.cs" Inherits="HelloThereWebForms.HelloThere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: cyan">
    <form id="form1" runat="server">
    <div style="font-size: medium; text-align: center;">
    
        <asp:Label ID="helloLbl" runat="server" Font-Size="X-Large" Text="Hello There"></asp:Label>
        <br />
        What&#39;s your name?
        <asp:TextBox ID="nameBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="submitBttn" runat="server" Font-Size="Large" OnClick="submitBttn_Click" Text="Submit" />
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
