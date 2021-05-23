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
    public partial class UC_PregledKorisnika_ : UserControl
    {
        private readonly APIService _apiService = new APIService("Korisnik");

        public UC_PregledKorisnika_()
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
                txtPretraga.Text = "";
        }

        private async void UC_PregledKorisnika__Load(object sender, EventArgs e)
        {
           
            //calling API
            var result = await _apiService.Get<List<Models.Korisnik>>();

            dgvPregledKorisnika.DataSource = result;

            txtPretraga.Text = "";

            txtPretraga.GotFocus += RemoveText;
            txtPretraga.LostFocus += AddText;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var search = new KorisnikPretragaRequest()
            {
                Search = txtPretraga.Text
            };
            //calling API
            var result = await _apiService.Get<List<Models.Korisnik>>(search);

            dgvPregledKorisnika.DataSource = result;
        }

        private void dgvPregledKorisnika_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvPregledKorisnika.SelectedRows[0].Cells[0].Value;

            frmPregledDetalja frm = new frmPregledDetalja(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}