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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fabrika
{
    public partial class calisanislem : Form
    {
        public calisanislem()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;
        string yon = "K";
        string[] hareket = { "M", "L", "R" };

        SqlConnection baglanti = new SqlConnection("Data Source=ASLAN\\SQLEXPRESS;Initial Catalog=Fabrika;Integrated Security=True");
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void calisanislem_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'fabrikaDataSet1.robot' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.robotTableAdapter.Fill(this.fabrikaDataSet1.robot);
            comboYon.Items.Add("K");
            comboYon.Items.Add("G");
            comboYon.Items.Add("D");
            comboYon.Items.Add("B");
            txtAlan.MaxLength = 5;
            txtX.MaxLength = 5;
            txtY.MaxLength = 5;
            txtHareket.CharacterCasing = CharacterCasing.Upper;
        }

        private BindingList<Point> hareketListesi = new BindingList<Point>();
        private void HareketEttir(string hareketler)
        {
            int x = Convert.ToInt32(txtX.Text);
            int y = Convert.ToInt32(txtY.Text);
            string yon = comboYon.SelectedItem.ToString();

            foreach (char hareket in hareketler)
            {
                switch (hareket)
                {
                    case 'M':
                        if (yon == "K")
                            y += 1;
                        else if (yon == "G")
                            x -= 1;
                        else if (yon == "D")
                            x += 1;
                        else if (yon == "B")
                            y -= 1;
                        break;
                    case 'L':
                        if (yon == "K")
                            yon = "B";
                        else if (yon == "B")
                            yon = "G";
                        else if (yon == "G")
                            yon = "D";
                        else if (yon == "D")
                            yon = "K";
                        break;
                    case 'R':
                        if (yon == "K")
                            yon = "D";
                        else if (yon == "D")
                            yon = "G";
                        else if (yon == "G")
                            yon = "B";
                        else if (yon == "B")
                            yon = "K";
                        break;
                }

                hareketListesi.Add(new Point(x, y));
                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO robot (X_Konumu, Y_Konumu) VALUES (@p1, @p2)", baglanti);
                komut.Parameters.AddWithValue("@p1", x);
                komut.Parameters.AddWithValue("@p2", y);
                komut.ExecuteNonQuery();
                baglanti.Close();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hareketListesi;
            }
        }

        private void btnKonumlandır_Click(object sender, EventArgs e)
        {
            int xBaslangic = Convert.ToInt32(txtX.Text);
            int yBaslangic = Convert.ToInt32(txtY.Text);

            SqlCommand konum = new SqlCommand("insert into robot (X_Konumu, Y_Konumu) values (@p1, @p2)", baglanti);
            baglanti.Open();
            konum.Parameters.AddWithValue("@p1", xBaslangic);
            konum.Parameters.AddWithValue("@p2", yBaslangic);
            konum.ExecuteNonQuery();
            baglanti.Close();

            this.robotTableAdapter.Fill(this.fabrikaDataSet1.robot);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.fabrikaDataSet1.robot;
        }

        private void btnHareket_Click(object sender, EventArgs e)
        {
            string hareketler = txtHareket.Text;
            HareketEttir(hareketler);
            this.robotTableAdapter.Fill(this.fabrikaDataSet1.robot);
            dataGridView1.DataSource = this.fabrikaDataSet1.robot;
        }
    }
}
