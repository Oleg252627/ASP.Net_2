<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rename_user.aspx.cs" Inherits="Dz2zad1.Rename_user" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
    <link href="Style.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"/>
    <title></title>
</head>
<body class="body_backgraung">
    <form id="form1" runat="server" class="form_default">
        <div class="div_backgraund">
            <div class="globus">
                <i class="fa fa-globe" aria-hidden="true"></i>
            </div>
            <asp:Label ID="Label1" CssClass="h1_default" runat="server" Text="ASP.Net"></asp:Label>
            <div class="div_user">
                <div class="icon">
                    <i class="fa fa-user-o" aria-hidden="true"></i>
                </div>
                <asp:TextBox ID="_name" CssClass="text_Box input_form" runat="server" placeholder="Имя:"></asp:TextBox>
            </div>
            <div class="div_user">
                <div class="icon">
                    <i class="fa fa-user-o" aria-hidden="true"></i>  
                </div>
                <asp:TextBox ID="_familiy" CssClass="text_Box input_form" runat="server" placeholder="Фамилия:"></asp:TextBox>
            </div>
            <div class="div_user">
                <div class="icon">
                    <i class="fa fa-street-view" aria-hidden="true"></i>  
                </div>
                <asp:TextBox ID="_city" CssClass="text_Box input_form" runat="server" placeholder="Город:"></asp:TextBox>
            </div>
            <asp:Label ID="Label3" runat="server" Text="Заполните все поля!" Visible = "False" CssClass="lable_warning"></asp:Label>
            <div class="div_user div_user_top">
                <div class="icon">
                    <i class="fa fa-envelope-o" aria-hidden="true"></i> 
                </div>
                <asp:TextBox ID="_email" CssClass="text_Box input_form" runat="server" placeholder="Почта:"></asp:TextBox>
            </div>
            <div class="div_user">
                <div class="icon">
                    <i class="fa fa-key" aria-hidden="true"></i>  
                </div>
                <asp:TextBox ID="_password" CssClass="text_Box input_form" runat="server" placeholder="Пароль:"></asp:TextBox>
            </div>
            <div class="div_user">
                <div class="icon">
                    <i class="fa fa-sign-in" aria-hidden="true"></i>  
                </div>
                <asp:TextBox ID="_login" CssClass="text_Box input_form" runat="server" placeholder="Логин:"></asp:TextBox>
            </div>
            <div class="div_user">
                <asp:Label ID="Label2" CssClass="lable_rol" runat="server" Text="Роль:"></asp:Label>
                <asp:DropDownList CssClass="Uroven_form" ID="DropDownList2" runat="server" BackColor="Transparent" ForeColor="#000">
                    <asp:ListItem Text="Пользователь" Value="1" />
                    <asp:ListItem Text="Редактор" Value="2"  />
                    <asp:ListItem Text="Администратор" Value="3"  />
                    <asp:ListItem Text="СуперПользователь" Value="4" />
                </asp:DropDownList>
            </div>
            <asp:LinkButton ID="LinkButton1" runat="server"  CssClass="link_Rename link_top hvr-buzz-out" OnClick="LinkButton1_OnClick">Изменить</asp:LinkButton>
            <asp:HyperLink ID="HyperLink1" CssClass="link_Rename hvr-buzz-out" runat="server">Перейти к таблице</asp:HyperLink>
        </div>
    </form>
</body>
</html>
