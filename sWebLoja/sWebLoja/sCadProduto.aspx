<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="sCadProduto.aspx.cs" Inherits="sWebLoja.sCadProduto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
     <div class="blocoGrupoCampos" style="margin-left: 25px; width: 1132px; height: 1041px;">
        <fieldset class="bordaFieldset" style="width:780px;">
            <legend>Cadastro de Produtos</legend>
                       
            <div class="blocoGrupoCampos">
                <div class="blocoeditor">
                    <label>
                        Código</label>
                    <br />
                    <asp:TextBox ID="txtCodigo" runat="server" Width="100px" ValidateRequestMode="Enabled"></asp:TextBox>
                     
                                       
                </div>
                <div class="blocoeditor">
                <asp:ImageButton ID="bntPesquisar" runat="server" 
                        ImageUrl="~/Images/pesq.jpg" 
                        Style="background-image: url('~/Styles/Imagens/pesqback.jpg');
                            background-repeat: no-repeat; margin-top:13px; background-position: right;" BackColor="#FF3300"
                            ForeColor="Black" BorderColor="#333300" Height="28px" Width="55px" OnClick="bntPesquisar_Click" TabIndex="9" ValidateRequestMode="Enabled" />                  
                </div>
                <div class="blocoeditor">
                    <label style=" margin-left:0px;">
                        Nome Produto</label>
                    <br />
                    <asp:TextBox ID="TxtNome" runat="server" Width="300px" TabIndex="1" ValidateRequestMode="Enabled"></asp:TextBox>
                    
                </div>
                <div class="blocoeditor">
                 <label>
                      Preço Unitário</label>
                    <br />
                    <asp:TextBox ID="TxtPreco" runat="server" Width="150px" TabIndex="2" ValidateRequestMode="Enabled"></asp:TextBox>
                </div>
                <br />
                
            </div>

            <div class="blocoGrupoCampos"  style="margin-left: 0px;  width: 800px;">
                <div class="blocoeditor">
                 <label>
                        Quantidade</label>
                    <br />
                    <asp:TextBox ID="TxtQuant" runat="server" Width="150px" TabIndex="3" ValidateRequestMode="Enabled"></asp:TextBox>
                </div>                
                
               <br />
           </div>    
           

               
          
                <div class="blocoGrupoCampos"  style="margin-left: 25px;  width: 800px;">
                      <div class="blocoeditor">
                        <br />
                        <asp:Button ID="BtnNovo" ValidationGroup="btnNovo" runat="server" Width="100px"
                            Text="Novo" OnClick="btnNovo_Click" ValidateRequestMode="Enabled" />
                    </div>
                    <div class="blocoeditor">
                        <br />
                        <asp:Button ID="btnSalvar" ValidationGroup="btnSalvar" runat="server" Width="100px"
                            Text="Salvar" OnClick="btnSalvar_Click" ValidateRequestMode="Enabled" />
                    </div>
                    <div class="blocoeditor">
                        <br />
                        <asp:Button ID="btnCancelar" runat="server" Width="100px" Text="Limpar Form" OnClick="btnCancelar_Click" ValidateRequestMode="Enabled" />
                    </div>

                    <div class="blocoeditor">
                        <br />
                        <asp:Button ID="BtnMenu" runat="server" Width="100px" Text="Excluir" OnClick="btnMenu_Click" Visible="False" style="height: 26px" ValidateRequestMode="Enabled" />
                    </div>                    
                </div>
                <div class="blocoGrupoCampos"  style="margin-left: 25px;  width: 800px;" >
                <div class="blocoeditor">
                    <asp:Label ID="lblAviso" runat="server" Text="Erro ou Invalido." ForeColor="Red"
                        Visible="false"></asp:Label>
                </div>
                 </div>
        </fieldset>
        </div>
       <br/>
       <br/>
      <br/>
       <br/>
     <br/>
       <br/>
     <br/>
       <br/>
      <br/>
       <br/>
</asp:Content>
