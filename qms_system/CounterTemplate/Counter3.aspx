<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Counter3.aspx.cs" Inherits="qms_system.CounterTemplate.Counter3" %>

<asp:Content ID="Content4" ContentPlaceHolderID="chead" runat="server">
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <link href="../Scripts/style/style.css" rel="stylesheet" />
    <style type="text/css">
        
    </style>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h1 style="margin-left: 440px;margin-right: 450px;padding: 10px;text-align:center;">ကောင်တာ (၃)</h1>
    
  
    <div style="display: flex; flex-direction: row; justify-content: center;" class="counter3_style_handle">
        
        <div class="countercontainer">
           
           <div class="counter_token">
               <asp:Label runat="server" ID="token_no_access3" ></asp:Label>
           </div><br />
           
       </div>
        <div style="width:60px;">

            <asp:Button runat="server" ID="counter3_btn" style="width:200px;height:50px;border-radius:10px;padding:3px;margin-left:80px;" Text="Token ရယူရန်" CssClass="btn-dark" OnClick="counter3_btn_Click"/>
            <br /><br />
            
        </div>
        <div class="next-btn">
        </div>
        
        

        
        
    </div>

</asp:Content>
