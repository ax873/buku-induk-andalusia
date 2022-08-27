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
    public partial class TampilNilai : Form
    {
        public static string id;
        public static string agama;
        public static string txtnis;
        public static string txtnisn;
        public static string txtalamatsmapindahan;
        public static string txtnamalengkap;
        public static string txtjeniskelamin;
        public static string txttempatlahir;
        public static string txtasalsmp;
             public static string txtalamatsmp;
        public static string txtpindahandikelas;
        public static string txtanake;
               public static string txtditerimasekolahpadatanggal;
        public static string txtkelainanlain;
        public static string txtriwayatpenyakit;
        public static string txttinggiketikalulus;
             public static string txtselamasekolahtinggaldi;
        public static string extr;
        public static string txtnamaayah;
            public static string txtberat;
        public static string txttempatlahirR;
        public static string txtalasanpindahan;
        public static string txtpenghasilanayah;
        public static string txtalamatayah;
        public static string txtasalsmppindahandanno;
        public static string txtditerimadisekolahpindah;
        public static string txttgldannoijazah;
        public static string txtpendidikanibu;
        public static string txtkewarganegaraan;
        public static string txtpekerjaanayah;
              public static string txtberatketikalulus;
        public static string txtpendidikanayah;
        public static string txtgolongandarah;
             public static string txtnamaibu;
        public static string txtket;
        public static string txtjumlahsaudara;
            public static string txtdarisma;
        public static string txtkesekolahjalankaki;
              public static string txttahun;
        public static string txtanakyatim;
               public static string txtjarak;
        public static string txtkewarganegaraanayah;
        public static string txtalamatsmapindahanN;
        public static string txtbahasasehari;
        public static string txttempatlahiribu;
              public static string txtkewarganegaraanibu;
        public static string txtnamapanggil;
             public static string txtalamat;
        public static string txtpekerjaanibu;
              public static string txtpenghasilanibu;
        public static string txtalamatibu;
             public static string txtstatus;
            public static string txtgambar;
        public static string kata;
        public TampilNilai()
        {
           
            InitializeComponent();
                       anj();
            display();

        }
        public void anj()
        {
            label2.Text = menuutama.txtstatus;
            
        }
       
        public void display()
        {

            if (label2.Text == "IPA")
            {
                dbstuden.disp("SELECT no, nisn, nis, namalengkap,status,keterangan,tahunmasuk,tam1 From siswasma WHERE status = 'IPA'", dataGridView11);
            } 
            else if (label2.Text == "IPS")
            {
                dbstuden.disp("SELECT no, nisn, nis, namalengkap,status,keterangan,tahunmasuk,tam1 From siswasma WHERE status = 'IPS'", dataGridView11);
            }
            else
            {
                dbstuden.disp("SELECT no, nisn, nis, namalengkap,status,keterangan,tahunmasuk,tam1 From siswasma", dataGridView11);
            }
          
              

         
            
            



            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                id = dataGridView11.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtnamalengkap = dataGridView11.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtstatus = dataGridView11.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtket = dataGridView11.Rows[e.RowIndex].Cells[9].Value.ToString();
                extr = dataGridView11.Rows[e.RowIndex].Cells[11].Value.ToString();
                kata = "PENGETAHUAN";
                persemester a = new persemester();
                a.Text = id;
                a.Text = kata;
                a.Text = txtstatus;
                a.Text = txtnamalengkap;
                a.Text = txtket;
                a.Show();


            }


            else if (e.ColumnIndex == 1)
            {

                id = dataGridView11.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtnamalengkap = dataGridView11.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtstatus = dataGridView11.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtket = dataGridView11.Rows[e.RowIndex].Cells[9].Value.ToString();
                extr = dataGridView11.Rows[e.RowIndex].Cells[11].Value.ToString();

                kata = "KETERAMPILAN";
                persemester a = new persemester();
                a.Text = id;
                a.Text = kata;
                a.Text = txtstatus;
                a.Text = txtnamalengkap;
                a.Text = txtket;
                a.Show();




            }
           

            else if (e.ColumnIndex == 2)
            {
                id = dataGridView11.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtnamalengkap = dataGridView11.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtstatus = dataGridView11.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtket = dataGridView11.Rows[e.RowIndex].Cells[9].Value.ToString();
                extr = dataGridView11.Rows[e.RowIndex].Cells[11].Value.ToString();

                kata = "MENU PRESTASI";
                menuprestasi a = new menuprestasi();
                a.Text = id;
                a.Text = kata;
                a.Text = txtstatus;
                a.Text = txtnamalengkap;
                a.Text = txtket;
                a.Show();

            }
          

          else  if (e.ColumnIndex == 3)
            {
                id = dataGridView11.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtnamalengkap = dataGridView11.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtstatus = dataGridView11.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtket = dataGridView11.Rows[e.RowIndex].Cells[9].Value.ToString();
                extr = dataGridView11.Rows[e.RowIndex].Cells[11].Value.ToString();


                kata = "PRINT NILAI";
                persemester a = new persemester();
                a.Text = id;
                a.Text = kata;
                a.Text = txtstatus;
                a.Text = txtnamalengkap;
                a.Text = txtket;
                a.Show();
            }
            else
            {
                MessageBox.Show("pencet sing bener");
            }


        }

        private void dataGridView11_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }

        private void TampilNilai_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // dbstuden.displayseacr("SELECT nisn,namalengkap From siswasma WHERE Name LIKE '%" + textBox1.Text + "%'", dataGridView11);
            dbstuden.disp("SELECT no, nisn, nis, namalengkap,status,keterangan,tahunmasuk,tam1 From siswasma where nis LIKE '%" + textBox1.Text + "%' OR namalengkap LIKE '%" + textBox1.Text + "%' OR status LIKE '%" + textBox1.Text + "%' OR  keterangan LIKE '%" + textBox1.Text + "%' OR tahunmasuk LIKE '%" + textBox1.Text + "%'", dataGridView11);
        }
    }
}
