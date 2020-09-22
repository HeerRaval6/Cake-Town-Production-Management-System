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
    public partial class purchase_edit : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                string qv = "select * from raw_material";
                cmd = new SqlCommand(qv, con);

                SqlDataAdapter adpraw = new SqlDataAdapter(cmd);
                DataSet dsraw = new DataSet();
                adpraw.Fill(dsraw);

                DataTable dtraw= new DataTable();
                dtraw= dsraw.Tables[0];
                txtRaw.DataSource = dtraw;
                txtRaw.DataValueField = "raw_id";
                txtRaw.DataTextField = "name";
                txtRaw.DataBind();
            }

            if (!IsPostBack)
            {
                string purch_id = Request.QueryString["purch_id"];
                string qr = "select * from purchase  where purch_id=" + purch_id;
                cmd = new SqlCommand(qr, con);

                SqlDataAdapter adppurch = new SqlDataAdapter(cmd);
                DataSet dspurch = new DataSet();
                adppurch.Fill(dspurch);

                DataTable dtpurch = new DataTable();
                dtpurch = dspurch.Tables[0];

                txtQty.Text = dtpurch.Rows[0]["quantity"].ToString();
                txtRaw.Text = dtpurch.Rows[0]["raw_id"].ToString();
                txtVendor.Text = dtpurch.Rows[0]["vendor_id"].ToString();
                txtDate.Text = dtpurch.Rows[0]["purch_date"].ToString();
            }
            

        }

            protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string qty = txtQty.Text;
            string user_id = Session["user_id"].ToString();
            string raw_id = txtRaw.SelectedValue;
            string vendor_id = txtVendor.SelectedValue;
            string purchase_date = txtDate.Text;

            string purch_id = Request.QueryString["purch_id"];

            string q = "update purchase set quantity='" + qty +
            "',user_id='" + user_id + 
            "',raw_id='" + raw_id +
            "',vendor_id='" + vendor_id + 
            "',purch_date='" + purchase_date +
            "'where purch_id=" +  purch_id;
;

            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Updated";


        }
        
        }
  }
