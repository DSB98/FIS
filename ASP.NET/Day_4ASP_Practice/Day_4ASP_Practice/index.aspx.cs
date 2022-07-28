using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_4ASP_Practice
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnTrnasfer_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx",false);
        }

        protected void BtnExecute_Click(object sender, EventArgs e)
        {
            Server.Execute("Home.aspx");
        }
    }
}