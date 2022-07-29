using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppPractice_Day5
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    DataSet db = new DataSet();
            //    db.ReadXml(Server.MapPath("~/EmployeeData2.xml"));
            //    GridEmp.DataSource = db;
            //    GridEmp.DataBind();
            //}
            //catch(System.IO.FileNotFoundException ff)
            //{
            //    ErrorLable.Text = "FIle Not FOund";
            //}

            DataSet db = new DataSet();
            db.ReadXml(Server.MapPath("~/EmployeeData2.xml"));
            GridEmp.DataSource = db;
            GridEmp.DataBind();
        }
    }
}