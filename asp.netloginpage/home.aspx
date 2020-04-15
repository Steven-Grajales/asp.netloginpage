<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="asp.netloginpage.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>

        #lblUserDetails{
            margin: auto;
        }

        #btnlogout {
            margin: auto;
        }

        th, td{
            padding: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserDetails" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            <br /><br />
            <table style="border:1px solid black; ">
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox></td>
                </tr>
                                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>
                        </td>
                    <td>
                        <asp:Button ID="btnRegistrar" runat="server" Text="Registrar Usuario" OnClick="btnlogin_Click" /></td>
                </tr>

                <tr>
                    <td>
                        </td>
                    <td>
                        <asp:Label ID="lblSuccesMessage" runat="server" Text="Usuario registrado" ForeColor="Green"></asp:Label></td>
                </tr>
                
                <tr>
                    <td>
                        </td>
                    <td>
                        <asp:Label ID="lblErrorMessage" runat="server" Text="El usuario ya existe" ForeColor="Red"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
