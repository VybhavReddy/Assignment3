<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="department.aspx.cs" Inherits="assignment3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:label runat="server">Department Number(auto increment)</asp:label></td>
                <td><asp:TextBox ID="departmentNumber" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server">Name</asp:Label>
                    </td>
                    <td><asp:TextBox ID="name" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="insert_button" runat="server" Text="Insert" OnClick="insert_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="update_button" runat="server" Text="Update" OnClick="update_button_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="delete_button" runat="server" Text="Delete" OnClick="delete_button_Click" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; select row then use delete and update<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
            <Columns>
                <asp:BoundField DataField="departmentNumber" HeaderText="Department Number" />
                <asp:BoundField DataField="name" HeaderText="Name" />
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:LinkButton ID="select_button" runat="server" CommandArgument='<%# Eval("departmentNumber")%>' CommandName="select">select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
