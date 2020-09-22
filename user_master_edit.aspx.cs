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
    public partial class user_master_edit : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();

            if (!IsPostBack)
            {
                string user_id = Request.QueryString["user_id"];

                string q = "select * from user_master where user_id=" + user_id;

                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                txtName.Text = dt.Rows[0]["name"].ToString();
                txtPhone.Text = dt.Rows[0]["contact"].ToString();
                txtEmail.Text = dt.Rows[0]["email"].ToString();
                txtUsertype.Text = dt.Rows[0]["user_type"].ToString();
                TxtPassword.Text = dt.Rows[0]["password"].ToString();
                
            }

        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string usertype = txtUsertype.Text;
            string password = TxtPassword.Text;

            string user_id = Request.QueryString["user_id"];

            string q = "update user_master set name='" + name +
            "'email='" + email + 
            "',contact='" + phone + 
            "',user_type='" + usertype + 
            "',password='" + password +
            "'where user_id=" + user_id;


            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Inserted ";


        }

    }
}