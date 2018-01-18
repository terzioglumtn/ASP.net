<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Kayıt.aspx.cs" Inherits="RentACar.Kayıt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS.css" />
</head>
<body>
    <form id="form1" runat="server">

         <div class="kayıtcss">
        <div class="icerik">
        <div class="icerik-sol">

        <div class="kayıt">
                    <div class="ust">
                        Kayıt Ol
                    </div>
                    <div class="alt">
                        <span>Kullanıcı Adı</span>
                        <asp:TextBox ID="txtkullanici" CssClass="txt" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <span>Şifre</span><br />
                        <asp:TextBox ID="txtsifre" TextMode="Password" CssClass="txt" runat="server"></asp:TextBox>
                        <asp:Button ID="btnkayıt" CssClass="btnkayıt" runat="server" Text="Kaydet" OnClick="btnkayıt_Click" />
                        <a href="/" class="btnKCıkıs">ÇIKIŞ</a>
                        <asp:Label ID="lblkayıt" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
            </div>
            </div>
            
       
    </form>
</body>
</html>
