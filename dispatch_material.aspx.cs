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
    public partial class dispatch_material : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from temp", con);
            cmd.ExecuteNonQuery();

            string ord_id = Request.QueryString["ord_id"];
            string qord = "select * from order_master where order_id=" + ord_id;
            DataTable dtOrd = bindrecords(qord);
            string product_id = dtOrd.Rows[0]["product_id"].ToString();

            DataTable dtProcess = bindrecords("select * from process where product_id=" + product_id);
            float productionqty = float.Parse(txtqty.Text);

            for (int i =0;i<dtProcess.Rows.Count;i++){
                string raw_id = dtProcess.Rows[i]["raw_id"].ToString();
                float processqty= float.Parse(dtProcess.Rows[i]["quantity"].ToString());
                float req_qty = (processqty * productionqty) / 10;

                string qins = "insert into temp (raw_id,req_qty) values('" + raw_id + "','" + req_qty + "')";
                cmd = new SqlCommand(qins, con);
                cmd.ExecuteNonQuery();

            }

            string qtemp = "select t.*,r.name,r.type_raw,r.stock from temp t,raw_material r where t.raw_id=r.raw_id";
            DataTable dttemp = bindrecords(qtemp);
            rpt.DataSource = dttemp;
            rpt.DataBind();

            
        }

        public DataTable bindrecords(string q)
        {
            cmd = new SqlCommand(q, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            DataTable dt= new DataTable();
            dt = ds.Tables[0];
            return dt;
        }

        protected void btndispatch_Click(object sender, EventArgs e)
        {
            DataTable dtraw = bindrecords("select * from temp");

            for (int i = 0; i < dtraw.Rows.Count; i++)
            {
                string req_qty = dtraw.Rows[i]["req_qty"].ToString();
                string raw_id = dtraw.Rows[i]["raw_id"].ToString();

                string upd = "update raw_material set stock = stock -" + req_qty + " where raw_id=" + raw_id;
                cmd = new SqlCommand(upd, con);
                cmd.ExecuteNonQuery();
            }

            Response.Redirect("order_pending.aspx");


        }
    }
}