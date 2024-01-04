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
    public partial class yoneticigiris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=ASLAN\\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True");
        public yoneticigiris()
        {
            InitializeComponent();
        }
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen bütün alanları doldurun.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From yonetimgiris Where KullaniciAdi = @p1 and Sifre = @p2",baglanti);
                komut.Parameters.AddWithValue("@p1", txtTC.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    yoneticipanel yonetici = new yoneticipanel();
                    yonetici.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı TC veya Şifre girdiniz!","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                baglanti.Close();
            }
        }

        private void yoneticigiris_Load(object sender, EventArgs e)
        {
            txtTC.MaxLength = 11;
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            if (txtSifre.UseSystemPasswordChar)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }
    }
}
