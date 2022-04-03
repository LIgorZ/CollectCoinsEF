using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectCoinsEF
{
    public partial class FAddEditCoin : Form
    {
        public Boolean Ok {set; get;}
        private Boolean IsInsert { set; get; }

        private int Index { set; get; }

        public FAddEditCoin(Coin myCoin, bool isInsert = false)
        {
            IsInsert = isInsert;
            Index = myCoin.Id;

            InitializeComponent();

            tNameCoin.Text = myCoin.Name;   
            tTypeCoin.Text = myCoin.Type;
            tYearCoin.Text = myCoin.Year;
            tMatherialCoin.Text = myCoin.Matherial;
            tDescCoin.Text = myCoin.Desc;
            tDiametrCoin.Text = myCoin.Diametr;
            tCountryCoin.Text = myCoin.Country;
            tStateCoin.Text = myCoin.State;
            tCirculationCoin.Text = myCoin.Circulation.ToString();
            tBitkinCoin.Text = myCoin.Bitkin;

            ShowPhoto();

            oFilePhoto.Filter = "jpg(*.jpg)|*.jpg";

            if (IsInsert) 
            {
                bAddPhoto.Enabled = false;
                bDeletePhoto.Enabled = false;
            }
        }

        private void ShowPhoto()
        {
            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var lcoinsPhoto = db.CoinsPhoto
                                  .Where(c => c.CoinsId == Index)
                                  .ToList();
                if ((lcoinsPhoto != null) & (lcoinsPhoto.Count > 0))
                {
                    MemoryStream stmBLOBData = new MemoryStream(lcoinsPhoto[0].Photo);
                    pB_Photo.Image = Image.FromStream(stmBLOBData);
                    dGridPhoto.DataSource = lcoinsPhoto;
                } else
                {
                    pB_Photo.Image = null;
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            
            Ok = false;
            
            Close();
        }

        private void bOK_Click(object sender, EventArgs e)
        {
            if (!IsInsert)
            {
                using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
                {
                    Coin myCoin = new Coin();

                    myCoin.Id = Index;
                    myCoin.Name = tNameCoin.Text;
                    myCoin.Type = tTypeCoin.Text;
                    myCoin.Year = tYearCoin.Text;
                    myCoin.Matherial = tMatherialCoin.Text;
                    myCoin.Desc = tDescCoin.Text;
                    myCoin.Diametr = tDiametrCoin.Text;
                    myCoin.Country = tCountryCoin.Text;
                    myCoin.State = tStateCoin.Text;
                    myCoin.Circulation = double.Parse(tCirculationCoin.Text);
                    myCoin.Bitkin = tBitkinCoin.Text;

                    db.Coins.Update(myCoin);
                    db.SaveChanges();
                }
            }
            else
            {
                using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
                {
                    Coin myCoin = new Coin();

                    myCoin.Name = tNameCoin.Text;
                    myCoin.Type = tTypeCoin.Text;
                    myCoin.Year = tYearCoin.Text;
                    myCoin.Matherial = tMatherialCoin.Text;
                    myCoin.Desc = tDescCoin.Text;
                    myCoin.Diametr = tDiametrCoin.Text;
                    myCoin.Country = tCountryCoin.Text;
                    myCoin.State = tStateCoin.Text;
                    myCoin.Circulation = double.Parse(tCirculationCoin.Text);
                    myCoin.Bitkin = tBitkinCoin.Text;

                    db.Coins.Add(myCoin);
                    db.SaveChanges();
                }
            }

            Ok = true;

            Close();
        }

        private void bAddPhoto_Click(object sender, EventArgs e)
        {
            string pathPhoto = "";

            if (oFilePhoto.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            pathPhoto = oFilePhoto.FileName;

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                FileStream fsBLOBFile = new FileStream(pathPhoto, FileMode.Open, FileAccess.Read);
                Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                fsBLOBFile.Close();

                CoinsPhoto myAddCoinsPhoto = new CoinsPhoto();
                myAddCoinsPhoto.NamePhoto = pathPhoto;
                myAddCoinsPhoto.CoinsId = Index;
                myAddCoinsPhoto.Photo = bytBLOBData;
                

                db.CoinsPhoto.Add(myAddCoinsPhoto);
                db.SaveChanges();

                MemoryStream stmBLOBData = new MemoryStream(bytBLOBData);
                pB_Photo.Image = Image.FromStream(stmBLOBData);

                var coinsPhoto = db.CoinsPhoto
                                  .Where(c => c.CoinsId == Index)
                                  .ToList(); 
                dGridPhoto.DataSource = coinsPhoto;
            }
        }

        private void dGridPhoto_Click(object sender, EventArgs e)
        {
            if (dGridPhoto == null) { return; }

            MemoryStream stmBLOBData = new MemoryStream((byte[])dGridPhoto.CurrentRow.Cells["Photo"].Value);
            pB_Photo.Image = Image.FromStream(stmBLOBData);
            
            //ShowPhoto();
        }

        private void bDeletePhoto_Click(object sender, EventArgs e)
        {
            if (dGridPhoto == null) { return; }

            using (AppContext db = new AppContext("Data Source=" + Program.filenameDB))
            {
                var lcoinsPhoto = db.CoinsPhoto
                                  .Where(c => c.Id == int.Parse(dGridPhoto.CurrentRow.Cells["Id"].Value.ToString()))
                                  .ToList();
                if (lcoinsPhoto != null)
                {
                    db.Remove(lcoinsPhoto[0]);
                    db.SaveChanges();
                }
            }

            ShowPhoto();
        }
    }
}
