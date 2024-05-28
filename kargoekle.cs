using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakipOtomasonu2
{
    public partial class kargoekle : Form
    {
        public kargoekle()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-QPC87EO;Initial Catalog=kargotakip;Integrated Security=True;Encrypt=False";
        SqlConnection baglan = new SqlConnection(constring);

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                string kayit = "insert into kargoekle (ID,kullanici_adi, teslimtipi, ödemetipi, adres, ürünaciklamasi, gönderilenil, alınacakil ,alıcı ,kargotipi ,ağırlık) values (@ID,@kullanici_adi,  @teslimtipi, @ödemetipi, @adres, @ürünaciklamasi, @gönderilenil,@alınacakil,@alıcı,@kargotipi,@ağırlık)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@ID", textBox3.Text);
                komut.Parameters.AddWithValue("@kullanici_adi", textBox1.Text);
               // komut.Parameters.AddWithValue("@gonderilentarih", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@teslimtipi", comboBoxDeliveryType.Text);
                komut.Parameters.AddWithValue("@ödemetipi", comboBoxPaymentType.Text);
                komut.Parameters.AddWithValue("@adres", textBoxAdress.Text);
                komut.Parameters.AddWithValue("@ürünaciklamasi", textBoxProductDetails.Text);
                komut.Parameters.AddWithValue("@gönderilenil", comboBox1.Text);
                komut.Parameters.AddWithValue("@alınacakil", comboBoxAlinanIl.Text);
                komut.Parameters.AddWithValue("@alıcı", textBoxReceiver.Text);
                komut.Parameters.AddWithValue("@kargotipi", comboBoxCargoType.Text);
                komut.Parameters.AddWithValue("@ağırlık", textBoxWeight.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("veriler Başarıyla Eklendi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata var: " + hata.Message);
            }
            finally
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ANASAYFA geri = new ANASAYFA();
            geri.Show();
            this.Close();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
             textBox1.Clear();


            textBoxAdress.Clear();


            textBoxReceiver.Clear();

            textBoxWeight.Clear();
        }
    }
}
