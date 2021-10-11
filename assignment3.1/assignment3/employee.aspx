<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="assignment3.employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 33px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label runat="server">Employee Number(auto increment)</asp:Label></td>
                    <td><asp:TextBox ID="employeeNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">job title</asp:Label></td>
                    <td><asp:TextBox ID ="jobTitle" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">lastName</asp:Label></td>
                    <td><asp:TextBox ID="lastName" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td><asp:Label runat="server">First name</asp:Label></td>
                    <td><asp:TextBox ID="firstName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">gender</asp:Label></td>
                    <td><asp:TextBox ID="gender" runat="server"></asp:TextBox></td>

                </tr>
                <tr>
                    <td><asp:Label runat="server">birthday</asp:Label></td>
                    <td><asp:TextBox ID="birthday" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style1"><asp:Label runat="server">hireDate</asp:Label></td>
                    <td class="auto-style1"><asp:TextBox ID="hireDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Department Number</asp:Label></td>
                    <td><asp:TextBox ID="departmentNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server">Project Number</asp:Label></td>
                    <td><asp:TextBox ID="projectNumber" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="insert_button" runat="server" Text="Insert" OnClick="insert_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="update_button" runat="server" Text="Update" OnClick="update_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="delete_button" runat="server" Text="Delete" OnClick="delete_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="search_box" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="search_button" runat="server" Text="Search" OnClick="search_button_Click" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; select row then&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; enter the project number<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; use delete and update&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; to search<br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="employeeNumber" HeaderText="Employee no." />
                <asp:BoundField DataField="jobTitle" HeaderText="Job title" />
                <asp:BoundField DataField="lastName" HeaderText="Last Name" />
                <asp:BoundField DataField="firstName" HeaderText="First Name" />
                <asp:BoundField DataField="gender" HeaderText="gender" />
                <asp:BoundField DataField="birthday" HeaderText="birthday" />
                <asp:BoundField DataField="hireDate" HeaderText="hireDate" />
                <asp:BoundField DataField="departmentNumber" HeaderText="Department Number" />
                <asp:BoundField DataField="projectNumber" HeaderText="Project Number" />
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:LinkButton ID="select_button" runat="server" CommandArgument='<%# Eval("employeeNumber")%>' CommandName="select">select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
