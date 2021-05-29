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
        private MainError me = new MainError();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool t = true;
            if (this.TextBox1.Text == "")
            {
                me.e2 = "There is no input please input a search text";
                Session["e1"] = me;
                Response.Redirect("~/Error.aspx");
            }
            if (!this.TextBox1.Text.Contains("https://"))
            {
                me.e2 = "There is no https:// in the input so its showing an error which states that\nInvalid URI: The format of the URI could not be determined.\n To Resolve this please use https:// before the search query \n a valid search query is (https://www.google.com)";
                Session["e1"] = me;
                Response.Redirect("~/Error.aspx");
            }
            if(!this.TextBox1.Text.Contains("www."))
            {
                me.e2 = "There is no www. in the input so its showing an error which states that\nInvalid URI: The format of the URI could not be determined.\n To Resolve this please use www. after https:// and  before the search query \n a valid search query is (https://www.google.com)";
                Session["e1"] = me;
                Response.Redirect("~/Error.aspx");
            }
            if (!this.TextBox1.Text.Contains(".com"))
            {
                me.e2 = "There is no .com or .in or .org or .co in the input so its showing an error which states that\nInvalid URI: The format of the URI could not be determined.\n To Resolve this please use .com or and of the .in, .org etc. after the search query \n a valid search query is (https://www.google.com)";
                Session["e1"] = me;
                Response.Redirect("~/Error.aspx");
            }
            if (!this.TextBox1.Text.Contains("https://") && !this.TextBox1.Text.Contains(".www") && !this.TextBox1.Text.Contains(".com"))
            {
                me.e2 = "There is no https:// or www. or .com or .in or .org or .co in the input so its showing an error which states that\nInvalid URI: The format of the URI could not be determined.\n To Resolve this please use https:// at the start and www. before the search qury and  .com or and of the .in, .org etc. after the search query \n a valid search query is (https://www.google.com)";
                Session["e1"] = me;
                Response.Redirect("~/Error.aspx");
            }
            else
            {
                url = this.TextBox1.Text;
                t = urlExists(url);
                if (t == false)
                {
                    me.e2 = "HTTP 404. The resource you are looking for (or one of its dependencies) could have been removed, had its name changed, or is temporarily unavailabe.Please review the following URL and make sure that it is spelled correctly\n\n\n\n\nRequested URL is : "+url;
                    Session["e1"] = me;
                    Response.Redirect("~/Error.aspx");
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