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
    public partial class vender_add : System.Web.UI.Page
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
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string fax = txtFax.Text;
            string typeraw = txtRawtype.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string pincode = txtPin.Text;

            string q = "insert into vendor(name,address,email,contact,fax,type_raw,city,state,pin) values('" +
                name + "','" +
                address + "','" +
                email + "','" +
                 phone + "','" +
                fax + "','" +
                typeraw + "','" +
                city + "','" +
                state + "','" +
                pincode + "')";


            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();


            lblmsg.Text = " Record Inserted ";


        }
    }
}