using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kdvhesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            int label2, label3;
            label2 = Convert.ToInt32(txturunfiyati.Text);
            label3 = Convert.ToInt32(txturunkdv.Text);
            int carpma;
            carpma = Label2 * label3;
            MessageBox.Show("hesapla="*carpma.ToString());

            txturunadi.Clear();
            txturunfiyati.Clear();
            txturunkdv.Clear();
        }
    }
}
