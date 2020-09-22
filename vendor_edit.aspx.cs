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
    public partial class vendor_edit : System.Web.UI.Page
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
                string vendor_id = Request.QueryString["vendor_id"];

                string q = "select * from vendor where vendor_id=" + vendor_id;

                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                txtName.Text = dt.Rows[0]["name"].ToString();
                txtPhone.Text = dt.Rows[0]["contact"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtAddress.Text = dt.Rows[0]["address"].ToString();
                txtFax.Text = dt.Rows[0]["fax"].ToString();
                txtRawtype.Text = dt.Rows[0]["type_raw"].ToString();
                txtCity.Text = dt.Rows[0]["city"].ToString();
                txtState.Text = dt.Rows[0]["state"].ToString();
                txtPin.Text = dt.Rows[0]["pin"].ToString();
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string fax = txtFax.Text;
            string typeraw = txtRawtype.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string pincode = txtPin.Text;

            string vendor_id = Request.QueryString["vendor_id"];

            string q = "update vendor set name,='" + name +
            "',address='" + address +
            "',email='" + email +
            "',contact='" + phone +
            "',fax='" + fax +
            "',type_raw='" + typeraw +
            "',city='" + city +
            "',state='" + state +
            "',pin='" + pincode +
            "' where vendor_id='" + vendor_id;

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Inserted ";


        }

       
    }
}