<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryPage.aspx.cs" Inherits="StudentManagmentApp.UI.StudentEntryPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align ="center">
            <table class="auto-style1" >
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox ID="firstNameTxtBx" runat="server" Height="31px" Width="221px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Last Name</td>
                    <td>
                        <asp:TextBox ID="lastNameTxtBx" runat="server" Height="31px" Width="221px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Class</td>
                    <td>
                        <asp:DropDownList ID="classDropDownList" runat="server" Height="40px" Width="231px">
                            <asp:ListItem Value=" ">Please Select</asp:ListItem>
                            <asp:ListItem Value="Class One">Class One</asp:ListItem>
                            <asp:ListItem Value="Class Two">Class Two</asp:ListItem>
                            <asp:ListItem Value="Class Three">Class Three</asp:ListItem>
                            <asp:ListItem Value="Class Four">Class Four</asp:ListItem>
                            <asp:ListItem Value="Class Five">Class Five</asp:ListItem>
                            <asp:ListItem Value="Class Six">Class Six</asp:ListItem>
                            <asp:ListItem Value="Class Seven">Class Seven</asp:ListItem>
                            <asp:ListItem Value="Class Eight">Class Eight</asp:ListItem>
                            <asp:ListItem Value="Class Nine">Class Nine</asp:ListItem>
                            <asp:ListItem Value="Class Ten">Class Ten</asp:ListItem>
                        </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>Roll No</td>
                    <td>
                        <asp:TextBox ID="rollNoTxtBx" runat="server" Height="31px" Width="221px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Result</td>
                    <td>
                        <asp:TextBox ID="resultTxtBx" runat="server" Height="31px" Width="221px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="emailTxtBx" runat="server" Height="31px" Width="221px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="100" align="center">
                        <asp:Button ID="saveBtn" runat="server" Text="Save" OnClick="saveBtn_Click"/>
                    </td>
                </tr>
            </table>
            <br />
                <asp:Label ID="SuccessedFailedLabel" runat="server"></asp:Label>
             <br />

               <div>  
                   <td>Please Select to View Class Infomation</td>

                    <asp:DropDownList ID="EachClassName" runat="server" Height="33px" Width="112px">
                            <asp:ListItem Value=" ">Please Select</asp:ListItem>
                            <asp:ListItem Value="Class One">Class One</asp:ListItem>
                            <asp:ListItem Value="Class Two">Class Two</asp:ListItem>
                            <asp:ListItem Value="Class Three">Class Three</asp:ListItem>
                            <asp:ListItem Value="Class Four">Class Four</asp:ListItem>
                            <asp:ListItem Value="Class Five">Class Five</asp:ListItem>
                            <asp:ListItem Value="Class Six">Class Six</asp:ListItem>
                            <asp:ListItem Value="Class Seven">Class Seven</asp:ListItem>
                            <asp:ListItem Value="Class Eight">Class Eight</asp:ListItem>
                            <asp:ListItem Value="Class Nine">Class Nine</asp:ListItem>
                            <asp:ListItem Value="Class Ten">Class Ten</asp:ListItem>
                        </asp:DropDownList>
                     <td colspan="100" align="center">
                        <asp:Button ID="EachclassInfoShowBtn" runat="server" Text="Submit" OnClick="EachclassInfoShowBtn_Click"/>
                   </td>
               </div>

            <br />
                <asp:GridView ID="StudentInfoDisplayGrid" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#808080" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
             <br />

        </div>
    </form>
</body>
</html>
