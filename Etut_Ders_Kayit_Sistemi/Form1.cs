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
using System.IO;

namespace Etut_Ders_Kayit_Sistemi
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=faruk\\sqlexpress;Initial Catalog=EtutTest;Integrated Security=True;");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistele();
            etutListele();
        }

        void derslistele()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBLDERSLER", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbo_Ders.ValueMember = "DERSID";
            cmbo_Ders.DisplayMember = "DERSAD";
            cmbo_Ders.DataSource = dt;
            conn.Close();
        }

        void etutListele()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("Execute sp_ETUT", conn);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }

        private void cmbo_Ders_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da2 = new SqlDataAdapter("Select * from TBLOGRETMEN where BRANSID=" + cmbo_Ders.SelectedValue, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbo_ogrt.ValueMember = "OGRTID";
            cmbo_ogrt.DataSource = dt2;

            cmbo_ogrt.Format += new ListControlConvertEventHandler(cmbo_ogrt_Format);
        }

        private void cmbo_ogrt_Format(object sender, ListControlConvertEventArgs e)
        {
            // öğretmen soyad ekleme bölümü
            // daha sonra yukarıya ekledim

            DataRowView row = (DataRowView)e.ListItem;
            e.Value = row["AD"] + " " + row["SOYAD"];
        }

        private void btn_etutolustur_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@P1,@P2,@P3,@P4)", conn);
            cmd.Parameters.AddWithValue("@P1", cmbo_Ders.SelectedValue);
            cmd.Parameters.AddWithValue("@P2", cmbo_ogrt.SelectedValue);
            cmd.Parameters.AddWithValue("@P3", mask_tarih.Text);
            cmd.Parameters.AddWithValue("@P4", mask_saat.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Ders Kayıt Edildi");
            etutListele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txt_etutid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void Btn_fotoekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@P1,@P2,@P3,@P4,@P5,@P6)", conn);
            cmd.Parameters.AddWithValue("@P1", txt_ogrciad.Text);
            cmd.Parameters.AddWithValue("@P2", txt_ogrcisoyad.Text);
            cmd.Parameters.AddWithValue("@P3", pictureBox1.ToString());
            cmd.Parameters.AddWithValue("@P4", txt_ogrciSinif.Text);
            cmd.Parameters.AddWithValue("@P5", msk_telno.Text);
            cmd.Parameters.AddWithValue("@P6", txt_ogrciMail.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Öğrenci Sisteme Eklenmiştir","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_dersEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLDERSLER (DERSAD) values (@P1)",conn);
            cmd.Parameters.AddWithValue("@P1", txt_dersAdi.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Ders Sisteme Eklenmiştir !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@P1,@P2,@P3)", conn);
            cmd.Parameters.AddWithValue("@P1",txt_ogtmenAd.Text);
            cmd.Parameters.AddWithValue("@P2",txt_ogtmenSoyad.Text);
            cmd.Parameters.AddWithValue("@P3", txt_ders.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Ders Sisteme Eklenmiştir !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
