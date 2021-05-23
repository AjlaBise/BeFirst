using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Oprema
{
    public partial class frmDodajOpremu : Form
    {
        private readonly APIService _apiService = new APIService("Oprema");
        private readonly UCOprema _parent;

        public frmDodajOpremu(UCOprema parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {

                var request = new BeFirst.Models.Oprema()
                {
                    Naziv = txtNaziv.Text,
                    BrojKomada = int.Parse(txtBrojKomada.Text.ToString()),
                    Cijena = int.Parse(txtCijena.Text.ToString()),
                    NaStanju = checkBoxNaStanju.Checked

                };

                await _apiService.Insert<Models.Oprema>(request);
                MessageBox.Show("Uspješno dodato!");
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

        private void txtBrojKomada_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrojKomada.Text))
            {
                errorProvider.SetError(txtBrojKomada, "Polje mora biti u brojčanom obliku!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtBrojKomada, null);
            }
        }

        private void txtCijena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCijena.Text))
            {
                errorProvider.SetError(txtCijena, "Polje mora biti u brojčanom obliku!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCijena, null);
            }
        }
    }
}
