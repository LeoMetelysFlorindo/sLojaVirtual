<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sConsProd.aspx.cs" Inherits="sWebLoja.sConsProd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
          <div class="blocoGrupoCampos" style="margin-left: 25px;">
                        <div class="blocoeditor">
                            <asp:Label ID="lblAviso" style="font-family: Arial Black;margin-left: 425px;font-size: 9pt;" runat="server" Text="Erro ou Invalido." ForeColor="Red"
                                Visible="False" Width="400px"></asp:Label>
                        </div>
                </div>
    <table>
    <td class="style527">

         <asp:GridView ID="gdItens" runat="server" 
        CaptionAlign="Top" DataKeyNames="codigo"
                       Height="47px" Style="margin-left: 15px; margin-top: 19px;
                        color: #000000; font-size: medium;" Width="1184px" 
        Caption="Produtos - Consulta" SelectedIndex="1" PageSize="20" 
    GridLines="None"
                        CellPadding="8" ForeColor="#333333" TabIndex="3" ValidateRequestMode="Enabled" ViewStateMode="Enabled">
                        <AlternatingRowStyle BackColor="White" />                        
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="False" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="true" ForeColor="White" />
                        <PagerStyle Height="30px" BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="false" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView> 
        <asp:Timer ID="sAtualiza" runat="server" Enabled="False" Interval="100">
        </asp:Timer>
    </td>
    </table>
</asp:Content>
