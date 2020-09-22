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
    public partial class production_add : System.Web.UI.Page
    {
         SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();

            
            //**   if (Session["user_id"] == null)
            //**   {
            //**       Response.Redirect("login/login.aspx");
            //**   }


            if (!IsPostBack)
            {
                txtOrder.Text = Request.QueryString["ord_id"];
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string date = txtDate.Text;
            string order_id = txtOrder.Text;
            string finishqty = txtFqty.Text;
            string wastage = txtWastage.Text;

            //string user_id = Session["user_id"].ToString();
            string user_id = "1";

                string q = "insert into production(date,ord_id,user_id,finishqty,wastage) values('" +
                date + "','" +
                order_id + "','" +
                user_id + "','" + 
                finishqty + "','" +
                wastage + "')";

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();

            DataTable dt = bindrecords("select * from order_master where order_id=" + order_id);
            float oqty = float.Parse(dt.Rows[0]["quantity"].ToString());
            float complete= float.Parse(dt.Rows[0]["complete"].ToString());

            float ans = float.Parse(finishqty) * 100 / oqty;
            string updatequery = "update order_master set complete = complete + " + ans + " where order_id=" + order_id;
            cmd = new SqlCommand(updatequery, con);
            cmd.ExecuteNonQuery();

            Response.Redirect("order_pending.aspx");


        }


        public DataTable bindrecords(string q)
        {
            cmd = new SqlCommand(q, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return dt;
        }

    }
}