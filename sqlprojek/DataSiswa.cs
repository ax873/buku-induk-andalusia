using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MySql.Data.MySqlClient;
namespace sqlprojek
{
    public partial class DataSiswa : Form
    {
        public string id;
        int rown;
        public static string txttus;

        public DataSiswa()
        {
            InitializeComponent();
        }
       private void bersih()
        {
            txtnis.Text = "";
            txtnisn.Text = "";
            txtnis.Text = "";
            txtnamalengkap.Text = "";
            txtket.Text = "";
            txtnamapanggil.Text = "";
            txtjeniskelamin.Text = "";
            txtagama.Text = "";
            txtkewarganegaraan.Text = "";
            txtanake.Text = "";
            txtjumlahsaudara.Text = "";
            txtanakyatim.Text = "";
            txtbahasasehari.Text = "";
            txtjarak.Text = "";
txtkesekolahjalankaki.Text = "";
            txtditerimadisekolahpindah.Text = "";
            txtpindahandikelas.Text = "";
            txtdarisma.Text = "";
            txtalamatsmapindahan.Text = "";
            txtasalsmppindahandanno.Text = "";
            txtalasanpindahan.Text = "";
            txtextra.Text = "";
            txtditerimasekolahpadatanggal.Text = "";
            txtalamatsmp.Text = "";
            txtasalsmp.Text = "";
            txttgldannoijazah.Text = "";
            txtalamat.Text = "";
            txtselamasekolahtinggaldi.Text = "";
            txtberat.Text = "";
            txttinggi.Text = "";
            txtberatketikalulus.Text = "";
            txttinggiketikalulus.Text = "";
            txtgolongandarah.Text = "";
            txtriwayatpenyakit.Text = "";
            txtkelainanlain.Text = "";
            txtnamaayah.Text = "";
            txtkewarganegaraanayah.Text = "";
            txtpendidikanayah.Text = "";
            txtlahirayah.Text = "";
            txtpekerjaanayah.Text = "";
            txtpenghasilanayah.Text = "";
            txtalamatayah.Text = "";
            txtnamaibu.Text = "";
            txttempatlahiribu.Text = "";
            txtkewarganegaraanibu.Text = "";
            txtpendidikanibu.Text = "";
            txtpekerjaanibu.Text = "";
            txtpenghasilanibu.Text = "";
            txtalamatibu.Text = "";
            txtgambar.Text = "";
            txttahun.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtnis.Text.Trim() == "") 
            {
                MessageBox.Show("Isi Semua Data Dengan Benar");
            }
          else  if (txtnisn.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data Dengan Benar");
            }
          else  if (txtstatus.Text.Trim() == "Pilih salah satu")
            {
                MessageBox.Show("Isi Semua Data Dengan Benar");
            }
            else if (txtnamalengkap.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data Dengan Benar");
            }
            else if (txtket.Text.Trim() == "")
            {
                MessageBox.Show("Isi Semua Data Dengan Benar");
            }
           

