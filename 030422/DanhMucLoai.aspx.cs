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
    public partial class DanhMucLoai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                return;
            string q;
            if (Context.Items["madm"] == null)
                q = "select * from Hoa";
            else
                q="select * from Hoa where MaDM='"+ Context.Items["madm"].ToString()+"'";

            Ketnoi ketnoi=new Ketnoi();
            DataTable dt = ketnoi.laydulieu(q);

            this.DataList1.DataSource = dt;
            this.DataList1.DataBind();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {

        }
    }
}