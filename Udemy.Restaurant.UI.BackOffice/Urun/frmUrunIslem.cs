﻿using System;
using System.Windows.Forms;
using Udemy.Restaurant.Business.Workers;
using Udemy.Restaurant.Entities.Enums;
using Udemy.Restaurant.Entities.Tables;
using Udemy.Restaurant.UI.BackOffice.Tanim;

namespace Udemy.Restaurant.UI.BackOffice.Urun
{
    public partial class frmUrunIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entities.Tables.Urun _urunEntity;
        private Porsiyon _porsiyonEntity;
        private EkMalzeme _ekMalzemeEntity;
        public frmUrunIslem(Entities.Tables.Urun urunEntity)
        {
            InitializeComponent();
            _urunEntity = urunEntity;
            if (_urunEntity.Id == Guid.Empty)
            {
                _urunEntity.Id = Guid.NewGuid();
            }
            worker.PorsiyonService.Load(c => c.UrunId == urunEntity.Id);
            gridControlPorsiyon.DataSource = worker.PorsiyonService.BindingList();
            worker.EkMalzemeService.Load(c => c.UrunId == urunEntity.Id);
            gridControlMalzeme.DataSource = worker.EkMalzemeService.BindingList();
            UrunBinding();
        }
        void UrunBinding()
        {
            txtBarkod.DataBindings.Clear();
            txtUrunAd.DataBindings.Clear();
            txtUrunAciklama.DataBindings.Clear();
            picUrunFoto.DataBindings.Clear();
            //Text, entity, varsayılan deger, ne zaman update?
            txtBarkod.DataBindings.Add("Text", _urunEntity, "Barkod", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUrunAd.DataBindings.Add("Text", _urunEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUrunAciklama.DataBindings.Add("Text", _urunEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            picUrunFoto.DataBindings.Add("EditValue", _urunEntity, "Fotograf", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void PorsiyonBindig()
        {
            txtPorsiyonAdi.DataBindings.Clear();
            txtPorsiyonFiyat.DataBindings.Clear();
            txtEkMalzemeCarpan.DataBindings.Clear();
            txtPorsiyonAciklama.DataBindings.Clear();

            txtPorsiyonAdi.DataBindings.Add("Text", _porsiyonEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPorsiyonFiyat.DataBindings.Add("Value", _porsiyonEntity, "Fiyat", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEkMalzemeCarpan.DataBindings.Add("Value", _porsiyonEntity, "EkMalzemeCarpan", false, DataSourceUpdateMode.OnPropertyChanged);
            txtPorsiyonAciklama.DataBindings.Add("Text", _porsiyonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void EkMalzemeBinding()
        {
            txtMalzemeAdi.DataBindings.Clear();
            txtMalzemeFiyat.DataBindings.Clear();
            txtMalzemeAciklama.DataBindings.Clear();

            txtMalzemeAdi.DataBindings.Add("Text", _ekMalzemeEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMalzemeFiyat.DataBindings.Add("Value", _ekMalzemeEntity, "Fiyat", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMalzemeAciklama.DataBindings.Add("Text", _ekMalzemeEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuPorsiyon_EkleClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = true;
            groupPorsiyonBilgi.Visible = true;
            _porsiyonEntity = new Porsiyon();
            _porsiyonEntity.UrunId = _urunEntity.Id;
            PorsiyonBindig();
        }

        private void controlMenuPorsiyon_DuzenleClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = true;
            groupPorsiyonBilgi.Visible = true;
            _porsiyonEntity = (Porsiyon)gridPorsiyon.GetFocusedRow();
            PorsiyonBindig();
        }

        private void controlMenuPorsiyon_KaydetClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = false;
            groupPorsiyonBilgi.Visible = false;
            worker.PorsiyonService.AddOrUpdate(_porsiyonEntity);
        }

        private void controlMenuPorsiyon_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridPorsiyon.DeleteSelectedRows();
            }
        }

        private void controlMenuPorsiyon_VazgecClick(object sender, EventArgs e)
        {
            controlMenuPorsiyon.KayitAc = false;
            groupPorsiyonBilgi.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.UrunService.AddOrUpdate(_urunEntity);
            worker.Commit();
            Close();
        }

        private void controlMenuEkMalzeme_EkleClick(object sender, EventArgs e)
        {
            controlMenuEkMalzeme.KayitAc = true; 
            groupEkMalzeme.Visible = true;
            _ekMalzemeEntity = new EkMalzeme();
            _ekMalzemeEntity.UrunId = _urunEntity.Id;
            EkMalzemeBinding();
        }

        private void controlMenuEkMalzeme_DuzenleClick(object sender, EventArgs e)
        {

            controlMenuEkMalzeme.KayitAc = true;
            groupEkMalzeme.Visible = true;
            _ekMalzemeEntity = (EkMalzeme)gridMalzeme.GetFocusedRow();
            EkMalzemeBinding();
        }

        private void controlMenuEkMalzeme_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridPorsiyon.DeleteSelectedRows();
            }
        }

        private void controlMenuEkMalzeme_KaydetClick(object sender, EventArgs e)
        {

            controlMenuEkMalzeme.KayitAc = false;
            groupEkMalzeme.Visible = false;
            worker.EkMalzemeService.AddOrUpdate(_ekMalzemeEntity);

        }

        private void controlMenuEkMalzeme_VazgecClick(object sender, EventArgs e)
        {

            controlMenuEkMalzeme.KayitAc = false;
            groupEkMalzeme.Visible = false;
        }

        private void txtKategori_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.UrunGrup);
            form.ShowDialog();
            if (form.Secildi==true)
            {
                txtKategori.Text = form.tanimEntity.Adi;
                _urunEntity.UrunGrupId = form.tanimEntity.Id;
            }
        }

        private void txtBirim_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.Birim);
            form.ShowDialog();
            if (form.Secildi==true)
            {
                txtBirim.Text = form.tanimEntity.Adi;
                _porsiyonEntity.BirimId = form.tanimEntity.Id;
            }
        }
    }
}