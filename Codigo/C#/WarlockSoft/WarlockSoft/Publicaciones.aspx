<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Publicaciones.aspx.cs" Inherits="WarlockSoft.Publicaciones" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lbl_error" runat="server" Text="Label"></asp:Label>
    <div class="col-xs-12">
        <h2 class="pager">Publicaciones</h2>
    </div>
    <div class="col-xs-6">
        <h3>Publicar estado</h3>
        <p>Contenido: </p>
        <asp:TextBox ID="txt_contenido" runat="server" Height="60px" Width="500px"></asp:TextBox>
        <asp:Button ID="btn_publicar" runat="server" Text="Publicar" OnClick="btn_publicar_Click" />
    </div>
    <div class="col-xs-6">   
         <p>Nickname:</p>
       <div class="col-xs-12">
           <asp:TextBox ID="txt_nickname" runat="server" Width="332px" Text=""></asp:TextBox>
       </div>
          
          <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar Contacto" Width="120" OnClick="btn_eliminar_Click"/>
          <asp:Button ID="btn_contacto" runat="server" Text="Agregar Contacto" Width="120" OnClick="btn_contacto_Click"/>
          <asp:Button ID="btn_verPerfil" runat="server" Text="Ver Perfil" Width="120"/>
   </div>
    <div class="col-xs-6">
        <h3>Mis Publicaciones</h3>
        <asp:GridView ID="gv_comentarios1" class="col-xs-12" runat="server"></asp:GridView>
        <asp:Label ID="lbl_hidden1" runat="server" Text="Comentar: "></asp:Label>
        <asp:TextBox ID="txt_hidden1" runat="server" Height="56px" Width="244px"></asp:TextBox>
        <asp:Button ID="btn_hidden1" runat="server" Text="Comentar" OnClick="btn_hidden1_Click" />
        <asp:GridView ID="gv_estados" class="col-xs-12" runat="server" OnSelectedIndexChanged="gv_estados_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div class="col-xs-6">
        <h3>Publicaciones Contactos</h3>
        <asp:GridView ID="gv_comentarios2" class="col-xs-12" runat="server"></asp:GridView>
        <asp:Label ID="lbl_hidden2" runat="server" Text="Comentar: "></asp:Label>
        <asp:TextBox ID="txt_hidden2" runat="server" Height="56px" Width="244px"></asp:TextBox>
        <asp:Button ID="btn_hidden2" runat="server" Text="Comentar" OnClick="btn_hidden2_Click" />
        <asp:GridView ID="gv_contactos" class="col-xs-12" runat="server" OnSelectedIndexChanged="gv_contactos_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>