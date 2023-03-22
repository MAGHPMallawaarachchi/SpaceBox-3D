<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shapes.aspx.cs" Inherits="SpaceBox_3D.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <div class="flex flex-col gap-5">
             <h2 class="flex text-h1-color text-[80px] justify-center font-readex"> SpaceBox 3D</h2>

            <p class="flex text-h1-color text-[80px] justify-center font-readex"> 
                <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="269px" CssClass="w-[100px] px-4 py-2 border-t-0 border-r-0 border-l-0 border-b-4 border-primary-yellow shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-yellow focus:border-primary-yellow DropDownList1">
                    <asp:ListItem CssClass="hover:bg-secondary-grey">Circle</asp:ListItem>
                    <asp:ListItem CssClass="hover:bg-secondary-grey">Triangle</asp:ListItem>
                    <asp:ListItem CssClass="hover:bg-secondary-grey">Rectangle</asp:ListItem>
                    <asp:ListItem CssClass="hover:bg-secondary-grey">Square</asp:ListItem>
                </asp:DropDownList>

            </p>
        </div>
       
    </main>
</asp:Content>
