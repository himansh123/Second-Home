<%@ Page Title="" Language="C#" MasterPageFile="~/admin/MasterPage2.master" AutoEventWireup="true" CodeFile="list_student.aspx.cs" Inherits="list_student" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contentplaceholder2" Runat="Server">

    <asp:GridView ID="showdata" runat="server" OnSelectedIndexChanged="showdata_SelectedIndexChanged">
    </asp:GridView>

</asp:Content>

