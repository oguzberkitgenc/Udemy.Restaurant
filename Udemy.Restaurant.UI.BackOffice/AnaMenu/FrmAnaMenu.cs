﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Udemy.Restaurant.Core.Function;
using Udemy.Restaurant.Core.Functions;
using Udemy.Restaurant.UI.BackOffice.Urun;

namespace Udemy.Restaurant.UI.BackOffice
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                FrmSetupConnection form = new FrmSetupConnection();
                form.ShowDialog();
            }
        }

        private void btnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         FrmUrun  form = new FrmUrun();
            form.MdiParent= this;
            form.Show();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
