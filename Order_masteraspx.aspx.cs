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
    public partial class Order_masteraspx : System.Web.UI.Page
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
            //************************

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

            string q = "insert into order_master(order_date, product_id, quantity, est_date, user_id, customer_id, complete ) values('" +
                orderdate + "','" +
                product + "','" +
                quantity + "','" +
                estimatedate + "','" +
                user_id + "','" +
                name + "','" +
               complete + "')";

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Inserted ";


        }
    }
}