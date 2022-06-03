using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT.SPSS
{
    public partial class DaftarBahanJadi : Form
    {
        List<BahanJadi> listBahanJadi = new List<BahanJadi>();
        public DaftarBahanJadi()
        {
            InitializeComponent();
        }

        private void DaftarBahanJadi_Load(object sender, EventArgs e)
        {
            listBahanJadi = BahanJadi.BacaData("", "");

            if (listBahanJadi.Count > 0)
            {
                dataGridViewBahanJadi.DataSource = listBahanJadi;
            }
            else
            {
                dataGridViewBahanJadi.DataSource = null;
            }

            dataGridViewBahanJadi.AllowUserToAddRows = false;
            dataGridViewBahanJadi.ReadOnly = true;
        }
    }
}
