<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWebView.aspx.cs" Inherits="ViewWeb.TestWebView" %>

<%@ Register src="Models/UCHitCount.ascx" tagname="UCHitCount" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:UCHitCount ID="UCHitCount1" runat="server" />
        </div>
    </form>
</body>
</html>
