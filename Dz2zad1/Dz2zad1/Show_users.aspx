<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Show_users.aspx.cs" Inherits="Dz2zad1.Show_users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Style.css" rel="stylesheet" />
    <title></title>
</head>
<body class="body_user">

    <form id="form1" runat="server" class="form_users">
        <div class="users">
            <div class="div_chek_box">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CheckBoxList1_OnSelectedIndexChanged"></asp:CheckBoxList>
            </div>
            <asp:Panel ID="Panel1" runat="server" CssClass="panal_buttom"></asp:Panel>
        </div>
        <div class="boz"></div>
        <asp:LinkButton ID="LinkButton1" runat="server" Visible="False" CssClass="link_delete hvr-pulse-grow">Удалить</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="link_delete hvr-pulse-grow">Перейти к форме</asp:LinkButton>
    </form>
</body>
</html>
