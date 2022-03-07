using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WndAppModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnModelFirst_Click(object sender, EventArgs e)
        {
            Model1Container db = new Model1Container();

            db.EmlakSet.Add(new Emlak { Adres = "Kadıköy", Metrekare = 120, Fiyat = 4000000 });

            db.SaveChanges();

            dataGridView1.DataSource = db.EmlakSet.ToList();
        }
    }
}
