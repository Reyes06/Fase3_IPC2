<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Social.aspx.cs" Inherits="WarlockSoft.Social" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lbl_notificacion" runat="server" Text="Label"></asp:Label>
    <div>
        <h2 class="pager">Mensajeria</h2>
        <div class="col-xs-12">
            <div class="col-xs-6">
                <h3>Enviar Mensaje</h3>
                <p>Destinatario:</p>
                <asp:TextBox ID="txt_destinatario" runat="server" Width="260px"></asp:TextBox>
                <p>Cuerpo:</p>
                <asp:TextBox ID="txt_cuerpo" runat="server" Width="260px"></asp:TextBox>
                <asp:Button ID="txt_enviar" runat="server" Text="Enviar" OnClick="txt_enviar_Click" />
                <h3>Mensajes Enviados</h3>
                <asp:GridView ID="gv_enviados" runat="server"></asp:GridView>
            </div>
            <div class="col-xs-6">
                <h3>Mensajes Recibidos</h3>
                <asp:GridView ID="gv_recibidos" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
    <div>
        <h2 class="pager">Mis Asociaciones</h2>
        <div class="col-xs-12">
            <div class="col-xs-6">
                <h3>Rol de Administrador</h3>
                <asp:GridView ID="gv_administrador" runat="server" OnSelectedIndexChanged="gv_administrador_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-xs-6">
                <h3>Rol de Miembro</h3>
                <asp:GridView ID="gv_miembro" runat="server" OnSelectedIndexChanged="gv_miembro_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
    <div>
        <h2 class="pager">Crear Asociacion</h2>
        <div class="col-xs-6">
            <h3>Informacion</h3>
            <p>Nombre:</p>
            <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
            <asp:Button ID="btn_crear" runat="server" Text="Crear" OnClick="btn_crear_Click" />
        </div>
        <div class="col-xs-6">
            <h3>Miembros</h3>
            <p>Nickname:</p>
            <asp:TextBox ID="txt_nickname" runat="server"></asp:TextBox>
            <asp:Button ID="txt_agregar" runat="server" Text="Agregara" OnClick="txt_agregar_Click" />
            <p>Lista de miembros:</p>
            <asp:GridView ID="gv_nicknames" runat="server" OnSelectedIndexChanged="gv_nicknames_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>