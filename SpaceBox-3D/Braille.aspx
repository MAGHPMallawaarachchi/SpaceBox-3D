<%@ Page Title="Braille" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Braille.aspx.cs" Inherits="SpaceBox_3D.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">

        <div class="flex flex-col gap-5 justify-center">
            <h2 class="flex text-h1-color text-[80px] justify-center font-readex"> SpaceBox 3D</h2>
            <div class="flex text-[14px] justify-center font-readex mt-5"> 

                <textarea id="TextArea1" cols="20" name="S1" rows="2" class="bg-primary-grey border-0 border-primary-grey shadow-sm focus:outline-none focus:ring-2 focus:ring-primary-grey focus:border-primary-grey" placeholder="Write text here" style="font-family: 'Readex Pro'; font-size: 14px; color: #FFCB74; background-color: #3B3B3B; width: 500px; height: 150px;"></textarea>

            </div>

            <div class="flex flex-row gap-5 justify-center">
                <asp:Button ID="btnConvert" runat="server" Text="Convert" BackColor="#FFCB74" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#2F2F2F" Height="40px" Width="120px" style="border-radius: 30px;" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" BackColor="#3B3B3B" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#FFCB74" Height="40px" Width="120px" style="border-radius: 30px;" />        
            </div>

            <div class="flex flex-row justify-center mt-5">
                <asp:Panel ID="Panel1" runat="server" BackColor="#3B3B3B" Height="300px" Width="900px"> </asp:Panel>
            </div>

            <div class="flex flex-row gap-5 justify-center">
                <asp:Button ID="btnPrint" runat="server" Text="Print" BackColor="#FFCB74" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#2F2F2F" Height="40px" Width="120px" style="border-radius: 30px;" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" BackColor="#3B3B3B" BorderColor="#FFCB74" BorderStyle="Solid" BorderWidth="1px" Font-Names="Readex Pro Deca" Font-Size="Medium" ForeColor="#FFCB74" Height="40px" Width="120px" style="border-radius: 30px;" />        
            </div>
                
        </div>
        
    </main>
</asp:Content>
