using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace WarlockSoft
{
    public partial class Denuncias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargarCom();
            cargarPro();
            cargarPub();
            cargarTar();
        }

        public void cargarPub()
        {
            JDenuncia.Denuncia d = new JDenuncia.Denuncia();
            String[] de = d.obtenerPubDenunciadas();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Soplon");
            tabla.Columns.Add("Infractor");
            tabla.Columns.Add("Razon de denuncia");
            if (de != null)
            {
                for (int i = 0; i < de.Length; i++)
                {
                    String[] valores = de[i].Split(';');
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = valores[0];
                    fila["Soplon"] = valores[1];
                    fila["Infractor"] = valores[2];
                    fila["Razon de denuncia"] = valores[3];
                }
            }
            gv1.DataSource = tabla;
            gv1.DataBind();
        }

        public void cargarCom()
        {
            JDenuncia.Denuncia d = new JDenuncia.Denuncia();
            String[] de = d.obtenerComDenunciadas();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Soplon");
            tabla.Columns.Add("Infractor");
            tabla.Columns.Add("Razon de denuncia");
            if (de != null)
            {
                for (int i = 0; i < de.Length; i++)
                {
                    String[] valores = de[i].Split(';');
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = valores[0];
                    fila["Soplon"] = valores[1];
                    fila["Infractor"] = valores[2];
                    fila["Razon de denuncia"] = valores[3];
                }
            }
            gv2.DataSource = tabla;
            gv2.DataBind();
        }

        public void cargarPro()
        {
            JDenuncia.Denuncia d = new JDenuncia.Denuncia();
            String[] de = d.obtenerProDenunciadas();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Soplon");
            tabla.Columns.Add("Infractor");
            tabla.Columns.Add("Razon de denuncia");
            if (de != null)
            {
                for (int i = 0; i < de.Length; i++)
                {
                    String[] valores = de[i].Split(';');
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = valores[0];
                    fila["Soplon"] = valores[1];
                    fila["Infractor"] = valores[2];
                    fila["Razon de denuncia"] = valores[3];
                }
            }
            gv4.DataSource = tabla;
            gv4.DataBind();
        }

        public void cargarTar()
        {
            JDenuncia.Denuncia d = new JDenuncia.Denuncia();
            String[] de = d.obtenerTarDenunciadas();
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Soplon");
            tabla.Columns.Add("Infractor");
            tabla.Columns.Add("Razon de denuncia");
            if (de != null)
            {
                for (int i = 0; i < de.Length; i++)
                {
                    String[] valores = de[i].Split(';');
                    DataRow fila = tabla.NewRow();
                    fila["Id"] = valores[0];
                    fila["Soplon"] = valores[1];
                    fila["Infractor"] = valores[2];
                    fila["Razon de denuncia"] = valores[3];
                }
            }
            gv3.DataSource = tabla;
            gv3.DataBind();
        }

    }
}