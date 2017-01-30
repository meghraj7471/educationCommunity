﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="EducationCommunity.Demo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Rows:
    <asp:TextBox ID="txtRows" runat="server" />&nbsp;
    Cols:
    <asp:TextBox ID="txtCols" runat="server" />
    <br /><br />
    <asp:CheckBox ID="chkBorder" runat="server"
         Text="Put Border Around Cells" />
    <br /><br />
    <asp:Button ID="cmdCreate" OnClick="cmdCreate_Click" runat="server"
     Text="Create" />
    <br /><br />
    <asp:Table ID="tbl" runat="server" />
  </div>
    </form>
</body>
</html>
