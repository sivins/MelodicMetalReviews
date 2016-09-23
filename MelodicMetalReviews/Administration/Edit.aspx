<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="MelodicMetalReviews.Administration.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:DetailsView ID="DetailsView1" ItemType="MelodicMetalReviews.Models.Album" runat="server" Height="50px" Width="125px" SelectMethod="GetAlbum" UpdateMethod="SetAlbum" InsertMethod="NewAlbum" DefaultMode="Edit" AutoGenerateRows="False">
    <Fields>
      <asp:TemplateField>
        <ItemTemplate>
          <asp:TextBox ID="AlbumName" Text='<%#:Item.AlbumName %>' runat="server" />
        </ItemTemplate>
      </asp:TemplateField>
      <asp:TemplateField></asp:TemplateField>
      <asp:TemplateField></asp:TemplateField>
      <asp:TemplateField></asp:TemplateField>
    </Fields>
  </asp:DetailsView>
</asp:Content>
