using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace production_management.Login
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

            string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();
            txtPassword.Text = "admin";

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string vusername = txtUser.Text;
            string vpassword = txtPassword.Text;

            string q = "select * from user_master where email='" + vusername + "' and password ='" + vpassword + "'" ;
            cmd = new SqlCommand(q, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            if(dt.Rows.Count>0)
            {
                Session["user_id"] = dt.Rows[0]["user_id"].ToString();
                Response.Redirect("../Customer_add.aspx");

            }
            else
            {
                lblmsg.Text = "Invalid email or password";
            }

        }
    }
}