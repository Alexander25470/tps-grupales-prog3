using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_2
{
    public partial class Ejercicio_5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int vMemoria= Convert.ToInt32(ddlMemoria.SelectedValue);
            int vComponentes = 0;
            int v;
            foreach (ListItem s in cblComponentes.Items)
            { 
                if (s.Selected)
                {
                    vComponentes += Convert.ToInt32(cblComponentes.SelectedValue);
                }
            }
            v = vMemoria + vComponentes;
            lblPrecio.Text = v.ToString();
        }
    }
}