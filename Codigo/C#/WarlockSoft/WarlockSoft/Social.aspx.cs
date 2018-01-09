using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Web.UI.WebControls;

namespace WarlockSoft
{
    public partial class Social : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cargar las tablas
            cargarMensajesEnviados();
            cargarMensajesRecibidos();
            cargarAdministrador();
            cargarMiembro();
            cargarMiembros();
        }

        protected void txt_enviar_Click(object sender, EventArgs e)
        {
            JUsuario.Usuario u = new JUsuario.Usuario();
            if (u.enviarMensaje(Convert.ToInt32((String)Session["id_usuario"]), txt_destinatario.Text, txt_cuerpo.Text))
            {
                lbl_notificacion.Text = "Enviado";
            }
            else
            {
                lbl_notificacion.Text = "Error amiguito";
            }
        }

        public void cargarMensajesEnviados()
        {
            JUsuario.Usuario u = new JUsuario.Usuario();
            String[] mensajes = u.mensajesEnviados(Convert.ToInt32((String)Session["id_usuario"]));
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Mensaje");
            if (mensajes != null)
            {
                for (int i = 0; i < mensajes.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] msj = mensajes[i].Split(';');
                    fila["Usuario"] = msj[2];
                    fila["Mensaje"] = msj[1];
                    tabla.Rows.Add(fila);
                }
            }
            gv_enviados.DataSource = tabla;
            gv_enviados.DataBind();
        }

        public void cargarMensajesRecibidos()
        {
            JUsuario.Usuario u = new JUsuario.Usuario();
            String[] mensajes = u.mensajesRecibidos(Convert.ToInt32((String)Session["id_usuario"]));
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Usuario");
            tabla.Columns.Add("Mensaje");
            if (mensajes != null)
            {
                for (int i = 0; i < mensajes.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] msj = mensajes[i].Split(';');
                    fila["Usuario"] = msj[2];
                    fila["Mensaje"] = msj[1];
                    tabla.Rows.Add(fila);
                }
            }
            gv_recibidos.DataSource = tabla;
            gv_recibidos.DataBind();
        }

        public void cargarAdministrador()
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            String[] asociaciones = a.obtenerAsociacionesPorUsuario(Convert.ToInt32((String)Session["id_usuario"]), "Administrador");
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            if (asociaciones != null)
            {
                for (int i = 0; i < asociaciones.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] msj = asociaciones[i].Split(';');
                    fila["Id"] = msj[0];
                    fila["Nombre"] = msj[1];
                    tabla.Rows.Add(fila);
                }
            }
            gv_administrador.DataSource = tabla;
            gv_administrador.DataBind();
        }

        public void cargarMiembro()
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            String[] asociaciones = a.obtenerAsociacionesPorUsuario(Convert.ToInt32((String)Session["id_usuario"]), "Miembro");
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            if (asociaciones != null)
            {
                for (int i = 0; i < asociaciones.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    String[] msj = asociaciones[i].Split(';');
                    fila["Id"] = msj[0];
                    fila["Nombre"] = msj[1];
                    tabla.Rows.Add(fila);
                }
            }
            gv_miembro.DataSource = tabla;
            gv_miembro.DataBind();
        }

        public void cargarMiembros()
        {
            if (gv_nicknames.DataSource == null)
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("Usuario");
                gv_nicknames.DataSource = tabla;
                gv_nicknames.DataBind();
            }
            else
            {
                DataTable tabla = (DataTable) gv_nicknames.DataSource;
                DataRow fila = tabla.NewRow();
                fila["Usuario"] = txt_nickname.Text;
                tabla.Rows.Add(fila);
                gv_nicknames.DataSource = tabla;
                gv_nicknames.DataBind();
            }
        }

        protected void txt_agregar_Click(object sender, EventArgs e)
        {
            cargarMiembros();
        }

        protected void btn_crear_Click(object sender, EventArgs e)
        {
            JAsociacion.Asociacion a = new JAsociacion.Asociacion();
            int id = a.crearAsociacion(txt_nombre.Text, Convert.ToInt32((String)Session["id_usuario"]));

            DataTable tabla = (DataTable) gv_nicknames.DataSource;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow fila = tabla.Rows[i];
                a.nuevoMiembro((String)fila["Usuario"], id);
            }
        }

        protected void gv_nicknames_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)gv_nicknames.DataSource;
            tabla.Rows.RemoveAt(gv_nicknames.SelectedIndex);
            gv_nicknames.DataSource = tabla;
            gv_nicknames.DataBind();
        }

        protected void gv_administrador_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable) gv_administrador.DataSource;
            DataRow fila = tabla.Rows[gv_administrador.SelectedIndex];
            String id_asociacion = (String) fila["Id"];
            String nombre = (String)fila["Nombre"];
            Session["id_asociacion.a"] = id_asociacion;
            Session["tipo.a"] = "admin";
            Session["nombre.a"] = nombre;
            Response.Redirect("Asociacion.aspx");
        }

        protected void gv_miembro_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)gv_miembro.DataSource;
            DataRow fila = tabla.Rows[gv_miembro.SelectedIndex];
            String id_asociacion = (String)fila["Id"];
            String nombre = (String)fila["Nombre"];
            Session["nombre.a"] = nombre;
            Session["id_asociacion.a"] = id_asociacion;
            Session["tipo.a"] = "miembro";
            Response.Redirect("Asociacion.aspx");
        }
    }
}