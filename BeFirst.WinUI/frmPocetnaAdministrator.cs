using BeFirst.WinUI.Internet;
using BeFirst.WinUI.Korisnici;
using BeFirst.WinUI.Oprema;
using BeFirst.WinUI.Paketi;
using BeFirst.WinUI.Ponude;
using BeFirst.WinUI.Uposlenici;
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
    public partial class frmPocetnaAdministrator : Form
    {

        static frmPocetnaAdministrator _obj;

        public static frmPocetnaAdministrator Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frmPocetnaAdministrator();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }


        public void ShowControl(Control control)
        {
            PnlContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            PnlContainer.Controls.Add(control);
        }
        public frmPocetnaAdministrator()
        {
            InitializeComponent();
        }

        private void buttonPocetna_Click(object sender, EventArgs e)
        {
            panelTracker.Height = buttonPocetna.Height;
            panelTracker.Top = buttonPocetna.Top;

            UCPocetna ucd = new UCPocetna();

            ShowControl(ucd);
        }

        private void buttonUposlenici_Click(object sender, EventArgs e)
        {
            panelTracker.Height = buttonUposlenici.Height;
            panelTracker.Top = buttonUposlenici.Top;

            UCUposlenici uce = new UCUposlenici();

            ShowControl(uce);


        }

        private void buttonKorisnici_Click(object sender, EventArgs e)
        {
            panelTracker.Height = buttonKorisnici.Height;
            panelTracker.Top = buttonKorisnici.Top;

            UCKorisnici ucc = new UCKorisnici();

            ShowControl(ucc);
        }

        private void buttonPonuda_Click(object sender, EventArgs e)
        {
            panelTracker.Height = buttonPonuda.Height;
            panelTracker.Top = buttonPonuda.Top;

            UCPonuda ucc = new UCPonuda();

            ShowControl(ucc);
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {

        }

        private void btnPaketi_Click(object sender, EventArgs e)
        {
            panelTracker.Height = btnPaketi.Height;
            panelTracker.Top = btnPaketi.Top;

            UCPaketi ucc = new UCPaketi();

            ShowControl(ucc);
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {

            panelTracker.Height = btnInternet.Height;
            panelTracker.Top = btnInternet.Top;

           UCInternet ucc = new UCInternet();

            ShowControl(ucc);

        }

        private void btnOprema_Click(object sender, EventArgs e)
        {
            panelTracker.Height = btnOprema.Height;
            panelTracker.Top = btnOprema.Top;

            UCOprema ucc = new UCOprema();

            ShowControl(ucc);
        }

        private void panelTracker_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
