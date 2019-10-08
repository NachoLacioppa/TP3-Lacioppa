<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DatosClientes.aspx.cs" Inherits="TP_Web.DatosClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Carga tus datos</h1>
    <!-- DNI -->
     <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="dni">DNI</span>
            <asp:TextBox ID="txtDni" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- NOMBRE -->
    <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="nombre">Nombre</span>
            <asp:TextBox ID="txtNombre" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- APELLIDO -->
    <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="apellido">Apellido</span>
            <asp:TextBox ID="txtApellido" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- EMAIL -->
   <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="email">E-Mail</span>
            <asp:TextBox ID="txtEmail" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- DIRECCION -->
   <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="direccion">Direccion</span>
            <asp:TextBox ID="txtDireccion" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- CIUDAD -->
    <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="ciudad">Ciudad</span>
            <asp:TextBox ID="txtCiudad" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- CODIGO POSTAL -->
   <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="postal">Codigo Postal</span>
            <asp:TextBox ID="txtPostal" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <!-- FECHA DE REGISTRO -->
   <div class="input-group mb-3">
        <div class="input-group-prepend">
             <span class="input-group-text" id="fecha">Fecha de Registro</span>
            <asp:TextBox ID="txtFecha" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
            <small id="formatofecha" class="form-text text-muted">DD/MM/AAAA</small>
        </div>
    </div>
    <br />
    <!-- BOTON DE REGISTRO -->
    <asp:Button ID="btnRegistro" runat="server" Text="Cargar Datos" OnClick="btnRegistro_Click" class="btn btn-success" />
</asp:Content>
