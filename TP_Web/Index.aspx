<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TP_Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Bienvenido!</h2>
    <div>
        <div class="input-group mb-3">
            <div class="input-group-prepend">
            <span class="input-group-text" id="inputGroup-sizing-default">Codigo Voucher</span>
            </div>
            <asp:TextBox ID="txtVoucher" runat="server" class="form-control" aria-label="Sizing example input" aria-describedby="inputGroup-sizing-default"></asp:TextBox>
        </div>
    </div>
    <div>
        <asp:Button ID="btnVoucher" runat="server" Text="COMPROBAR VOUCHER" class="btn btn-outline-success" OnClick="btnVoucher_Click" />
    </div>
    
</asp:Content>
