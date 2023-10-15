using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace REMISYA
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Choferes oChofer = new Choferes();
            oChofer.Chofer = Convert.ToInt32(TextBox1.Text);
            oChofer.Buscar();
            TextBox2.Text = oChofer.Nombre;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Choferes oChofer = new Choferes();

            oChofer.Chofer = Convert.ToInt32(TextBox1.Text);
            oChofer.Nombre = TextBox2.Text;

            oChofer.Modificar();

            TextBox1.Text = "";
            TextBox2.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Choferes oChofer = new Choferes();

            oChofer.Chofer = Convert.ToInt32(TextBox1.Text);
            oChofer.Nombre = TextBox2.Text;

            oChofer.agregar();

            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    }
}