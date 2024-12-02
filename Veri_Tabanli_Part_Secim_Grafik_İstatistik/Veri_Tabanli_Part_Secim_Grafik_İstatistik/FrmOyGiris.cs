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

namespace Veri_Tabanli_Part_Secim_Grafik_İstatistik
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBSECIMPROJE;Integrated Security=True");

        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO TBLILCE VALUES (@p1,@p2,@p3,@p4,@p5,@p6)",con);
            cmd.Parameters.AddWithValue("@p1",TxtIlceAd.Text);
            cmd.Parameters.AddWithValue("@p2",TxtA.Text);
            cmd.Parameters.AddWithValue("@p3",TxtB.Text);
            cmd.Parameters.AddWithValue("@p4",TxtC.Text);
            cmd.Parameters.AddWithValue("@p5",TxtD.Text);
            cmd.Parameters.AddWithValue("@p6",TxtE.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
