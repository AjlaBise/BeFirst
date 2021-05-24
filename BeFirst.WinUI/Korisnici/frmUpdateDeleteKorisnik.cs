using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Korisnici
{
    public partial class frmUpdateDeleteKorisnik : Form
    {
       
        private readonly APIService _apiService = new APIService("Korisnik");
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly APIService _apiPaketiService = new APIService("Paket");
        private readonly UCKorisnici _parent;

        private int? _id = null;

        public frmUpdateDeleteKorisnik(UCKorisnici parent, int? KorisnikId = null)
        {
            InitializeComponent();
            _id = KorisnikId;
            _parent = parent;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var request = new Korisnik()
            {
                Id = int.Parse(_id.ToString()),
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Adresa = txtAdresa.Text,
                Grad = txtGrad.Text,
                BrojTelefona = txtBrojTelefona.Text,
                Email = txtEmail.Text,
                Komentar = txtKomenatar.Text,
                DatumRodjenja = DateTime.Parse(dateTimePickerRodjenje.Text.ToString()),
                UgovorId = int.Parse(comboBoxUgovor.Text.ToString()),
                PaketId = int.Parse(comboBoxPaket.Text.ToString())

            };

            await _apiService.Update<Models.Korisnik>(_id, request);
            MessageBox.Show("Uspjesan update!");
            this.Close();
            _parent.Reload(this, EventArgs.Empty);
        }

        private async void btnUkloni_Click(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                await _apiService.Delete<bool>(_id);
                MessageBox.Show("Uspjesno obrisano!");
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
        }

        private async void frmUpdateDeleteKorisnik_Load(object sender, EventArgs e)
        {
            await LoadVrstaUgovora();
            await LoadVrstaPaketa();

            if (_id.HasValue)
            {
                var korisnik = await _apiService.GetById<Models.Korisnik>(_id);

                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtAdresa.Text = korisnik.Adresa;
                txtGrad.Text = korisnik.Grad;
                txtBrojTelefona.Text = korisnik.BrojTelefona;
                txtEmail.Text = korisnik.Email;
                txtKomenatar.Text = korisnik.Komentar;
                dateTimePickerRodjenje.Text = korisnik.DatumRodjenja.ToString();
                comboBoxUgovor.Text = korisnik.UgovorId.ToString();
                comboBoxPaket.Text = korisnik.PaketId.ToString();
            };
        }

        private async Task LoadVrstaUgovora()
        {
            var result = await _apiUgovorService.Get<List<Models.Ugovor>>(null);
            result.Insert(0, new Models.Ugovor());

            comboBoxUgovor.DataSource = result;
            comboBoxUgovor.DisplayMember = "Id";
            comboBoxUgovor.ValueMember = "Id";
        }

        private async Task LoadVrstaPaketa()
        {
            var result = await _apiPaketiService.Get<List<Models.Paket>>(null);
            result.Insert(0, new Models.Paket());

            comboBoxPaket.DataSource = result;
            comboBoxPaket.DisplayMember = "Id";
            comboBoxPaket.ValueMember = "Id";
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider1.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtAdresa, null);
            }
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrad.Text))
            {
                errorProvider1.SetError(txtGrad, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtGrad, null);
            }
        }

        private void txtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            string telefon = txtBrojTelefona.Text;
            Regex regex = new Regex(@"^\d+$");
            Match match = regex.Match(telefon);

            if (!match.Success)
            {
                errorProvider1.SetError(txtBrojTelefona, Properties.Resources.brojTelefona_invalid);
                e.Cancel = true;
            }
            else if (string.IsNullOrWhiteSpace(txtBrojTelefona.Text))
            {
                errorProvider1.SetError(txtBrojTelefona, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtBrojTelefona, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.email_invalid);
                e.Cancel = true;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void comboBoxUgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxUgovor.Text))
            {
                errorProvider1.SetError(comboBoxUgovor, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBoxUgovor, null);
            }
        }

        private void comboBoxPaket_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxPaket.Text))
            {
                errorProvider1.SetError(comboBoxPaket, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBoxPaket, null);
            }
        }
    }
}

