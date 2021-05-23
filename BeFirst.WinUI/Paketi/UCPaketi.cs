using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Paketi
{
    public partial class UCPaketi : UserControl
    {
        private readonly APIService _apiService = new APIService("Paket");

        public UCPaketi()
        {
            InitializeComponent();
        }

        private async void UCPaketi_Load(object sender, EventArgs e)
        {
            // calling API
            var result = await _apiService.Get<List<Models.Paket>>();
            dgvPaketi.DataSource = result;
        }

        public async void Reload(object sender, EventArgs e)
        {
            UCPaketi_Load(sender, e);
        }

        private void btnDodajPaket_Click(object sender, EventArgs e)
        {
            frmDodajPaket frm = new frmDodajPaket(this);
            frm.Show();
        }

        private void dgvPaketi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPaketi.SelectedRows[0].Cells[0].Value;

            frmUpdateDeletePaket frm = new frmUpdateDeletePaket(this, int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
