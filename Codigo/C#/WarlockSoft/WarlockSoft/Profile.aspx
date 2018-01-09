<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WarlockSoft.Profile" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lbl_error" runat="server" Text=""></asp:Label>
 <div>   
    <div class="col-xs-12">
       <h2 class="Pager">Informacion del perfil</h2>
       <div class="col-xs-6">
            <p>Nombre: </p><asp:Label ID="lbl_nombre" runat="server" Text=""></asp:Label>
            <p>Correo: </p><asp:Label ID="lbl_correo" runat="server" Text=""></asp:Label>
       </div>
       <div class="col-xs-6">
            <p>FechaNacimiento: </p>
            <asp:Label ID="lbl_fecha" runat="server" Text=""></asp:Label>
            <p>Nickname: </p>
            <asp:Label ID="lbl_nick" runat="server" Text=""></asp:Label>
       </div>
   </div>
</div>
    <div class="col-xs-12">
        <h2 class="Pager">Carga Masiva</h2>
        <div class="col-xs-12">
            <p>Ruta: </p>
            <asp:TextBox ID="txt_ruta" runat="server" Width="472px"></asp:TextBox>
        </div>
        <div class="col-xs-12">
            <asp:Button class="col-xs-3" ID="btn_carga1" runat="server" Text="Asociaciones y Usuarios" />
        <asp:Button class="col-xs-3" ID="btn_carga2" runat="server" Text="Publicaciones y Comentarios" />
        <asp:Button class="col-xs-3" ID="btn_carga3" runat="server" Text="Tareas" />
        <asp:Button class="col-xs-3" ID="btn_carga4" runat="server" Text="Proyectos" />
        </div>
        
    </div>
<div>
    <div  class="col-xs-12">
        <h2 class="Pager">Conocimientos y Habilidades</h2>
        <asp:Label ID="lbl_habilidades" runat="server" Text=""></asp:Label>
    </div>
    <div class="col-xs-12">
        <h3 class="Pager">Agregar conocimiento</h3>
        <p>Conocimiento: </p>
        <asp:DropDownList ID="ddl_conocimiento" runat="server" Height="16px" Width="240px"></asp:DropDownList>
        <asp:Button ID="btn_conocimiento" runat="server" Text="Agregar" OnClick="btn_conocimiento_Click" />
    </div>
</div>
</asp:Content>