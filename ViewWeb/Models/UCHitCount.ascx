<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCHitCount.ascx.cs" Inherits="ViewWeb.Models.UCHitCount" %>

<table>
    <tr>
        <td>Today Visit : </td>
        <td align="right">&nbsp;&nbsp;<asp:Label ID="lblTodayVisit" runat="server" /></td>
    </tr>
    <tr>
        <td>Total Visit : </td>
        <td align="right">&nbsp;&nbsp;<asp:Label ID="lblTotalVisit" runat="server" /></td>
    </tr>

</table>