<%@ Page Language="C#"  MasterPageFile="~/Site.Master"AutoEventWireup="true" CodeBehind="Denuncias.aspx.cs" Inherits="WarlockSoft.Denuncias" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<div>
    <h2 class="Pager">Estados Denunciados</h2>
    <asp:GridView ID="gv1" runat="server">
        <Columns>
            <asp:ButtonField Text="Borrar" />
            <asp:ButtonField Text="Suspender" />
            <asp:ButtonField Text="Retirar" />
        </Columns>
    </asp:GridView>
</div>
<div>
    <h2 class="Pager">Comentarios Denunciados</h2>
    <asp:GridView ID="gv2" runat="server">
        <Columns>
            <asp:ButtonField Text="Borrar" />
            <asp:ButtonField Text="Suspender" />
            <asp:ButtonField Text="Retirar" />
        </Columns>
    </asp:GridView>
</div>
<div>
    <h2 class="Pager">Tareas Denunciados</h2>
    <asp:GridView ID="gv3" runat="server">
        <Columns>
            <asp:ButtonField Text="Borrar" />
            <asp:ButtonField Text="Suspender" />
            <asp:ButtonField Text="Retirar" />
        </Columns>
    </asp:GridView>
</div>
<div>
    <h2 class="Pager">Proyectos Denunciados</h2>
    <asp:GridView ID="gv4" runat="server" OnSelectedIndexChanged="gv4_SelectedIndexChanged">
        <Columns>
            <asp:ButtonField Text="Borrar"  ButtonType="Button"/>
            <asp:ButtonField Text="Suspender" />
            <asp:ButtonField Text="Retirar" />
        </Columns>
    </asp:GridView>
</div>
</asp:Content>