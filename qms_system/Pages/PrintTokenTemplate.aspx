<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PrintTokenTemplate.aspx.cs" Inherits="qms_system.Pages.PrintTokenTemplate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="chead" runat="server">
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/print.min.js"></script>
    <link href="../Scripts/style/print.min.css" rel="stylesheet" />
    <link href="../Scripts/style/print.css" rel="stylesheet" />

    <style type="text/css">
        
    </style>
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
        <h1 style="margin-left: 450px;margin-right: 450px;padding: 10px;text-align:center;">Reception</h1>
    
  
    <div style="display: flex; flex-direction: row; justify-content: center;" class="print-div-handle">
        
        <div class="printcontainer">
           <asp:Label ID="lbl_Date" runat="server" CssClass="serve-date"></asp:Label>

           <div class="row1">
               <asp:Label runat="server" ID="txtshow_token"></asp:Label>
           </div><br />
           <div class="row2">
               <asp:Label runat="server" ID="txtusername"></asp:Label>
           </div>
           <div class="row3">
               <asp:Label runat="server" ID="txtcontact"></asp:Label>
           </div>
           <div class="row4">
               <asp:Label runat="server" ID="txtlicence"></asp:Label>
           </div>
       </div>
        <div style="width:60px;">

        </div>
        <div class="print-btn">
            <input type="button" class="button-click btn-dark" id="printbtn" value="Print Token"/>
            <input type="button" class="button-click btn-dark" id="nextbtn" value="ရှေ့သို့"/>
        </div>
        
        
    </div>
    <script>
        $('#printbtn').click(function () {
            window.print();

        });
        $('#nextbtn').click(function () {
            window.location = "Reception.aspx";
        });

    </script>
</asp:Content>
