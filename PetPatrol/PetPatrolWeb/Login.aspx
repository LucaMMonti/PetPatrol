<%@ Page Title="Inicio de Sesión" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PetPatrolWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2>Iniciar Sesión</h2>
        <div class="form-group">
            <label for="txtNombreUsuario">Nombre de Usuario:</label>
            <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtContrasena">Contraseña:</label>
            <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnLogin" runat="server" CssClass="btn btn-primary" Text="Iniciar Sesión" OnClick="btnLogin_Click" />
        <div class="mt-3">
            <p>¿No tienes una cuenta? <a href="Registro.aspx">Regístrate aquí</a>.</p>
        </div>
    </div>
</asp:Content>

