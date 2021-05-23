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

namespace BeFirst.WinUI.Uposlenici
{
    public partial class UCUposlenici : UserControl
    {
        private readonly APIService _apiService = new APIService("Uposlenik");

        public UCUposlenici()
        {
            InitializeComponent();
        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (txtPretraga.Text == "Pretraga po imenu, gradu, adresi..")
            {
                txtPretraga.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPretraga.Text))
                txtPretraga.Text = string.Empty;
        }
        private async void UCUposlenici_Load(object sender, EventArgs e)
        {
            string search = null;
            //calling API
            var result = await _apiService.Get<List<Models.Uposlenik>>(search);

            dgvUposlenici.DataSource = result;

            txtPretraga.Text = "";

            txtPretraga.GotFocus += RemoveText;
            txtPretraga.LostFocus += AddText;

        }

        public async void Reload(object sender, EventArgs e)
        {
            UCUposlenici_Load(sender, e);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new UposlenikPretragaRequest()
            {
                Search = txtPretraga.Text
            };
            //calling API
            var result = await _apiService.Get<List<Models.Uposlenik>>(search);

            dgvUposlenici.DataSource = result;
        }

        private void btnDodajUposlenika_Click(object sender, EventArgs e)
        {
            frmDodajUposlenika frm = new frmDodajUposlenika(this);

            frm.Show();
        }

        private void dgvUposlenici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvUposlenici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvUposlenici.SelectedRows[0].Cells[0].Value;

            frmUpdateDeleteUposlenik frm = new frmUpdateDeleteUposlenik(this, int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
