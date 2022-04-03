using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CollectCoinsEF
{
    public partial class FCoins : Form
    {
        private int indexPhoto = 0;

        private bool sortFlag = false;
        public FCoins()
        {
            InitializeComponent();

            openFileDialogDB.Filter = "DB(*.sqlite)|*.sqlite";
            saveFileDialogDB.Filter = "DB(*.sqlite)|*.sqlite";

            ShowCoins();

            // ShowPhoto();
        }

        private void ShowCoins()
        {
            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var coins = db.Coins.ToList();
                dGridCoins.DataSource = coins;
            }
        }

        private void bSaveBD_Click(object sender, EventArgs e)
        {
            if (saveFileDialogDB.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            Program.filenameDB = saveFileDialogDB.FileName;
           
            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                db.Database.EnsureCreated();
            }
        }

        private void bOpenBD_Click(object sender, EventArgs e)
        {
            if (openFileDialogDB.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            Program.filenameDB = openFileDialogDB.FileName;

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                db.Database.EnsureCreated();
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAddCoin_Click(object sender, EventArgs e)
        {
            Coin myCoin = new Coin();
            myCoin.Id = 1;
            myCoin.Name = "Рубль";
            myCoin.Type = "монета";
            myCoin.Year = "1899";
            myCoin.Matherial = "Серебро";
            myCoin.Desc = "Хорошая";
            myCoin.Diametr = "42";
            myCoin.Country = "Российская Империя";
            myCoin.State = "VF";
            myCoin.Circulation = 105000;
            myCoin.Bitkin = "2544";

            FAddEditCoin fcoin = new FAddEditCoin(myCoin, true);
            fcoin.ShowDialog();

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var coins = db.Coins.ToList();
                dGridCoins.DataSource = coins;
            }
        }

        private void bEditCoin_Click(object sender, EventArgs e)
        {
            if (dGridCoins.DataSource == null) { return; }

            Coin myCoin = new Coin();
            myCoin.Id = Int32.Parse(dGridCoins.CurrentRow.Cells["Id"].Value.ToString());
            myCoin.Name = dGridCoins.CurrentRow.Cells["Name"].Value.ToString();
            myCoin.Type = dGridCoins.CurrentRow.Cells["Type"].Value.ToString();
            myCoin.Year = dGridCoins.CurrentRow.Cells["Year"].Value.ToString();
            myCoin.Matherial = dGridCoins.CurrentRow.Cells["Matherial"].Value.ToString();
            myCoin.Desc = dGridCoins.CurrentRow.Cells["Desc"].Value.ToString();
            myCoin.Diametr = dGridCoins.CurrentRow.Cells["Diametr"].Value.ToString();
            myCoin.Country = dGridCoins.CurrentRow.Cells["Country"].Value.ToString();
            myCoin.State = dGridCoins.CurrentRow.Cells["State"].Value.ToString();
            myCoin.Circulation = double.Parse(dGridCoins.CurrentRow.Cells["Circulation"].Value.ToString());
            myCoin.Bitkin = dGridCoins.CurrentRow.Cells["Bitkin"].Value.ToString();

            FAddEditCoin fcoin = new FAddEditCoin(myCoin, false);
            fcoin.ShowDialog();

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var coins = db.Coins.ToList();
                dGridCoins.DataSource = coins;
            }
        }

        private void bReCreateBD_Click(object sender, EventArgs e)
        {
            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }

        private void bDeleteCoin_Click(object sender, EventArgs e)
        {
            if (dGridCoins == null) { return; }

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var lcoins = db.Coins
                             .Where(c => c.Id == int.Parse(dGridCoins.CurrentRow.Cells["Id"].Value.ToString()))
                             .ToList();
                if (lcoins != null)
                {
                    db.Coins.Remove(lcoins[0]);
                    db.SaveChanges();
                }
                var lcoinsPhoto = db.CoinsPhoto
                                 .Where(c => c.CoinsId == int.Parse(dGridCoins.CurrentRow.Cells["Id"].Value.ToString()))
                                 .ToList();
                foreach (var coinPhoto in lcoinsPhoto)
                {
                    db.CoinsPhoto.Remove(coinPhoto);
                }
                db.SaveChanges();
            }


            ShowCoins();
        }

        private void ShowPhoto()
        {
            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var lcoinsPhoto = db.CoinsPhoto
                                  .Where(c => c.CoinsId == int.Parse(dGridCoins.CurrentRow.Cells["Id"].Value.ToString()))
                                  .ToList();
                if ((lcoinsPhoto != null) & (lcoinsPhoto.Count > indexPhoto))
                {
                    MemoryStream stmBLOBData = new MemoryStream(lcoinsPhoto[indexPhoto].Photo);
                    pBoxPhoto.Image = Image.FromStream(stmBLOBData);
                }
                else
                {
                    if ((lcoinsPhoto == null) || (lcoinsPhoto.Count == 0))
                    {
                        pBoxPhoto.Image = null;
                    }
                    if (indexPhoto > 0) indexPhoto--;
                }
            }
        }
        private void ShowRecordCoin()
        {
            tNameCoin.Text = dGridCoins.CurrentRow.Cells["Name"].Value.ToString();
            tTypeCoin.Text = dGridCoins.CurrentRow.Cells["Type"].Value.ToString(); ;
            tYearCoin.Text = dGridCoins.CurrentRow.Cells["Year"].Value.ToString(); ;
            tMatherialCoin.Text = dGridCoins.CurrentRow.Cells["Matherial"].Value.ToString(); ;
            tDescCoin.Text = dGridCoins.CurrentRow.Cells["Desc"].Value.ToString(); ;
            tDiametrCoin.Text = dGridCoins.CurrentRow.Cells["Diametr"].Value.ToString();
            tCountryCoin.Text = dGridCoins.CurrentRow.Cells["Country"].Value.ToString();
            tStateCoin.Text = dGridCoins.CurrentRow.Cells["State"].Value.ToString();
            tCirculationCoin.Text = dGridCoins.CurrentRow.Cells["Circulation"].Value.ToString();
            tBitkinCoin.Text = dGridCoins.CurrentRow.Cells["Bitkin"].Value.ToString();
        }
        private void dGridCoins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexPhoto = 0;

            ShowPhoto();
            ShowRecordCoin();
        }

        private void bPhotoNext_Click(object sender, EventArgs e)
        {
            indexPhoto++;
            ShowPhoto();
        }

        private void bPhotoPrev_Click(object sender, EventArgs e)
        {
            if (indexPhoto > 0) indexPhoto--;
            ShowPhoto();
        }

        private void dGridCoins_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Coin> coins;

            string strColumnName = dGridCoins.Columns[e.ColumnIndex].Name;
            SortOrder strSortOrder = getSortOrder(e.ColumnIndex);

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                if (strSortOrder == SortOrder.Ascending)
                {
                    coins = db.Coins.FromSqlRaw("SELECT * FROM Coins ORDER BY [" + strColumnName + "]").ToList();
                }
                else
                {
                    coins = db.Coins.FromSqlRaw("SELECT * FROM Coins ORDER BY [" + strColumnName+ "] DESC").ToList();
                }
                dGridCoins.DataSource = coins;
                dGridCoins.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = strSortOrder;
            }
        }

        private SortOrder getSortOrder(int columnIndex)
        {
            if (dGridCoins.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None ||
                dGridCoins.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending)
            {
                dGridCoins.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                return SortOrder.Ascending;
            }
            else
            {
                dGridCoins.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                return SortOrder.Descending;
            }
        }

        private void tSearch_TextChanged(object sender, EventArgs e)
        {
            string strSearch = tSearch.Text;
            
            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {

                  var   coins = db.Coins.FromSqlRaw("SELECT * FROM Coins WHERE UPPER([Name]) LIKE UPPER('%" + strSearch + "%') OR UPPER([Desc]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Year]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([State]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Matherial]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Diametr]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Country]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Type]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Bitkin]) LIKE UPPER('%" + strSearch + "%')" +
                      " OR UPPER([Circulation]) LIKE UPPER('%" + strSearch + "%')").ToList();
     
                dGridCoins.DataSource = coins;
            }
        }
    }
}