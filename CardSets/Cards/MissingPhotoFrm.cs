using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using System.IO;

namespace CardSets
{
    public partial class MissingPhotoFrm : DevExpress.XtraEditors.XtraForm
    {
        public MissingPhotoFrm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string commandString = @"SELECT     imgpath, memberid, titleid, membername, sefaid, LagnaId, cdsubcommite, False AS chk, KidNumber, Sefa2,
                          (SELECT     titleName
                             FROM         cdtitle
                             WHERE     titleid = memberdata.titleid) AS titleName,
                          (SELECT     sefaName
                             FROM         cdsefa
                             WHERE     sefaid = memberdata.sefaid) AS sefaName,
                          (SELECT     LagnaName
                             FROM         CDLagna
                             WHERE     LagnaId = memberdata.LagnaId) AS LagnaName,
                          (SELECT     subcommite
                             FROM         cdsubcommite
                             WHERE     cdsubcommite = memberdata.cdsubcommite) AS subcommite
                            FROM         memberdata";
            DataSources.dsCards.memberdataDataTable tbl = new DataSources.dsCards.memberdataDataTable();
            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.CARDSConnectionString);
            OleDbCommand cmd = new OleDbCommand(commandString, con);
            OleDbDataReader dr = null;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString() != string.Empty)
                    {
                        if (File.Exists(Program.ImagePath + dr.GetValue(0).ToString()))
                            continue;
                        DataSources.dsCards.memberdataRow row = tbl.NewmemberdataRow();
                        row.imgpath = dr.GetValue(0).ToString();
                        row.memberid = Convert.ToInt32(dr.GetValue(1));
                        row.titleid = Convert.ToInt32(dr.GetValue(2));
                        row.membername = dr.GetValue(3).ToString();
                        row.sefaid = Convert.ToByte(dr.GetValue(4));
                        row.LagnaId = Convert.ToInt32(dr.GetValue(5));
                        row.cdsubcommite = Convert.ToInt32(dr.GetValue(6));
                        row.chk = Convert.ToBoolean(dr.GetValue(7));
                        row.KidNumber = dr.GetValue(8).ToString();
                        row.Sefa2 = dr.GetValue(9).ToString();
                        row.titleName = dr.GetValue(10).ToString();
                        row.sefaName = dr.GetValue(11).ToString();
                        row.LagnaName = dr.GetValue(12).ToString();
                        row.subcommite = dr.GetValue(13).ToString();
                        tbl.AddmemberdataRow(row);
                    }
                }
                con.Close();
                gridControlMain.DataSource = tbl;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}