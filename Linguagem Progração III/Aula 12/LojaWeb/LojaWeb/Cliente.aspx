<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="LojaWeb.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <asp:ObjectDataSource ID="odsClientes" runat="server" 
            DataObjectTypeName="LojaWin.Modelos.ModeloClientes" DeleteMethod="excluir" 
            InsertMethod="incluir" SelectMethod="listagem" 
            TypeName="LojaWin.Bll.ClientesBll" UpdateMethod="alterar">
            <SelectParameters>
                <asp:Parameter ConvertEmptyStringToNull="False" DefaultValue="''" Name="filtro" 
                    Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:GridView ID="gvCliente" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" AllowPaging="True" AutoGenerateColumns="False" 
            DataKeyNames="IdCliente" DataSourceID="odsClientes">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField CancelText="Cancelar" DeleteText="Excluir" 
                    InsertText="Inserir" SelectText="Selecionar" ShowDeleteButton="True" 
                    ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="IdCliente" HeaderText="IdCliente" 
                    SortExpression="IdCliente" />
                <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Telefone" HeaderText="Telefone" 
                    SortExpression="Telefone" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </p>
    <asp:DetailsView ID="DetailsView1" runat="server" BackColor="#DEBA84" 
        BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2" Height="54px" Width="276px" 
        AutoGenerateInsertButton="True" AutoGenerateRows="False" 
        DataSourceID="odsClientes" DefaultMode="Insert">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="IdCliente" HeaderText="IdCliente" 
                SortExpression="IdCliente" />
            <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Telefone" HeaderText="Telefone" 
                SortExpression="Telefone" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
