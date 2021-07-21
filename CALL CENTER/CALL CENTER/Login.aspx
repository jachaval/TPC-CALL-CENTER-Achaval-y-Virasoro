﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CALL_CENTER.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="estilos.css" rel="stylesheet"/>
    <title>Bienvenido!</title>

</head>
<body>
         <img src="images/fondologin.jpg" class="fondo" > 
        <form id="form1" runat="server">
        <!--PENSAR UN NOMBRE CANCHERO / PODRIA SER UNA IMAGEN CON UN LOGO TAMBIEN-->
        <h2 class="logo">CALL CENTER</h2>
        <div class="formContainer">
                <h3 class="formTitle">Ingresa a tu cuenta</h3>
            <div>
                <asp:TextBox ID="txtUsu" class="form-control" type="text" runat="server" placeholder="Usuario"></asp:TextBox>
            </div>
            <div>
                <asp:TextBox ID="txtPass" class="form-control" type="text" runat="server" placeholder="********" TextMode="Password"></asp:TextBox>
            </div>
                <label class="rememberme mt-checkbox mt-checkbox-outline" style="margin-left: 60px">
                        <input type="checkbox" name="remember" value="1"> Recordarme 
                        <span></span>
                    </label>
                <%--<input type="submit" class="btnEnviar" value="Ingresar" />--%>
                <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnLogin" OnClick="btnLoginClick" runat="server" />
        </div>
    </form>
</body>
</html>
