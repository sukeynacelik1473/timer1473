using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TİMER_ÖRNEK1473
{
    
    public partial class Form1 : Form
    {
        int sayac = 10;
        DateTime zaman2 = new DateTime(2024, 01, 09, 11, 40, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Yellow;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void lblSayac_Click(object sender, EventArgs e)
        {
            sayac++;
            lblSayac.Text = sayac.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            TimeSpan fark = zaman2 - DateTime.Now;

            lblSayac.Text=$"{fark.Minutes} : {fark.Seconds}";
        }
    }
}
