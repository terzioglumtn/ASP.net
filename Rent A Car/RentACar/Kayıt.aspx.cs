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
    public partial class Kayıt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnkayıt_Click(object sender, EventArgs e)
        {
            if (txtkullanici.Text != "" && txtsifre.Text != "")
            {
                SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cars"].ConnectionString);
                string sorgu = "Insert into Kullanici (KullaniciAdi,Sifre) Values (@kullaniciadi,@sifre)";
                SqlCommand cmd = new SqlCommand(sorgu, cnn);
                cnn.Open();

                try
                {
                    cmd.Parameters.AddWithValue("@kullaniciadi", txtkullanici.Text);
                    cmd.Parameters.AddWithValue("@sifre", txtsifre.Text);

                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    
                   

                    Session.Add("kullaniciadi", txtkullanici.Text);
                    lblkayıt.Text= "Başarıyla Kayıt Yapılmıştır.";
                }

                catch (Exception)
                {
                    lblkayıt.Text = "Maalesef, Kaydınız Yapılamamıştır";
                }
            }

            else
            {
                lblkayıt.Text = "Boş alanları doldurunuz!";
            }
        }
    }
    }
