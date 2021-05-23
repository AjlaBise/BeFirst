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

namespace BeFirst.WinUI.Ponude
{
    public partial class frmUpdateDeletePonuda : Form
    {
        private readonly APIService _apiService = new APIService("Ponuda");
        private readonly UCPonuda _parent;

        private int? _id = null;

        public frmUpdateDeletePonuda(UCPonuda parent, int? PonudaId = null)
        {
            InitializeComponent();
            _id = PonudaId;
            _parent = parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void frmUpdateDeletePonuda_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var ponuda = await _apiService.GetById<Models.Ponuda>(_id);

                txtNaziv.Text = ponuda.Naziv;
                txtOpis.Text = ponuda.Opis;
               
            };
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new Ponuda()
                {
                    Id = int.Parse(_id.ToString()),
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text
                };

                await _apiService.Update<Models.Ponuda>(_id, request);
                MessageBox.Show("Uspjesan update!");
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
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
    }
}
