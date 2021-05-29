using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        string url;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool t = true;
            if (this.TextBox1.Text == "")
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please input a valid url Eg:(https://www.google.com)')", true);
            if (!this.TextBox1.Text.Contains("https://"))
                url = "https://" + this.TextBox1.Text;
            if (!this.TextBox1.Text.Contains(".com"))
                url = TextBox1.Text + ".com";
            if (!this.TextBox1.Text.Contains("https://") && !this.TextBox1.Text.Contains(".www") && !this.TextBox1.Text.Contains(".com"))
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Wrong input')", true);
            else
            {
                url = this.TextBox1.Text;
                t = urlExists(url);
                if (t == false)
                {
                    Response.StatusCode = 404;
                    Response.StatusDescription = "Page not found";
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Page not Found')", true);
                }
                else
                {
                    Response.Redirect(url);
                }
            }
        }

        public bool urlExists(string url1)
        {
            bool t = false;
            WebRequest req = WebRequest.Create(url1);
            WebResponse res;
            try
            {
                res = req.GetResponse();
                t = true;
                this.TextBox1.Text = "";
            }
            catch
            {
                t = false;
            }
            return t;
        }
    }
}