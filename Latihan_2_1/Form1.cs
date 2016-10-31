using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblMax_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBarAwal_Scroll(object sender, ScrollEventArgs e)
        {
            LblMin.Text = vScrollBarAwal.Value.ToString();
            DateTime Tanggal = DateTime.Now;
            string Jarak;
            if (vScrollBarAwal.Value > vScrollBarAkhir.Value)
            {
                vScrollBarAkhir.Value = vScrollBarAwal.Value;
            }

            LblMax.Hide();
            LblAkhir2.Text = vScrollBarAwal.Value.ToString();
            LblAkhir2.Show();
            Jarak = (vScrollBarAkhir.Value - vScrollBarAwal.Value).ToString();
            txtBox.Text = Jarak;
        }

        private void vScrollBarAkhir_Scroll(object sender, ScrollEventArgs e)
        {
            LblMax.Show();
            LblMax.Text = vScrollBarAkhir.Value.ToString();
            DateTime Tanggal = DateTime.Now;
            string Jarak;
            if (vScrollBarAwal.Value >= vScrollBarAkhir.Value)
            {
                vScrollBarAkhir.Value = vScrollBarAwal.Value;

            }
            Jarak = (vScrollBarAkhir.Value - vScrollBarAwal.Value).ToString();
            txtBox.Text = Jarak;
            int Jarak1 = (vScrollBarAkhir.Value - vScrollBarAwal.Value);
            if (vScrollBarAkhir.Value != vScrollBarAwal.Value)
            {
                dateTimePicker1.MinDate = Tanggal.AddYears(vScrollBarAkhir.Value - vScrollBarAwal.Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Jarak;
            DateTime Tanggal = DateTime.Now;
            Jarak = (vScrollBarAkhir.Value - vScrollBarAwal.Value).ToString();
            if (vScrollBarAkhir.Value != vScrollBarAwal.Value)
            {
                dateTimePicker1.MinDate = Tanggal.AddYears(vScrollBarAkhir.Value - vScrollBarAwal.Value);
            }
        }

        private void LblAkhir2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
