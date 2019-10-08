<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Premios.aspx.cs" Inherits="TP_Web.Premios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Elegi el premio</h2>
    
    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">
        <% foreach (var item in listaProductos)
            { %>
        <div class="card">
            <img src="<% = item.URLImagen %>" class="card-img-top" alt="..."; width ="150"; height="300">
            <div class="card-body">
                <h5 class="card-title"><% = item.Titulo %></h5>
                <p class="card-text"><% = item.Descripcion %></p>
                <asp:Button ID="btnPremio" runat="server" Text="Quiero Este!" class="btn btn-outline-success" OnClick="btnPremio_Click" CommandArgument='<%#Eval("item.Id")%>' CommandName="IdProdcuto" />
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
