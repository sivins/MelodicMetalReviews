<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="NewAlbum.aspx.cs" Inherits="MelodicMetalReviews.Administration.NewAlbum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <p>
    <asp:Label Text="Album Name: " runat="server" /><asp:TextBox ID="AlbumNameField" runat="server" />
  </p>
  <p>
    <asp:DropDownList ID="BandPicker" SelectMethod="GetBands" DataTextField="BandName" DataValueField="BandID" runat="server"></asp:DropDownList>
    <br />
    <a href="NewBand.aspx">Add a New Band</a>
  </p>
  <p>
    <asp:Label Text="Release Date: " runat="server" /><asp:Calendar ID="ReleaseDatePicker" runat="server"></asp:Calendar>
  </p>
  <p>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
      <asp:ListItem Text="5" Value="5" />
      <asp:ListItem Text="4" Value="4" />
      <asp:ListItem Text="3" Value="3" />
      <asp:ListItem Text="2" Value="2" />
      <asp:ListItem Text="1" Value="1" />
    </asp:RadioButtonList>
  </p>
  <p>
    <asp:Label Text="Review" runat="server" /><asp:TextBox ID="ReviewField" TextMode="MultiLine" Width="500px" Height="100px" runat="server" />
  </p>
  <p>
    <asp:Label Text="Album Image: " runat="server" /><asp:FileUpload ID="ImageUpload" runat="server" /><asp:Label ID="LabelAddStatus" CssClass="danger" Text="" runat="server" />
  </p>
  <p>
    <asp:Button Text="Add Album" runat="server" OnClick="Unnamed5_Click" />
  </p>
</asp:Content>

