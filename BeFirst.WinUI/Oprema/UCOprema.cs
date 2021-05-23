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

namespace BeFirst.WinUI.Oprema
{
    public partial class UCOprema : UserControl
    {
        private readonly APIService _apiService = new APIService("Oprema");

        public UCOprema()
        {
            InitializeComponent();
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (txtPretraga.Text == "Pretraga po nazivu")
            {
                txtPretraga.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPretraga.Text))
                txtPretraga.Text = "";
        }

        private async void UCOprema_Load(object sender, EventArgs e)
        {
            string search = null;
            //calling API
            var result = await _apiService.Get<List<Models.Oprema>>(search);

            dgvOprema.DataSource = result;

            txtPretraga.Text = "";

            txtPretraga.GotFocus += RemoveText;
            txtPretraga.LostFocus += AddText;
        }

        public async void Reload(object sender, EventArgs e)
        {
            UCOprema_Load(sender, e);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajOpremu frm = new frmDodajOpremu(this);

            frm.Show();
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var search = new OpremaPretragaRequest()
            {
                Search = txtPretraga.Text
            };
            //calling API
            var result = await _apiService.Get<List<Models.Oprema>>(search);

            dgvOprema.DataSource = result;
        }

        private void dgvOprema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvOprema_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvOprema.SelectedRows[0].Cells[0].Value;

            frmUpdateDeleteOprema frm = new frmUpdateDeleteOprema(this, int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
