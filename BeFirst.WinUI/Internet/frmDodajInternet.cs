using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Internet
{
    public partial class frmDodajInternet : Form
    {
        private readonly APIService _apiService = new APIService("Internet");
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly UCInternet _parent;

        public frmDodajInternet(UCInternet parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new BeFirst.Models.Internet()
                {
                    Naziv = txtNaziv.Text,
                    Brzina = txtBrzina.Text,
                    Cijena = int.Parse(txtCijena.Text.ToString()),
                    Opis = txtOpis.Text,
                    UgovorId = comboBoxUgovor.SelectedIndex,

                };

                await _apiService.Insert<Models.Internet>(request);
                MessageBox.Show("Uspjesno dodato!");
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }

        }

        private async void frmDodajInternet_Load(object sender, EventArgs e)
        {
            await LoadVrstaUgovora();
        }

        private void txtUgovor_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text))
            {
                errorProvider.SetError(txtNaziv, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNaziv, null);
            }
        }

        private void txtBrzina_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrzina.Text))
            {
                errorProvider.SetError(txtBrzina, "Polje mora biti u brojčanom obliku ! ");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrzina, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text.ToString()))
            {
                errorProvider.SetError(txtCijena, "Polje mora biti u brojčanom obliku ! ");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }

        private void txtOpis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOpis.Text))
            {
                errorProvider.SetError(txtOpis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtOpis, null);
            }
        }


        private void txtUgovor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxUgovor.Text.ToString()))
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
    }
}
