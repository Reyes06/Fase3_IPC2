using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WarlockSoft
{
    public partial class Asociacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            gv_hidden.Visible = false;
            lbl_hidden.Visible = false;
            txt_hidden.Visible = false;
            btn_hidden.Visible = false;
            lbl_nombre.Text = (String)Session["nombre.a"];
            cargarPublicaciones();
            cargarMiembros();
            cargarControles();
        }

        public void cargarPublicaciones()
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            String[] asociacion = a.obtenerPublicacionesAsociacion(Convert.ToInt32((String)Session["id_asociacion.a"]));
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Contenido");
            if (asociacion != null)
            {
                for (int i = 0; i < asociacion.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] aso = asociacion[i].Split(';');
                    fila["Id"] = aso[2];
                    fila["Usuario"] = aso[1];
                    fila["Contenido"] = aso[3];
                    tabla.Rows.Add(fila);
                }
            }
            gv_publicaciones.DataSource = tabla;
            gv_publicaciones.DataBind();
        }

        public void cargarMiembros()
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            String[] miembros = a.obtenerUsuariosPorAsociacion(Convert.ToInt32((String)Session["id_asociacion.a"]));
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Nickname");
            tabla.Columns.Add("Tipo");
            if (miembros != null)
            {
                for (int i = 0; i < miembros.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] m = miembros[i].Split(';');
                    fila["Nickname"] = m[1];
                    fila["Tipo"] = m[2];
                    tabla.Rows.Add(fila);
                }
            }
            gv_miembros.DataSource = tabla;
            gv_miembros.DataBind();
        }

        public void cargarControles()
        {
            String tipo = (String)Session["tipo.a"];
            if (tipo.Equals("miembro"))
            {
                btn_agregar.Visible = false;
                btn_eliminar.Visible = false;
                txt_nickname.Visible = false;
                lbl_nick.Visible = false;
            }
            else if (tipo.Equals("admin"))
            {
                btn_agregar.Visible = true;
                btn_eliminar.Visible = true;
                txt_nickname.Visible = true;
                lbl_nick.Visible = true;
            }
        }

        protected void btn_ascender_Click(object sender, EventArgs e)
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            a.cambiarTipoMembresia(txt_nickname.Text, Convert.ToInt32((String)Session["id_asociacion.a"]), "Administrador");
        }

        protected void btn_degradar_Click(object sender, EventArgs e)
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            a.cambiarTipoMembresia(txt_nickname.Text, Convert.ToInt32((String)Session["id_asociacion.a"]), "Miembro");
        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            a.nuevoMiembro(txt_nickname.Text, Convert.ToInt32((String)Session["id_asociacion.a"]));
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            a.eliminarMiembro(txt_nickname.Text, Convert.ToInt32((String) Session["id_asociacion.a"]));
        }

        protected void btn_publicar_Click(object sender, EventArgs e)
        {
            JPublicacion.Publicacion p = new JPublicacion.Publicacion();
            p.agregarPublicacion(Convert.ToInt32((String)Session["id_usuario"]), txt_publicacion.Text);
        }

        protected void gv_publicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)gv_publicaciones.DataSource;
            DataRow fila = tabla.Rows[gv_publicaciones.SelectedIndex];
            int id_pub = Convert.ToInt32((String)fila["Id"]);
            String contenido = (String)fila["Contenido"];
            String nickname = (String)fila["Usuario"];
            Session["id_pub"] = id_pub;

            //Llenar la nueva tabla
            
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Contenido");
            fila = tabla.NewRow();
            fila["Id"] = id_pub;
            fila["Usuario"] = nickname;
            fila["Contenido"] = contenido;
            tabla.Rows.Add(fila);
            gv_hidden.DataSource = tabla;
            gv_hidden.DataBind();
            gv_hidden.Visible = true;
            lbl_hidden.Visible = true;
            txt_hidden.Visible = true;
            btn_hidden.Visible = true;
            lbl_accion.Text = "Comentar";

            JPublicacion.Publicacion pub = new JPublicacion.Publicacion();
            String[] comentarios = pub.obtenerComentarios(id_pub);
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Comentario");
            if (comentarios != null)
            {
                for (int i = 0; i < comentarios.Length; i++)
                {
                    fila = tabla.NewRow();
                    String[] com = comentarios[i].Split(';');
                    fila["Id"] = com[0];
                    fila["Usuario"] = com[2];
                    fila["Comentario"] = com[1];
                    tabla.Rows.Add(fila);
                }
            }
            gv_publicaciones.DataSource = tabla;
            gv_publicaciones.DataBind();
        }

        protected void btn_hidden_Click(object sender, EventArgs e)
        {
            JPublicacion.Publicacion p = new JPublicacion.Publicacion();
            p.comentarPub((String)Session["nickname"], (int) Session["id_pub"], txt_hidden.Text);
        }
    }
}