            else if (btsimpandata.Text == "Save")
            {

           

                //  MemoryStream ms = new MemoryStream();
                /// pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                //  byte[] img = ms.ToArray();//

            string kos = "kosong";

              Studenttambah sud = new Studenttambah(txtnis.Text.Trim(), txtnisn.Text.Trim(), txtnamalengkap.Text.Trim(), txtnamapanggil.Text.Trim(), txtjeniskelamin.Text.Trim(), txttempatlahir.Text.Trim(), txtagama.Text.Trim(), txtkewarganegaraan.Text.Trim(), txtanake.Text.Trim(), txtjumlahsaudara.Text.Trim(), txtanakyatim.Text.Trim(), txtbahasasehari.Text.Trim(), txtalamat.Text.Trim(), txtselamasekolahtinggaldi.Text.Trim(), txtjarak.Text.Trim(), txtkesekolahjalankaki.Text.Trim(), txtberat.Text.Trim(), txttinggi.Text.Trim(), txtberatketikalulus.Text.Trim(), txttinggiketikalulus.Text.Trim(), txtgolongandarah.Text.Trim(), txtriwayatpenyakit.Text.Trim(), txtkelainanlain.Text.Trim(), txtditerimasekolahpadatanggal.Text.Trim(), txtasalsmp.Text.Trim(), txtalamatsmp.Text.Trim(), txttgldannoijazah.Text.Trim(), txtditerimadisekolahpindah.Text.Trim(), txtpindahandikelas.Text.Trim(), txtdarisma.Text.Trim(), txtalamatsmapindahan.Text.Trim(), txtasalsmppindahandanno.Text.Trim(), txtalamatsmapindahan.Text.Trim(), txtalasanpindahan.Text.Trim(), txtnamaayah.Text.Trim(), txtlahirayah.Text.Trim(), txtpendidikanayah.Text.Trim(), txtpekerjaanayah.Text.Trim(), txtpenghasilanayah.Text.Trim(), txtalamatayah.Text.Trim(), txtnamaibu.Text.Trim(), txttempatlahiribu.Text.Trim(), txtpendidikanibu.Text.Trim(), txtpekerjaanibu.Text.Trim(), txtpenghasilanibu.Text.Trim(), txtalamatibu.Text.Trim(), txtgambar.Text.Trim(), txtstatus.Text.Trim(), txttahun.Text.Trim(), txtket.Text.Trim(), txtkewarganegaraanayah.Text.Trim(), txtkewarganegaraanibu.Text.Trim(), txtextra.Text.Trim(), kos, kos);

                //   Studenttambah sud = new Studenttambah(txtnis.Text.Trim(), txtnisn.Text.Trim(), txtnamalengkap.Text.Trim(), txtnamapanggil.Text.Trim(), txtjeniskelamin.Text.Trim(), txttempatlahir.Text.Trim(), txtagama.Text.Trim(), txtkewarganegaraan.Text.Trim(), txtanake.Text.Trim(), txtjumlahsaudara.Text.Trim(), txtanakyatim.Text.Trim(), txtbahasasehari.Text.Trim(), txtalamat.Text.Trim(), txtselamasekolahtinggaldi.Text.Trim(), txtjarak.Text.Trim(), txtkesekolahjalankaki.Text.Trim(), txtberat.Text.Trim(), txttinggi.Text.Trim(), txtberatketikalulus.Text.Trim(), txttinggiketikalulus.Text.Trim(), txtgolongandarah.Text.Trim(), txtriwayatpenyakit.Text.Trim(), txtkelainanlain.Text.Trim(), txtditerimasekolahpadatanggal.Text.Trim(), txtasalsmp.Text.Trim(), txtalamatsmp.Text.Trim(), txttgldannoijazah.Text.Trim(), txtditerimadisekolahpindah.Text.Trim(), txtpindahandikelas.Text.Trim(), txtdarisma.Text.Trim(), txtalamatsmapindahan.Text.Trim(), txtasalsmppindahandanno.Text.Trim(), txtalamatsmapindahan.Text.Trim(), txtalasanpindahan.Text.Trim(), txtnamaayah.Text.Trim(), txtlahirayah.Text.Trim(), txtpendidikanayah.Text.Trim(), txtpekerjaanayah.Text.Trim(), txtpenghasilanayah.Text.Trim(), txtalamatayah.Text.Trim(), txtnamaibu.Text.Trim(), txttempatlahir.Text.Trim(), txtpendidikanibu.Text.Trim(), txtpekerjaanibu.Text.Trim(), txtpenghasilanibu.Text.Trim(), txtalamatibu.Text.Trim(), Path.GetFileName(pictureBox1.ImageLocation), txtstatus.Text.Trim(), txttahun.Text.Trim(), txtket.Text.Trim(), txtkewarganegaraanayah.Text.Trim(), txtkewarganegaraanibu.Text.Trim());

                dbstuden.Tambahdata(sud);
                //   File.Copy(txtgambar.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));




                bersih();
                display();
                dataGridView11.Visible = true;
                button3.Show();


            }
         else   if (btsimpandata.Text == "Update")
            {
                string kos = "kosong";
                dataGridView11.Visible = true;
                Studenttambah sud = new Studenttambah(txtnis.Text.Trim(), txtnisn.Text.Trim(), txtnamalengkap.Text.Trim(), txtnamapanggil.Text.Trim(), txtjeniskelamin.Text.Trim(), txttempatlahir.Text.Trim(), txtagama.Text.Trim(), txtkewarganegaraan.Text.Trim(), txtanake.Text.Trim(), txtjumlahsaudara.Text.Trim(), txtanakyatim.Text.Trim(), txtbahasasehari.Text.Trim(), txtalamat.Text.Trim(), txtselamasekolahtinggaldi.Text.Trim(), txtjarak.Text.Trim(), txtkesekolahjalankaki.Text.Trim(), txtberat.Text.Trim(), txttinggi.Text.Trim(), txtberatketikalulus.Text.Trim(), txttinggiketikalulus.Text.Trim(), txtgolongandarah.Text.Trim(), txtriwayatpenyakit.Text.Trim(), txtkelainanlain.Text.Trim(), txtditerimasekolahpadatanggal.Text.Trim(), txtasalsmp.Text.Trim(), txtalamatsmp.Text.Trim(), txttgldannoijazah.Text.Trim(), txtditerimadisekolahpindah.Text.Trim(), txtpindahandikelas.Text.Trim(), txtdarisma.Text.Trim(), txtalamatsmapindahan.Text.Trim(), txtasalsmppindahandanno.Text.Trim(), txtalamatsmapindahan.Text.Trim(), txtalasanpindahan.Text.Trim(), txtnamaayah.Text.Trim(), txtlahirayah.Text.Trim(), txtpendidikanayah.Text.Trim(), txtpekerjaanayah.Text.Trim(), txtpenghasilanayah.Text.Trim(), txtalamatayah.Text.Trim(), txtnamaibu.Text.Trim(), txttempatlahiribu.Text.Trim(), txtpendidikanibu.Text.Trim(), txtpekerjaanibu.Text.Trim(), txtpenghasilanibu.Text.Trim(), txtalamatibu.Text.Trim(), txtgambar.Text.Trim(), txtstatus.Text.Trim(), txttahun.Text.Trim(), txtket.Text.Trim(), txtkewarganegaraanayah.Text.Trim(), txtkewarganegaraanibu.Text.Trim(), txtextra.Text.Trim(), kos, kos);
                dbstuden.ubahdata(sud, id);
                bersih();
                display();
            }
        }

