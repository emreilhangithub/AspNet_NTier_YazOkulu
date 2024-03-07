<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="AspNet_NTier_YazOkulu.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control" ></asp:TextBox>
            </div>
            <div>
                <asp:Label for="TxtAd" runat="server" Text="Ögrenci Adı:" Style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtSoyad" runat="server" Text="Ögrenci Soyadı:" Style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtNumara" runat="server" Text="Ögrenci Numara:" Style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtSifre" runat="server" Text="Ögrenci Şifre:" Style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtFoto" runat="server" Text="Ögrenci Fotoğraf:" Style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <asp:Button ID="BtnOgrenciGuncelle" runat="server" Text="Güncelle" OnClick="BtnOgrenciGuncelle_Click" CssClass="btn btn-info" />
    </form>

</asp:Content>
