using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeFirst.Models.Requests;

namespace BeFirst.WinUI.Izvještaji
{
    public partial class UCIzvjestaji : UserControl
    {
        public UCIzvjestaji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIzvjestaj frm = new frmIzvjestaj();
            frm.Show();
        }
    }
}
