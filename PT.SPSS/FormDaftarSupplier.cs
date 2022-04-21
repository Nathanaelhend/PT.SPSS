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
    public partial class FormDaftarSupplier : Form
    {
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
    }
}
