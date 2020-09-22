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
    public partial class order_edit : System.Web.UI.Page
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
                txtProd.DataSource = dtproducts;
                txtProd.DataValueField = "product_id";
                txtProd.DataTextField = "name";
                txtProd.DataBind();
            }
            //************************
            //*************** bind dropdown raw 
            if (!IsPostBack)
            {
                string qr = "select * from customer";
                cmd = new SqlCommand(qr, con);

                SqlDataAdapter adpcust = new SqlDataAdapter(cmd);
                DataSet dscust = new DataSet();
                adpcust.Fill(dscust);

                DataTable dtcust = new DataTable();
                dtcust = dscust.Tables[0];
                txtCustomer.DataSource = dtcust;
                txtCustomer.DataValueField = "cust_id";
                txtCustomer.DataTextField = "name";
                txtCustomer.DataBind();
            }
         
            if (!IsPostBack)
            {
                string order_id = Request.QueryString["order_id"];
                string q = "select * from order_master where order_id=" + order_id;
                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                txtCustomer.Text = dt.Rows[0]["customer_id"].ToString();
                 txtDate.Text = dt.Rows[0]["order_date"].ToString(); 
                txtProd.Text = dt.Rows[0]["product_id"].ToString();
                txtQuantity.Text = dt.Rows[0]["quantity"].ToString();
                TxtEdate.Text = dt.Rows[0]["est_date"].ToString();
            }

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtCustomer.SelectedValue;
            string orderdate = txtDate.Text;
            string product = txtProd.SelectedValue;
            string quantity = txtQuantity.Text;
            string estimatedate = TxtEdate.Text;

            string user_id = Session["user_id"].ToString();
            string complete = "0";

            string order_id = Request.QueryString["order_id"];

            string q = "update order_master set customer_id='" + name +
                "',order_date='" + orderdate +
                "',product_id='" + product +
                "',quantity='" + quantity+
                "',est_date='" + estimatedate +
                "',user_id='" + user_id +
                "',complete='" + complete +
                "' where order_id=" + order_id;           

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record updated ";


        }
    }
}