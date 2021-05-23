using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Zahtjevi
{
    public partial class UCZahtjevi : UserControl
    {
        private readonly APIService _apiService = new APIService("Zahtjev");

        public UCZahtjevi()
        {
            InitializeComponent();
        }

        private async void UCZahtjevi_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Models.Zahtjev>>();

            dgvZahtjevi.DataSource = result;
        }

        public async void Reload(object sender, EventArgs e)
        {
            UCZahtjevi_Load(sender, e);
        }

        private void dgvZahtjevi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvZahtjevi.SelectedRows[0].Cells[0].Value;

            frmDodajOdgovor frm = new frmDodajOdgovor(this, int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
