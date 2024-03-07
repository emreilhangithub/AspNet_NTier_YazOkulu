<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="AspNet_NTier_YazOkulu.OgrenciListesi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">
        <tr>
            <th>Ögrenci ID </th>
            <th>Ögrenci Ad </th>
            <th>Ögrenci Soyad </th>
            <th>Ögrenci Numara </th>
            <th>Ögrenci Şifre </th>
            <th>Ögrenci Fotoğraf </th>
            <th>Ögrenci Bakiye </th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td> <%#Eval("ID")%> </td>
                        <td> <%#Eval("AD")%> </td>
                        <td> <%#Eval("SOYAD")%> </td>
                        <td> <%#Eval("NUMARA")%> </td>
                        <td> <%#Eval("FOTOGRAF")%> </td>
                        <td> <%#Eval("SIFRE")%> </td>
                        <td> <%#Eval("BAKIYE")%> </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
</asp:Content>
