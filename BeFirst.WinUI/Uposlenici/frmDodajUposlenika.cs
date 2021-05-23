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

namespace BeFirst.WinUI.Uposlenici
{
    public partial class frmDodajUposlenika : Form
    {
        private readonly APIService _apiService = new APIService("Uposlenik");
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly APIService _apiPozicijaService = new APIService("Pozicija");
        private readonly UCUposlenici _parent;

        public frmDodajUposlenika(UCUposlenici parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSpremiUposlenika_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new Uposlenik()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Adresa = txtAdresa.Text,
                    Grad = txtGrad.Text,
                    BrojTelefona = txtBrojTelefona.Text,
                    Email = txtEmail.Text,
                    Plata = int.Parse(txtPlata.Text.ToString()),
                    PozicijaId = comboBoxPozicija.SelectedIndex,
                    UgovorId = comboBoxUgovor.SelectedIndex,
                    Aktivan = chBxAktivan.Checked,

                };

                await _apiService.Insert<Models.Uposlenik>(request);
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
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

        private void txtPlata_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlata.Text))
            {
                errorProvider.SetError(txtPlata, "Polje mora biti u brojčanom obliku!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPlata, null);
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

        private async Task LoadVrstaUgovora()
        {
            var result = await _apiUgovorService.Get<List<Models.Ugovor>>(null);
            result.Insert(0, new Models.Ugovor());

            comboBoxUgovor.DataSource = result;
            comboBoxUgovor.DisplayMember = "Naziv";
            comboBoxUgovor.ValueMember = "Id";
        }

        private async Task LoadPozicija()
        {
            var result = await _apiPozicijaService.Get<List<Models.Pozicija>>(null);
            result.Insert(0, new Models.Pozicija());

            comboBoxPozicija.DataSource = result;
            comboBoxPozicija.DisplayMember = "Naziv";
            comboBoxPozicija.ValueMember = "Id";
        }
        private async void frmDodajUposlenika_Load(object sender, EventArgs e)
        {
            await LoadVrstaUgovora();
            await LoadPozicija();
        }

      

        private void comboBoxPozicija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxPozicija.Text))
            {
                errorProvider.SetError(comboBoxPozicija, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(comboBoxPozicija, null);
            }
        }
    }
}
