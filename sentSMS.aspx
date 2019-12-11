<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sentSMS.aspx.cs" Inherits="sentSMS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>发送短信</title>
</head>
<body>
    <form id="form1" runat="server">
    <div><span style="font-weight:bold">发送短信</span><br />
        <br />
        发送号码<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        发送内容<br />
        <asp:TextBox ID="TextBox2" runat="server" Height="84px" TextMode="MultiLine" Width="311px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="发送" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="响应数据："></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        </div>
    <p>
        <span>Design by<span>&nbsp;</span></span><a class="external" href="https://snd.kim/SMSVCAPI" style="box-sizing: border-box; color: rgb(121, 106, 238); text-decoration: none; background-color: rgb(238, 245, 249); display: inline-block; transition: all 0.3s ease 0s; font-family: Poppins, sans-serif; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: center; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;" target="_blank">咻尔特verification</a></p>
    </form>
    </body>
</html>
