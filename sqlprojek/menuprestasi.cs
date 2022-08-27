using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace sqlprojek
{
    public partial class menuprestasi : Form
    {
        public string id;
        public menuprestasi()
        {
            InitializeComponent();
            anj();
            refref();
        }
        public void anj()
        {
            y.Text = TampilNilai.id;
            label2.Text = TampilNilai.txtstatus;
            label3.Text = TampilNilai.txtnamalengkap;
            label4.Text = TampilNilai.txtket;
            label5.Text = TampilNilai.kata;
            //     dbstuden.disp("SELECT * From nilaipengetahuan where no ='" + txtno.Text + "' ", dataGridView11);
            string sql = "SELECT * From prestasi where no ='" + y.Text + "' ";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtkepribadian.Text = (dr["kepribadian"].ToString());
            }

            }

        public void refref()
        {
         if (txtkepribadian.Text=="")
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = false;

                string sql = "SELECT * From prestasi where no ='" + y.Text + "' ";
                MySqlConnection conn = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    y.Text = (dr["no"].ToString());
                    label2.Text = (dr["status"].ToString());
                    label3.Text = (dr["namalengkap"].ToString());
                    label4.Text = (dr["keterangan"].ToString());
                    txtiq.Text = (dr["iq"].ToString());
                    txtkepribadian.Text = (dr["kepribadian"].ToString());
                    txtkesenian.Text = (dr["kesenian"].ToString());
                    txtolahraga.Text = (dr["olahraga"].ToString());
                    txtOrganisasi.Text = (dr["organisasi"].ToString());
                    txtpramuka.Text = (dr["pramuka"].ToString());
                    txtkaryatulis.Text = (dr["karya"].ToString());
                    txtbeas1.Text = (dr["bea1"].ToString());
                    txtbeas2.Text = (dr["bea2"].ToString());
                    txtbeas3.Text = (dr["bea3"].ToString());

                    txtlapbeas1.Text = (dr["dari1"].ToString());
                    txtleapbeas2.Text = (dr["dari2"].ToString());
                    txtlapbeas3.Text = (dr["bea3"].ToString());

                    txttamat.Text = (dr["tamat"].ToString());
                    txtlanjut.Text = (dr["melanjutkan"].ToString());
                    txtalamt.Text = (dr["alamatmelanjutkan"].ToString());
                    txtpindahke.Text = (dr["pindahsekolahke"].ToString());
                    txttanggalpindah.Text = (dr["tanggalpindah"].ToString());
                    txtalamatsekolahpindah.Text = (dr["alamatsekolahpindahan"].ToString());
                    txtputussekolah.Text = (dr["putussekolah"].ToString());

                    txtcatatan.Text = (dr["catatanlain"].ToString());
                    txtnamawali.Text = (dr["namawali"].ToString());
                    txttempatlahirwali.Text = (dr["tempatlahirwali"].ToString());
                    txtkewarganegaraan.Text = (dr["kewarganegaraan"].ToString());
                    txtpendidikantertinggiwali.Text = (dr["pendidikantertinggiwali"].ToString());
                    txtpekerjaan.Text = (dr["pekerjaan"].ToString());
                    txtpenghasilan.Text = (dr["penghasilan"].ToString());
                   
                   
                    txtalamatwa.Text = (dr["alamat"].ToString());
                    txthubungan.Text = (dr["hubungan"].ToString());
                   



                }
            }
               

        }
        private void menuprestasi_Load(object sender, EventArgs e)
        {

        }
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clasprestasi std = new clasprestasi(y.Text.Trim(), label3.Text.Trim(), label2.Text.Trim(), label4.Text.Trim(), txtiq.Text.Trim(), txtkepribadian.Text.Trim(), txtkesenian.Text.Trim(), txtolahraga.Text.Trim(), txtOrganisasi.Text.Trim(), txtpramuka.Text.Trim(), txtkaryatulis.Text.Trim(), txtbeas1.Text.Trim(), txtbeas2.Text.Trim(), txtbeas3.Text.Trim(), txtlapbeas1.Text.Trim(), txtleapbeas2.Text.Trim(), txtlapbeas3.Text.Trim(), txtlanjut.Text.Trim(), 
                txtalamt.Text.Trim(), txtpindahke.Text.Trim(),txttanggalpindah.Text.Trim(), txtalamatsekolahpindah.Text.Trim(), txtputussekolah.Text.Trim(), txtcatatan.Text.Trim(), txtnamawali.Text.Trim(), txttempatlahirwali.Text.Trim(), txtkewarganegaraan.Text.Trim(), txtpendidikantertinggiwali.Text.Trim(), txtpekerjaan.Text.Trim(),txtpenghasilan.Text.Trim(), txtalamatwa.Text.Trim(), txthubungan.Text.Trim(), txttamat.Text.Trim());
            dbstuden.tambahprestasi(std);
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = y.Text;
            clasprestasi std = new clasprestasi(y.Text.Trim(), label3.Text.Trim(), label2.Text.Trim(), label4.Text.Trim(), txtiq.Text.Trim(), txtkepribadian.Text.Trim(), txtkesenian.Text.Trim(), txtolahraga.Text.Trim(), txtOrganisasi.Text.Trim(), txtpramuka.Text.Trim(), txtkaryatulis.Text.Trim(), txtbeas1.Text.Trim(), txtbeas2.Text.Trim(), txtbeas3.Text.Trim(), txtlapbeas1.Text.Trim(), txtleapbeas2.Text.Trim(), txtlapbeas3.Text.Trim(), txtlanjut.Text.Trim(),
                txtalamt.Text.Trim(), txtpindahke.Text.Trim(), txttanggalpindah.Text.Trim(), txtalamatsekolahpindah.Text.Trim(), txtputussekolah.Text.Trim(), txtcatatan.Text.Trim(), txtnamawali.Text.Trim(), txttempatlahirwali.Text.Trim(), txtkewarganegaraan.Text.Trim(), txtpendidikantertinggiwali.Text.Trim(), txtpekerjaan.Text.Trim(), txtpenghasilan.Text.Trim(), txtalamatwa.Text.Trim(), txthubungan.Text.Trim(), txttamat.Text.Trim());

            dbstuden.ubahdaa(std,id);
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            printprestasi frm = new printprestasi();
            CrystalReport1 studrpt = new CrystalReport1();


            TextObject vv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text107"];
            vv.Text = txtiq.Text;

            TextObject vGv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text108"];
            vGv.Text = txtkepribadian.Text;

            TextObject Zvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text109"];
            Zvv.Text = txtkesenian.Text;

            TextObject vvS = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text111"];
            vvS.Text = txtOrganisasi.Text;

            TextObject vTv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text110"];
            vTv.Text = txtolahraga.Text;

            TextObject vJv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text112"];
            vJv.Text = txtpramuka.Text;

            TextObject vBv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text113"];
            vBv.Text = txtkaryatulis.Text;

            TextObject vhuv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text20"];
            vhuv.Text = txthubungan.Text;

            TextObject vaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text21"];
            vaav.Text = txtalamatwa.Text;

            TextObject vaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text22"];
            vaaav.Text = txtpenghasilan.Text;

            TextObject vssv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text23"];
            vssv.Text = txtpekerjaan.Text;

            TextObject vasv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text24"];
            vasv.Text = txtpendidikantertinggiwali.Text;

            TextObject vsav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text25"];
            vsav.Text = txtkewarganegaraan.Text;

            TextObject vasav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text26"];
            vasav.Text = txttempatlahirwali.Text;

            TextObject vvss = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text27"];
            vvss.Text = txtnamawali.Text;




            TextObject v3v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text45"];
            v3v.Text = txtbeas1.Text;


            TextObject v4v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text49"];
            v4v.Text = txtbeas2.Text;

            TextObject v5v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text53"];
            v5v.Text = txtbeas3.Text;



            TextObject lavv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text46"];
            lavv.Text = txtlapbeas1.Text;

            TextObject vlav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text50"];
            vlav.Text = txtleapbeas2.Text;

            TextObject vlavla = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text54"];
            vlavla.Text = txtlapbeas3.Text;




            TextObject uyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text125"];
            uyvv.Text = txttamat.Text;

            TextObject uyvvs = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text126"];
            uyvvs.Text = txtlanjut.Text;

            TextObject uyvsv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text127"];
            uyvsv.Text = txtalamt.Text;

            TextObject fuyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text128"];
            fuyvv.Text = txttanggalpindah.Text;

            TextObject ufyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text129"];
            ufyvv.Text = txtalamatsekolahpindah.Text;

            TextObject uafyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text130"];
            uafyvv.Text = txtputussekolah.Text;

            TextObject fgguyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text12"];
            fgguyvv.Text = txtcatatan.Text;




            TextObject gfuyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["nama"];
            gfuyvv.Text = label3.Text;

            TextObject hhuyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["kelas"];
            hhuyvv.Text = label2.Text;

            TextObject jjuyvv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text18"];
            jjuyvv.Text = label4.Text;

          




            frm.crystalReportViewer1.ReportSource = studrpt;
            frm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
