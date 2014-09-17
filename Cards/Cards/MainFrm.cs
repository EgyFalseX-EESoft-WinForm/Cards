using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace Cards
{
    public partial class MainFrm : XtraForm
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        private void iAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Programmed by E-E-Soft", "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MainFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCards.DATA_SNAME' table. You can move, or remove it, as needed.
            this.dATA_SNAMETableAdapter.Fill(this.dsCards.DATA_SNAME);
            // TODO: This line of code loads data into the 'dsCards.FASL' table. You can move, or remove it, as needed.
            this.fASLTableAdapter.Fill(this.dsCards.FASL);
            // TODO: This line of code loads data into the 'dsCards.Saf' table. You can move, or remove it, as needed.
            this.safTableAdapter.Fill(this.dsCards.Saf);
        }
        private void StudentItem_ItemChanged(object sender, EventArgs e)
        {
            GCQueryOptions.Visible = true;
        }
        private void MissingPhoto_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            MissingPhotoFrm Frm = new MissingPhotoFrm();
            Frm.Show();
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (lueSNAME.EditValue != null)
            {
                this.dATATableAdapter.FillByID(dsCards.DATA, Convert.ToInt32(lueSNAME.EditValue));
                return;
            }
            if ((LUESaf.EditValue == null || LUEFasl.EditValue == null))
            {
                MessageBox.Show("من فضلك اختار الصف و الفصل او اختر اسم");
                return;
            }
            // TODO: This line of code loads data into the 'dsCards.DATA' table. You can move, or remove it, as needed.
            this.dATATableAdapter.Fill(this.dsCards.DATA, LUESaf.EditValue.ToString(), LUEFasl.EditValue.ToString());
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if ((LUESaf.EditValue == null || LUEFasl.EditValue == null) && lueSNAME.EditValue == null)
            {
                MessageBox.Show("من فضلك اختار الصف و الفصل");
                return;
            }
            if (lueSNAME.EditValue != null)
            {
                XRepCardFront front = new XRepCardFront(Convert.ToInt32(lueSNAME.EditValue));
                Misc.Misc.ShowPrintPreview(front);
                XRepCardBack back = new XRepCardBack(Convert.ToInt32(lueSNAME.EditValue));
                Misc.Misc.ShowPrintPreview(back);
            }
            else
            {
                XRepCardFront front = new XRepCardFront(LUESaf.EditValue.ToString(), LUEFasl.EditValue.ToString());
                Misc.Misc.ShowPrintPreview(front);
                XRepCardBack back = new XRepCardBack(LUESaf.EditValue.ToString(), LUEFasl.EditValue.ToString());
                Misc.Misc.ShowPrintPreview(back);
            }
            
        }
        private void btnPrintEditor_Click(object sender, EventArgs e)
        {
            if (LUESaf.EditValue == null || LUEFasl.EditValue == null)
            {
                MessageBox.Show("من فضلك اختار الصف و الفصل");
                return;
            }
            XRepCardFront front = new XRepCardFront(LUESaf.EditValue.ToString(), LUEFasl.EditValue.ToString());
            Misc.Misc.ShowPrintPreview(front);
            XRepCardBack back = new XRepCardBack(LUESaf.EditValue.ToString(), LUEFasl.EditValue.ToString());
            Misc.Misc.ShowPrintPreview(front);
        }

        

    }
}