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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            yoneticigiris yonetici = new yoneticigiris();
            yonetici.ShowDialog();
            this.Close();
        }

        private void btnCalisan_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisangiris calisan = new calisangiris();
            calisan.ShowDialog();
            this.Close();
        }
    }
}
