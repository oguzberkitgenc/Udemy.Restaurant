using System;
using Udemy.Restaurant.Business.Workers;

namespace Udemy.Restaurant.UI.BackOffice.Urun
{
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            gridControlUrunler.DataSource = worker.UrunService.GetList(null, c => c.UrunGrup);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmUrunIslem ff = new frmUrunIslem(new Entities.Tables.Urun());
            ff.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }
    }
}