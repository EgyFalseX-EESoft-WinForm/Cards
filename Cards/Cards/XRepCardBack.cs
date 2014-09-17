using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.IO;

namespace Cards
{
    public partial class XRepCardBack : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepCardBack(string Saf, string Fasl)
        {
            InitializeComponent();
            dATATableAdapter.Fill(dsCards1.DATA, Saf, Fasl);
            LoadInfo();
        }
        public XRepCardBack(int ID)
        {
            InitializeComponent();
            dATATableAdapter.FillByID(dsCards1.DATA, ID);
            LoadInfo();
        }
        private void LoadInfo()
        {
            if (System.IO.File.Exists(Program.LogoPath))
            {
                xrPBLogo.ImageUrl = Program.LogoPath;
            }

            for (int i = dsCards1.DATA.Rows.Count - 1; i >= 0; i--)
            {
                if (dsCards1.DATA.Rows[i]["IMG"].ToString() == string.Empty)
                {
                    dsCards1.DATA.Rows.RemoveAt(i);
                    continue;
                }
                if (!File.Exists(Program.ImagePath + dsCards1.DATA.Rows[i]["IMG"].ToString()))
                {
                    dsCards1.DATA.Rows.RemoveAt(i);
                    continue;
                }
            }
            Report.DataSource = dsCards1.DATA;
        }
    }
}
