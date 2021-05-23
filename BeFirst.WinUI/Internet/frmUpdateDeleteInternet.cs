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
    public partial class frmUpdateDeleteInternet : Form
    {
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly APIService _apiService = new APIService("Internet");
        private readonly UCInternet _parent;

        private int? _id = null;

        public frmUpdateDeleteInternet(UCInternet parent, int? InternetId = null)
        {
            InitializeComponent();
            _id = InternetId;
            _parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new BeFirst.Models.Internet()
                {
                    Id = int.Parse(_id.ToString()),
                    Naziv = txtNaziv.Text,
                    Brzina = txtBrzina.Text,
                    Cijena = float.Parse(txtCijena.Text.ToString()),
                    Opis = txtOpis.Text,
                    UgovorId = (int)comboBoxUgovor.SelectedValue,


                };

                await _apiService.Update<Models.Internet>(_id, request);
                MessageBox.Show("Uspjesan update!");
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
        }

        private async void frmUpdateDeleteInternet_Load(object sender, EventArgs e)
        {
            await LoadVrstaUgovora();

            if (_id.HasValue)
            {
                var internet = await _apiService.GetById<Models.Internet>(_id);

                txtNaziv.Text = internet.Naziv;
                txtBrzina.Text = internet.Brzina;
                txtCijena.Text = internet.Cijena.ToString();
                txtOpis.Text = internet.Opis;
                comboBoxUgovor.Text = internet.UgovorId.ToString();


            };

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

        private async Task LoadVrstaUgovora()
        {
            var result = await _apiUgovorService.Get<List<Models.Ugovor>>(null);
            result.Insert(0, new Models.Ugovor());

            comboBoxUgovor.DataSource = result;
            comboBoxUgovor.DisplayMember = "Id";
            comboBoxUgovor.ValueMember = "Id";
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
