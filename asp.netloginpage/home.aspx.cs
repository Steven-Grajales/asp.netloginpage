using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace asp.netloginpage
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccesMessage.Visible = false;
            lblErrorMessage.Visible = false;

            if (Session["username"] == null)
                Response.Redirect("login.aspx");
            lblUserDetails.Text = "Username: " + Session["username"];
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(local);initial Catalog=LoginDB;Integrated Security=True"))
            {
                string query;
                try
                {
                    sqlCon.Open();

                    query = "SELECT * FROM tblUser WHERE username = @username";
                    SqlCommand sqlCmdconsulta = new SqlCommand(query, sqlCon);
                    sqlCmdconsulta.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                    int count = Convert.ToInt32(sqlCmdconsulta.ExecuteScalar());

                    if (count > 0)
                    {
                        lblSuccesMessage.Visible = false;
                        lblErrorMessage.Visible = true;
                        txtUserName.Text = "";
                    }
                    else
                    {
                        query = "INSERT INTO tblUser(UserName, Password) VALUES (@username, @password)";
                        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                        sqlCmd.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Dispose();
                        sqlCon.Close();
                        lblErrorMessage.Visible = false;
                        lblSuccesMessage.Visible = true;
                        txtUserName.Text = "";
                    }
                }
                catch (Exception ex)
                {
                   
                }

            }
        }   
    }   
}