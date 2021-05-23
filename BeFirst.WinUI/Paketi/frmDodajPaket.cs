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

namespace BeFirst.WinUI.Paketi
{
    public partial class frmDodajPaket : Form
    {
        private readonly APIService _apiService = new APIService("Paket");
        private readonly APIService _apiInternetService = new APIService("Internet");
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly APIService _apiVrstaService = new APIService("VrstaPaketa");
        private readonly UCPaketi _parent;

        public frmDodajPaket(UCPaketi parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private async void frmDodajPaket_Load(object sender, EventArgs e)
        {
            await LoadVrstaInterneta();
            await LoadVrstaUgovora();
            await LoadVrstaPaketa();
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                var request = new Paket()
                {
                    CaTv = chBoxVaTv.Checked,
                    InternetId = (int)comboBoxInternet.SelectedValue,
                    UgovorId = (int)comboBoxUgovor.SelectedValue,
                    PaketNamjenaId = (int)comboBoxVrsta.SelectedValue,
                };

                await _apiService.Insert<Models.Paket>(request);
                MessageBox.Show("Uspjesno dodato!");
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
        }

        private async Task LoadVrstaInterneta()
        {
            var result = await _apiInternetService.Get<List<Models.Internet>>(null);
            result.Insert(0, new Models.Internet());

            comboBoxInternet.DataSource = result;
            comboBoxInternet.DisplayMember = "Naziv";
            comboBoxInternet.ValueMember = "Id";
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
            var result = await _apiVrstaService.Get<List<Models.VrstaPaketa>>(null);
            result.Insert(0, new Models.VrstaPaketa());

            comboBoxVrsta.DataSource = result;
            comboBoxVrsta.DisplayMember = "Naziv";
            comboBoxVrsta.ValueMember = "Id";
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

        private void comboBoxVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
