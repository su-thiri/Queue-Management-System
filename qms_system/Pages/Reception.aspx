<%@ Page Title="Reception" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reception.aspx.cs" Inherits="qms_system.Pages.Reception" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <h2 style="margin-left: 410px;">Reception</h2>
    <div id="get-token" class="form-block col-6" style="border:1px solid black;padding: 10px;width: 40%;height: 400px;position:relative; left: 30%;line-height: 40px;">
    <form class="form">
        <div class="form-group">
            <asp:Label runat="server" class="mx-sm-5" style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;font-size:25px;">အမည်</asp:Label>
            <asp:TextBox runat="server" type="text" ID="customername" class="form-control mx-sm-5"></asp:TextBox>
            <asp:Label runat="server" class="mx-sm-5" style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;font-size:25px;">ဖုန်းနံပါတ်</asp:Label>
            <asp:TextBox runat="server" ID="phone" class="form-control mx-sm-5"></asp:TextBox>
            <asp:Label class="mx-sm-5" runat="server" style="font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;font-size:25px;">မော်တော်ယာဉ်အမှတ်</asp:Label>
            <asp:TextBox ID="license" runat="server" class="form-control mx-sm-5"></asp:TextBox>
      <!--<asp:TextBox runat="server" ID="wheeltag" style="margin-left:20px;"></asp:TextBox>
      <asp:Label runat="server" ID="show_wheeltag" style="margin-left:20px; margin-top:10px;"></asp:Label>-->
            <asp:Button ID="btnreception" runat="server" Text="Token ထုတ်ရန်" style="margin-left: 50px; width: 500px; margin-top: 10px;padding: 12px;font-size:18px; background-color:darkslategray;color: white; " OnClick="btnreception_Click"/>
        </div>
    </form>
    </div>

    <br /><br />
</asp:Content>