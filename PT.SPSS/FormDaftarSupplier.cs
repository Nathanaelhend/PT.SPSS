using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SPSS_LIB;

namespace PT.SPSS
{
    public partial class FormDaftarSupplier : Form
    {
        List<Supplier> listSupplier = new List<Supplier>();
        public FormDaftarSupplier()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormEntrySupplier formEntrySup = new FormEntrySupplier();
            formEntrySup.Owner = this;
            formEntrySup.Show();
        }

        private void FormDaftarSupplier_Load(object sender, EventArgs e)
        {
            listSupplier = Supplier.BacaData("", "");

            if (listSupplier.Count > 0)
            {
                dataGridViewSupplier.DataSource = listSupplier;
            }
            else
            {
                dataGridViewSupplier.DataSource = null;
            }

            dataGridViewSupplier.AllowUserToAddRows = false;
            dataGridViewSupplier.ReadOnly = true;
        }
    }
}
