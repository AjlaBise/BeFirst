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
    public partial class frmUpdateDeletePaket : Form
    {
        private readonly APIService _apiService = new APIService("Paket");
        private readonly APIService _apiUgovorService = new APIService("Ugovor");
        private readonly APIService _apiInternetService = new APIService("Internet");
        private readonly APIService _apiVrstaService = new APIService("VrstaPaketa");

        private readonly UCPaketi _parent;

        private int? _id = null;

        public frmUpdateDeletePaket(UCPaketi parent, int? PaketId = null)
        {
            InitializeComponent();
            _id = PaketId;
            _parent = parent;
        }

        private async void frmUpdateDeletePaket_Load(object sender, EventArgs e)
        {
            await LoadVrstaInterneta();
            await LoadVrstaUgovora();
            await LoadVrstaPaketa();

            if (_id.HasValue)
            {
                var paketi = await _apiService.GetById<Models.Paket>(_id);

                chBxCaTv.Checked = paketi.CaTv;
                comboBoxInternet.Text = paketi.InternetId.ToString();
                comboBoxUgovor.Text = paketi.UgovorId.ToString();
                comboBoxVrsta.Text = paketi.PaketNamjenaId.ToString();

            };
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            var request = new Paket()
            {
                Id = int.Parse(_id.ToString()),
                CaTv = chBxCaTv.Checked,
                InternetId= (int)comboBoxInternet.SelectedValue,
                UgovorId= (int)comboBoxUgovor.SelectedValue,
                PaketNamjenaId = (int)comboBoxVrsta.SelectedValue,


            };

            await _apiService.Update<Models.Paket>(_id, request);
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

        private async Task LoadVrstaInterneta()
        {
            var result = await _apiInternetService.Get<List<Models.Internet>>(null);
     

            comboBoxInternet.DataSource = result;
            comboBoxInternet.DisplayMember = "Id";
            comboBoxInternet.ValueMember = "Id";
        }

        private async Task LoadVrstaUgovora()
        {
            var result = await _apiUgovorService.Get<List<Models.Ugovor>>(null);
       

            comboBoxUgovor.DataSource = result;
            comboBoxUgovor.DisplayMember = "Id";
            comboBoxUgovor.ValueMember = "Id";
        }

        private async Task LoadVrstaPaketa()
        {
            var result = await _apiVrstaService.Get<List<Models.VrstaPaketa>>(null);
         

            comboBoxVrsta.DataSource = result;
            comboBoxVrsta.DisplayMember = "Naziv";
            comboBoxVrsta.ValueMember = "Id";
        }

        private void chBxCaTv_Validating(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
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
