<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="PetPatrolWeb.Registro" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <title>Registro</title>
    <!-- Incluye aquí referencias a Bootstrap u otros estilos si son necesarios -->
</head>
<body>
    <form id="formRegistro" runat="server">
        <div class="form-group">
            <label for="txtNombreUsuario">Nombre de Usuario:</label>
            <asp:TextBox ID="txtNombreUsuario" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="txtApellido">Apellido:</label>
            <asp:TextBox ID="txtApellido" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <!-- Continúa agregando campos para cada propiedad relevante del Usuario -->
        <div class="form-group">
            <label for="txtContrasena">Contraseña:</label>
            <asp:TextBox ID="txtContrasena" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Text="Registrar" OnClick="btnRegistrar_Click" />
    </form>
</body>
</html>
