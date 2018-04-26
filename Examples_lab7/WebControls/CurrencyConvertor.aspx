<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="CurrencyConvertor.aspx.cs" Inherits="CurrencyConvertor" %>

<!DOCTYPE html>

<html>
  <head runat="server">
    <title>Currency Converter</title>
  </head>
  <body>
    <form ID="Form1" method="post" runat="server">

        <div style="border-right: thin ridge; padding-right: 20px; border-top: thin ridge;
            padding-left: 20px; padding-bottom: 20px; border-left: thin ridge; width: 531px;
            padding-top: 20px; border-bottom: thin ridge; font-family: Verdana; background-color: #FFFFE8">
           
            Convert: &nbsp;
            <asp:TextBox ID="txtCanadianDollar" runat="server" style="width: 102px" />&nbsp; Canadian dollars to &nbsp;
            <asp:DropdownList ID="drpCurrency" runat="server" />
            <br /><br />
            <asp:Button text="submit" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" />
            <br /><br />
            <asp:Literal ID="ltrResult" runat="server" />
        
        </div>
    </form>
  </body>
</html>
