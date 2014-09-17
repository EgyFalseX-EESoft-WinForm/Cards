using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using System.IO;
namespace CardSets
{
    public partial class XRepCard : DevExpress.XtraReports.UI.XtraReport
    {
        public XRepCard(DataTable dt)
        {
            InitializeComponent();
            for (int i = dt.Rows.Count -1; i >= 0; i--)
            {
                if (dt.Rows[i]["imgpath"].ToString() == string.Empty)
                {
                    dt.Rows.RemoveAt(i);
                    continue;
                }
                if (!File.Exists(Program.ImagePath + dt.Rows[i]["imgpath"].ToString()))
                {
                    dt.Rows.RemoveAt(i);
                    continue;
                }
            }
            dsCards1.memberdata.Rows.Clear();
            dsCards1.memberdata.Merge(dt);
            //xlmembername.DataBindings.Add("Text", this.DataSource, "membername");
            //xlsefaName.DataBindings.Add("Text", this.DataSource, "sefaName");
            //xlsubcommite.DataBindings.Add("Text", this.DataSource, "subcommite");
            //xlLagnaName.DataBindings.Add("Text", this.DataSource, "LagnaName");
            //xrtitleName.DataBindings.Add("Text", this.DataSource, "titleName");
            xrPBImg.DataBindings.Add("ImageUrl", this.DataSource, "imgpath", Program.ImagePath + "{0}");

        }

    }
}
