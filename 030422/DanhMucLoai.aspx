<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DanhMucLoai.aspx.cs" Inherits="_030422.DanhMucLoai" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+Eval("Hinhanh") %>' Height="200px" Width="200px" />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" Text='<%# Eval("TenHoa") %>' OnClick="LinkButton2_Click" ></asp:LinkButton>
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" Text='<%# "Giá: "+Eval("DonGia") %>'></asp:LinkButton>
            <br />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>
