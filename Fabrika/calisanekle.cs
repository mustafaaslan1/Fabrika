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

namespace Fabrika
{
    public partial class calisanekle : Form
    {
        public calisanekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASLAN\\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True");

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtSicil.Text)
                || string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text)) 
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (radioButton1.Checked)
                {
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into calisanekle (CalisanTC_NO,Sicil_NO,Ad,Soyad,Cinsiyet) " +
                        "values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                    ekle.Parameters.AddWithValue("@p1", txtTC.Text);
                    ekle.Parameters.AddWithValue("@p2", txtSicil.Text);
                    ekle.Parameters.AddWithValue("@p3", txtAd.Text);
                    ekle.Parameters.AddWithValue("@p4", txtSoyad.Text);
                    ekle.Parameters.AddWithValue("@p5", label7.Text);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Çalışan kişi kaydı yapıldı!");
                }
                else if (radioButton2.Checked)
                {
                    baglanti.Open();
                    SqlCommand ekle = new SqlCommand("insert into calisanekle (CalisanTC_NO,Sicil_NO,Ad,Soyad,Cinsiyet) " +
                        "values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                    ekle.Parameters.AddWithValue("@p1", txtTC.Text);
                    ekle.Parameters.AddWithValue("@p2", txtSicil.Text);
                    ekle.Parameters.AddWithValue("@p3", txtAd.Text);
                    ekle.Parameters.AddWithValue("@p4", txtSoyad.Text);
                    ekle.Parameters.AddWithValue("@p5", label7.Text);
                    ekle.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Çalışan kişi kaydı yapıldı!");
                }
                else
                {
                    MessageBox.Show("Lütfen bir seçenek seçimi yapın!", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void calisanekle_Load(object sender, EventArgs e)
        {
            txtTC.MaxLength = 11;
            txtSicil.MaxLength = 8;
            label7.Visible = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtSicil.Text = "";
            txtTC.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtTC.Focus();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            yoneticipanel eklecikar = new yoneticipanel();
            eklecikar.ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Kadın";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "Erkek";
        }
    }
}
