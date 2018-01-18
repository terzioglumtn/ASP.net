<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="RentACar.Cars" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   <div class="galeri">
       <%--<div class="text">
       <asp:Label runat="server" Text="Cars"></asp:Label>
       </div>--%>

       <asp:ListView ID="lstCars" runat="server">
           <ItemTemplate>
               <div class="cars">
                <asp:Image ID="Image1" ImageUrl='<%#Eval("Resim") %>' Width="300px" Height="200px" runat="server"/>
                <br />
                MARKA:<asp:Label ID="Label1" runat="server" Text='<%#Eval("Marka") %>'></asp:Label>
                <br />
                MODEL:<asp:Label ID="Label2" runat="server" Text='<%#Eval("Model") %>'></asp:Label>
                <br />
                YAKIT:<asp:Label ID="Label4" runat="server" Text='<%#Eval("Yakıt") %>'></asp:Label>
                <br />
                YIL:<asp:Label ID="Label3" runat="server" Text='<%#Eval("Yıl") %>'></asp:Label>
                <br />
           </div>
           </ItemTemplate>
       </asp:ListView>




   <%-- <div class="cars">
        <asp:Image ID="Image1" ImageUrl="imageurl" Width="300px" Height="200px" runat="server"/>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Text"></asp:Label>
    </div>
    <div class="cars">
        <asp:Image ID="Image2" ImageUrl="imageurl" runat="server"/>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Text"></asp:Label>
    </div>
    <div class="cars">
        <asp:Image ID="Image3" ImageUrl="imageurl" runat="server"/>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Text"></asp:Label>
    </div>
    <div class="cars">
        <asp:Image ID="Image4" ImageUrl="imageurl" runat="server"/>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Text"></asp:Label>
    </div>
    <div class="cars">
        <asp:Image ID="Image5" ImageUrl="imageurl" runat="server"/>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Text"></asp:Label>
    </div>--%>
      
   </div>

</asp:Content>
