using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Udemy.Restaurant.Business.Workers;
using Udemy.Restaurant.Entities.Enums;
using Udemy.Restaurant.Entities.Tables;

namespace Udemy.Restaurant.UI.BackOffice.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public bool Secildi = false;
        public Entities.Tables.Tanim tanimEntity;
        public FrmTanim(TanimTip tanimTip)
        {
            InitializeComponent();
            worker.TanimService.Load(c => c.TanimTip == tanimTip);
            gridControlTanim.DataSource = worker.TanimService.BindingList();
            TanimBinding();
        }
        void TanimBinding()
        {
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();

            txtTanim.DataBindings.Add("Text", tanimEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", tanimEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void controlMenu_SecClick(object sender, EventArgs e)
        {
            Secildi = true;
            tanimEntity = (Entities.Tables.Tanim)gridTanim.GetFocusedRow();
            Close();
        }
        private void controlMenu_EkleClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            groupTanimBilgi.Visible = true;
            tanimEntity = new Entities.Tables.Tanim();
            tanimEntity.Id = Guid.NewGuid();
            TanimBinding();
        }

        private void controlMenu_DuzenleClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            groupTanimBilgi.Visible = true;
            tanimEntity = (Entities.Tables.Tanim)gridTanim.GetFocusedRow();

        }

        private void controlMenu_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridTanim.DeleteSelectedRows();
            }
        }

        private void controlMenu_KaydetClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = false;
            groupTanimBilgi.Visible = false;
            worker.TanimService.AddOrUpdate(tanimEntity);
        }

        private void controlMenu_VazgecClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = false;
            groupTanimBilgi.Visible = false;
        }

        private void controlMenu_KapatClick(object sender, EventArgs e)
        {
            Close();
        }

    }
}