using BeFirst.Models;
using BeFirst.Models.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Izvještaji
{
    public partial class frmIzvjestaj : Form
    {
        private readonly APIService _apiService = new APIService("Report");
        private readonly APIService _apiServiceRadniNalogSum = new APIService("Report/GetRadniNalogSum");
        private readonly APIService _apiServiceGetBrojOprema = new APIService("Report/GetBrojOprema");

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            txtMjesec.Text = DateTime.Now.Month.ToString();
            txtGodina.Text = DateTime.Now.Year.ToString();
        }
  
        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGodina.Text) || string.IsNullOrEmpty(txtMjesec.Text))
                return;

            var search = new ReportSearchRequest()
            {
                Month = Int16.Parse(txtMjesec.Text),
                Year = Int16.Parse(txtGodina.Text)
            };


            var resultMonthAndYear = await _apiService.Get<int>(search);
            var resultUtroseniAlatUKM = await _apiServiceRadniNalogSum.Get<int>(search);
            var resultBrojIskoristeneOpreme = await _apiServiceGetBrojOprema.Get<int>(search);

            txtIntervencije.Text = resultMonthAndYear.ToString();
            txtIskoristenaOprema.Text = resultBrojIskoristeneOpreme.ToString();
            txtPotroseniAlat.Text = resultUtroseniAlatUKM.ToString();
        }
    }
}
