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
    public partial class kargogörüntüle : Form
    {
        public kargogörüntüle()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=DESKTOP-QPC87EO;Initial Catalog=kargotakip;Integrated Security=True;Encrypt=False";
        SqlConnection baglan = new SqlConnection(constring);
        public void kayitlarigetir()
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            string getir = "Select * from kargoekle ";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void kargogörüntüle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kargotakipDataSet.kargoekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kargoekleTableAdapter.Fill(this.kargotakipDataSet.kargoekle);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kayitlarigetir();
        }
        public void verisil(int id)
        {
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            string sil = "Delete From  kargoekle Where ID = @id";
            SqlCommand komut = new SqlCommand(sil, baglan);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayitlarigetir();
                MessageBox.Show("Başarıyla silindi");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ANASAYFA geri = new ANASAYFA();
            geri.Show();
            this.Close();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kayit = "Select * from kargoekle where  kullanici_adi=@kullanici_adi";
            SqlCommand komut = new SqlCommand(kayit,baglan);
            komut.Parameters.AddWithValue("@kullanici_adi",textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
    }
}
