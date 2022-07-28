using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_4ASP_Practice
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Method 1: 

            //System.Collections.Specialized.NameValueCollection collection = Request.Form;
            //LblUsername.Text = collection["Username"];
            //LblEmail.Text = collection["Email"];

            //Method 2:
            //Using PreviousPage

            //Page pp = Page.PreviousPage;
            //if (pp != null)
            //{
            //    LblUsername.Text = ((TextBox)pp.FindControl("Username")).Text;
            //    LblEmail.Text = ((TextBox)pp.FindControl("Email")).Text;
            //}

            //3. Execute method

            System.Collections.Specialized.NameValueCollection collection = Request.Form;
            LblUsername.Text = collection["Username"];
            LblEmail.Text = collection["Email"];


        }
    }
}