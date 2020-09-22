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
    public partial class product_add : System.Web.UI.Page
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

 
        }
         protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string productname = txtName.Text;
            string productsize = txtSize.Text;
            string productflavour = txtFlavour.Text;

            string user_id = Session["user_id"].ToString();
     
             string q = "insert into products(name,size,flavous,user_id) values('" +
                productname+ "','" +
                productsize+ "','" +
                productflavour+ "','" +
                user_id + "')";



             cmd = new SqlCommand(q, con);
             cmd.ExecuteNonQuery();


             lblmsg.Text = " Record Inserted ";


        }
    }
}