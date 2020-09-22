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
    public partial class purchaseadd : System.Web.UI.Page
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
                txtRaw.DataSource = dtraw;
                txtRaw.DataValueField = "raw_id";
                txtRaw.DataTextField = "name";
                txtRaw.DataBind();
            }
            //************************

            //*************** bind dropdown vendor
            if (!IsPostBack)
            {
                string qv = "select * from vendor";
                cmd = new SqlCommand(qv, con);

                SqlDataAdapter adpvendor = new SqlDataAdapter(cmd);
                DataSet dsvendor = new DataSet();
                adpvendor.Fill(dsvendor);

                DataTable dtvendor = new DataTable();
                dtvendor = dsvendor.Tables[0];
                txtVendor.DataSource = dtvendor;
                txtVendor.DataValueField = "vendor_id";
                txtVendor.DataTextField = "name";
                txtVendor.DataBind();
            }
            //************************


        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string qty = txtQty.Text;
            string user_id = "2";
            string raw_id = txtRaw.SelectedValue;
            string vendor_id = txtVendor.SelectedValue;
            string purch_date = txtDate.Text;

            string q = "insert into purchase(quantity,user_id,raw_id,vendor_id,purch_date) values('" +
                qty+ "','" +
                user_id + "','" +
                raw_id + "','" +
                vendor_id + "','" +
                purch_date + "')";

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Inserted ";


        }

    }
}