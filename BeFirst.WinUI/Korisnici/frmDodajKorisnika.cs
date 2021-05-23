using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Korisnici
{
    public partial class frmDodajKorisnika : Form
    {
        private readonly APIService _apiService = new APIService("Korisnik");
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly APIService _apiPaketiService = new APIService("Paket");
        private readonly UCKorisnici _parent;

        public frmDodajKorisnika(UCKorisnici parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private async void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
            await LoadVrstaUgovora();
            await LoadVrstaPaketa();
        }

        private async void BtnSpremi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                var request = new Korisnik()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    Grad = txtGrad.Text,
                    BrojTelefona = txtBrojTelefona.Text,
                    Email = txtEmail.Text,
                    Komentar = txtKomenatar.Text,
                    DatumRodjenja = DateTime.Parse(dateTimePickerRodjenje.Text.ToString()),
                    UgovorId = comboBoxUgovor.SelectedIndex,
                    PaketId = int.Parse(comboBoxPaket.Text.ToString())

                };


                await _apiService.Insert<Models.Korisnik>(request);
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
             
        }

        private async Task LoadVrstaUgovora()
        {
            var result = await _apiUgovorService.Get<List<Models.Ugovor>>(null);
            result.Insert(0, new Models.Ugovor());

            comboBoxUgovor.DataSource = result;
            comboBoxUgovor.DisplayMember = "Naziv";
            comboBoxUgovor.ValueMember = "Id";
        }

        private async Task LoadVrstaPaketa()
        {
            var result = await _apiPaketiService.Get<List<Models.Paket>>(null);

            comboBoxPaket.DataSource = result;
            comboBoxPaket.DisplayMember = "Id";
            comboBoxPaket.ValueMember = "Id";
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

        private void txtAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                errorProvider.SetError(txtAdresa, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAdresa, null);
            }
        }

        private void txtGrad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrad.Text))
            {
                errorProvider.SetError(txtGrad, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGrad, null);
            }
        }

        private void txtBrojTelefona_Validating(object sender, CancelEventArgs e)
        {
            string telefon = txtBrojTelefona.Text;
            Regex regex = new Regex(@"^[1-9]");
            Match match = regex.Match(telefon);

            if (!match.Success)
            {
                errorProvider.SetError(txtBrojTelefona, Properties.Resources.brojTelefona_invalid);
                e.Cancel = true;
            }
            else if (string.IsNullOrWhiteSpace(txtBrojTelefona.Text))
            {
                errorProvider.SetError(txtBrojTelefona, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojTelefona, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
            {
                errorProvider.SetError(txtEmail, Properties.Resources.email_invalid);
                e.Cancel = true;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtDatumRodjenja_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dateTimePickerRodjenje.Text))
            {
                errorProvider.SetError(dateTimePickerRodjenje, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dateTimePickerRodjenje, null);
            }
        }

        private void comboBoxUgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxUgovor.Text))
            {
                errorProvider.SetError(comboBoxUgovor, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(comboBoxUgovor, null);
            }
        }

        private void comboBoxPaket_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxPaket.Text))
            {
                errorProvider.SetError(comboBoxPaket, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(comboBoxPaket, null);
            }
        }
    }
}
