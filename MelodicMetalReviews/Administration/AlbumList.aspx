﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AlbumList.aspx.cs" Inherits="MelodicMetalReviews.Administration.AlbumList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
  <asp:GridView ID="GridView1" runat="server" DataKeyNames="AlbumID" ItemType="MelodicMetalReviews.Models.Album"
     SelectMethod="GetAlbums" UpdateMethod="UpdateAlbum" DeleteMethod="DeleteAlbum"
     AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" CssClass="table">
    <Columns>
      <asp:BoundField DataField="AlbumName" HeaderText="Album Name" />
      <asp:DynamicField DataField="Rating" HeaderText="Rating" />
      <asp:TemplateField HeaderText="Review" ItemStyle-Height="100" ItemStyle-Width="300">
        <ItemTemplate>
          <asp:Label Text="<%#: Item.Review %>" runat="server" />
        </ItemTemplate>
        <EditItemTemplate>
          <asp:TextBox Text="<%#: Item.Review %>" TextMode="MultiLine" Height="100" Width="300" runat="server" />
        </EditItemTemplate>
      </asp:TemplateField>
      <asp:TemplateField HeaderText="Band Name">
        <ItemTemplate>
          <asp:Label Text='<%# Eval("Band.BandName") %>' runat="server" />
        </ItemTemplate>
      </asp:TemplateField>
    </Columns>
  </asp:GridView>
</asp:Content>
