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
    public partial class product_edit : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                string product_id = Request.QueryString["product_id"];

                string q = "select * from products where product_id=" + product_id;
                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                txtName.Text = dt.Rows[0]["name"].ToString();
                txtSize.Text = dt.Rows[0]["size"].ToString();
                txtFlavour.Text = dt.Rows[0]["flavous"].ToString();
                
            }

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string productname = txtName.Text;
            string productsize = txtSize.Text;
            string productflavour = txtFlavour.Text;

            string product_id = Request.QueryString["product_id"];
            string user_id = Session["user_id"].ToString();

            string q = "update products set name='" + productname +
            "',size='" + productsize +
            "',flavous='" + productflavour +
            "',user_id='" + user_id +
            "' where product_id=" + product_id;



            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record updated";


        }

    }
}