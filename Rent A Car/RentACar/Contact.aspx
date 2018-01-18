<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="RentACar.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color:#dcddc7 ;width:auto;height:auto">
    <pre>
    <font color="black" size="3" face="calibri">
        <font color="#555" size="4"><bold>ADRES       :</font>  Tümsan Sanayi Sitesi Tunç İş Merkezi 
                                No:3/120 3.Kat Başakşehir/İSTANBUL</bold>
        <font color="#555" size="4"><bold>TELEFON   :</font> 0212 254 28 67</bold>
        <font color="#555" size="4"><bold>CEP            :</font> 0533 164 00 67</bold>
        <font color="#555" size="4"><bold>                   :</font> 0549 164 00 67</bold>
        <font color="#555" size="4"><bold>FAX            :</font> 0212 254 28 68</bold>
        <font color="#555" size="4"><bold>E-MAİL      :</font> info@metinrentacar.com</bold>
    </font>
    </pre>
    <br />
    <br />
        </div>
    <div class="yorum">
        <div class="yorumüst">
            <div class="yorumiç">
                YORUM YAP
            </div>
        </div>
        <asp:TextBox ID="txtYorum" CssClass="txtyorum" placeHolder="Yorumunuzu Yazın" TextMode="MultiLine"  runat="server"></asp:TextBox>
        <asp:Panel ID="pnlYorum" runat="server">
        <asp:Button ID="btnYorum" runat="server" CssClass="btnyorum" Text="KAYDET" OnClick="btnYorum_Click" />
        </asp:Panel>
        <asp:Panel ID="Panel1" runat="server">
           <center>  Yorum yapabilmek için lütfen kullanjıcı girişi yapınız...</center>
        </asp:Panel>
            </div>
    <div style="margin-left:auto;margin-right:auto"><table style="width:100%"><tr><td></td><td></td><td width="100%" height="100%"><a href="https://www.instagram.com" target="_blank"><img src="images/insta.png" width="50px" height="50px" /></a></td><td width="8px" height="10px"><a href="https://www.google.com.tr/maps/@41.0663699,28.7841732,17z" target="_blank"><img src="images/yer.png" width="50px" height="50px" /></a></td></tr></table></div>


</asp:Content>
