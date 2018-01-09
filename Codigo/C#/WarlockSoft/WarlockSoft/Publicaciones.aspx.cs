using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WarlockSoft
{
    public partial class Publicaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarTablaIndividuales();
            llenarTablaContactos();

            //Ocultar botones
            lbl_hidden1.Visible = false;
            lbl_hidden2.Visible = false;
            txt_hidden1.Visible = false;
            txt_hidden2.Visible = false;
            btn_hidden1.Visible = false;
            btn_hidden2.Visible = false;
        }

        public void llenarTablaIndividuales()
        {
            try
            {
                JPublicacion.Publicacion p = new JPublicacion.Publicacion();
                String[] pub = p.obtenerPublicacionesIndividuales(Convert.ToInt32((String)Session["id_usuario"]));
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Id");
                tabla.Columns.Add("Usuario");
                tabla.Columns.Add("Contenido");
                if (pub != null)
                {
                    for (int i = 0; i < pub.Length; i++)
                    {
                        DataRow fila = tabla.NewRow();
                        String[] publicacion = pub[i].Split(';');
                        fila["Id"] = publicacion[0];
                        fila["Usuario"] = publicacion[2];
                        fila["Contenido"] = publicacion[1];
                        tabla.Rows.Add(fila);
                    }
                }
                gv_estados.DataSource = tabla;
                gv_estados.DataBind();
            }
            catch (Exception e)
            {
                //No hagas nada
                lbl_error.Text = e.Message + " Lugar:"+e.TargetSite;
            }
        }

        public void llenarTablaContactos()
        {
            try
            {
                JPublicacion.Publicacion p = new JPublicacion.Publicacion();
                String[] pub = p.obtenerPublicacionesContactos(Convert.ToInt32((String)Session["id_usuario"]));
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Id");
                tabla.Columns.Add("Usuario");
                tabla.Columns.Add("Contenido");
                for (int i = 0; i < pub.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] publicacion = pub[i].Split(';');
                    fila["Id"] = publicacion[0];
                    fila["Usuario"] = publicacion[2];
                    fila["Contenido"] = publicacion[1];
                    tabla.Rows.Add(fila);
                }
                gv_contactos.DataSource = tabla;
                gv_contactos.DataBind();
            }
            catch (Exception e)
            {
                lbl_error.Text = e.Message+ " Lugar:"+e.TargetSite;
                //No hagas nada campeon
            }
            
        }

        protected void btn_publicar_Click(object sender, EventArgs e)
        {
            JPublicacion.Publicacion p = new JPublicacion.Publicacion();
            p.agregarPublicacion(Convert.ToInt32((String)Session["id_usuario"]), txt_contenido.Text);
            Response.Redirect("Publicaciones.aspx");
        }

        protected void gv_estados_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable) gv_estados.DataSource;
            DataRow fila = tabla.Rows[gv_estados.SelectedIndex];
            int id_pub = Convert.ToInt32( (String) fila["Id"]);
            String contenido = (String) fila["Contenido"];
            Session["id_pub.p"] = id_pub;

            //Llenar la nueva tabla
            gv_comentarios1.Visible = true;
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Contenido");
            fila = tabla.NewRow();
            fila["Id"] = id_pub;
            fila["Usuario"] = (String) Session["nickname"];
            fila["Contenido"] = contenido;
            tabla.Rows.Add(fila);
            gv_comentarios1.DataSource = tabla;
            gv_comentarios1.DataBind();

            lbl_hidden1.Visible = true;
            txt_hidden1.Visible = true;
            btn_hidden1.Visible = true;
            
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
            gv_estados.DataSource = tabla;
            gv_estados.DataBind();
        }

        protected void gv_contactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)gv_contactos.DataSource;
            DataRow fila = tabla.Rows[gv_contactos.SelectedIndex];
            int id_pub = Convert.ToInt32((String)fila["Id"]);
            String contenido = (String)fila["Contenido"];
            String nickname = (String)fila["Usuario"];
            Session["id_pub.p"] = id_pub;
            Session["nick.p"] = nickname;

            //Llenar la nueva tabla
            gv_comentarios2.Visible = true;
            tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Contenido");
            fila = tabla.NewRow();
            fila["Id"] = id_pub;
            fila["Usuario"] = nickname;
            fila["Contenido"] = contenido;
            tabla.Rows.Add(fila);
            gv_comentarios2.DataSource = tabla;
            gv_comentarios2.DataBind();

            lbl_hidden2.Visible = true;
            txt_hidden2.Visible = true;
            btn_hidden2.Visible = true;

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
            gv_contactos.DataSource = tabla;
            gv_contactos.DataBind();
        }

        protected void btn_hidden1_Click(object sender, EventArgs e)
        {
            JPublicacion.Publicacion pub = new JPublicacion.Publicacion();
            pub.comentarPublicacion(Convert.ToInt32((String)Session["id_usuario"]), (int) Session["id_pub.p"], txt_hidden1.Text);
        }

        protected void btn_hidden2_Click(object sender, EventArgs e)
        {
            
            JPublicacion.Publicacion pub = new JPublicacion.Publicacion();
            pub.comentarPub((String) Session["nick.p"], (int) Session["id_pub.p"], txt_hidden2.Text);
        }


        protected void btn_contacto_Click(object sender, EventArgs e)
        {
            JUsuario.Usuario u = new JUsuario.Usuario();
            u.agregarContacto(txt_nickname.Text, Convert.ToInt32((String)Session["id_usuario"]));
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            JUsuario.Usuario u = new JUsuario.Usuario();
            u.eliminarContacto(txt_nickname.Text, Convert.ToInt32((String)Session["id_usuario"]));
        }
        
    }
}