        private void datagd_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(""+id);

        }

        private void DataSiswa_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void anj()
        {
            //   string sqll = "SELECT * From nilaiketerampilan where semester ='" + pelsm + "' ";
            txttus = menuutama.txtstatus;
            txtstatus.Text= txttus;


        }

        public void display()
        {
            //   string sqll = "SELECT * From nilaiketerampilan where semester ='" + pelsm + "' ";
            textBox4.Visible = false;
            label53.Visible = false;


            if (txttus == "IPA")
            {

                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPA'", dataGridView11);
                
            }
            else if (txttus == "IPS")
            {
                dbstuden.disp("SELECT nis, namalengkap,status,keterangan,tahunmasuk  From siswasma WHERE status = 'IPS'", dataGridView11);
            }
            else
            {
                dbstuden.disp("SELECT nis, namalengkap,status,keterangan,tahunmasuk  From siswasma", dataGridView11);
                textBox2.Visible=false;
                textBox3.Visible = false;
                label51.Visible = false;
                label52.Visible = false;
                label53.Visible = false;
            }




            // dbstuden.disp("SELECT no,nis, namalengkap From siswasma where semester ='" + txttus + "'", dataGridView11);
          
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                dbstuden.dissp("SELECT * From siswasma", dataGridView11);
                btsimpandata.Text = "Update";
                button3.Visible = false;
                id = dataGridView11.Rows[e.RowIndex].Cells[2].Value.ToString();
              
                txtlabel.Text = dataGridView11.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtnis.Text = dataGridView11.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtnisn.Text = dataGridView11.Rows[e.RowIndex].Cells[4].Value.ToString();  
                txtnamalengkap.Text = dataGridView11.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtnamapanggil.Text = dataGridView11.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtagama.Text = dataGridView11.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtjeniskelamin.Text = dataGridView11.Rows[e.RowIndex].Cells[7].Value.ToString();
                txttempatlahir.Text = dataGridView11.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtkewarganegaraan.Text = dataGridView11.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtanake.Text = dataGridView11.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtjumlahsaudara.Text = dataGridView11.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtanakyatim.Text = dataGridView11.Rows[e.RowIndex].Cells[13].Value.ToString();
                txtbahasasehari.Text = dataGridView11.Rows[e.RowIndex].Cells[14].Value.ToString();
                txtalamat.Text = dataGridView11.Rows[e.RowIndex].Cells[15].Value.ToString();
                txtselamasekolahtinggaldi.Text = dataGridView11.Rows[e.RowIndex].Cells[16].Value.ToString();
                txtjarak.Text = dataGridView11.Rows[e.RowIndex].Cells[17].Value.ToString();
                txtkesekolahjalankaki.Text = dataGridView11.Rows[e.RowIndex].Cells[18].Value.ToString();
                txtberat.Text = dataGridView11.Rows[e.RowIndex].Cells[19].Value.ToString();
                txttinggi.Text = dataGridView11.Rows[e.RowIndex].Cells[20].Value.ToString();
                txtberatketikalulus.Text = dataGridView11.Rows[e.RowIndex].Cells[21].Value.ToString();
                txttinggiketikalulus.Text = dataGridView11.Rows[e.RowIndex].Cells[22].Value.ToString();
                txtgolongandarah.Text = dataGridView11.Rows[e.RowIndex].Cells[23].Value.ToString();
                txtriwayatpenyakit.Text = dataGridView11.Rows[e.RowIndex].Cells[24].Value.ToString();
                txtkelainanlain.Text = dataGridView11.Rows[e.RowIndex].Cells[25].Value.ToString();
                txtditerimasekolahpadatanggal.Text = dataGridView11.Rows[e.RowIndex].Cells[26].Value.ToString();
               txtasalsmp.Text = dataGridView11.Rows[e.RowIndex].Cells[27].Value.ToString();
                txtalamatsmp.Text = dataGridView11.Rows[e.RowIndex].Cells[28].Value.ToString();
                txttgldannoijazah.Text = dataGridView11.Rows[e.RowIndex].Cells[29].Value.ToString();
                txtditerimadisekolahpindah.Text = dataGridView11.Rows[e.RowIndex].Cells[30].Value.ToString();
                txtpindahandikelas.Text = dataGridView11.Rows[e.RowIndex].Cells[31].Value.ToString();
                txtdarisma.Text = dataGridView11.Rows[e.RowIndex].Cells[32].Value.ToString();
                txtalamatsmapindahan.Text = dataGridView11.Rows[e.RowIndex].Cells[33].Value.ToString();
                txtasalsmppindahandanno.Text = dataGridView11.Rows[e.RowIndex].Cells[34].Value.ToString();
                txtalamatsmapindahan.Text = dataGridView11.Rows[e.RowIndex].Cells[35].Value.ToString();
                txtalasanpindahan.Text = dataGridView11.Rows[e.RowIndex].Cells[36].Value.ToString();
                txtnamaayah.Text = dataGridView11.Rows[e.RowIndex].Cells[37].Value.ToString();
                txtlahirayah.Text = dataGridView11.Rows[e.RowIndex].Cells[38].Value.ToString();
                txtpendidikanayah.Text = dataGridView11.Rows[e.RowIndex].Cells[39].Value.ToString();
                txtpekerjaanayah.Text = dataGridView11.Rows[e.RowIndex].Cells[40].Value.ToString();
                txtpenghasilanayah.Text = dataGridView11.Rows[e.RowIndex].Cells[41].Value.ToString();
                txtalamatayah.Text = dataGridView11.Rows[e.RowIndex].Cells[42].Value.ToString();
                txtnamaibu.Text = dataGridView11.Rows[e.RowIndex].Cells[43].Value.ToString();
                txttempatlahiribu.Text = dataGridView11.Rows[e.RowIndex].Cells[44].Value.ToString();
                txtpendidikanibu.Text = dataGridView11.Rows[e.RowIndex].Cells[45].Value.ToString();
                txtpekerjaanibu.Text = dataGridView11.Rows[e.RowIndex].Cells[46].Value.ToString();
                txtpenghasilanibu.Text = dataGridView11.Rows[e.RowIndex].Cells[47].Value.ToString();
                txtalamatibu.Text = dataGridView11.Rows[e.RowIndex].Cells[48].Value.ToString();

           

          txtgambar.Text = dataGridView11.Rows[e.RowIndex].Cells[49].Value.ToString();
                                            txtstatus.Text = dataGridView11.Rows[e.RowIndex].Cells[50].Value.ToString();
                txttahun.Text = dataGridView11.Rows[e.RowIndex].Cells[51].Value.ToString();
                txtket.Text = dataGridView11.Rows[e.RowIndex].Cells[52].Value.ToString();
                txtkewarganegaraanayah.Text = dataGridView11.Rows[e.RowIndex].Cells[54].Value.ToString();
                txtkewarganegaraanibu.Text = dataGridView11.Rows[e.RowIndex].Cells[53].Value.ToString();
                txtextra.Text = dataGridView11.Rows[e.RowIndex].Cells[55].Value.ToString();

                //      txtasalsmppindahan.Text = dataGridView11.Rows[e.RowIndex].Cells[27].Value.ToString();
                dataGridView11.Hide();

                panel2.Hide();
                label52.Hide();
                label53.Hide();
                Nama.Hide();
                label51.Hide();
                textBox4.Hide();
                textBox3.Hide();
                textBox2.Hide();
                textBox1.Hide();
            
              
                return;
            }else
            {
                MessageBox.Show("GAgal");
            }
            if (e.ColumnIndex == 1)
            {

                if (MessageBox.Show("delete?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)

                {
                    dbstuden.HAPUS(dataGridView11.Rows[e.RowIndex].Cells[2].Value.ToString());
                    display(); bersih();
                }
                return;
            }
            else
            {
                MessageBox.Show("GAgal");
            }

            
        }

        public void uj()
        {
           

        }

        private void DataSiswa_Shown(object sender, EventArgs e)
        {
            anj();
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txttus == "IPA")
            {

                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPA' and namalengkap LIKE '%" + textBox1.Text + "%'", dataGridView11);

            }
            else if (txttus == "IPS")
            {
                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPS' and namalengkap LIKE '%" + textBox1.Text + "%'" , dataGridView11);
            }
            else
            {
                dbstuden.disp("SELECT nis, namalengkap,status,keterangan,tahunmasuk  From siswasma WHERE namalengkap LIKE '" + textBox1.Text + "'", dataGridView11);
               
            }


           // dbstuden.disp("SELECT nis, namalengkap, status From siswasma ", dataGridView11);


        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            print frm = new print();
            cry studrpt = new cry();
            TextObject lname_text = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbnamalengkap"];
            lname_text.Text = txtnamalengkap.Text;
            TextObject lname = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbnamapanggil"];
            lname.Text = txtnamapanggil.Text;
            TextObject a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbjeniskelamin"];
            a.Text = txtjeniskelamin.Text;
            TextObject b = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbtempattinggal"];
            b.Text = txttempatlahir.Text;
            TextObject c = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbagama"];
            c.Text = txtagama.Text;
            TextObject d= (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbkewargan"];
            d.Text = txtkewarganegaraan.Text;
            TextObject ee = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbanake"];
            ee.Text = txtanake.Text;
            TextObject f = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["lbjumlahsaudara"];
            f.Text = txtanake.Text;
            TextObject fd = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text49"];
            fd.Text = txtnis.Text;
            TextObject fdd = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text50"];
            fdd.Text = txtnisn.Text;
            TextObject g = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text110"];
            g.Text = txtanakyatim.Text;
            TextObject h = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text111"];
            h.Text = txtbahasasehari.Text;
            TextObject i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text112"];
            i.Text = txtalamat.Text;
            TextObject j = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text113"];
            j.Text = txtselamasekolahtinggaldi.Text;
            TextObject k = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text114"];
            k.Text = txtjarak.Text;
            TextObject l = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text115"];
            l.Text = txtkesekolahjalankaki.Text;
            TextObject m = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text116"];
            m.Text = txtberat.Text;
            TextObject n = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text117"];
            TextObject o = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text118"];
            n.Text = txttinggi.Text;

            TextObject p = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text119"];
            TextObject q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text120"];
            TextObject r = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text121"];
            TextObject s = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text122"];
            TextObject t = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text123"];
            o.Text = txtberatketikalulus.Text;
            TextObject u = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text124"];
            TextObject v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text125"];
            p.Text = txttinggiketikalulus.Text;
            q.Text = txtgolongandarah.Text;

            r.Text = txtriwayatpenyakit.Text;
            s.Text = txtkelainanlain.Text;
            t.Text = txtasalsmp.Text;
            u.Text = txtalamatsmp.Text;
            v.Text = txttgldannoijazah.Text;

            TextObject w = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text126"];
                      w.Text = txtpindahandikelas.Text;




            TextObject x = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text126"];
            x.Text = txtpindahandikelas.Text;

            TextObject y = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text127"];
            y.Text = txtdarisma.Text;

            TextObject z = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text128"];
            z.Text = txtasalsmppindahandanno.Text;

            TextObject zz = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text129"];
            zz.Text = txtalamatsmapindahan.Text;

            TextObject zzz = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text130"];
            zzz.Text = txtalasanpindahan.Text;

            TextObject xx = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text89"];
            xx.Text = txtnamaayah.Text;

            TextObject xxx = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text90"];
            xxx.Text = txtlahirayah.Text;

            TextObject xzx = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text91"];
            xzx.Text = txtkewarganegaraanayah.Text;

            TextObject xxxxx = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text92"];
            xxxxx.Text = txtpendidikanayah.Text;

            TextObject xxxxxx = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text93"];
            xxxxxx.Text = txtpekerjaanayah.Text;

            TextObject yy = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text94"];
            yy.Text = txtpenghasilanayah.Text;

            TextObject yyy = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text95"];
            yyy.Text = txtalamatayah.Text;

            TextObject ttt = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text131"];
            ttt.Text = txtnamaibu.Text;

            TextObject rrr = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text132"];
            rrr.Text = txttempatlahiribu.Text;

            TextObject uu5 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text133"];
            uu5.Text = txtkewarganegaraanibu.Text;

            TextObject ttt5 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text134"];
            ttt5.Text = txtpendidikanibu.Text;

            TextObject rr5r = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text135"];
            rr5r.Text = txtpekerjaanibu.Text;

            TextObject u5u = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text136"];
            u5u.Text = txtpenghasilanibu.Text;

            TextObject us5u = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text137"];
            us5u.Text = txtalamatibu.Text;
         
            frm.crystalReportViewer1.ReportSource = studrpt;
            frm.Show();
        }

        private void txtbahasasehari_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            // dlg.Title = "Seleccione una imagen";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
               txtgambar.Text = openfd.FileName.ToString();
                pictureBox1.ImageLocation = openfd.FileName;
                pictureBox1.Image = new Bitmap(openfd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            label52.Hide();
            label53.Hide();
            Nama.Hide();
            label51.Hide();
            textBox4.Hide();
            textBox3.Hide();
            textBox2.Hide();
            textBox1.Hide();

            dataGridView11.Hide();
            button3.Hide();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
         //   dbstuden.disp("SELECT nis, namalengkap, status From siswasma WHERE tahunmasuk = '2018'", dataGridView11);


        }
        public void an()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);

            conn.Open();
            string insertquery = " Select * from percobaan where id ='"+txtnis.Text+"'";

            MySqlCommand command = new MySqlCommand(insertquery, conn);
            DataTable tablle = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);

            da.Fill(tablle);
            // textBox1.Name = tablle.Rows[0][1].ToString();

            byte[] img = (byte[])tablle.Rows[0][2];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            //  dataGridView1.Dispose();
        }
        public void asn()
        {

           
         
            
              }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            asn();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
          //  if (comboBox2.Text == "10")
        //    {
              //  string f = comboBox1.Text;
     //           string y = comboBox2.Text;
      //          MessageBox.Show("kelas10");
                //dbstuden.disp("SELECT nis, namalengkap, status From siswasma WHERE tahunmasuk = '%" + f + "%' and keterangan = '10'", dataGridView11);
       //     } if (comboBox2.Text == "11")
