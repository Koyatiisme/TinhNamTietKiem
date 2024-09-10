<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApplication1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>chương trình tính tổng hoá đơn</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <h1>CHƯƠNG TRÌNH TÍNH SỐ THÁNG CẦN GỬI TIẾT KIỆM</h1>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="nhan_nhap_so">Nhập số tiền hiện có: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="nhan_nhap_so">Nhập số tiền muốn có: 
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="nhan_nhap_so">Lãi suất(%): 
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" value="5" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Tính ngay và luôn" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div id="ketqua" runat="server"></div>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
