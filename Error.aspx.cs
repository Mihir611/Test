using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Error : System.Web.UI.Page
    {
        MainError me;
        protected void Page_Load(object sender, EventArgs e)
        {
            me = Session["e1"] as MainError;
            Label1.Text = me.e2.ToString();
        }
    }
}