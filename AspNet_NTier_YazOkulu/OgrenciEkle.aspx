<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciEkle.aspx.cs" Inherits="AspNet_NTier_YazOkulu.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <asp:Label for="TxtAd" runat="server" Text="Ögrenci Adı:" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtSoyad" runat="server" Text="Ögrenci Soyadı:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtNumara" runat="server" Text="Ögrenci Numara:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtSifre" runat="server" Text="Ögrenci Şifre:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TxtFoto" runat="server" Text="Ögrenci Fotoğraf:" style="font-weight: bold"></asp:Label>
                <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <asp:Button ID="BtnOgrenciKaydet" runat="server" Text="Kaydet" OnClick="BtnOgrenciKaydet_Click"  CssClass="btn btn-info"/>
    </form>

</asp:Content>
