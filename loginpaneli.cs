using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;   //  formu sqle bağlamak için bu kodu yazdım
using System.Data.SqlClient;

namespace KargoTakipOtomasonu2
{
    public partial class loginpaneli : Form
    {
        public loginpaneli()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QPC87EO;Initial Catalog=kargotakip;Integrated Security=True;Encrypt=False");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // burada bağlantıyı açtım
            SqlCommand komut = new SqlCommand("select * from Tbl_KargoTakip where kullanici_adi ='" + textBox1.Text + "' and sifre='" + textBox2.Text + "'", baglanti);//burada textboxları sqldeli değerlere bağladım
            SqlDataReader dr = komut.ExecuteReader();// bu komutla sql komutunu çalıştırdım
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Hoşgeldiniz");// eğer şifre doğruysa girdi

                ANASAYFA frm = new ANASAYFA(); // buraya yeni bir method tanımladım 
                frm.Show();// oluşturduğum methodla show komutunu kullanarak admin paneli formunu açıcak eğer şifre doğruysa
                textBox1.Clear();// ve textbox1 ve 3 ü temizlettirrdim
                textBox2.Clear();

            }


            else
            {
                MessageBox.Show("Tekrar deneyiniz");// şifre yanlış olduğunda da bizi uyardı 


            }
            baglanti.Close(); // bağlantı close diyerek de bağlantıyı kapattım
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { textBox2.PasswordChar = '\0'; }
            else { textBox2.PasswordChar = '*'; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

       
    }
}
