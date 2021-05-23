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

namespace BeFirst.WinUI.Zahtjevi
{
    public partial class frmDodajOdgovor : Form
    {
        private readonly APIService _apiService = new APIService("Zahtjev");
        private readonly UCZahtjevi _parent;
        private int? _id = null;

        public frmDodajOdgovor(UCZahtjevi parent, int? ZahtjevId = null)
        {
            InitializeComponent();
            _id = ZahtjevId;
            _parent = parent;
        }

        private async void frmDodajOdgovor_Load(object sender, EventArgs e)
        {

            if (_id.HasValue)
            {
                var zahtjev = await _apiService.GetById<Models.Zahtjev>(_id);

                txtNaslov.Text = zahtjev.Naslov;
                richTextBoxZahjtev.Text = zahtjev.Opis;
                txtKorisnik.Text = zahtjev.KorisnikId.ToString();
                checkBoxOdgovoreno.Checked = zahtjev.Odgovoreno.Value;
                checkBoxPOgledano.Checked = zahtjev.Pogledno.Value;
                rtbOdgovor.Text = zahtjev.Odgovor;
            };
        }

        private async void btnOdgovori_Click(object sender, EventArgs e)
        {
            var request = new Zahtjev()
            {
                Id = int.Parse(_id.ToString()),
                KorisnikId = int.Parse(txtKorisnik.Text.ToString()),
                Naslov = txtNaslov.Text,
                Opis = richTextBoxZahjtev.Text,
                Odgovoreno = checkBoxOdgovoreno.Checked,
                Pogledno = checkBoxPOgledano.Checked,
                Odgovor = rtbOdgovor.Text
            };
           

            await _apiService.Update<Models.Zahtjev>(_id, request);
            MessageBox.Show("Odgovoreno!");
            this.Close();
            _parent.Reload(this, EventArgs.Empty);
        }
    }
}
