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
    public partial class calisancikar : Form
    {
        public calisancikar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASLAN\\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True");


        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void calisancikar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'fabrikaDataSet.calisanekle' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.calisanekleTableAdapter.Fill(this.fabrikaDataSet.calisanekle);
            txtTC.MaxLength = 11;

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            yoneticipanel eklecikar = new yoneticipanel();
            eklecikar.ShowDialog();
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand ara = new SqlCommand("Select * From calisanekle Where CalisanTC_NO = @a1", baglanti);
            ara.Parameters.AddWithValue("@a1", txtTC.Text);
            SqlDataReader reader = ara.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                baglanti.Close();
                MessageBox.Show("Bilgi Bulundu.");
                this.calisanekleTableAdapter.Fill(this.fabrikaDataSet.calisanekle);
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Bilgi Bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.calisanekleTableAdapter.Fill(this.fabrikaDataSet.calisanekle);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text))
            {
                MessageBox.Show("Önce çalışan kişinin TC'sini girmelisiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand sil = new SqlCommand("Delete From calisanekle Where CalisanTC_NO = @k1", baglanti);
                sil.Parameters.AddWithValue("@k1", txtTC.Text);
                sil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi!");
                txtTC.Text = "";

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;

                txtTC.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.calisanekleTableAdapter.Fill(this.fabrikaDataSet.calisanekle);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.fabrikaDataSet.calisanekle;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
