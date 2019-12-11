<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/sentSMS.aspx" Target="_blank">发送短信</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/getReceipt.aspx" Target="_blank">获取回执</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/getReply.aspx" Target="_blank">获取回复</asp:HyperLink>
    
    </div>
    </form>
    <p>
        <span>Design by&nbsp;</span><a class="external" href="https://snd.kim/SMSVCAPI" style="box-sizing: border-box; color: rgb(121, 106, 238); text-decoration: none; background-color: rgb(238, 245, 249); display: inline-block; transition: all 0.3s ease 0s; font-family: Poppins, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;" target="_blank">咻尔特verification</a></p>
</body>
</html>
