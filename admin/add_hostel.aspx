<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage2.master" AutoEventWireup="true" CodeFile="add_hostel.aspx.cs" Inherits="add_hostel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contentplaceholder2" Runat="Server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Area Name"></asp:Label>
    <br />
    <asp:TextBox ID="name" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Hostel Name"></asp:Label>
    <br />
    <asp:TextBox ID="hostel" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" Text="No of Rooms"></asp:Label>
    <br />
    <asp:TextBox ID="room_no" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Contact no"></asp:Label>
    <br />
    <asp:TextBox ID="contact_no" runat="server"></asp:TextBox>
    <br />
    <%--<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Address"></asp:Label>
    <br />
    <asp:TextBox ID="Address" runat="server"></asp:TextBox>
    <br />--%>
    <asp:Button ID="addhostel" runat="server" Text="Add Hostel" OnClick="addhostel_Click" />
</asp:Content>

