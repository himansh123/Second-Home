<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage2.master" AutoEventWireup="true" CodeFile="add_student.aspx.cs" Inherits="add_student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contentplaceholder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Student name"></asp:Label>
    <br />
    <asp:TextBox ID="s_name" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Email"></asp:Label>
    <br />
    <asp:TextBox ID="s_email" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="passwd" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Confirm Password"></asp:Label>
    <br />
    <asp:TextBox ID="cnfpass" runat="server"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Date of Birth"></asp:Label>
    <br />
    <asp:TextBox ID="dob" runat="server"></asp:TextBox>
    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Hostel"></asp:Label>
    <br />
    <asp:DropDownList ID="hostel" runat="server" DataSourceID="SqlDataSource1" DataTextField="h_name" DataValueField="h_id">
    </asp:DropDownList>
    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Room"></asp:Label>
    <br />
    
    
    <asp:DropDownList ID="room" runat="server" DataSourceID="SqlDataSource2" DataTextField="r_id" DataValueField="r_id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [r_id] FROM [room]"></asp:SqlDataSource>
    
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [h_name], [h_id] FROM [hostel]"></asp:SqlDataSource>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Contact no"></asp:Label>
    <br />
    <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="X-Large" Text="College"></asp:Label>
    <br />
    <asp:TextBox ID="college" runat="server"></asp:TextBox>
    <br />
    <asp:TextBox ID="contact_no" runat="server"></asp:TextBox>
    <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Parents Contact no"></asp:Label>
    <br />
    <asp:TextBox ID="p_contact_no" runat="server"></asp:TextBox>

    <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Join Date"></asp:Label>
    <br />
    <asp:TextBox ID="join_date" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Address"></asp:Label>
    <br />
    <asp:TextBox ID="address" runat="server"></asp:TextBox>
    <asp:Button ID="addstudent" runat="server" Text="Add Student" OnClick="addstudent_Click" />
    <br />
</asp:Content>

