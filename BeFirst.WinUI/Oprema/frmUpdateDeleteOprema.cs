﻿using System;
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
    public partial class frmUpdateDeleteOprema : Form
    {
        private readonly APIService _apiService = new APIService("Oprema");
        private readonly UCOprema _parent;

        private int? _id = null;

        public frmUpdateDeleteOprema(UCOprema parent, int? OpremaId = null)
        {
            InitializeComponent();
            _id = OpremaId;
            _parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new BeFirst.Models.Oprema()
                {
                    Id = int.Parse(_id.ToString()),
                    Naziv = txtNaziv.Text,
                    BrojKomada = int.Parse(txtBrojKomada.Text.ToString()),
                    Cijena = int.Parse(txtCijena.Text.ToString()),
                    NaStanju = checkBoxNaStanju.Checked


                };

                await _apiService.Update<Models.Oprema>(_id, request);
                MessageBox.Show("Uspjesan update!");
                this.Close();
                _parent.Reload(this, EventArgs.Empty);
            }
        }

        private async void frmUpdateDeleteOprema_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var oprema = await _apiService.GetById<Models.Oprema>(_id);

                txtNaziv.Text = oprema.Naziv;
                txtBrojKomada.Text = oprema.BrojKomada.ToString();
                txtCijena.Text = oprema.Cijena.ToString();
                checkBoxNaStanju.Checked = oprema.NaStanju;


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
