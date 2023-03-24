<%@ Page Title="Shapes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shapes.aspx.cs" Inherits="SpaceBox_3D.About" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main aria-labelledby="title">
        <div class="flex flex-col gap-5">
            <h2 class="flex text-h1-color text-[80px] justify-center font-readex"> SpaceBox 3D</h2>

            <div class="flex justify-center gap-[200px]">

                <p class="flex text-h1-color text-[80px] justify-center font-readex"> 
                    <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="294px" CssClass="w-[100px] px-4 py-2 border-t-0 border-r-0 border-l-0 border-b-4 border-primary-yellow shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-yellow focus:border-primary-yellow" Height="45px">
                        <asp:ListItem CssClass="hover:bg-secondary-grey">Circle</asp:ListItem>
                        <asp:ListItem CssClass="hover:bg-secondary-grey">Triangle</asp:ListItem>
                        <asp:ListItem CssClass="hover:bg-secondary-grey">Rectangle</asp:ListItem>
                        <asp:ListItem CssClass="hover:bg-secondary-grey">Square</asp:ListItem>
                    </asp:DropDownList>
                </p>

                <div class="flex flex-col gap-4">
                    <div class="flex flex-col gap-1">
                        <p class="text-h1-color text-[14px] font-readex">Length</p>

                        <asp:TextBox ID="txtLength" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="454px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>
                    </div>
                    
                    <div class="flex flex-col gap-1">
                        <p class="text-h1-color text-[14px] font-readex">Width</p>

                        <asp:TextBox ID="txtWidth" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="454px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>
                    </div>

                    <div class="flex items-center gap-2">
                        <asp:Label ID="Label1" runat="server" Text="Fill" CssClass="text-h1-color text-[14px] font-readex pt-2"></asp:Label>
                        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="custom-checkbox" EnableTheming="True"  />
                    </div>

                                                
                </div>
                
            </div>
            
        </div>
       
    </main>
</asp:Content>
