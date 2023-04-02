<%@ Page Title="Shapes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Shapes.aspx.cs" Inherits="SpaceBox_3D.Shapes" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main aria-labelledby="title">

        <asp:Label ID="Label1" runat="server" Text="SpaceBox 3D" Font-Names="Readex Pro Deca Medium" Font-Size="60pt" ForeColor="#E6A02D" CssClass="flex justify-center"></asp:Label>

        <br />
        <br />

        <div class="container mx-auto px-4" style="max-width: 900px;">
            <div class="flex flex-col gap-5">

                <div class="flex justify-center gap-20">

                    <p class="flex text-h1-color text-[80px] justify-center font-readex"> 
                        <asp:DropDownList ID="ddlSelectShape" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="294px" CssClass="w-[100px] px-4 py-2 border-t-0 border-r-0 border-l-0 border-b-4 border-primary-yellow shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-yellow focus:border-primary-yellow mt-2" Height="45px" AutoPostBack="True" OnSelectedIndexChanged="ddlSelectShape_SelectedIndexChanged">
                            
                            <asp:ListItem CssClass="hover:bg-secondary-grey">Circle</asp:ListItem>
                            <asp:ListItem CssClass="hover:bg-secondary-grey">Triangle</asp:ListItem>
                            <asp:ListItem CssClass="hover:bg-secondary-grey">Rectangle</asp:ListItem>
                        </asp:DropDownList>
                    </p>

                    <div class="flex flex-col gap-4">

                        <div class="flex flex-col gap-1">

                            <!-- Rectangle -->
                            
                            <div class="flex flex-col" id="rectangle" runat="server">
                                <asp:Label ID="lblLength" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Length"></asp:Label>

                                <div class="flex gap-2 mb-2">
                                    <asp:TextBox ID="txtLength" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="294px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>
                            
                                    <asp:DropDownList ID="ddlLength" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="80px" height="40px" CssClass="border-0 border-maincolor shadow-sm focus:outline-none focus:ring-2 focus:ring-maincolor focus:border-maincolor" AutoPostBack="True">
                                        <asp:ListItem>mm</asp:ListItem>
                                        <asp:ListItem>cm</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label ID="lblWidth" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Width" CssClass="mt-2"></asp:Label>

                                <div class="flex gap-2 mb-2">
                                    <asp:TextBox ID="txtWidth" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="294px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>

                                    <asp:DropDownList ID="ddlWidth" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="80px" height="40px" CssClass="border-0 border-maincolor shadow-sm focus:outline-none focus:ring-2 focus:ring-maincolor focus:border-maincolor" AutoPostBack="True">
                                        <asp:ListItem>mm</asp:ListItem>
                                        <asp:ListItem>cm</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>


                            <!-- Circle -->

                            <div class="flex flex-col" id="circle" runat="server">
                                <asp:Label ID="lblRadius" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Radius"></asp:Label>

                                <div class="flex gap-2 mb-2">
                                    <asp:TextBox ID="txtRadius" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="294px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>

                                    <asp:DropDownList ID="ddlRadius" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="80px" height="40px" CssClass="border-0 border-maincolor shadow-sm focus:outline-none focus:ring-2 focus:ring-maincolor focus:border-maincolor" AutoPostBack="True">
                                        <asp:ListItem>mm</asp:ListItem>
                                        <asp:ListItem>cm</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label ID="lblCenterPoint" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Center Point" CssClass="mt-2"></asp:Label>

                                <asp:TextBox ID="txtCenterPoint" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="382px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>
                            </div>

                            <!-- Triangle -->

                            <div class="flex flex-col" id="triangle" runat="server">
                                <asp:Label ID="lblSide_a" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Side a"></asp:Label>

                                <div class="flex gap-2 mb-2">
                                    <asp:TextBox ID="txtSide_a" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="294px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>

                                    <asp:DropDownList ID="ddlSide_a" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="80px" height="40px" CssClass="border-0 border-maincolor shadow-sm focus:outline-none focus:ring-2 focus:ring-maincolor focus:border-maincolor" AutoPostBack="True">
                                            <asp:ListItem>mm</asp:ListItem>
                                            <asp:ListItem>cm</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label ID="lblSide_b" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Side b" CssClass="mt-2"></asp:Label>

                                <div class="flex gap-2 mb-2">
                                    <asp:TextBox ID="txtSide_b" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="294px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>

                                    <asp:DropDownList ID="ddlSide_b" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="80px" height="40px" CssClass="border-0 border-maincolor shadow-sm focus:outline-none focus:ring-2 focus:ring-maincolor focus:border-maincolor" AutoPostBack="True">
                                        <asp:ListItem>mm</asp:ListItem>
                                        <asp:ListItem>cm</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label ID="lblSide_c" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Side c" CssClass="mt-2"></asp:Label>

                                <div class="flex gap-2">
                                    <asp:TextBox ID="txtSide_c" runat="server" BackColor="#3B3B3B" ForeColor="White" Width="294px" Height="40px" CssClass="px-4 py-2 border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey"></asp:TextBox>

                                    <asp:DropDownList ID="ddlSide_c" runat="server" BackColor="#3B3B3B" DataTextField="Select a shape" ForeColor="White" Width="80px" height="40px" CssClass="border-0 border-maincolor shadow-sm focus:outline-none focus:ring-2 focus:ring-maincolor focus:border-maincolor" AutoPostBack="True">
                                        <asp:ListItem>mm</asp:ListItem>
                                        <asp:ListItem>cm</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                        </div>

                        <div class="flex flex-row gap-5 justify-center">
                            <asp:Button ID="btnApply" runat="server" Text="Apply" BackColor="#FFCB74" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#2F2F2F" Height="40px" Width="120px" style="border-radius: 30px;" OnClick="btnApply_Click" />
                            <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#3B3B3B" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#FFCB74" Height="40px" Width="120px" style="border-radius: 30px;" OnClick="btnClear_Click" />                  
                        </div>
                        
                    </div>

                </div>

                

                <div class="justify-center mt-2">
                    
                    <div class="flex gap-2">
                        <asp:Label ID="lblDotAmount" runat="server" Font-Names="Readex Pro Deca" Font-Size="12pt" ForeColor="White" Text="Dot Amount :"></asp:Label>
                        <asp:Label ID="lblDisplayDotAmount" runat="server" Font-Names="Readex Pro Deca" ForeColor="White" Font-Size="12"></asp:Label>
                    </div>

                    <div class="flex flex-row mt-2">
                        <asp:Panel ID="braillePreviewPanel" runat="server" BackColor="#3B3B3B" Height="300px" Width="900px">
                            <asp:Label ID="lblBraillePreview" runat="server" Font-Names="Readex Pro Deca" Font-Size="20pt" ForeColor="White" CssClass="mt-5 flex justify-center"></asp:Label>
                        </asp:Panel>
                    </div>

                </div>                 


                <div class="flex flex-row gap-5 justify-center mb-5">
                    <asp:Button ID="btnPrint" runat="server" Text="Print" BackColor="#FFCB74" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#2F2F2F" Height="40px" Width="120px" style="border-radius: 30px;" />
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" BackColor="#3B3B3B" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#FFCB74" Height="40px" Width="120px" style="border-radius: 30px;" OnClick="btnCancel_Click" />        
                </div>           
            </div>
       </div>

    </main>
</asp:Content>
