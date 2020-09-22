﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;


namespace production_management
{
    public partial class production_view : System.Web.UI.Page
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
                string ord_id= Request.QueryString["order_id"];
                string q = "select * from production where ord_id=" + ord_id;
                cmd = new SqlCommand(q, con);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                rpt.DataSource = dt;
                rpt.DataBind();

                hlink.NavigateUrl = "dispatch_material.aspx?ord_id=" + ord_id;
                lnkproduction.NavigateUrl = "production_add.aspx?ord_id=" + ord_id;

            }
        }
    }
}