using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WarlockSoft
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Session["id_usuario"] = "1";
            Session["nickname"] = "Reyes06";
            //Cargar la tabla de conocimientos
            tablaConocimientos();
            //Carga la informacion del usuario
            llenarCampos();
            cargarDDL();
        }

        protected void btn_proyecto_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevoProyecto.aspx");
        }

        protected void btn_tarea_Click(object sender, EventArgs e)
        {
            Response.Redirect("NuevaTarea.aspx");
        }

        public void tablaConocimientos()
        {
            JConocimiento.Conocimiento c = new JConocimiento.Conocimiento();
            int id_usuario = Convert.ToInt32((String) Session["id_usuario"]);
            String[] conocimientos = c.obtenerConocimientosUsuario(id_usuario);
            if (conocimientos != null)
            {

                String tabla = "<table class=\"col-xs-12\" border=\"1\"><tr><th>HABILIDADES</th><th>CONOCIMIENTOS</th><th>KARMA</th><th>KARMA EXTRA</th></tr>";
                for (int i = 0; i < conocimientos.Length; i++)
                {
                    String[] con = conocimientos[i].Split(';');
                    tabla += "<tr><td>" + con[0] + "</td><td>" + con[1] + "</td><td>" + con[2] + "</td><td>" + con[3] + "</td></tr>";

                    for (int j = 4; j < con.Length; j = j + 3)
                    {
                        tabla += "<tr><td></td><td>" + con[j] + "</td><td>" + con[j+1] + "</td><td>" + con[j+2] + "</td></tr>";
                    }
                }
                tabla += "</table>";
                lbl_habilidades.Text = tabla;
            }
        }

        public void llenarCampos()
        {
            try
            {
                lbl_nombre.Text = (String)Session["nombre"];
                lbl_correo.Text = (String)Session["correo"];
                lbl_fecha.Text = (String)Session["fecha"];
                lbl_nick.Text = (String)Session["nickname"];
            }
            catch (Exception e)
            {
                lbl_error.Text = e.Message;
            }
            
        }

        public void cargarDDL()
        {
            JConocimiento.Conocimiento c = new JConocimiento.Conocimiento();
            String[] conocimientos = c.obtenerConocimientos();
            for (int i = 0; i < conocimientos.Length; i++)
            {
                ddl_conocimiento.Items.Add(conocimientos[i]);
            }
        }

        protected void btn_carga1_Click(object sender, EventArgs e)
        {
            JCargaMasiva1.UsuariosYAsociaciones a = new JCargaMasiva1.UsuariosYAsociaciones();
            a.leerUsuariosYAsociaciones(txt_ruta.Text);
        }

        protected void btn_carga2_Click(object sender, EventArgs e)
        {
            JCargaMasiva2.EstadosYComentarios a = new JCargaMasiva2.EstadosYComentarios();
            a.leerEstadosYComentarios(txt_ruta.Text);
        }

        protected void btn_carga3_Click(object sender, EventArgs e)
        {
            JCargaMasiva3.Tareas t = new JCargaMasiva3.Tareas();
            t.leerTareas(txt_ruta.Text);
        }

        protected void btn_carga4_Click(object sender, EventArgs e)
        {
            JCargaMasiva4.Proyectos p = new JCargaMasiva4.Proyectos();
            p.leerProyectos(txt_ruta.Text);
        }

        protected void btn_conocimiento_Click(object sender, EventArgs e)
        {
            JUsuario.Usuario u = new JUsuario.Usuario();
            u.agregarConocimiento(Convert.ToInt32((String)Session["id_usuario"]), ddl_conocimiento.SelectedValue);
        }

    }
}