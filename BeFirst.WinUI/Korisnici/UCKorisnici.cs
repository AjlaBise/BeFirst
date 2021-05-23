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

namespace BeFirst.WinUI.Korisnici
{
    public partial class UCKorisnici : UserControl
    {
        private APIService _apiService = new APIService("Korisnik");
  
        public UCKorisnici()
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
        

        private async void UCKorisnik_Load(object sender, EventArgs e)
        {
            string search = null;
            //calling API
            var result = await _apiService.Get<List<Models.Korisnik>>(search);

            dgvKorisnici.DataSource = result;

            txtPretraga.Text = string.Empty;

            txtPretraga.GotFocus += RemoveText;
            txtPretraga.LostFocus += AddText;
        }

        public async void Reload(object sender, EventArgs e)
        {
            UCKorisnik_Load(sender, e);
        }

        private async void btnPrikazi_ClickAsync(object sender, EventArgs e)
        {
            var search = new KorisnikPretragaRequest()
            {
                Search = txtPretraga.Text
            };
            //calling API
            var result = await _apiService.Get<List<Models.Korisnik>>(search);

            dgvKorisnici.DataSource = result;
        }

        private void btnAddKorisnik_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika frmDodaj = new frmDodajKorisnika(this);

            frmDodaj.Show();
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;

            frmUpdateDeleteKorisnik frm = new frmUpdateDeleteKorisnik(this, int.Parse(id.ToString()));
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}