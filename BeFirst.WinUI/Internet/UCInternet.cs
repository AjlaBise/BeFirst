using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeFirst.WinUI.Internet
{
    public partial class UCInternet : UserControl
    {
        private readonly APIService _apiService = new APIService("Internet");

        public UCInternet()
        {
            InitializeComponent();
        }

        private async void UCInternet_Load(object sender, EventArgs e)
        {
            //calling API
            var result = await _apiService.Get<List<Models.Internet>>();

            dgvInternet.DataSource = result;

        }

        public async void Reload(object sender, EventArgs e)
        {
            UCInternet_Load(sender, e);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmDodajInternet frm = new frmDodajInternet(this);
            frm.Show();
        }

        private void dgvInternet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvInternet.SelectedRows[0].Cells[0].Value;

            frmUpdateDeleteInternet frm = new frmUpdateDeleteInternet(this, int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
