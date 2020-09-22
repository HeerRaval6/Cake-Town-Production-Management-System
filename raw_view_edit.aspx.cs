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
    public partial class raw_view_edit : System.Web.UI.Page
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

                string raw_id = Request.QueryString["raw_id"];

                string q = "select * from raw_material where raw_id=" + raw_id;
                
                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();

                dt = ds.Tables[0];

                txtName.Text = dt.Rows[0]["name"].ToString();
                txtRawtype.Text = dt.Rows[0]["type_raw"].ToString();
                txtStock.Text = dt.Rows[0]["stock"].ToString();
                }


        }
        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string typeraw = txtRawtype.Text;
            string stock = txtStock.Text;

            string raw_id = Request.QueryString["raw_id"];

            string q = "update raw_material set name='" + name + 
            "', type_raw='" + typeraw +
            "',stock='" + stock +
            "'where raw_id=" + raw_id;
            


            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Updated ";


        }

    }
}