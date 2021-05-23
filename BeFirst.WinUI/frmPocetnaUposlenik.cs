using BeFirst.WinUI.Izvještaji;
using BeFirst.WinUI.Korisnici;
using BeFirst.WinUI.Zahtjevi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI
{
    public partial class frmPocetnaUposlenik : Form
    {

        static frmPocetnaUposlenik _obj;

        public static frmPocetnaUposlenik Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmPocetnaUposlenik();
                }
                return _obj;
            }
        }


        public void ShowControl(Control control)
        {
            PnlContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            PnlContainer.Controls.Add(control);
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public frmPocetnaUposlenik()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPocetna_Click(object sender, EventArgs e)
        {
            panelTracker.Width = btnPocetna.Width;
            panelTracker.Left = btnPocetna.Left;

            UCPocetnaUposlenik ucd = new UCPocetnaUposlenik();

            ShowControl(ucd);
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            panelTracker.Width = btnIzvjestaji.Width;
            panelTracker.Left = btnIzvjestaji.Left;

            UCIzvjestaji ucd = new UCIzvjestaji();

            ShowControl(ucd);
        }

        private void btnZahtjevi_Click(object sender, EventArgs e)
        {
            panelTracker.Width = btnZahtjevi.Width;
            panelTracker.Left = btnZahtjevi.Left;

            UCZahtjevi ucd = new UCZahtjevi();

            ShowControl(ucd);
        }

        private void btnKorisnici_Click(object sender, EventArgs e)
        {
            panelTracker.Width = btnKorisnici.Width;
            panelTracker.Left = btnKorisnici.Left;

            UC_PregledKorisnika_ ucd = new UC_PregledKorisnika_();

            ShowControl(ucd);
        }
    }
}
