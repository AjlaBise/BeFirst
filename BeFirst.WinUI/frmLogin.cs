using BeFirst.Models.Requests;
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
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Account");

        public frmLogin()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private async void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.KorisnickoIme = txtKorisnickoIme.Text;
                APIService.Password = txtLozinka.Text;


                var request = new AuthenticateRequest()
                {
                    Username = APIService.KorisnickoIme,
                    Password = APIService.Password
                };

                var ac = await _service.InsertWithoutAuth<Models.Account>(request);

                if (ac != null)
                {
                    if (ac.Uloga.Id == 3)
                    {
                        await _service.Get<dynamic>(null);

                        frmPocetnaUposlenik frm = new frmPocetnaUposlenik();
                        frm.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                        frm.Show();
                        Hide();
                    }
                    else if (ac.Uloga.Id == 1)
                    {
                        await _service.Get<dynamic>(null);

                        frmPocetnaAdministrator frm = new frmPocetnaAdministrator();
                        frm.FormClosed += new FormClosedEventHandler(frmLogin_FormClosed);
                        frm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Netacni podaci ili nemate permisije!");
                    }

                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji ! ");
                    txtKorisnickoIme.Text = "";
                    txtLozinka.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Podaci nisu ispravni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }
    }
}
