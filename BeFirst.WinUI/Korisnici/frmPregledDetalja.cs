using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Korisnici
{
    public partial class frmPregledDetalja : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");

        private int? _id = null;

        public frmPregledDetalja(int? KorisnikId = null)
        {
            InitializeComponent();
            _id = KorisnikId;
        }

        private async void frmPregledDetalja_Load(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Models.Korisnik>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtAdresa.Text = korisnik.Adresa;
                txtGrad.Text = korisnik.Grad;
                txtBrojTelefona.Text = korisnik.BrojTelefona;
                txtEmail.Text = korisnik.Email;
                txtKomentar.Text = korisnik.Komentar;
                txtDatumRodjenja.Text = korisnik.DatumRodjenja.ToString();
                txtUgovor.Text = korisnik.UgovorId.ToString();
                txtPaket.Text = korisnik.PaketId.ToString();
            };
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
