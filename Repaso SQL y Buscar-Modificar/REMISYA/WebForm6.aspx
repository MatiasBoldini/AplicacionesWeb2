﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="REMISYA.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CHOFER<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            NOMBRE<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="277px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="BUSCAR" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="MODIFICAR" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="AGREGAR" />
        </div>
    </form>
</body>
</html>
