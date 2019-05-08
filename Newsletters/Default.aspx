<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Newsletters.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Newsletter</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Sign up for our newsletter</h1>

        <asp:Label ID="LblEmail" runat="server" Text="Please enter your email: "></asp:Label><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br /> 
        <asp:Label ID="lblTellUs" runat="server" Text="Please tell us how did you hear about us: "></asp:Label>
            <asp:DropDownList ID="ddlTelUs" runat="server">
                <asp:ListItem Text="Advert" Value="Advert"></asp:ListItem>
                <asp:ListItem Text="Word Of Mouth" Value="WordOfMouth"></asp:ListItem>
                <asp:ListItem Text="Other" Value="Other"></asp:ListItem>
            </asp:DropDownList>
        <br />
        <asp:Label ID="lblReason" runat="server" Text="Tell us why you have decided to sign up: "></asp:Label><asp:TextBox ID="txtReason" runat="server"></asp:TextBox>
        <br />    
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <div>
        </div>
    </form>
</body>
</html>
