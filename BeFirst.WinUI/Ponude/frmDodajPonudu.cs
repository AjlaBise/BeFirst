using BeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Ponude
{
    public partial class frmDodajPonudu : Form
    {
        private readonly APIService _apiService = new APIService("Ponuda");
        private readonly UCPonuda _parent;


        public frmDodajPonudu(UCPonuda parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var request = new Ponuda()
                {
                    Naziv = txtNaziv.Text,
                    Opis = txtOpis.Text,
                };


                await _apiService.Insert<Models.Ponuda>(request);
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
