using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace production_management
{
    public partial class customer_view : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();

            if (Session["user_id"] == null)
            {
                Response.Redirect("login/login.aspx");
            }

            //************ delete coding
            if (Request.QueryString["cust_id"] != null)
            {
                string qdel = "delete from customer where cust_id=" + Request.QueryString["cust_id"];
                cmd = new SqlCommand(qdel, con);
                cmd.ExecuteNonQuery();
            }
            //******************

            if (!IsPostBack)
            {

                string q = "select * from customer";
                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                rpt.DataSource = dt;
                rpt.DataBind();


            }
        }
    }
}