<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="qms_system.Pages._Home" %>

<asp:Content ID="Content7" ContentPlaceHolderID="chead" runat="server">
    <meta http-equiv="refresh" content="5" />
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <div class="row">
        <div class="Counters">
  
            <div class="counter1">
                <h2>ကောင်တာ (၁)</h2>
                <p style="color: #041C32;font-size:25px;font-weight:bold;"><asp:Label runat="server" ID="lbltoshow1" ></asp:Label></p>
            </div>
    
            <div class="counter2">
                <h2>ကောင်တာ (၂)</h2>
                <p style="color: #041C32;font-size:25px;font-weight:bold;"><asp:Label runat="server" ID="lbltoshow2" ></asp:Label></p>
            </div>

            <div class="counter3">
                <h2>ကောင်တာ (၃)</h2>
                <p style="color: #041C32;font-size:25px;font-weight:bold;"><asp:Label runat="server" ID="lbltoshow3" ></asp:Label></p>
            </div>

            <div class="counter4">
                <h2>ကောင်တာ (၄)</h2>
                <p style="color: #041C32;font-size:25px;font-weight:bold;"><asp:Label runat="server" ID="lbltoshow4" ></asp:Label></p>
            </div>

            <div class="counter5">
                <h2>ကောင်တာ (၅)</h2>
                <p style="color: #041C32;font-size:25px;font-weight:bold;"><asp:Label runat="server" ID="lbltoshow5" ></asp:Label></p>
            </div>
    
            </div>
        
            <div class="token-show">
                <asp:Label runat="server" ID="lbltoshow6" style="color: #041C32;font-size:80px;text-align:center">Token : 0000</asp:Label>
                <br />
                <asp:Label runat="server" style="color: #041C32;font-size:35px;text-align:center;" >နောက်လာမည့် Token နံပါတ်မှာ.....</asp:Label>
            </div>
  
    </div>

</asp:Content>
