using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _030422
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;

            Ketnoi ketnoi=new Ketnoi();
            DataTable dt=ketnoi.laydulieu("select * from DanhMucHoa");

            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string madm = ((LinkButton)sender).CommandArgument;
            Context.Items["madm"] = madm;
            Server.Transfer("DanhMucLoai.aspx");
        }
    }
}