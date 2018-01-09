<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Asociacion.aspx.cs" Inherits="WarlockSoft.Asociacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-xs-10">
        <div class="col-xs-12">
            <h2 class="Pager">Asociacion: </h2>
            <asp:Label ID="lbl_nombre" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <h3>Publicar</h3>
            <asp:TextBox ID="txt_publicacion" runat="server" Width="658px"></asp:TextBox>
            <asp:Button ID="btn_publicar" runat="server" Text="Publicar" OnClick="btn_publicar_Click" />
        </div>
        <div class="col-xs-12">
            <asp:Label ID="lbl_accion" runat="server" Text="Publicaciones"></asp:Label>
            <asp:GridView ID="gv_hidden" class="col-xs-12" runat="server"></asp:GridView>
            <asp:Label ID="lbl_hidden" runat="server" Text="Comentar:"></asp:Label>
            <asp:TextBox ID="txt_hidden" runat="server" Width="594px"></asp:TextBox>
            <asp:Button ID="btn_hidden" runat="server" Text="Comentar" OnClick="btn_hidden_Click" />
            <asp:GridView ID="gv_publicaciones" class="col-xs-12" runat="server" OnSelectedIndexChanged="gv_publicaciones_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    <div class="col-xs-2">
        <h3>Miembros</h3>
        <div class="col-xs-12">
            <asp:Label ID="lbl_nick" runat="server" Text="Nickname:"></asp:Label>
            <asp:TextBox ID="txt_nickname" runat="server" Width="145px"></asp:TextBox>
        </div>
        <div class="col-xs-12">
            <asp:Button ID="btn_agregar" runat="server" Text="Agregar" OnClick="btn_agregar_Click" />
            <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" OnClick="btn_eliminar_Click" />
            <asp:Button ID="btn_ascender" runat="server" Text="Ascender" OnClick="btn_ascender_Click" />
            <asp:Button ID="btn_degradar" runat="server" Text="Degradar" OnClick="btn_degradar_Click" />
        </div>
        <asp:GridView ID="gv_miembros" class="col-xs-11" runat="server"></asp:GridView>
    </div>
</asp:Content>