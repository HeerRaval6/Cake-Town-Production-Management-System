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
    public partial class Process_master : System.Web.UI.Page
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
            //*************** bind dropdown vendor
            if (!IsPostBack)
            {
                string qr = "select * from products";
                cmd = new SqlCommand(qr, con);

                SqlDataAdapter adpproducts = new SqlDataAdapter(cmd);
                DataSet dsproducts = new DataSet();
                adpproducts.Fill(dsproducts);

                DataTable dtproducts = new DataTable();
                dtproducts = dsproducts.Tables[0];
                txtPname.DataSource = dtproducts;
                txtPname.DataValueField = "product_id";
                txtPname.DataTextField = "name";
                txtPname.DataBind();
            }
            //************************
            //*************** bind dropdown raw 
            if (!IsPostBack)
            {
                string qr = "select * from raw_material";
                cmd = new SqlCommand(qr, con);

                SqlDataAdapter adpraw = new SqlDataAdapter(cmd);
                DataSet dsraw = new DataSet();
                adpraw.Fill(dsraw);

                DataTable dtraw = new DataTable();
                dtraw = dsraw.Tables[0];
                txtRawtype.DataSource = dtraw;
                txtRawtype.DataValueField = "raw_id";
                txtRawtype.DataTextField = "name";
                txtRawtype.DataBind();
            }
            //************************
        }
         protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string productname = txtPname.SelectedValue;
            string rawtype = txtRawtype.SelectedValue;
            string quantity = txtQty.Text;

            string q = "insert into process(product_id, raw_id, quantity ) values('" +
               productname + "','" +
               rawtype + "','" +
               quantity + "')" ;

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Inserted ";

        }
    }
}