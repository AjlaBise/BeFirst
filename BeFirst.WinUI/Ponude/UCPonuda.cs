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

namespace BeFirst.WinUI.Ponude
{
    public partial class UCPonuda : UserControl
    {
        private readonly APIService _apiService = new APIService("Ponuda");

        public UCPonuda()
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

        public  void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPretraga.Text))
                txtPretraga.Text = "";
        }

        private async void UCPonuda_Load(object sender, EventArgs e)
        {
            string search = null;
            //calling API
            var result = await _apiService.Get<List<Models.Ponuda>>(search);

            dgvPonuda.DataSource = result;

            txtPretraga.Text = "";

            txtPretraga.GotFocus += RemoveText;
            txtPretraga.LostFocus += AddText;
        }

        public async void Reload(object sender, EventArgs e)
        {
            UCPonuda_Load(sender, e);
        }

        private void btnDodajPonudu_Click(object sender, EventArgs e)
        {
            frmDodajPonudu frm = new frmDodajPonudu(this);

            frm.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new PonudaPretragaRequest()
            {
                Search = txtPretraga.Text
            };
            //calling API
            var result = await _apiService.Get<List<Models.Ponuda>>(search);

            dgvPonuda.DataSource = result;
        }

        private void dgvPonuda_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPonuda.SelectedRows[0].Cells[0].Value;

            frmUpdateDeletePonuda frm = new frmUpdateDeletePonuda(this, int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
