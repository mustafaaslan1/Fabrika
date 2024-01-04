using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fabrika
{
    public partial class yoneticipanel : Form
    {
        public yoneticipanel()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisanekle ekle = new calisanekle();
            ekle.ShowDialog();
            this.Close();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisancikar cikar = new calisancikar();
            cikar.ShowDialog();
            this.Close();
        }
    }
}
