using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbNotKayit;Integrated Security=True");

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            DurumSorgula();

            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

        }

        private void BtnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) VALUES (@p1,@p2,@p3)", baglanti);
            cmd.Parameters.AddWithValue("@p1", MskNumara.Text);
            cmd.Parameters.AddWithValue("@p2", TxtAd.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
            DurumSorgula();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            LblOrtalama.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnSinavGuncelle_Click(object sender, EventArgs e)
        {
            string durum;
            double ortalama, s1, s2, s3;
            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            LblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("UPDATE TBLDERS SET OGRS1=@p1, OGRS2=@p2, OGRS3=@p3, ORTALAMA=@p4, DURUM=@p5 WHERE OGRNUMARA=@p6", baglanti);
            cmd.Parameters.AddWithValue("@p1", TxtSinav1.Text);
            cmd.Parameters.AddWithValue("@p2", TxtSinav2.Text);
            cmd.Parameters.AddWithValue("@p3", TxtSinav3.Text);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(LblOrtalama.Text));
            cmd.Parameters.AddWithValue("@p5", durum);
            cmd.Parameters.AddWithValue("@p6", MskNumara.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
            DurumSorgula();
        }

        public void DurumSorgula()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(CASE WHEN DURUM = 1 THEN 1 ELSE 0 END) AS DurumTrueSayisi,SUM(CASE WHEN DURUM = 0 THEN 1 ELSE 0 END) AS DurumFalseSayisi FROM TBLDERS", baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LblGecen.Text = dr[0].ToString();
                LblKalan.Text = dr[1].ToString();
            }
            baglanti.Close();
        }
    }
}
