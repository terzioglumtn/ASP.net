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
    public partial class Cars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cars"].ConnectionString);

            string sorgu = "Select * from Bilgiler";
            SqlCommand cmd = new SqlCommand(sorgu, cnn);

            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            lstCars.DataSource = dr;
            lstCars.DataBind();

            cnn.Close();
        }
    }
}