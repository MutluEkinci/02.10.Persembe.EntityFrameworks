using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataGetir_Click(object sender, EventArgs e)
        {
            CalısmaEntities db = new CalısmaEntities();

            //3.Yöntem:Navigation Property
            dataGridView1.DataSource = db.tbl_Urunler.Select(u => new { u.UrunID, u.UrunAdi, u.Resim, u.Fiyat, u.Aciklama, u.tbl_Kategoriler.KategoriAdi }).ToList();
        }

        private void btnJoinData_Click(object sender, EventArgs e)
        {
            CalısmaEntities db = new CalısmaEntities();

            //1. Yöntem SQL gibi
            //var liste = from u in db.tbl_Urunler
            //            join k in db.tbl_Kategoriler
            //            on u.KategoriID equals k.KategoriID
            //            select new { u.UrunID, u.UrunAdi, u.Resim, u.Fiyat, u.Aciklama, u.tbl_Kategoriler.KategoriAdi };

            //2.Yöntem:Expression tree
            //var liste = db.tbl_Urunler.Join(db.tbl_Kategoriler, u => u.KategoriID, k => k.KategoriID, (u, k) => new { u.UrunID, u.UrunAdi, k.KategoriAdi });

            //4.Yöntem:SQL Sorgusu yaz...

            var liste = db.Database.SqlQuery<tbl_Urunler>("select*from tbl_urunler");


            dataGridView1.DataSource = liste.ToList();
        }

        private void btnSakliProsedur_Click(object sender, EventArgs e)
        {
            CalısmaEntities db = new CalısmaEntities();

            int ID = db.gp_AdvUrunEkle("aa-asd", "top", "kırmızı", 75.56M);
            MessageBox.Show(ID.ToString());
        }
    }
}