//{
          //  string f = comboBox1.Text;
         //       string y = comboBox2.Text;
                //  dbstuden.disp("SELECT nis, namalengkap, status From siswasma WHERE tahunmasuk = '%" + f + "%' and keterangan = '11'", dataGridView11);
            //    MessageBox.Show("kelas11");
          //  } if (comboBox2.Text == "12")
          //  {
               // string f = comboBox1.Text;
              //  string y = comboBox2.Text;
             //   MessageBox.Show("kelas12");
                //   dbstuden.disp("SELECT nis, namalengkap, status From siswasma WHERE tahunmasuk = '%" + f + "%' and keterangan = '12'", dataGridView11);
       //  }
         //   else
          //  {
                // MessageBox.Show("kelas12");
              //  string f = comboBox1.Text;
             //   string y = comboBox2.Text;
                // dbstuden.disp("SELECT nis, namalengkap, status From siswasma ", dataGridView11);
            //}

        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
           
           
          //  dbstuden.disp("SELECT nis, namalengkap, status From siswasma WHERE tahunmasuk = '%" + textBox2.Text + "%'", dataGridView11);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (txttus == "IPA")
            {

                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPA' and nis LIKE '%" + textBox2.Text + "%'", dataGridView11);

            }
            else if (txttus == "IPS")
            {
                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPS' and nis LIKE '%" + textBox2.Text + "%'", dataGridView11);
            }
            else
            {
                dbstuden.disp("SELECT nis, namalengkap,status,keterangan,tahunmasuk  From siswasma WHERE namalengkap LIKE '" + textBox1.Text + "'" , dataGridView11);
                
            }


            // dbstuden.disp("SELECT nis, namalengkap, keterangan From siswasma ", dataGridView11);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            label53.Visible = true;
            if (txttus == "IPA")
            {

                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPA' and tahunmasuk LIKE '%" + textBox3.Text + "%'", dataGridView11);

            }
            else if (txttus == "IPS")
            {
                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPS' and tahunmasuk LIKE '%" + textBox3.Text + "%'", dataGridView11);
            }
            else
            {
                dbstuden.disp("SELECT nis, namalengkap,status,keterangan  From siswasma WHERE namalengkap LIKE '" + textBox1.Text + "'", dataGridView11);
              
            }


            // dbstuden.disp("SELECT nis, namalengkap, keterangan From siswasma ", dataGridView11);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (txttus == "IPA")
            {

                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPA' and tahunmasuk LIKE '%" + textBox3.Text + "%' and keterangan LIKE '%" + textBox4.Text + "%' ", dataGridView11);

            }
            else if (txttus == "IPS")
            {
                dbstuden.disp("SELECT nis, namalengkap, status,keterangan,tahunmasuk From siswasma WHERE status = 'IPS' and tahunmasuk LIKE '%" + textBox3.Text + "%'and keterangan LIKE '%" + textBox4.Text + "%'", dataGridView11);
            }
            else
            {
                dbstuden.disp("SELECT nis, namalengkap,status,keterangan,tahunmasuk  From siswasma WHERE namalengkap LIKE '" + textBox1.Text + "'", dataGridView11);

            }


            // dbstuden.disp("SELECT nis, namalengkap, keterangan From siswasma ", dataGridView11);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);

            conn.Open();
            string insertquery = " Select * from percobaan where id ='"+txtnis.Text+"'";

            MySqlCommand command = new MySqlCommand(insertquery, conn);
            DataTable tablle = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);

            da.Fill(tablle);
            // textBox1.Name = tablle.Rows[0][1].ToString();

            byte[] img = (byte[])tablle.Rows[0][2];
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
           
        }
    }

}
