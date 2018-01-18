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
    public partial class main : System.Web.UI.MasterPage
    {
        SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cars"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            YorumGöster();

            object kullanici = Session["kullaniciadi"];
            if (kullanici != null)
            {
                pnlGiris.Visible = false;
                pnlKullanici.Visible = true;
                lblKullaniciAdi.Text = kullanici.ToString();
            }
            else
            {
                pnlGiris.Visible = true;
                pnlKullanici.Visible = false;
            }

        }

        private void YorumGöster()
        {
            string sorgu = "Select * from Yorumlar";
            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cnn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            lstYorum.DataSource = dr;
            lstYorum.DataBind();
            cnn.Close();
        }

        protected void btnGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "Select * from Kullanici where KullaniciAdi=@kullaniciadi AND Sifre=@sifre";
            SqlCommand cmd = new SqlCommand(sorgu, cnn);
            cmd.Parameters.AddWithValue("@kullaniciadi", txtkullanici.Text);
            cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session.Timeout = 300;
                Session.Add("kullaniciadi", dr["kullaniciadi"].ToString());
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                lblkayıt.Text = "Giriş Yapılamadı";
            }
            cnn.Close();
        }

        protected void btnCıkıs_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect(Request.RawUrl);
        }

        protected void btnRez_Click(object sender,EventArgs e)
        {
            Response.Redirect("Reservation.aspx");
        }
    }

}