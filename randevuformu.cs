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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KargoTakipOtomasonu2
{
    public partial class randevuformu : Form
    {
        public randevuformu()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-QPC87EO;Initial Catalog=kargotakip;Integrated Security=True;Encrypt=False";
        SqlConnection baglan = new SqlConnection(constring);


        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
                string kayit = "insert into tbl_randevuekleme (ID, randevusaati) values (@ID,@randevusaati)";
                SqlCommand komut = new SqlCommand(kayit, baglan);
                komut.Parameters.AddWithValue("@ID", textBoxTrackNo.Text);
                 //komut.Parameters.AddWithValue("@dtarih", DateTime.Parse(dateTimePicker1.Text));
                komut.Parameters.AddWithValue("@randevusaati", comboBox1.Text);
              
               
                
                

                komut.ExecuteNonQuery();
                MessageBox.Show("randevu başarıyla oluşturuldu");
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

        private void button1_Click(object sender, EventArgs e)
        {

            ANASAYFA geri = new ANASAYFA();
            geri.Show();
            this.Close();
            this.Hide();
        }
    }
}
    

