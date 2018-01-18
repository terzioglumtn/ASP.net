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
    public partial class Reservation : System.Web.UI.Page
    {
        int sayac = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            //rezer();
            //Button5.Enabled = true;
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = this.Calendar1.SelectedDate.ToShortDateString();

        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = this.Calendar2.SelectedDate.ToShortDateString();

        }
        //void rezer()
        //{
        //    ListBox3.Items.Clear();

        //    ListBox3.Items.Add(">>>>> Mevcut Rezervasyonlarınız <<<<<");
        //    SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Rez"].ConnectionString);
        //    string sorgu = "Select * from Rezer where rezervasyon_adi='" + "'ORDER BY aracno DESC";
        //    SqlCommand cmd = new SqlCommand(sorgu, cnn);
        //    cnn.Open();

        //    SqlDataReader oku = cmd.ExecuteReader();



        //    while (oku.Read())

        //    {
        //        ListBox3.Items.Add("Tarihi: " + oku["rezervasyon_tarih"].ToString() + " \n");
        //    }

        //    //cnn.Close();
        //}
        protected void Button5_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();

            int.Parse(this.Calendar1.SelectedDate.Day.ToString());

            SqlConnection baglanti = new SqlConnection(" database=Cars; Integrated security=SSPI; MultipleActiveResultSets=True");
            baglanti.Open();



            DateTime dt1 = new DateTime();
            for (int i = int.Parse(this.Calendar1.SelectedDate.Day.ToString()); i < int.Parse(this.Calendar2.SelectedDate.Day.ToString()); i++)
            {
                sayac += 1;
            }
            Response.Write(sayac);
            string[] dizi = new string[sayac];
            int say = 0;
            for (int i = int.Parse(this.Calendar1.SelectedDate.Day.ToString()); i <= int.Parse(this.Calendar2.SelectedDate.Day.ToString()); i++)
            {

                dizi[say] = i + "." + this.Calendar1.SelectedDate.Month.ToString() + "." + this.Calendar1.SelectedDate.Year.ToString();
                say += 1;


            }
            //cnn.Close();
            for (int i = 0; i < dizi.Length; i++)
            {
                SqlCommand can = new SqlCommand("Select * from Rezer where aracno='" + DropDownList3.SelectedIndex + 1 + "'and rezervasyon_tarih='" + dizi[i] + "'", baglanti);

                SqlDataReader okuu = can.ExecuteReader();



                if (okuu.Read())

                {
                    ListBox1.Items.Add(okuu["rezervasyon_tarih"].ToString() + " ");
                }

                else
                {
                    ListBox2.Items.Add(dizi[i] + " Tarihine Rezervasyonunuz Alınmıştır.");
                    string komut = "insert into Rezer (aracno,durum,rezervasyon_adi,rezervasyon_tarih,odeme_turu) values ('" + DropDownList3.SelectedIndex + 1 + "','" + DropDownList3.Text + "','" + "Rezerve Edildi" + "','" /*+ _default.girisad + "','"*/ + dizi[i] + "','" + DropDownList4.Text + "')";
                    SqlCommand cmdd = new SqlCommand(komut, baglanti);
                    cmdd.ExecuteNonQuery();
                    //cnn.Open();



                    Label9.Text = "Uygun Tarih Aralığına Rezervasyon Yapılmıştır";
                    //cnn.Close();
                }
            }

            
                
                baglanti.Close();
                //rezer();
        }

        
        protected void Button7_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();

            int.Parse(this.Calendar1.SelectedDate.Day.ToString());

            SqlConnection baglanti = new SqlConnection(" database=Cars; Integrated security=SSPI; MultipleActiveResultSets=True");
            baglanti.Open();



            DateTime dt1 = new DateTime();
            for (int i = int.Parse(this.Calendar1.SelectedDate.Day.ToString()); i < int.Parse(this.Calendar2.SelectedDate.Day.ToString()); i++)
            {
                sayac += 1;
            }

            Response.Write(sayac);
            string[] dizi = new string[sayac];
            int say = 0;
            for (int i = int.Parse(this.Calendar1.SelectedDate.Day.ToString()); i <= int.Parse(this.Calendar2.SelectedDate.Day.ToString()); i++)
            {

                dizi[say] = i + "." + this.Calendar1.SelectedDate.Month.ToString() + "." + this.Calendar1.SelectedDate.Year.ToString();
                say += 1;


            }
            
            for (int i = 0; i < dizi.Length; i++)
            {
                
                SqlCommand com = new SqlCommand("Select * from Rezer where aracno='" + DropDownList3.SelectedIndex + 1 + "'and rezervasyon_tarih='" + dizi[i] + "'", baglanti);
               
                SqlDataReader oku = com.ExecuteReader();



                if (oku.Read())

                {
                    ListBox1.Items.Add(oku["rezervasyon_tarih"].ToString() + " ");
                }

                else
                {
                   ListBox2.Items.Add(dizi[i] + "");


                }

                
            }

            baglanti.Close();
            Button5.Enabled = true;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}
