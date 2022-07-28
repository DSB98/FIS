using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_4ASP_Practice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            if (FileToUpload.HasFile)
            {
                FileToUpload.SaveAs(@"C:\Deepak\"+FileToUpload.FileName);
                Msg.Text = "File uploadded succesfully";
                Msg.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Msg.Text = "File not selected";
                Msg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}