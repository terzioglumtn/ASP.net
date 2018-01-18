using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RentACar
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["kullaniciadi"];
            if (kullanici != null)
            {
                pnlYorum.Visible = true;
                Panel1.Visible = false;
            }
            else
            {
                Panel1.Visible = true;
                pnlYorum.Visible = false;
            }

        }



        protected void btnYorum_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cars"].ConnectionString);
            string sorgu = "Insert into Yorumlar (Yorum) Values (@yorum)";
            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();
            cmd.Parameters.AddWithValue("@yorum", txtYorum.Text);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}