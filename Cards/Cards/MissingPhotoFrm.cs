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

namespace Cards
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
            string commandString = @"SELECT IMG, ID, SNAME, SAF, FASL, PHONE, USERNAME, [PASSWORD], Edara, Gov, year, site, [add] FROM DATA";
            DataSources.dsCards.DATADataTable tbl = new DataSources.dsCards.DATADataTable();
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
                        DataSources.dsCards.DATARow row = tbl.NewDATARow();
                        row.IMG = dr.GetValue(0).ToString();
                        row.ID = Convert.ToInt32(dr.GetValue(1));
                        row.SNAME = dr.GetValue(2).ToString();
                        row.SAF = dr.GetValue(3).ToString();
                        row.FASL = dr.GetValue(4).ToString();
                        row.PHONE = dr.GetValue(5).ToString();
                        row.USERNAME = dr.GetValue(6).ToString();
                        row.PASSWORD = dr.GetValue(7).ToString();
                        row.Edara = dr.GetValue(8).ToString();
                        row.Gov = dr.GetValue(9).ToString();
                        row.year = dr.GetValue(10).ToString();
                        row.site = dr.GetValue(11).ToString();
                        row.add = dr.GetValue(12).ToString();
                        tbl.AddDATARow(row);
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControlMain.ShowRibbonPrintPreview();
        }
    }
}