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
    public partial class randevugörüntüle : Form
    {
        public randevugörüntüle()
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
            string getir = "Select * from tbl_randevuekleme ";
            SqlCommand komut = new SqlCommand(getir, baglan);
            SqlDataAdapter ad = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }
        private void randevugörüntüle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kargotakipDataSet3.tbl_randevuekleme' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_randevueklemeTableAdapter.Fill(this.kargotakipDataSet3.tbl_randevuekleme);
            // TODO: Bu kod satırı 'kargotakipDataSet2.tbl_randevuekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           
            // TODO: Bu kod satırı 'kargotakipDataSet1.tbl_randevuo' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            

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
            string sil = "Delete From  tbl_randevuekleme Where ID = @id";
            SqlCommand komut = new SqlCommand(sil, baglan);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
        private void buttonAppCancel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                verisil(id);
                kayitlarigetir();
                MessageBox.Show("Başarıyla iptal edildi");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ANASAYFA geri = new ANASAYFA();
            geri.Show();
            this.Close();
            this.Hide();
        }
    }
}
