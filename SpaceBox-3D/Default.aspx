﻿<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpaceBox_3D._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main aria-labelledby="title">
        
        <div class="flex flex-col gap-[100px] justify-center items-center h-screen">
            <h1 class="flex text-h1-color text-[140px] justify-center font-readex">SpaceBox 3D</h1>
    
            <p class="flex justify-center gap-[80px]">
                <asp:Button ID="btnShapes" runat="server" Text="Shapes" BackColor="#FFCB74" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca Medium" Font-Size="24pt" ForeColor="#2F2F2F" Height="80px" Width="240px" style="border-radius: 30px;" OnClick="btnShapes_Click" />
                <asp:Button ID="btnBraille" runat="server" Text="Braille" BackColor="#3B3B3B" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca Medium" Font-Size="24pt" ForeColor="#FFCB74" Height="80px" Width="240px" style="border-radius: 30px;" OnClick="btnBraille_Click" />
            </p>
        </div>
               
    </main>

</asp:Content>
