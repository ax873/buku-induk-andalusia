using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sqlprojek
{
    public partial class kkm : Form
    {
        public kkm()
        {
            InitializeComponent();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                        tambahkkm st = new tambahkkm(txtag.Text.Trim(), txtpk.Text.Trim(), txtin.Text.Trim(), txtig.Text.Trim(), txtmt.Text.Trim(), txtja.Text.Trim(), txtso.Text.Trim(), txtbi.Text.Trim(), txtfi.Text.Trim(), txtki.Text.Trim(), txtge.Text.Trim(), txteko.Text.Trim(), txtsej.Text.Trim(), txtsenbud.Text.Trim(), txtora.Text.Trim(), txttik.Text.Trim(), txtarr.Text.Trim(), txtpkw.Text.Trim(), txts.Text.Trim(), txtmtmm.Text.Trim());
            dbstuden.tambhakkm(st);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tambahkkm st = new tambahkkm(txtag.Text.Trim(), txtpk.Text.Trim(), txtin.Text.Trim(), txtig.Text.Trim(), txtmt.Text.Trim(), txtja.Text.Trim(), txtso.Text.Trim(), txtbi.Text.Trim(), txtfi.Text.Trim(), txtki.Text.Trim(), txtge.Text.Trim(), txteko.Text.Trim(), txtsej.Text.Trim(), txtsenbud.Text.Trim(), txtora.Text.Trim(), txttik.Text.Trim(), txtarr.Text.Trim(), txtpkw.Text.Trim(), txts.Text.Trim(), txtmtmm.Text.Trim());
            dbstuden.tambhakkm2(st);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tambahkkm st = new tambahkkm(txtag.Text.Trim(), txtpk.Text.Trim(), txtin.Text.Trim(), txtig.Text.Trim(), txtmt.Text.Trim(), txtja.Text.Trim(), txtso.Text.Trim(), txtbi.Text.Trim(), txtfi.Text.Trim(), txtki.Text.Trim(), txtge.Text.Trim(), txteko.Text.Trim(), txtsej.Text.Trim(), txtsenbud.Text.Trim(), txtora.Text.Trim(), txttik.Text.Trim(), txtarr.Text.Trim(), txtpkw.Text.Trim(), txts.Text.Trim(), txtmtmm.Text.Trim());
            dbstuden.tambhakkm3(st);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tambahkkm st = new tambahkkm(txtag.Text.Trim(), txtpk.Text.Trim(), txtin.Text.Trim(), txtig.Text.Trim(), txtmt.Text.Trim(), txtja.Text.Trim(), txtso.Text.Trim(), txtbi.Text.Trim(), txtfi.Text.Trim(), txtki.Text.Trim(), txtge.Text.Trim(), txteko.Text.Trim(), txtsej.Text.Trim(), txtsenbud.Text.Trim(), txtora.Text.Trim(), txttik.Text.Trim(), txtarr.Text.Trim(), txtpkw.Text.Trim(), txts.Text.Trim(), txtmtmm.Text.Trim());
            dbstuden.tambhakkm4(st);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tambahkkm st = new tambahkkm(txtag.Text.Trim(), txtpk.Text.Trim(), txtin.Text.Trim(), txtig.Text.Trim(), txtmt.Text.Trim(), txtja.Text.Trim(), txtso.Text.Trim(), txtbi.Text.Trim(), txtfi.Text.Trim(), txtki.Text.Trim(), txtge.Text.Trim(), txteko.Text.Trim(), txtsej.Text.Trim(), txtsenbud.Text.Trim(), txtora.Text.Trim(), txttik.Text.Trim(), txtarr.Text.Trim(), txtpkw.Text.Trim(), txts.Text.Trim(), txtmtmm.Text.Trim());
            dbstuden.tambhakkm5(st);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tambahkkm st = new tambahkkm(txtag.Text.Trim(), txtpk.Text.Trim(), txtin.Text.Trim(), txtig.Text.Trim(), txtmt.Text.Trim(), txtja.Text.Trim(), txtso.Text.Trim(), txtbi.Text.Trim(), txtfi.Text.Trim(), txtki.Text.Trim(), txtge.Text.Trim(), txteko.Text.Trim(), txtsej.Text.Trim(), txtsenbud.Text.Trim(), txtora.Text.Trim(), txttik.Text.Trim(), txtarr.Text.Trim(), txtpkw.Text.Trim(), txts.Text.Trim(), txtmtmm.Text.Trim());
            dbstuden.tambhakkm6(st);
        }
    }
}
