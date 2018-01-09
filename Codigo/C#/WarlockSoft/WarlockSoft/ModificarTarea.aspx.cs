using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WarlockSoft
{
    public partial class ModificarTarea : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Llenar el DropDownList
            if (ddl_conocimientos.Items.Count == 0)
            {
                JConocimiento.Conocimiento conocimiento = new JConocimiento.Conocimiento();
                String[] conocimientos = conocimiento.obtenerConocimientos();
                for (int i = 0; i < conocimientos.Length; i++)
                {
                    ddl_conocimientos.Items.Add(conocimientos[i]);
                }
                ddl_conocimientos.DataBind();
            }
            //Cargar las tareas
            cargarTareas();

            //Validar el estado de la tarea
            if (txt_estado.Text.Equals("Activa"))
            {
                btn_publicar.Visible = false;
                btn_terminar.Visible = true;
            } else if(txt_estado.Text.Equals("Borrador")) 
            {
                btn_publicar.Visible = true;
                btn_terminar.Visible = false;
            }
            else if (txt_estado.Text.Equals("Terminada"))
            {
                btn_publicar.Visible = false;
                btn_terminar.Visible = false;
            }

            cargarInscritos();
            cargarParticipantes();

        }

        protected void btn_agregar_Click(object sender, EventArgs e)
        {
            //Llenar la tabla
            if (Session["tablaConocimientos-nt"] == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("CONOCIMIENTO REQUERIDO");
                Session["tablaConocimientos-nt"] = dt;
            }
            DataTable temp = (DataTable)Session["tablaConocimientos-nt"];
            DataRow dr = temp.NewRow();
            dr["CONOCIMIENTO REQUERIDO"] = ddl_conocimientos.SelectedItem.ToString();
            temp.Rows.Add(dr);
            Session["tablaConocimientos-nt"] = temp;
            tabla_conocimientos.DataSource = temp;
            tabla_conocimientos.DataBind();

            //Eliminar item del DropDownList
            int index = ddl_conocimientos.SelectedIndex;
            ddl_conocimientos.Items.RemoveAt(index);
        }

        protected void btn_limpiar_Click(object sender, EventArgs e)
        {
            Session["tablaConocimientos-nt"] = null;
            ddl_conocimientos.Items.Clear();
            ddl_conocimientos.DataBind();
            tabla_conocimientos.DataSource = null;
            tabla_conocimientos.DataBind();
            JConocimiento.Conocimiento c = new JConocimiento.Conocimiento();
            String[] conocimientos = c.obtenerConocimientos();
            for (int i = 0; i < conocimientos.Length; i++)
            {
                ddl_conocimientos.Items.Add(conocimientos[i]);
            }
            ddl_conocimientos.DataBind();
        }

        protected void btn_publicar_Click(object sender, EventArgs e)
        {
            JTarea.Tarea t = new JTarea.Tarea();
            t.cambiarEstado((int)Session["id_tarea-mt"], "Activa");
            Session["id_tarea-mt"] = null;
            Response.Redirect("TimeLine.aspx");
        }

        protected void cargarTareas()
        {
            JTarea.Tarea tarea = new JTarea.Tarea();
            int id_tarea = (int)Session["id_tarea-mt"];
            String[] t = tarea.obtenerDatosTarea(id_tarea);
            txt_nombre.Text = t[1];
            txt_descripcion.Text = t[2];
            txt_precio.Text = t[5];
            txt_cantidadMax.Text = t[6];
            txt_estado.Text = t[7]; 

            String fecha = t[3];
            String[] fIni = fecha.Split('-');
            int anoIni = Convert.ToInt32(fIni[0]);
            int mesIni = Convert.ToInt32(fIni[1]);
            int diaIni = Convert.ToInt32(fIni[2]);
            DateTime fechaHora = new DateTime(anoIni, mesIni, diaIni);
            calendar_inicio.SelectedDate = fechaHora;

            fecha = t[4];
            String[] fFin = fecha.Split('-');
            int anoFin = Convert.ToInt32(fFin[0]);
            int mesFin = Convert.ToInt32(fFin[1]);
            int diaFin = Convert.ToInt32(fFin[2]);
            DateTime fh = new DateTime(anoIni, mesIni, diaIni);
            calendar_inicio.SelectedDate = fh;
        }

        protected void btn_terminar_Click(object sender, EventArgs e)
        {
            JTarea.Tarea t = new JTarea.Tarea();
            t.cambiarEstado((int)Session["id_tarea-mt"], "Terminada");
            Session["id_tarea-mt"] = null;
            Response.Redirect("TimeLine.aspx");
        }

        public void cargarInscritos()
        {
            JTarea.Tarea t = new JTarea.Tarea();
            String[] inscritos = t.obtenerMiembrosInscritosPorTarea((int)Session["id_tarea-mt"]);
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Usuario");
            if (inscritos != null)
            {
                for (int i = 0; i < inscritos.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    fila["Usuario"] = inscritos[i];
                    tabla.Rows.Add(fila);
                }
            }
            gv_inscritos.DataSource = tabla;
            gv_inscritos.DataBind();
        }

        public void cargarParticipantes()
        {
            JTarea.Tarea t = new JTarea.Tarea();
            String[] inscritos = t.obtenerMiembrosParticipantesPorTarea((int)Session["id_tarea-mt"]);
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Usuario");
            if (inscritos != null)
            {
                for (int i = 0; i < inscritos.Length; i++)
                {
                    DataRow fila = tabla.NewRow();
                    fila["Usuario"] = inscritos[i];
                    tabla.Rows.Add(fila);
                }
            }
            gv_participantes.DataSource = tabla;
            gv_participantes.DataBind();
        }

        protected void gv_inscritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)gv_inscritos.DataSource;
            DataRow fila = tabla.Rows[gv_inscritos.SelectedIndex];
            tabla.Rows.RemoveAt(gv_inscritos.SelectedIndex);
            gv_inscritos.DataSource = tabla;
            gv_inscritos.DataBind();

            tabla = (DataTable)gv_participantes.DataSource;
            tabla.Rows.Add(fila);
            gv_participantes.DataSource = tabla;
            gv_participantes.DataBind();
        }

        protected void gv_participantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tabla = (DataTable)gv_participantes.DataSource;
            DataRow fila = tabla.Rows[gv_participantes.SelectedIndex];
            tabla.Rows.RemoveAt(gv_participantes.SelectedIndex);
            gv_participantes.DataSource = tabla;
            gv_participantes.DataBind();

            tabla = (DataTable)gv_inscritos.DataSource;
            tabla.Rows.Add(fila);
            gv_inscritos.DataSource = tabla;
            gv_inscritos.DataBind();
        }

    }
}