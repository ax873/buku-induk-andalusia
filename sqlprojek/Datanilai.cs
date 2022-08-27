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
    public partial class Datanilai : Form
    {
        public string id, pelsm,bantuuin,se1,se2, banin,extratambahan,cobalagi,bangke;
        double a,aa,aaa;
        string kkmagaama, kkmpkna, kkmindonesia, kkmingris, kkmmtk, kkmjawa, kkmsosio, kkmbioo, kkmfisika, kkmkimia, kkmgeog, kkmekono, kkmsejarahindonesia, kkmsejarah, kkmsenibudaya, kkmolahraga, kkmtik, kkmbahasarab, kkmpkwu, kkmmtkpwminatan;
        string kkmagaamaa, kkmpknaa, kkmindonesiaa, kkmingrisa, kkmmtka, kkmjawaa, kkmsosioa, kkmbiooa, kkmfisikaa, kkmkimiaa, kkmgeoga, kkmekonoa, kkmsejarahindonesiaa, kkmsejaraha, kkmsenibudayaa, kkmolahragaa, kkmtika, kkmbahasaraba, kkmpkwua, kkmmtkpwminatana;


        decimal b, bantula;
        public Datanilai()
        {
            InitializeComponent();
            anj();
             refres();
            rr();
            sembunyilpanel7();
            ipaa();
         paksa();

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

        public void anj()
        {
            pelnama.Enabled = false;
            extratambahan = persemester.exttr;
            txtno.Text = persemester.idd;
            pelid.Text = persemester.tdxtstatus;
            pelnama.Text = persemester.tdxtnamalengkap;
            pelkelas.Text = persemester.tdxtket;
            label57.Text = persemester.kdata;
            label58.Text = persemester.semes;
            pelsm = txtno.Text + "_" + label58.Text;
             bangke = persemester.cuk;
           
            double bantuasa = double.Parse(bangke);
             bantula = Convert.ToDecimal(bantuasa + 1);
            labelbantu.Text = ""+bantula;
            bantuuin = txtno.Text + "_SEMESTER"+labelbantu.Text;
            banin = "SEMESTER" + labelbantu.Text;
            se1 = label58.Text;
            se2 = banin;
          
        }
        public void ipaa()
        {
            if (pelid.Text=="IPA")
            {
                pelsosiolog.Enabled = false;
                pelsosiolog.Text = "";
                txtsejarahips.Enabled = false;
                pelgeograf.Enabled = false;
                pelgeograf.Text = "";
                pelekonomi.Enabled = false;
                pelekonomi.Text = "";
            }
            else if (pelid.Text == "IPS")
            {
                penjurusanbiologi.Enabled = false;
                penjurusanbiologi.Text = "";
                penjurusanfisika.Enabled = false;
                penjurusanfisika.Text = "";
                penjurusankimia.Enabled = false;
                penjurusankimia.Text = "";
                txtmtkpemintata.Enabled = false;
                    txtmtkpemintata.Text = "";
            }
            else
            {
                MessageBox.Show("Isilah Itu Jurusannya nanti ERROR");
                panel1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label57.Text == "PENGETAHUAN")
            {
                 pelsm = txtno.Text+"_"+label58.Text;
                ValueTambah std = new ValueTambah(txtno.Text.Trim(), pelnama.Text.Trim(), peltahun.Text.Trim(), pelkelas.Text.Trim(), pelsm.Trim(), pelagama.Text.Trim(), pelpkn.Text.Trim(), pelindo.Text.Trim(), pelinggris.Text.Trim(), pelmtk.Text.Trim(), penjurusanbiologi.Text.Trim(), penjurusanfisika.Text.Trim(), penjurusankimia.Text.Trim(), penjurusansejarah.Text.Trim(), pelgeograf.Text.Trim(), pelsosiolog.Text.Trim(), pelekonomi.Text.Trim(), pelsenibudy.Text.Trim(), pelolahraga.Text.Trim(), peltik.Text.Trim(), pelbjawa.Text.Trim(), peltambahan.Text.Trim(),txtpramuka.Text.Trim(), txtarab.Text.Trim(), txtkelakuan.Text.Trim(), txtdisiplin.Text.Trim(), txtkettrampil.Text.Trim(), txtkebersihan.Text.Trim(), txtsakit.Text.Trim(), txtizin.Text.Trim(), txttanpa.Text.Trim(), txtcatatan1.Text.Trim(), txtcatatan2.Text.Trim(), txtperingkat.Text.Trim(), txtmtkpemintata.Text.Trim(), txttambahanarab.Text.Trim(), txtpkwu.Text.Trim(), txtsejarahips.Text.Trim());
                dbstuden.tambahpengetahuan(std);

            }
           if  (label57.Text == "KETERAMPILAN")
            {
                pelsm = txtno.Text + "_" + label58.Text;
                ValueTambah std = new ValueTambah(txtno.Text.Trim(), pelnama.Text.Trim(), peltahun.Text.Trim(), pelkelas.Text.Trim(), pelsm.Trim(), pelagama.Text.Trim(), pelpkn.Text.Trim(), pelindo.Text.Trim(), pelinggris.Text.Trim(), pelmtk.Text.Trim(), penjurusanbiologi.Text.Trim(), penjurusanfisika.Text.Trim(), penjurusankimia.Text.Trim(), penjurusansejarah.Text.Trim(), pelgeograf.Text.Trim(), pelsosiolog.Text.Trim(), pelekonomi.Text.Trim(), pelsenibudy.Text.Trim(), pelolahraga.Text.Trim(), peltik.Text.Trim(), pelbjawa.Text.Trim(), peltambahan.Text.Trim(), txtpramuka.Text.Trim(), txtarab.Text.Trim(), txtkelakuan.Text.Trim(), txtdisiplin.Text.Trim(), txtkettrampil.Text.Trim(), txtkebersihan.Text.Trim(), txtsakit.Text.Trim(), txtizin.Text.Trim(), txttanpa.Text.Trim(), txtcatatan1.Text.Trim(), txtcatatan2.Text.Trim(), txtperingkat.Text.Trim(), txtmtkpemintata.Text.Trim(), txttambahanarab.Text.Trim(), txtpkwu.Text.Trim(), txtsejarahips.Text.Trim());
                dbstuden.tambahketerampilan(std);
            }
        }
      public void munculpanel7()
        {
         panel7.Visible = true;

        }
        public void sembunyilpanel7()
        {
        panel7.Visible = false;

        }
        public void refres()
        {
           
            if (label57.Text == "PENGETAHUAN")
            {
                pelsemster.Enabled = false;
                string sql = "SELECT * From nilaipengetahuan where semester ='" + pelsm + "' ";
                MySqlConnection conn = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtpramuka.Text = (dr["pramuka"].ToString());
                    txtarab.Text = (dr["tambahanextra"].ToString());
                    txtkelakuan.Text = (dr["kelakuan"].ToString());
                    txtdisiplin.Text = (dr["disiplin"].ToString());
                    txtkettrampil.Text = (dr["trampilan"].ToString());
                    txtkebersihan.Text = (dr["kebersihan"].ToString());
                    txtsakit.Text = (dr["sakit"].ToString());
                    txtizin.Text = (dr["izin"].ToString());
                    txttanpa.Text = (dr["tanpaizin"].ToString());
                    txtcatatan1.Text = (dr["catatan1"].ToString());
                    txtcatatan2.Text = (dr["catatan2"].ToString());
                    txtperingkat.Text = (dr["peringkat"].ToString());

                    pelagama.Text = (dr["pendagamanilai"].ToString());
                    pelpkn.Text = (dr["penpkn"].ToString());
                    pelindo.Text = (dr["penindo"].ToString());
                    pelinggris.Text = (dr["peninggris"].ToString());
                    pelmtk.Text = (dr["penmtk"].ToString());
                    penjurusanbiologi.Text = (dr["penprogbiologi"].ToString());
                    penjurusanfisika.Text = (dr["penprogfisika"].ToString());
                    penjurusankimia.Text = (dr["penprogkimia"].ToString());
                    penjurusansejarah.Text = (dr["penprogsejarah"].ToString());
                    pelgeograf.Text = (dr["penproggeografi"].ToString());
                    pelsosiolog.Text = (dr["penprogsosiologi"].ToString());
                    pelekonomi.Text = (dr["penprogekonomi"].ToString());
                    pelsenibudy.Text = (dr["penprogsenibudaya"].ToString());
                    pelolahraga.Text = (dr["penprogolahraga"].ToString());
                    peltik.Text = (dr["penprogtik"].ToString());
                    pelbjawa.Text = (dr["penjawa"].ToString());
                    peltambahan.Text = (dr["pentambahan"].ToString());
                    peltahun.Text = (dr["tahunpel"].ToString());
                    pelsemster.Text = (dr["semester"].ToString());

                    txtmtkpemintata.Text = (dr["mtkpeminatan"].ToString());
                    txttambahanarab.Text = (dr["arab"].ToString());
                    txtpkwu.Text = (dr["pkwu"].ToString());
                    txtsejarahips.Text = (dr["sejarah"].ToString());





                }
                if (pelagama.Text == "")
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Visible = false;
                }
                else
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Visible = false;
                }
            }
            if (label57.Text == "KETERAMPILAN")
            {
                pelsemster.Enabled = false;
                string sql = "SELECT * From nilaiketerampilan where semester ='" + pelsm + "' ";
                MySqlConnection conn = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dor = cmd.ExecuteReader();
                if (dor.Read())
                {
                    pelagama.Text = (dor["pendagamanilai"].ToString());
                    pelpkn.Text = (dor["penpkn"].ToString());
                    pelindo.Text = (dor["penindo"].ToString());
                    pelinggris.Text = (dor["peninggris"].ToString());
                    pelmtk.Text = (dor["penmtk"].ToString());
                    penjurusanbiologi.Text = (dor["penprogbiologi"].ToString());
                    penjurusanfisika.Text = (dor["penprogfisika"].ToString());
                    penjurusankimia.Text = (dor["penprogkimia"].ToString());
                    penjurusansejarah.Text = (dor["penprogsejarah"].ToString());
                    pelgeograf.Text = (dor["penproggeografi"].ToString());
                    pelsosiolog.Text = (dor["penprogsosiologi"].ToString());
                    pelekonomi.Text = (dor["penprogekonomi"].ToString());
                    pelsenibudy.Text = (dor["penprogsenibudaya"].ToString());
                    pelolahraga.Text = (dor["penprogolahraga"].ToString());
                    peltik.Text = (dor["penprogtik"].ToString());
                    pelbjawa.Text = (dor["penjawa"].ToString());
                    peltambahan.Text = (dor["pentambahan"].ToString());
                    peltahun.Text = (dor["tahunpel"].ToString());

                    pelsemster.Text = (dor["semester"].ToString());

                    txtpramuka.Text = (dor["pramuka"].ToString());
                    txtarab.Text = (dor["tambahanextra"].ToString());
                    txtkelakuan.Text = (dor["kelakuan"].ToString());
                    txtdisiplin.Text = (dor["disiplin"].ToString());
                    txtkettrampil.Text = (dor["trampilan"].ToString());
                    txtkebersihan.Text = (dor["kebersihan"].ToString());
                    txtsakit.Text = (dor["sakit"].ToString());
                    txtizin.Text = (dor["izin"].ToString());
                    txttanpa.Text = (dor["tanpaizin"].ToString());
                    txtcatatan1.Text = (dor["catatan1"].ToString());
                    txtcatatan2.Text = (dor["catatan2"].ToString());
                    txtperingkat.Text = (dor["peringkat"].ToString());
                    txtmtkpemintata.Text = (dor["mtkpeminatan"].ToString());
                    txttambahanarab.Text = (dor["arab"].ToString());
                    txtpkwu.Text = (dor["pkwu"].ToString());
                    txtsejarahips.Text = (dor["sejarah"].ToString());


                    mtkpem();
                    sejarhips();
                    pkw();
                    atamabhrab();



                }
                if (pelagama.Text == "")
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                    button3.Visible = false;
                }
                else
                {
                    button1.Enabled = false;
                    button2.Enabled = true;
                    button3.Visible = false;
                }
            }
            if (label57.Text == "PRINT NILAI")
            {
                panel1.Enabled = false;
                panel7.Enabled = false;
                button4.Enabled = true;
                peltahun.Enabled = false;
                button1.Visible = false;
                button2.Visible = false;
                string sql = "SELECT * From nilaipengetahuan where semester ='" + pelsm + "' ";
                MySqlConnection conn = GetConnection();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    pelagama.Text = (dtr["pendagamanilai"].ToString());
                    pelpkn.Text = (dtr["penpkn"].ToString());
                    pelindo.Text = (dtr["penindo"].ToString());
                    pelinggris.Text = (dtr["peninggris"].ToString());
                    pelmtk.Text = (dtr["penmtk"].ToString());
                    penjurusanbiologi.Text = (dtr["penprogbiologi"].ToString());
                    penjurusanfisika.Text = (dtr["penprogfisika"].ToString());
                    penjurusankimia.Text = (dtr["penprogkimia"].ToString());
                    penjurusansejarah.Text = (dtr["penprogsejarah"].ToString());
                    pelgeograf.Text = (dtr["penproggeografi"].ToString());
                    pelsosiolog.Text = (dtr["penprogsosiologi"].ToString());
                    pelekonomi.Text = (dtr["penprogekonomi"].ToString());
                    pelsenibudy.Text = (dtr["penprogsenibudaya"].ToString());
                    pelolahraga.Text = (dtr["penprogolahraga"].ToString());
                    peltik.Text = (dtr["penprogtik"].ToString());
                    pelbjawa.Text = (dtr["penjawa"].ToString());
                    peltambahan.Text = (dtr["pentambahan"].ToString());
                    peltahun.Text = (dtr["tahunpel"].ToString());

                    pelsemster.Text = (dtr["semester"].ToString());

                    txtpramuka.Text = (dtr["pramuka"].ToString());
                    txtarab.Text = (dtr["tambahanextra"].ToString());
                    txtkelakuan.Text = (dtr["kelakuan"].ToString());
                    txtdisiplin.Text = (dtr["disiplin"].ToString());
                    txtkettrampil.Text = (dtr["trampilan"].ToString());
                    txtkebersihan.Text = (dtr["kebersihan"].ToString());
                    txtsakit.Text = (dtr["sakit"].ToString());
                    txtizin.Text = (dtr["izin"].ToString());
                    txttanpa.Text = (dtr["tanpaizin"].ToString());
                    txtcatatan1.Text = (dtr["catatan1"].ToString());
                    txtcatatan2.Text = (dtr["catatan2"].ToString());
                    txtperingkat.Text = (dtr["peringkat"].ToString());

                    txtmtkpemintata.Text = (dtr["mtkpeminatan"].ToString());
                    txttambahanarab.Text = (dtr["arab"].ToString());
                    txtpkwu.Text = (dtr["pkwu"].ToString());
                    txtsejarahips.Text = (dtr["sejarah"].ToString());
                    


                }

                string sqll = "SELECT * From nilaiketerampilan where semester ='" + pelsm + "' ";
                MySqlConnection clonn = GetConnection();
                MySqlCommand clmd = new MySqlCommand(sqll, clonn);
                MySqlDataReader dlr = clmd.ExecuteReader();
                if (dlr.Read())
                {
                    pelagama1.Text = (dlr["pendagamanilai"].ToString());
                    pelpkn1.Text = (dlr["penpkn"].ToString());
                    pelindo1.Text = (dlr["penindo"].ToString());
                    pelinggris1.Text = (dlr["peninggris"].ToString());
                    pelmtk1.Text = (dlr["penmtk"].ToString());
                    penjurusanbiologi1.Text = (dlr["penprogbiologi"].ToString());
                    penjurusanfisika1.Text = (dlr["penprogfisika"].ToString());
                    penjurusankimia1.Text = (dlr["penprogkimia"].ToString());
                    penjurusansejarah1.Text = (dlr["penprogsejarah"].ToString());
                    pelgeograf1.Text = (dlr["penproggeografi"].ToString());
                    pelsosiolog1.Text = (dlr["penprogsosiologi"].ToString());
                    pelekonomi1.Text = (dlr["penprogekonomi"].ToString());
                    pelsenibudy1.Text = (dlr["penprogsenibudaya"].ToString());
                    pelolahraga1.Text = (dlr["penprogolahraga"].ToString());
                    peltik1.Text = (dlr["penprogtik"].ToString());
                    pelbjawa1.Text = (dlr["penjawa"].ToString());
                    peltambahan1.Text = (dlr["pentambahan"].ToString());

                    txtpramukaa0.Text = (dlr["pramuka"].ToString());
                    txtaraba0.Text = (dlr["tambahanextra"].ToString());
                    txtkelakuana0.Text = (dlr["kelakuan"].ToString());
                    txtdisiplina0.Text = (dlr["disiplin"].ToString());
                    txtkettrampila0.Text = (dlr["trampilan"].ToString());
                    txtkebersihana0.Text = (dlr["kebersihan"].ToString());
                    txtsakita0.Text = (dlr["sakit"].ToString());
                    txtizina0.Text = (dlr["izin"].ToString());
                    txttanpaa0.Text = (dlr["tanpaizin"].ToString());
                    txtcatatan1a0.Text = (dlr["catatan1"].ToString());
                    txtcatatan2a0.Text = (dlr["catatan2"].ToString());
                    txtperingkata0.Text = (dlr["peringkat"].ToString());

                    txtmtkpemintata0.Text = (dlr["mtkpeminatan"].ToString());
                    txttambahanarab0.Text = (dlr["arab"].ToString());
                    txtpkwu0.Text = (dlr["pkwu"].ToString());
                    txtsejarahips0.Text = (dlr["sejarah"].ToString());



                }

                string sqlal = "SELECT * From nilaipengetahuan where semester ='" + bantuuin + "' ";
                MySqlConnection cloann = GetConnection();
                MySqlCommand clmad = new MySqlCommand(sqlal, cloann);
                MySqlDataReader dlar = clmad.ExecuteReader();
                if (dlar.Read())
                {
                    pelagama1a.Text = (dlar["pendagamanilai"].ToString());
                    pelpkn1a.Text = (dlar["penpkn"].ToString());
                    pelindo1a.Text = (dlar["penindo"].ToString());
                    pelinggris1a.Text = (dlar["peninggris"].ToString());
                    pelmtk1a.Text = (dlar["penmtk"].ToString());
                    penjurusanbiologi1a.Text = (dlar["penprogbiologi"].ToString());
                    penjurusanfisika1a.Text = (dlar["penprogfisika"].ToString());
                    penjurusankimia1a.Text = (dlar["penprogkimia"].ToString());
                    penjurusansejarah1a.Text = (dlar["penprogsejarah"].ToString());
                    pelgeograf1a.Text = (dlar["penproggeografi"].ToString());
                    pelsosiolog1a.Text = (dlar["penprogsosiologi"].ToString());
                    pelekonomi1a.Text = (dlar["penprogekonomi"].ToString());
                    pelsenibudy1a.Text = (dlar["penprogsenibudaya"].ToString());
                    pelolahraga1a.Text = (dlar["penprogolahraga"].ToString());
                    peltik1a.Text = (dlar["penprogtik"].ToString());
                    pelbjawa1a.Text = (dlar["penjawa"].ToString());
                    peltambahan1a.Text = (dlar["pentambahan"].ToString());

                    txtpramukaaa.Text = (dlar["pramuka"].ToString());
                    txtarabaaa.Text = (dlar["tambahanextra"].ToString());
                    txtkelakuanaaa.Text = (dlar["kelakuan"].ToString());
                    txtdisiplinaaa.Text = (dlar["disiplin"].ToString());
                    txtkettrampilaaa.Text = (dlar["trampilan"].ToString());
                    txtkebersihanaaa.Text = (dlar["kebersihan"].ToString());
                    txtsakitaaa.Text = (dlar["sakit"].ToString());
                    txtizinaaa.Text = (dlar["izin"].ToString());
                    txttanpaaaa.Text = (dlar["tanpaizin"].ToString());
                    txtcatatan1aaa.Text = (dlar["catatan1"].ToString());
                    txtcatatan2aaa.Text = (dlar["catatan2"].ToString());
                    txtperingkataaa.Text = (dlar["peringkat"].ToString());

                    txtmtkpemintataaaa.Text = (dlar["mtkpeminatan"].ToString());
                    txtarabaaa.Text = (dlar["arab"].ToString());
                    txtpkwuaaa.Text = (dlar["pkwu"].ToString());
                    txtsejarahipsaaa.Text = (dlar["sejarah"].ToString());

                  

                    agama1a();
                    ppkn1a();
                    indones1a();
                    igggir1a();
                    mtkkk1a();
                    penjurusbiologi1a();
                    penjurusanfisik1a();
                    penjurusankimi1a();
                    penjurusansejara1a();
                    pelgeogra1a();
                    pelsosiolo1a();
                    pelsenibud1a();
                    pelekonom1a();
                    pelti1a();
                    pelbjaw1a();
                    pelbjpeltambahaaw1a();
                    pelolahrag1a();

                }

                string sqlaal = "SELECT * From nilaiketerampilan where semester ='" + bantuuin + "' ";
                MySqlConnection cloaann = GetConnection();
                MySqlCommand clmaad = new MySqlCommand(sqlaal, cloaann);
                MySqlDataReader dlaar = clmaad.ExecuteReader();
                if (dlaar.Read())
                {
                    pelagama1aa.Text = (dlaar["pendagamanilai"].ToString());
                    pelpkn1aa.Text = (dlaar["penpkn"].ToString());
                    pelindo1aa.Text = (dlaar["penindo"].ToString());
                    pelinggris1aa.Text = (dlaar["peninggris"].ToString());
                    pelmtk1aa.Text = (dlaar["penmtk"].ToString());
                    penjurusanbiologi1aa.Text = (dlaar["penprogbiologi"].ToString());
                    penjurusanfisika1aa.Text = (dlaar["penprogfisika"].ToString());
                    penjurusankimia1aa.Text = (dlaar["penprogkimia"].ToString());
                    penjurusansejarah1aa.Text = (dlaar["penprogsejarah"].ToString());
                    pelgeograf1aa.Text = (dlaar["penproggeografi"].ToString());
                    pelsosiolog1aa.Text = (dlaar["penprogsosiologi"].ToString());
                    pelekonomi1aa.Text = (dlaar["penprogekonomi"].ToString());
                    pelsenibudy1aa.Text = (dlaar["penprogsenibudaya"].ToString());
                    pelolahraga1aa.Text = (dlaar["penprogolahraga"].ToString());
                    peltik1aa.Text = (dlaar["penprogtik"].ToString());
                    pelbjawa1aa.Text = (dlaar["penjawa"].ToString());
                    peltambahan1aa.Text = (dlaar["pentambahan"].ToString());

                    txtpramuka1.Text = (dlaar["pramuka"].ToString());
                    txtarab1.Text = (dlaar["tambahanextra"].ToString());
                    txtkelakuan1.Text = (dlaar["kelakuan"].ToString());
                    txtdisiplin1.Text = (dlaar["disiplin"].ToString());
                    txtkettrampil1.Text = (dlaar["trampilan"].ToString());
                    txtkebersihan1.Text = (dlaar["kebersihan"].ToString());
                    txtsakit1.Text = (dlaar["sakit"].ToString());
                    txtizin1.Text = (dlaar["izin"].ToString());
                    txttanpa1.Text = (dlaar["tanpaizin"].ToString());
                    txtcatatan11.Text = (dlaar["catatan1"].ToString());
                    txtcatatan21.Text = (dlaar["catatan2"].ToString());
                    txtperingkat1.Text = (dlaar["peringkat"].ToString());

                    txtmtkpemintata1.Text = (dlaar["mtkpeminatan"].ToString());
                    txttambahanarab1.Text = (dlaar["arab"].ToString());
                    txtpkwu1.Text = (dlaar["pkwu"].ToString());
                    txtsejarahips1.Text = (dlaar["sejarah"].ToString());


                    

                    agama1aa();
                    ppkn1aa();
                    indones1aa();
                    igggir1aa();
                    mtkkk1aa();
                    penjurusbiologi1aa();
                    penjurusanfisik1aa();
                    penjurusankimi1aa();
                    penjurusansejara1aa();
                    pelgeogra1aa();
                    pelsosiolo1aa();
                    pelsenibud1aa();
                    pelekonom1aa();
                    pelti1aa();
                    pelbjaw1aa();
                    pelbjpeltambahaaw1aa();
                    pelolahrag1aa();

                    
                }












                agama1();
                ppkn1();
                indones1();
                igggir1();
                mtkkk1();
                penjurusbiologi1();
                penjurusanfisik1();
                penjurusankimi1();
                penjurusansejara1();
                pelgeogra1();
                pelsosiolo1();
                pelsenibud1();
                pelekonom1();
                pelti1();
                pelbjaw1();
                pelbjpeltambahaaw1();
                pelolahrag1();
            }




            mtkpema();
            sejarhipsa();
            pkwa();
            atamabhraba();

            mtkpem();
            sejarhips();
            pkw();
            atamabhrab();

            mtkpem1();
            sejarhips1();
            pkw1();
            atamabhrab1();

            mtkpem0();
            sejarhips0();
            pkw0();
            atamabhrab0();

            agama();
            ppkn();
            indones();
            igggir();
            mtkkk();
            penjurusbiologi();
            penjurusanfisik();
            penjurusankimi();
            penjurusansejara();
            pelgeogra();
            pelsosiolo();
            pelsenibud();
            pelekonom();
            pelti();
            pelbjaw();
            pelbjpeltambahaaw();
            pelolahrag();


            string qlal = "SELECT * From kkm where no ='" + bangke + "' ";
            MySqlConnection loann = GetConnection();
            MySqlCommand lmad = new MySqlCommand(qlal, loann);
            MySqlDataReader lar = lmad.ExecuteReader();
            if (lar.Read())
            {
                kkmagaama = (lar["agama"].ToString());
                kkmpkna = (lar["pkn"].ToString());
                kkmindonesia = (lar["indo"].ToString());
                kkmingris = (lar["inggris"].ToString());
                kkmmtk = (lar["mtk"].ToString());
                kkmjawa = (lar["jawa"].ToString());
                kkmsosio = (lar["sosiologi"].ToString());
                kkmbioo = (lar["biologi"].ToString());
                kkmfisika = (lar["fisika"].ToString());
                kkmkimia = (lar["kimia"].ToString());

                kkmgeog = (lar["geografi"].ToString());
                kkmekono = (lar["ekonomi"].ToString());
                kkmsejarahindonesia = (lar["sejarahindo"].ToString());
                kkmsenibudaya = (lar["senibudaya"].ToString());
                kkmolahraga = (lar["olahraga"].ToString());
                kkmtik = (lar["tik"].ToString());

                kkmbahasarab = (lar["bahasaarab"].ToString());
                kkmpkwu = (lar["pkwu"].ToString());
                kkmsejarah = (lar["sejarah"].ToString());
                kkmmtkpwminatan = (lar["matematikaminat"].ToString());
               
            }
            else
            {
                MessageBox.Show("Tambahkan KKM lalu Coba Print Ulang");
                kkm n = new kkm();
                n.Show();
            }

            string aqlal = "SELECT * From kkm where no ='" + bantula + "' ";
            MySqlConnection aloann = GetConnection();
            MySqlCommand almad = new MySqlCommand(aqlal, aloann);
            MySqlDataReader alar = almad.ExecuteReader();
            if (alar.Read())
            {
                kkmagaamaa = (alar["agama"].ToString());
                kkmpknaa = (alar["pkn"].ToString());
                kkmindonesiaa = (alar["indo"].ToString());
                kkmingrisa = (alar["inggris"].ToString());
                kkmmtka = (alar["mtk"].ToString());
                kkmjawaa = (alar["jawa"].ToString());
                kkmsosioa = (alar["sosiologi"].ToString());
                kkmbiooa = (alar["biologi"].ToString());
                kkmfisikaa = (alar["fisika"].ToString());
                kkmkimiaa = (alar["kimia"].ToString());

                kkmgeoga = (alar["geografi"].ToString());
                kkmekonoa = (alar["ekonomi"].ToString());
                kkmsejarahindonesiaa = (alar["sejarahindo"].ToString());
                kkmsenibudayaa = (alar["senibudaya"].ToString());
                kkmolahragaa = (alar["olahraga"].ToString());
                kkmtika = (alar["tik"].ToString());

                kkmbahasaraba = (alar["bahasaarab"].ToString());
                kkmpkwua = (alar["pkwu"].ToString());
                kkmsejaraha = (alar["sejarah"].ToString());
                kkmmtkpwminatana = (alar["matematikaminat"].ToString());
                alar.Close();
            }
            else
            {
                MessageBox.Show("Tambahkan KKM lalu Coba Print Ulang");
                kkm n = new kkm();
                n.Show();
            }






        }


        public void mtkpem()
        {
            if (txtmtkpemintata.Text == "")
            {

            }
            else
            {
                a = double.Parse(txtmtkpemintata.Text);
            }

            if (a <= 25 && a > 0)
            {
                lbnmat.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                lbnmat.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                lbnmat.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                lbnmat.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                lbnmat.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat.Text = "" + b;
            }
            else
            {
                lbhmat.Text = "-";
                lbnmat.Text = "-";

            }


        }
        public void atamabhrab()
        {
            if (txttambahanarab.Text == "")
            {

            }
            else
            {
                aa = double.Parse(txttambahanarab.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                lbnar.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                lbnar.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                lbnar.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                lbnar.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                lbnar.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar.Text = "" + b;
            }
            else
            {
                lbnar.Text = "-";
            }


        }
        public void pkw()
        {
            if (txtpkwu.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtpkwu.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnpk.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnpk.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnpk.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnpk.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnpk.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk.Text = "" + b;
            }

            else
            {
                lbnpk.Text = "-";
            }


        }
        public void sejarhips()
        {
            if (txtsejarahips.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtsejarahips.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnsj.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnsj.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnsj.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnsj.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnsj.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj.Text = "" + b;
            }

            else
            {
                lbnsj.Text = "-";
            }


        }


        public void mtkpem1()
        {
            if (txtmtkpemintata1.Text == "")
            {

            }
            else
            {
                a = double.Parse(txtmtkpemintata1.Text);
            }

            if (a <= 25 && a > 0)
            {
                lbnmat3.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat3.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                lbnmat3.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat3.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                lbnmat3.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat3.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                lbnmat3.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat3.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                lbnmat3.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat3.Text = "" + b;
            }
            else
            {
                lbhmat3.Text = "-";
            }


        }
        public void atamabhrab1()
        {
            if (txttambahanarab1.Text == "")
            {

            }
            else
            {
                aa = double.Parse(txttambahanarab1.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                lbnar3.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar3.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                lbnar3.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar3.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                lbnar3.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar3.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                lbnar3.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar3.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                lbnar3.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar3.Text = "" + b;
            }
            else
            {
                lbnar3.Text = "-";
            }


        }
        public void pkw1()
        {
            if (txtpkwu1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtpkwu1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnpk3.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk3.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnpk3.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk3.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnpk3.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk3.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnpk3.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk3.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnpk3.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk3.Text = "" + b;
            }

            else
            {
                lbnpk3.Text = "-";
            }


        }
        public void sejarhips1()
        {
            if (txtsejarahips1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtsejarahips1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnsj3.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj3.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnsj3.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj3.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnsj3.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj3.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnsj3.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj3.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnsj3.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj3.Text = "" + b;
            }

            else
            {
                lbnsj3.Text = "-";
            }


        }

        


        public void mtkpema()
        {
            if (txtmtkpemintataaaa.Text == "")
            {

            }
            else
            {
                a = double.Parse(txtmtkpemintataaaa.Text);
            }

            if (a <= 25 && a > 0)
            {
                lbnmat2.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat2.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                lbnmat2.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat2.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                lbnmat2.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat2.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                lbnmat2.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat2.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                lbnmat2.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat2.Text = "" + b;
            }
            else
            {
                lbnmat2.Text = "-";
                lbhmat2.Text = "-";
            }


        }
        public void atamabhraba()
        {
            if (txttambahanarabaaa.Text == "")
            {

            }
            else
            {
                aa = double.Parse(txttambahanarabaaa.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                lbnar2.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar2.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                lbnar2.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar2.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                lbnar2.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar2.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                lbnar2.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar2.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                lbnar2.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar2.Text = "" + b;
            }
            else
            {
                lbnar2.Text = "-";
                lbhar2.Text = "" ;
            }


        }
        public void pkwa()
        {
            if (txtpkwuaaa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtpkwuaaa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnpk2.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk2.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnpk2.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk2.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnpk2.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk2.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnpk2.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk2.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnpk2.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk2.Text = "" + b;
            }

            else
            {
                lbhpk2.Text = "";
                lbnpk2.Text = "-";
            }


        }
        public void sejarhipsa()
        {
            if (txtsejarahipsaaa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtsejarahipsaaa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnsj2.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj2.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnsj2.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj2.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnsj2.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj2.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnsj2.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj2.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnsj2.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj2.Text = "" + b;
            }

            else
            {
                lbnsj2.Text = "-";
                lbhsj2.Text = "";
            }


        }

        

        public void mtkpem0()
        {
            if (txtmtkpemintata0.Text == "")
            {

            }
            else
            {
                a = double.Parse(txtmtkpemintata0.Text);
            }

            if (a <= 25 && a > 0)
            {
                lbnmat1.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat1.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                lbnmat1.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat1.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                lbnmat1.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat1.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                lbnmat1.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat1.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                lbnmat1.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                lbhmat1.Text = "" + b;
            }
            else
            {
                lbhmat1.Text = "-";
                lbnmat1.Text = "-";
            }


        }
        public void atamabhrab0()
        {
            if (txttambahanarab0.Text == "")
            {

            }
            else
            {
                aa = double.Parse(txttambahanarab0.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                lbnar1.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar1.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                lbnar1.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar1.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                lbnar1.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar1.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                lbnar1.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar1.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                lbnar1.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                lbhar1.Text = "" + b;
            }
            else
            {
                lbhar1.Text = "-";
                lbnar1.Text = "-";
            }


        }
        public void pkw0()
        {
            if (txtpkwu0.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtpkwu0.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnpk1.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk1.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnpk1.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk1.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnpk1.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk1.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnpk1.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk1.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnpk1.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhpk1.Text = "" + b;
            }

            else
            {
                lbhpk1.Text = "";
                lbnpk1.Text = "-";
            }


        }
        public void sejarhips0()
        {
            if (txtsejarahips0.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(txtsejarahips0.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                lbnsj1.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj1.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                lbnsj1.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj1.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                lbnsj1.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj1.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                lbnsj1.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj1.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                lbnsj1.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                lbhsj1.Text = "" + b;
            }

            else
            {
                lbnsj1.Text = "-";
                lbhsj1.Text = "";
            }


        }




        public void agama()
        {
            if (pelagama.Text == "")
            {

            }
            else
            {
                a = double.Parse(pelagama.Text);
            }

            if (a <= 25 && a > 0)
            {
                label1.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                label2.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                label1.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                label2.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                label1.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                label2.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                label1.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                label2.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                label1.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                label2.Text = "" + b;
            }
            else
            {
                label2.Text = "-";
                label1.Text = "-";
            }


        }
        public void ppkn()
        {
            if (pelpkn.Text == "")
            {

            }
            else
            {
                aa = double.Parse(pelpkn.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                label25.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                label26.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                label25.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                label26.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                label25.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                label26.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                label25.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                label26.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                label25.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                label26.Text = "" + b;
            }
            else
            {
                label26.Text = "-";
                label25.Text = "-";
            }


        }
        public void indones()
        {
            if (pelindo.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelindo.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label27.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label27.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label27.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label27.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label27.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28.Text = "" + b;
            }

            else
            {
                label27.Text = "-";
                label28.Text = "-";
            }


        }
        public void igggir()
        {
            if (pelinggris.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelinggris.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label29.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label29.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label29.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label29.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label29.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30.Text = "" + b;
            }

            else
            {
                label30.Text = "-";
                label29.Text = "-";
            }


        }
        public void mtkkk()
        {
            if (pelmtk.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelmtk.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label31.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label31.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label31.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label31.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label31.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32.Text = "" + b;
            }

            else
            {
                label32.Text = "-";
                label31.Text = "-";
            }


        }
        public void penjurusbiologi()
        {
            if (penjurusanbiologi.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanbiologi.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label33.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label33.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label33.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label33.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label33.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34.Text = "" + b;
            }

            else
            {
                label34.Text = "-";
                label33.Text = "-";
            }


        }
        public void penjurusanfisik()
        {
            if (penjurusanfisika.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanfisika.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label35.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label35.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label35.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label35.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label35.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36.Text = "" + b;
            }

            else
            {
                label36.Text = "-";
                label35.Text = "-";
            }


        }
        public void penjurusankimi()
        {
            if (penjurusankimia.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusankimia.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label37.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label37.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label37.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label37.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label37.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38.Text = "" + b;
            }

            else
            {
                label37.Text = "-";
                label37.Text = "-";
            }


        }
        public void penjurusansejara()
        {
            if (penjurusansejarah.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusansejarah.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label39.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label39.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label39.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label39.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label39.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40.Text = "" + b;
            }

            else
            {
                label40.Text = "-";
                label39.Text = "-";
            }


        }
        public void pelgeogra()
        {
            if (pelgeograf.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelgeograf.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label41.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label41.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label41.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label41.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label41.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42.Text = "" + b;
            }

            else
            {
                label42.Text = "-";
                label41.Text = "-";
            }


        }
        public void pelsosiolo()
        {
            if (pelsosiolog.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsosiolog.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label43.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label43.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label43.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label43.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label43.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50.Text = "" + b;
            }

            else
            {
                label50.Text = "-";
                label43.Text = "-";
            }


        }
        public void pelekonom()
        {
            if (pelekonomi.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelekonomi.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label44.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label44.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label44.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label44.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label44.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51.Text = "" + b;
            }

            else
            {
                label51.Text = "-";
                label44.Text = "-";
            }


        }
        public void pelsenibud()
        {
            if (pelsenibudy.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsenibudy.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label45.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label45.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label45.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label45.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label45.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52.Text = "" + b;
            }

            else
            {
                label52.Text = "-";
                label45.Text = "-";
            }


        }
        public void pelti()
        {
            if (peltik.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltik.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label47.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label47.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label47.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label47.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label47.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54.Text = "" + b;
            }

            else
            {
                label54.Text = "-";
                label47.Text = "-";
            }


        }
        public void pelbjaw()
        {
            if (pelbjawa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelbjawa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label48.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label48.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label48.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label48.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label48.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55.Text = "" + b;
            }

            else
            {
                label55.Text = "-";
                label48.Text = "-";
            }


        }
        public void pelbjpeltambahaaw()
        {
            if (peltambahan.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltambahan.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label49.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label49.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label49.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label49.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label49.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56.Text = "" + b;
            }

            else
            {
                label56.Text = "-";
                label49.Text = "-";
            }


        }
        public void pelolahrag()
        {
            if (pelolahraga.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelolahraga.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label46.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label46.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label46.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label46.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label46.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53.Text = "" + b;
            }

            else
            {
                label53.Text = "-";
                label46.Text = "-";
            }


        }



        public void agama1()
        {
            if (pelagama1.Text == "")
            {

            }
            else
            {
                a = double.Parse(pelagama1.Text);
            }

            if (a <= 25 && a > 0)
            {
                label1v.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                label2v.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                label1v.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                label2v.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                label1v.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                label2v.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                label1v.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                label2v.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                label1v.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                label2v.Text = "" + b;
            }
            else
            {
                label2v.Text = "-";
                label1v.Text = "-";
            }


        }
        public void ppkn1()
        {
            if (pelpkn1.Text == "")
            {

            }
            else
            {
                aa = double.Parse(pelpkn1.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                label25v.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                label26v.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                label25v.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                label26v.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                label25v.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                label26v.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                label25v.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                label26v.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                label25v.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                label26v.Text = "" + b;
            }
            else
            {
                label26v.Text = "-";
                label25v.Text = "-";
            }


        }
        public void indones1()
        {
            if (pelindo1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelindo1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label27v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label27v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label27v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label27v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label27v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28v.Text = "" + b;
            }

            else
            {
                label28v.Text = "-";
                label27v.Text = "-";
            }


        }
        public void igggir1()
        {
            if (pelinggris1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelinggris1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label29v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label29v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label29v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label29v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label29v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30v.Text = "" + b;
            }

            else
            {
                label30v.Text = "-";
                label29v.Text = "-";
            }


        }
        public void mtkkk1()
        {
            if (pelmtk1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelmtk1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label31v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label31v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label31v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label31v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label31v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32v.Text = "" + b;
            }

            else
            {
                label32v.Text = "-";
                label31v.Text = "-";
            }


        }
        public void penjurusbiologi1()
        {
            if (penjurusanbiologi1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanbiologi1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label33v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label33v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label33v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label33v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label33v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34v.Text = "" + b;
            }

            else
            {
                label34v.Text = "-";
                label33v.Text = "-";
            }


        }
        public void penjurusanfisik1()
        {
            if (penjurusanfisika1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanfisika1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label35v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label35v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label35v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label35v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label35v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36v.Text = "" + b;
            }

            else
            {
                label36v.Text = "-";
                label35v.Text = "-";
            }


        }
        public void penjurusankimi1()
        {
            if (penjurusankimia1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusankimia1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label37v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label37v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label37v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label37v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label37v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38v.Text = "" + b;
            }

            else
            {
                label38v.Text = "-";
                label37v.Text = "-";
            }


        }
        public void penjurusansejara1()
        {
            if (penjurusansejarah1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusansejarah1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label39v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label39v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label39v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label39v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label39v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40v.Text = "" + b;
            }

            else
            {
                label40v.Text = "-";
                label39v.Text = "-";
            }


        }
        public void pelgeogra1()
        {
            if (pelgeograf1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelgeograf1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label41v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label41v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label41v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label41v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label41v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42v.Text = "" + b;
            }

            else
            {
                label42v.Text = "-";
                label41v.Text = "-";
            }


        }
        public void pelsosiolo1()
        {
            if (pelsosiolog1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsosiolog1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label43v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label43v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label43v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label43v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label43v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50v.Text = "" + b;
            }

            else
            {
                label50v.Text = "-";
                label43v.Text = "-";
            }


        }
        public void pelekonom1()
        {
            if (pelekonomi1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelekonomi1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label44v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label44v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label44v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label44v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label44v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51v.Text = "" + b;
            }

            else
            {
                label51v.Text = "-";
                label44v.Text = "-";
            }


        }
        public void pelsenibud1()
        {
            if (pelsenibudy1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsenibudy1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label45v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label45v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label45v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label45v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label45v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52v.Text = "" + b;
            }

            else
            {
                label52v.Text = "-";
                label45v.Text = "-";
            }


        }
        public void pelti1()
        {
            if (peltik1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltik1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label47v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label47v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label47v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label47v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label47v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54v.Text = "" + b;
            }

            else
            {
                label54v.Text = "-";
                label47v.Text = "-";
            }


        }
        public void pelbjaw1()
        {
            if (pelbjawa1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelbjawa1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label48v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label48v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label48v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label48v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label48v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55v.Text = "" + b;
            }

            else
            {
                label55v.Text = "-";
                label48v.Text = "-";
            }


        }
        public void pelbjpeltambahaaw1()
        {
            if (peltambahan1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltambahan1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label49v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label49v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label49v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label49v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label49v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56v.Text = "" + b;
            }

            else
            {
                label56v.Text = "-";
                label49v.Text = "-";
            }


        }
        public void pelolahrag1()
        {
            if (pelolahraga1.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelolahraga1.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label46v.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53v.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label46v.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53v.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label46v.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53v.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label46v.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53v.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label46v.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53v.Text = "" + b;
            }

            else
            {
                label53v.Text = "-";
                label46v.Text = "-";
            }


        }




        public void agama1a()
        {
            if (pelagama1a.Text == "")
            {

            }
            else
            {
                a = double.Parse(pelagama1a.Text);
            }

            if (a <= 25 && a > 0)
            {
                label1va.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                label2va.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                label1va.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                label2va.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                label1va.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                label2va.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                label1va.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                label2va.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                label1va.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                label2va.Text = "" + b;
            }
            else
            {
                label2va.Text = "-";
                label1va.Text = "-";
            }


        }
        public void ppkn1a()
        {
            if (pelpkn1a.Text == "")
            {

            }
            else
            {
                aa = double.Parse(pelpkn1a.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                label25va.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                label26va.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                label25va.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                label26va.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                label25va.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                label26va.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                label25va.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                label26va.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                label25va.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                label26va.Text = "" + b;
            }
            else
            {
                label26va.Text = "-";
                label25va.Text = "-";
            }


        }
        public void indones1a()
        {
            if (pelindo1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelindo1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label27va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label27va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label27va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label27va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label27va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28va.Text = "" + b;
            }

            else
            {
                label28va.Text = "-";
                label27va.Text = "-";
            }


        }
        public void igggir1a()
        {
            if (pelinggris1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelinggris1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label29va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label29va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label29va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label29va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label29va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30va.Text = "" + b;
            }

            else
            {
                label30va.Text = "-";
                label29va.Text = "-";
            }


        }
        public void mtkkk1a()
        {
            if (pelmtk1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelmtk1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label31va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label31va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label31va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label31va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label31va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32va.Text = "" + b;
            }

            else
            {
                label32va.Text = "-";
                label31va.Text = "-";
            }


        }
        public void penjurusbiologi1a()
        {
            if (penjurusanbiologi1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanbiologi1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label33va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label33va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label33va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label33va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label33va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34va.Text = "" + b;
            }

            else
            {
                label34va.Text = "-";
                label33va.Text = "-";
            }


        }
        public void penjurusanfisik1a()
        {
            if (penjurusanfisika1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanfisika1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label35va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label35va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label35va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label35va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label35va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36va.Text = "" + b;
            }

            else
            {
                label36va.Text = "-";
                label35va.Text = "-";
            }


        }
        public void penjurusankimi1a()
        {
            if (penjurusankimia1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusankimia1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label37va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label37va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label37va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label37va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label37va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38va.Text = "" + b;
            }

            else
            {
                label38va.Text = "-";
                label37va.Text = "-";
            }


        }
        public void penjurusansejara1a()
        {
            if (penjurusansejarah1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusansejarah1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label39va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label39va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label39va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label39va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label39va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40va.Text = "" + b;
            }

            else
            {
                label40va.Text = "-";
                label39va.Text = "-";
            }


        }
        public void pelgeogra1a()
        {
            if (pelgeograf1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelgeograf1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label41va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label41va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label41va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label41va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label41va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42va.Text = "" + b;
            }

            else
            {
                label42va.Text = "-";
                label41va.Text = "-";
            }


        }
        public void pelsosiolo1a()
        {
            if (pelsosiolog1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsosiolog1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label43va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label43va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label43va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label43va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label43va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50va.Text = "" + b;
            }

            else
            {
                label50va.Text = "-";
                label43va.Text = "-";
            }


        }
        public void pelekonom1a()
        {
            if (pelekonomi1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelekonomi1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label44va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label44va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label44va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label44va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label44va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51va.Text = "" + b;
            }

            else
            {
                label51va.Text = "-";
                label44va.Text = "-";
            }


        }
        public void pelsenibud1a()
        {
            if (pelsenibudy1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsenibudy1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label45va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label45va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label45va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label45va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label45va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52va.Text = "" + b;
            }

            else
            {
                label52va.Text = "-";
                label45va.Text = "-";
            }


        }
        public void pelti1a()
        {
            if (peltik1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltik1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label47va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label47va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label47va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label47va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label47va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54va.Text = "" + b;
            }

            else
            {
                label54va.Text = "-";
                label47va.Text = "-";
            }


        }
        public void pelbjaw1a()
        {
            if (pelbjawa1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelbjawa1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label48va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label48va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label48va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label48va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label48va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55va.Text = "" + b;
            }

            else
            {
                label55va.Text = "-";
                label48va.Text = "-";
            }


        }
        public void pelbjpeltambahaaw1a()
        {
            if (peltambahan1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltambahan1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label49va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label49va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label49va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label49va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label49va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56va.Text = "" + b;
            }

            else
            {
                label56va.Text = "-";
                label49va.Text = "-";
            }


        }
        public void pelolahrag1a()
        {
            if (pelolahraga1a.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelolahraga1a.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label46va.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53va.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label46va.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53va.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label46va.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53va.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label46va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label46va.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53va.Text = "" + b;
            }

            else
            {
                label53va.Text = "-";
                label46va.Text = "-";
            }


        }


        public void agama1aa()
        {
            if (pelagama1aa.Text == "")
            {

            }
            else
            {
                a = double.Parse(pelagama1aa.Text);
            }

            if (a <= 25 && a > 0)
            {
                label1vaa.Text = "D";
                decimal b = Convert.ToDecimal(a / 25);
                label2vaa.Text = "" + b;
            }
            else if (a <= 50 && a > 25)
            {
                label1vaa.Text = "C";
                decimal b = Convert.ToDecimal(a / 25);
                label2vaa.Text = "" + b;
            }
            else if (a <= 75 && a > 50)
            {
                label1vaa.Text = "B";
                decimal b = Convert.ToDecimal(a / 25);
                label2vaa.Text = "" + b;
            }
            else if (a <= 100 && a > 75)
            {
                label1vaa.Text = "A";
                decimal b = Convert.ToDecimal(a / 25);
                label2vaa.Text = "" + b;
            }
            else if (a <= 1000 && a > 100)
            {
                label1vaa.Text = "A+";
                decimal b = Convert.ToDecimal(a / 25);
                label2vaa.Text = "" + b;
            }
            else
            {
                label2vaa.Text = "-";
                label1vaa.Text = "-";
            }


        }
        public void ppkn1aa()
        {
            if (pelpkn1aa.Text == "")
            {

            }
            else
            {
                aa = double.Parse(pelpkn1aa.Text);
            }

            if (aa <= 25 && aa > 0)
            {
                label25vaa.Text = "D";
                decimal b = Convert.ToDecimal(aa / 25);
                label26vaa.Text = "" + b;
            }
            else if (aa <= 50 && aa > 25)
            {
                label25vaa.Text = "C";
                decimal b = Convert.ToDecimal(aa / 25);
                label26vaa.Text = "" + b;
            }
            else if (aa <= 75 && aa > 50)
            {
                label25vaa.Text = "B";
                decimal b = Convert.ToDecimal(aa / 25);
                label26vaa.Text = "" + b;
            }
            else if (aa <= 100 && aa > 75)
            {
                label25vaa.Text = "A";
                decimal b = Convert.ToDecimal(aa / 25);
                label26vaa.Text = "" + b;
            }
            else if (aa <= 1000 && aa > 100)
            {
                label25vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aa / 25);
                label26vaa.Text = "" + b;
            }
            else
            {
                label26vaa.Text = "-";
                label25vaa.Text = "-";
            }


        }
        public void indones1aa()
        {
            if (pelindo1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelindo1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label27vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label27vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label27vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label27vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label27vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label28vaa.Text = "" + b;
            }

            else
            {
                label28vaa.Text = "-";
                label27vaa.Text = "-";
            }


        }
        public void igggir1aa()
        {
            if (pelinggris1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelinggris1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label29vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label29vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label29vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label29vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label29vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label30vaa.Text = "" + b;
            }

            else
            {
                label30vaa.Text = "-";
                label29vaa.Text = "-";
            }


        }
        public void mtkkk1aa()
        {
            if (pelmtk1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelmtk1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label31vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label31vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label31vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label31vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label31vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label32vaa.Text = "" + b;
            }

            else
            {
                label32vaa.Text = "-";
                label31vaa.Text = "-";
            }


        }
        public void penjurusbiologi1aa()
        {
            if (penjurusanbiologi1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanbiologi1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label33vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label33vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label33vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label33vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label33vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label34vaa.Text = "" + b;
            }

            else
            {
                label34vaa.Text = "-";
                label33vaa.Text = "-";
            }


        }
        public void penjurusanfisik1aa()
        {
            if (penjurusanfisika1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusanfisika1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label35vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label35vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label35vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label35vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label35vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label36vaa.Text = "" + b;
            }

            else
            {
                label35vaa.Text = "-";
                label36vaa.Text = "-";
            }


        }
        public void penjurusankimi1aa()
        {
            if (penjurusankimia1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusankimia1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label37vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label37vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label37vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label37vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label37vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label38vaa.Text = "" + b;
            }

            else
            {
                label37vaa.Text = "-";
                label38vaa.Text = "-";
            }


        }
        public void penjurusansejara1aa()
        {
            if (penjurusansejarah1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(penjurusansejarah1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label39vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label39vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label39vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label39vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label39vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label40va.Text = "" + b;
            }

            else
            {
                label39vaa.Text = "-";
                label40va.Text = "-";
            }


        }
        public void pelgeogra1aa()
        {
            if (pelgeograf1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelgeograf1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label41vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label41vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label41vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label41vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label41vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label42vaa.Text = "" + b;
            }

            else
            {
                label41vaa.Text = "-";
                label42vaa.Text = "-";
            }


        }
        public void pelsosiolo1aa()
        {
            if (pelsosiolog1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsosiolog1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label43vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label43vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label43vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label43vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label43vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label50vaa.Text = "" + b;
            }

            else
            {
                label43vaa.Text = "-";
                label50vaa.Text = "-";
            }


        }
        public void pelekonom1aa()
        {
            if (pelekonomi1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelekonomi1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label44vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label44vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label44vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label44vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label44vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label51vaa.Text = "" + b;
            }

            else
            {
                label44vaa.Text = "-";
                label51vaa.Text = "-";
            }


        }
        public void pelsenibud1aa()
        {
            if (pelsenibudy1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelsenibudy1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label45vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label45vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label45vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label45vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label45vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label52vaa.Text = "" + b;
            }

            else
            {
                label45vaa.Text = "-";
                label52vaa.Text = "-";
            }


        }
        public void pelti1aa()
        {
            if (peltik1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltik1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label47vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label47vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label47vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label47vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label47vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label54vaa.Text = "" + b;
            }

            else
            {
                label47vaa.Text = "-";
                label54vaa.Text = "-";
            }


        }
        public void pelbjaw1aa()
        {
            if (pelbjawa1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelbjawa1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label48vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label48vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label48vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label48va.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55va.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label48vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label55vaa.Text = "" + b;
            }

            else
            {
                label48vaa.Text = "-";
                label55vaa.Text = "-";
            }


        }
        public void pelbjpeltambahaaw1aa()
        {
            if (peltambahan1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(peltambahan1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label49vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label49vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label49vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label49vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label49vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label56vaa.Text = "" + b;
            }

            else
            {
                label49vaa.Text = "-";
                label56vaa.Text = "-";
            }


        }
        public void pelolahrag1aa()
        {
            if (pelolahraga1aa.Text == "")
            {

            }
            else
            {
                aaa = double.Parse(pelolahraga1aa.Text);
            }

            if (aaa <= 25 && aaa > 0)
            {
                label46vaa.Text = "D";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53vaa.Text = "" + b;
            }
            else if (aaa <= 50 && aaa > 25)
            {
                label46vaa.Text = "C";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53vaa.Text = "" + b;
            }
            else if (aaa <= 75 && aaa > 50)
            {
                label46vaa.Text = "B";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53vaa.Text = "" + b;
            }

            else if (aaa <= 100 && aaa > 75)
            {
                label46vaa.Text = "A";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53vaa.Text = "" + b;
            }
            else if (aaa <= 1000 && aaa > 100)
            {
                label46vaa.Text = "A+";
                decimal b = Convert.ToDecimal(aaa / 25);
                label53vaa.Text = "" + b;
            }

            else
            {
                label46vaa.Text = "-";
                label53vaa.Text = "-";
            }


        }




        private void Datanilai_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            refres();
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 10;
            if (panel3.Width >= 55)
            {
                timer1.Stop();
                panel3.Width = 0;
                timer1.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
             panel6.Width -= 10;

            if (panel6.Width >= 695)
            {
                timer2.Stop();
                panel6.Width = 0;
                timer2.Start();
            }
        }

        private void label59_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void txtpramukaaa_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void txtcatatan2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            munculpanel7();
           
          
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        public void rr()
        {
           if( pelid.Text == "IPA")
            {
               
            }
           else if(pelid.Text == "IPS")
            {
               
               
             //   panel4.Location= new Point(224, 80);
             //   panel5.Location = new Point(222, 332);
            }
            else
            {

            }



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(label57.Text== "PENGETAHUAN")
            {
                if (pelagama.Text.Trim() == "")
                {
                    MessageBox.Show("Isi Semua Data Dengan Benar");
                }
                else if (peltahun.Text.Trim() == "")
                {
                    MessageBox.Show("Isi Semua Data Dengan Benar");
                }
                else if (pelid.Text.Trim() == "Pilih salah satu")
                {
                    MessageBox.Show("Isi Semua Data Dengan Benar");
                }
                else
                {


                    ValueTambah stdd = new ValueTambah(txtno.Text.Trim(), pelnama.Text.Trim(), peltahun.Text.Trim(), pelkelas.Text.Trim(), pelsm.Trim(), pelagama.Text.Trim(), pelpkn.Text.Trim(), pelindo.Text.Trim(), pelinggris.Text.Trim(), pelmtk.Text.Trim(), penjurusanbiologi.Text.Trim(), penjurusanfisika.Text.Trim(), penjurusankimia.Text.Trim(), penjurusansejarah.Text.Trim(), pelgeograf.Text.Trim(), pelsosiolog.Text.Trim(), pelekonomi.Text.Trim(), pelsenibudy.Text.Trim(), pelolahraga.Text.Trim(), peltik.Text.Trim(), pelbjawa.Text.Trim(), peltambahan.Text.Trim(), txtpramuka.Text.Trim(), txtarab.Text.Trim(), txtkelakuan.Text.Trim(), txtdisiplin.Text.Trim(), txtkettrampil.Text.Trim(), txtkebersihan.Text.Trim(), txtsakit.Text.Trim(), txtizin.Text.Trim(), txttanpa.Text.Trim(), txtcatatan1.Text.Trim(), txtcatatan2.Text.Trim(), txtperingkat.Text.Trim(), txtmtkpemintata.Text.Trim(), txttambahanarab.Text.Trim(), txtpkwu.Text.Trim(), txtsejarahips.Text.Trim());
                    dbstuden.ubahdatapengetahuan(stdd, pelsm);
                   
                }

            }
            if  (label57.Text == "KETERAMPILAN")
            {
                if (pelagama.Text.Trim() == "")
                {
                    MessageBox.Show("Isi Semua Data Dengan Benar");
                }
                else if (peltahun.Text.Trim() == "")
                {
                    MessageBox.Show("Isi Semua Data Dengan Benar");
                }
                else if (pelid.Text.Trim() == "Pilih salah satu")
                {
                    MessageBox.Show("Isi Semua Data Dengan Benar");
                }
                else
                {
                    ValueTambah stdd = new ValueTambah(txtno.Text.Trim(), pelnama.Text.Trim(), peltahun.Text.Trim(), pelkelas.Text.Trim(), pelsm.Trim(), pelagama.Text.Trim(), pelpkn.Text.Trim(), pelindo.Text.Trim(), pelinggris.Text.Trim(), pelmtk.Text.Trim(), penjurusanbiologi.Text.Trim(), penjurusanfisika.Text.Trim(), penjurusankimia.Text.Trim(), penjurusansejarah.Text.Trim(), pelgeograf.Text.Trim(), pelsosiolog.Text.Trim(), pelekonomi.Text.Trim(), pelsenibudy.Text.Trim(), pelolahraga.Text.Trim(), peltik.Text.Trim(), pelbjawa.Text.Trim(), peltambahan.Text.Trim(), txtpramuka.Text.Trim(), txtarab.Text.Trim(), txtkelakuan.Text.Trim(), txtdisiplin.Text.Trim(), txtkettrampil.Text.Trim(), txtkebersihan.Text.Trim(), txtsakit.Text.Trim(), txtizin.Text.Trim(), txttanpa.Text.Trim(), txtcatatan1.Text.Trim(), txtcatatan2.Text.Trim(), txtperingkat.Text.Trim(), txtmtkpemintata.Text.Trim(), txttambahanarab.Text.Trim(), txtpkwu.Text.Trim(), txtsejarahips.Text.Trim());
                    dbstuden.ubahdataketerampilan(stdd, pelsm);
                  
                }
            }
            else
            {
               
            }

        }


        private void paksa()
        {
            if (penjurusankimia1.Text == "")
            {
                lbnsj1.Text = "";
                lbhsj1.Text = "";
            }
          

            if (penjurusanbiologi1.Text=="-")
            {
                label33v.Text = "-";
                label36v.Text = "-";
            }
          
            if (txtpkwuaaa.Text == "")
            {
                lbhpk2.Text = "-";
                lbnpk2.Text = "-";
                lbnpk3.Text = "-";
                lbhpk3.Text = "-";
            }
            if (txtpkwu1.Text == "")
            {
                lbnpk3.Text = "-";
                lbhpk3.Text = "-";
            }
            if (txtmtkpemintataaaa.Text == "")
            {
                lbnmat2.Text = "-";
                lbhmat2.Text = "-";
                lbnmat3.Text = "-";
                lbhmat3.Text = "-";
            }
            if (txtmtkpemintata1.Text == "")
            {
                lbnmat3.Text = "-";
                lbhmat3.Text = "-";
            }
            if (txtpkwuaaa.Text == "")
            {
                lbnpk2.Text = "";
                lbhpk2.Text = "";
                lbnpk3.Text = "";
                lbhpk3.Text = "";

            }
            if (txtpkwu1.Text == "")
            {
                lbnpk3.Text = "";
                lbhpk3.Text = "";
            }
            if (txtsejarahipsaaa.Text == "")
            {
                lbnsj2.Text = "";
                lbhsj2.Text = "";
                lbnsj3.Text = "";
                lbhsj3.Text = "";

            }
            if (txtsejarahips1.Text == "")
            {

                lbnsj3.Text = "";
                lbhsj3.Text = "";
            }


            }
        private void button3_Click(object sender, EventArgs e)
        {


           


            printnilai frm = new printnilai();
            crynilai studrpt = new crynilai();
            if (pelid.Text == "IPA")
            {



                //k

                TextObject nusop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text225"];
                nusop.Text = label1.Text;

                TextObject nposus = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text226"];
                nposus.Text = label25.Text;

                TextObject nr4qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text227"];
                nr4qq.Text = label27.Text;

                TextObject nr45qsq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text228"];
                nr45qsq.Text = label29.Text;

                TextObject nr455qsaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text229"];
                nr455qsaq.Text = label31.Text;

                TextObject nvqasyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text230"];
                nvqasyuk.Text = label39.Text;


                TextObject usdop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text167"];
                usdop.Text = txtpkwu1.Text;
                TextObject ustdop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text168"];
                ustdop.Text = lbnpk3.Text;

                TextObject ustsdop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text169"];
                ustsdop.Text = lbhpk3.Text;


                TextObject usop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text246"];
                usop.Text = label1.Text;

                TextObject posus = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text247"];
                posus.Text = label25.Text;

                TextObject r4qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text248"];
                r4qq.Text = label27.Text;

                TextObject r45qsq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text249"];
                r45qsq.Text = label29.Text;

                TextObject r455qsaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text250"];
                r455qsaq.Text = label31.Text;

                TextObject vqasyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text251"];
                vqasyuk.Text = label39.Text;

                TextObject fuckj7udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text252"];
                fuckj7udi.Text = lbnmat.Text;

                TextObject fuckvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text253"];
                fuckvcsqyfuk.Text = label37.Text;

                TextObject fuckrvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text254"];
                fuckrvqqsyuk.Text = label33.Text;

                TextObject fuckvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text255"];
                fuckvcqsyuk.Text = label35.Text;

                TextObject fuckssaawaaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text256"];
                fuckssaawaaav1.Text = label45.Text;

                TextObject fuckvav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text257"];
                fuckvav.Text = label46.Text;

                TextObject fuckvaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text258"];
                fuckvaav.Text = label47.Text;

                TextObject fuckvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text259"];
                fuckvqqsyuk.Text = lbnpk.Text;

                TextObject fuckvaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text260"];
                fuckvaaav.Text = label48.Text;
                TextObject fuckvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text261"];
                fuckvaaaav.Text = label49.Text;






                TextObject nfuckj7udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text231"];
                nfuckj7udi.Text = lbnmat.Text;

                TextObject nfuckvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text234"];
                nfuckvcsqyfuk.Text = label37.Text;

                TextObject nfuckrvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text232"];
                nfuckrvqqsyuk.Text = label33.Text;

                TextObject nfuckvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text233"];
                nfuckvcqsyuk.Text = label35.Text;

                TextObject nfuckssaawaaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text238"];
                nfuckssaawaaav1.Text = label45.Text;

                TextObject nnfuckvav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text239"];
                nnfuckvav.Text = label46.Text;

                TextObject nnfuckvaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text240"];
                nnfuckvaav.Text = label47.Text;

                TextObject nnfuckvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text241"];
                nnfuckvqqsyuk.Text = lbnpk.Text;

                TextObject ccfuckvaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text242"];
                ccfuckvaaav.Text = label48.Text;
                TextObject cfuckvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text243"];
                cfuckvaaaav.Text = label49.Text;
                //kkm

                TextObject zj9ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text79"];
                zj9ui.Text = kkmagaama;
                TextObject zju9i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text190"];
                zju9i.Text = kkmpkna;
                TextObject zju99i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text191"];
                zju99i.Text = kkmindonesia;
                TextObject zju999i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text192"];
                zju999i.Text = kkmingris;
                TextObject zjlui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text193"];
                zjlui.Text = kkmmtk;
                TextObject zjllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text194"];
                zjllui.Text = kkmsejarahindonesia;
                TextObject zjlllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text195"];
                zjlllui.Text = kkmmtkpwminatan;
                TextObject zjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text196"];
                zjllllui.Text = kkmbioo;





                TextObject zjulli = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text197"];
                zjulli.Text = kkmkimia;
                TextObject zlljui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text198"];
                zlljui.Text = kkmfisika;
                TextObject zllljui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text199"];
                zllljui.Text = kkmsenibudaya;
                TextObject zjullllli = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text200"];
                zjullllli.Text = kkmolahraga;
                TextObject zjuili = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text201"];
                zjuili.Text = kkmtik;
                TextObject zj78ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text202"];
                zj78ui.Text = kkmpkwu;
                TextObject zj88ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text203"];
                zj88ui.Text = kkmjawa;
                TextObject zjui777 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text204"];
                zjui777.Text = kkmbahasarab;


                TextObject azj9ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text206"];
                azj9ui.Text = kkmagaamaa;
                TextObject azju9i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text207"];
                azju9i.Text = kkmpknaa;
                TextObject azju99i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text208"];
                azju99i.Text = kkmindonesiaa;
                TextObject azju999i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text209"];
                azju999i.Text = kkmingrisa;
                TextObject azjlui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text210"];
                azjlui.Text = kkmmtka;
                TextObject azjllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text211"];
                azjllui.Text = kkmsejarahindonesiaa;
                TextObject azjlllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text212"];
                azjlllui.Text = kkmmtkpwminatana;
                TextObject azjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text213"];
                azjllllui.Text = kkmbiooa;
                TextObject azjulli = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text214"];
                azjulli.Text = kkmkimiaa;
                TextObject azlljui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text215"];
                azlljui.Text = kkmfisikaa;
                TextObject azllljui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text219"];
                azllljui.Text = kkmsenibudayaa;
                TextObject azjullllli = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text220"];
                azjullllli.Text = kkmolahragaa;
                TextObject azjuili = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text221"];
                azjuili.Text = kkmtika;
                TextObject azj78ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text222"];
                azj78ui.Text = kkmpkwua;
                TextObject azj88ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text223"];
                azj88ui.Text = kkmjawaa;
                TextObject azjui777 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text224"];
                azjui777.Text = kkmbahasaraba;










                TextObject jui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text145"];
                jui.Text = txtmtkpemintata.Text;

                TextObject j7udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text146"];
                j7udi.Text = lbnmat.Text;

                TextObject ju7di = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text147"];
                ju7di.Text = lbhmat.Text;





                TextObject jud7i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text148"];
                jud7i.Text = txtmtkpemintata0.Text;

                TextObject jud77i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text149"];
                jud77i.Text = lbnmat1.Text;

                TextObject judi7 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text150"];
                judi7.Text = lbhmat1.Text;

                TextObject ju77di = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text151"];
                ju77di.Text = txtmtkpemintataaaa.Text;


                TextObject jud7a7i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text152"];
                jud7a7i.Text = lbnmat2.Text;

                TextObject aajudi7 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text153"];
                aajudi7.Text = lbhmat2.Text;


                TextObject j67udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text154"];
                j67udi.Text = txtmtkpemintata1.Text;

                TextObject jud7a71i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text155"];
                jud7a71i.Text = lbnmat3.Text;

                TextObject aaju1di7 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text156"];
                aaju1di7.Text = lbhmat3.Text;


                TextObject vqqsytuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text159"];
                vqqsytuk.Text = lbnpk.Text;
                TextObject avqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text160"];
                avqqsyuk.Text = lbhpk.Text;


                TextObject vvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text161"];
                vvqqsyuk.Text = txtpkwu0.Text;


                TextObject vFsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text182"];
                vFsyuk.Text = pelkelas.Text;


                TextObject vFsyDuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text180"];
                vFsyDuk.Text = peltahun.Text;

                TextObject vsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text158"];
                vsyuk.Text = txtpkwu.Text;


                TextObject vvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text162"];
                vvsyuk.Text = lbnpk1.Text;

                TextObject avvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text163"];
                avvqqsyuk.Text = lbhpk1.Text;


                TextObject avvaqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text165"];
                avvaqqsyuk.Text = lbnpk2.Text;
                TextObject asvvaqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text166"];
                asvvaqqsyuk.Text = lbhpk2.Text;




                TextObject avvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text164"];
                avvsyuk.Text = txtpkwuaaa.Text;



                TextObject avvsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text167"];
                avvsyuk1.Text = txtpkwu1.Text;











                TextObject rvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112"];
                rvsyuk.Text = penjurusanbiologi.Text;

                TextObject vcsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113"];
                vcsyuk.Text = penjurusankimia.Text;

                TextObject vcsyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114"];
                vcsyfuk.Text = penjurusanfisika.Text;


                TextObject rvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116"];
                rvqqsyuk.Text = label33.Text;

                TextObject vcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117"];
                vcqsyuk.Text = label35.Text;

                TextObject vcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118"];
                vcsqyfuk.Text = label37.Text;


                TextObject ravqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110"];
                ravqqsyuk.Text = label34.Text;

                TextObject avcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111"];
                avcqsyuk.Text = label36.Text;

                TextObject avcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112"];
                avcsqyfuk.Text = label38.Text;


                TextObject vrvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112a"];
                vrvsyuk.Text = penjurusanbiologi1.Text;

                TextObject vvcsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113a"];
                vvcsyuk.Text = penjurusankimia1.Text;

                TextObject vvcsyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114a"];
                vvcsyfuk.Text = penjurusanfisika1.Text;

                TextObject wvvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116a"];
                wvvqqsyuk.Text = label33v.Text;

                TextObject vvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117a"];
                vvcqsyuk.Text = label35v.Text;

                TextObject vvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118a"];
                vvcsqyfuk.Text = label37v.Text;

                TextObject wavvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110a"];
                wavvqqsyuk.Text = label34v.Text;

                TextObject avvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111a"];
                avvcqsyuk.Text = label36v.Text;


                TextObject avvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112a"];
                avvcsqyfuk.Text = label38v.Text;

                TextObject wavvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112aa"];
                wavvsyuk.Text = penjurusanbiologi1a.Text;

                TextObject avvcsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113aa"];
                avvcsyuk.Text = penjurusankimia1a.Text;

                TextObject avvcsyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114aa"];
                avvcsyfuk.Text = penjurusanfisika1a.Text;


                TextObject wavvaqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116aa"];
                wavvaqqsyuk.Text = label33va.Text;

                TextObject arvvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117aa"];
                arvvcqsyuk.Text = label35va.Text;

                TextObject vrvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118aa"];
                vrvcsqyfuk.Text = label37va.Text;


                TextObject wavrvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110aa"];
                wavrvqqsyuk.Text = label34va.Text;

                TextObject avrvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111aa"];
                avrvcqsyuk.Text = label36va.Text;

                TextObject avrvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112aa"];
                avrvcsqyfuk.Text = label38va.Text;

                TextObject wavvsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112aaa"];
                wavvsyuk1.Text = penjurusanbiologi1aa.Text;

                TextObject avvcsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113aaa"];
                avvcsyuk1.Text = penjurusankimia1aa.Text;

                TextObject avvcsyfuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114aaa"];
                avvcsyfuk1.Text = penjurusanfisika1aa.Text;


                TextObject cavvaqqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116aaa"];
                cavvaqqsyuk1.Text = label33vaa.Text;

                TextObject arvvcqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117aaa"];
                arvvcqsyuk1.Text = label35vaa.Text;

                TextObject vrvcsqyfuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118aaa"];
                vrvcsqyfuk1.Text = label37va.Text;

                TextObject cavrvqqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110aaa"];
                cavrvqqsyuk1.Text = label34vaa.Text;

                TextObject avrvcqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111aaa"];
                avrvcqsyuk1.Text = label36vaa.Text;

                TextObject avrvcsqyfuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112aaa"];
                avrvcsqyfuk1.Text = label38vaa.Text;




                TextObject czj9ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text146"];
                czj9ui.Text = lbnmat.Text;
                TextObject cdzju9i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text147"];
                cdzju9i.Text = lbhmat.Text;










                TextObject asaADasl = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text32"];
                asaADasl.Text = "IPA";



            }
            if (pelid.Text == "IPS")

            {

                TextObject usop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text255"];
                usop.Text = label1.Text;

                TextObject posus = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text256"];
                posus.Text = label25.Text;

                TextObject r4qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text257"];
                r4qq.Text = label27.Text;

                TextObject r45qsq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text258"];
                r45qsq.Text = label29.Text;

                TextObject r455qsaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text259"];
                r455qsaq.Text = label31.Text;

                TextObject vqasyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text260"];


                TextObject fuckrvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text233"];
                fuckrvqqsyuk.Text = lbnpk.Text;

                TextObject fuckvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text232"];
                fuckvcqsyuk.Text = lbnsj.Text;

                TextObject u1sop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text266"];
                u1sop.Text = label41.Text;

                TextObject posu22s = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text267"];
                posu22s.Text = label43.Text;

                TextObject r224qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text268"];
                r224qq.Text = label44.Text;




                //k

                TextObject nusop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text225"];
                nusop.Text = label1.Text;

                TextObject nposus = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text226"];
                nposus.Text = label25.Text;

                TextObject nr4qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text227"];
                nr4qq.Text = label27.Text;

                TextObject nr45qsq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text228"];
                nr45qsq.Text = label29.Text;

                TextObject nr455qsaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text229"];
                nr455qsaq.Text = label31.Text;

                TextObject nvqasyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text230"];
                nvqasyuk.Text = label39.Text;



                TextObject fuckssaawaaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text238"];
                fuckssaawaaav1.Text = label45.Text;

                TextObject fuckvav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text239"];
                fuckvav.Text = label46.Text;

                TextObject fuckvaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text240"];
                fuckvaav.Text = label47.Text;

                TextObject fuckvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text241"];
                fuckvqqsyuk.Text = lbnpk.Text;

                TextObject fuckvaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text242"];
                fuckvaaav.Text = label48.Text;
                TextObject fuckvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text243"];
                fuckvaaaav.Text = label49.Text;






                TextObject au1sop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text235"];
               au1sop.Text = label41.Text;

                TextObject poasu22s = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text236"];
                poasu22s.Text = label43.Text;

                TextObject ra224qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text237"];
                ra224qq.Text = label44.Text;



                TextObject eusop = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text246"];
                eusop.Text = label1.Text;

                TextObject eposus = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text247"];
                eposus.Text = label25.Text;
                
                TextObject r45qsrq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text249"];
                r45qsrq.Text = label29.Text;

                TextObject r455qsarq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text250"];
                r455qsarq.Text = label31.Text;

                TextObject vqasyruk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text251"];
                vqasyruk.Text = label39.Text;


                TextObject furckrvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text254"];
                furckrvqqsyuk.Text = lbnpk.Text;

                TextObject fucsskvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text255"];
                fucsskvcqsyuk.Text = lbnsj.Text;

                TextObject fucksssaawaa2av1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text256"];
                fucksssaawaa2av1.Text = label45.Text;

                TextObject fu2ckvav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text257"];
                fu2ckvav.Text = label46.Text;

                TextObject fuckva2av = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text258"];
                fuckvaav.Text = label47.Text;

                TextObject fuckveqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text259"];
                fuckveqqsyuk.Text = lbnpk.Text;

                TextObject fuckqvaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text260"];
                fuckqvaaav.Text = label48.Text;
                TextObject f1uckvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text261"];
                f1uckvaaaav.Text = label49.Text;






                TextObject azj9ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text265"];
                azj9ui.Text = lbhsj1.Text;

                TextObject azj9sui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110a"];
                azj9sui.Text = lbhpk1.Text;




                TextObject mar = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text263"];
                mar.Text = lbnsj2.Text;

                TextObject xuki = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text264"];
                xuki.Text = lbhsj2.Text;


                TextObject zj9ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text79"];
                zj9ui.Text = kkmagaama;
                TextObject zju9i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text190"];
                zju9i.Text = kkmpkna;
                TextObject zju99i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text191"];
                zju99i.Text = kkmindonesia;
                TextObject zju999i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text192"];
                zju999i.Text = kkmingris;
                TextObject zjlui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text193"];
                zjlui.Text = kkmmtk;
                TextObject zjllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text194"];
                zjllui.Text = kkmsejarahindonesia;

                TextObject zjlului = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text157"];
                zjlului.Text = "";
                TextObject zjllu4i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text202"];
                zjllu4i.Text = "";
                TextObject zjll7u4i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text222"];
                zjll7u4i.Text = "";

                TextObject qzjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text196"];
                qzjllllui.Text = kkmpkwu;

                TextObject q8zjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text197"];
                q8zjllllui.Text = kkmsejarah;
                TextObject q9zjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text205"];
                q9zjllllui.Text = kkmgeog;
                TextObject q12zjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text244"];
                q12zjllllui.Text = kkmsosio;
                TextObject q11zjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text245"];
                q11zjllllui.Text = kkmekono;




                TextObject zllljui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text199"];
                zllljui.Text = kkmsenibudaya;
                TextObject zjullllli = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text200"];
                zjullllli.Text = kkmolahraga;
                TextObject zjuili = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text201"];
                zjuili.Text = kkmtik;
                TextObject zj78ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text202"];
                zj78ui.Text = kkmpkwu;
                TextObject zj88ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text203"];
                zj88ui.Text = kkmjawa;
                TextObject zjui777 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text204"];
                zjui777.Text = kkmbahasarab;







                TextObject azjs9sui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text206"];
                azjs9sui.Text = kkmagaamaa;
                TextObject azju9i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text207"];
                azju9i.Text = kkmpknaa;
                TextObject azju99i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text208"];
                azju99i.Text = kkmindonesiaa;
                TextObject azju999i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text209"];
                azju999i.Text = kkmingrisa;
                TextObject azjlui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text210"];
                azjlui.Text = kkmmtka;
                TextObject azjllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text211"];
                azjllui.Text = kkmsejarahindonesiaa;

                TextObject qcukzjllllui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text213"];
                qcukzjllllui.Text = kkmpkwua;

                TextObject ahu = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text214"];
                ahu.Text = kkmsejaraha;
                TextObject kimc = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text216"];
                kimc.Text = kkmgeoga;
                TextObject nuji = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text217"];
                nuji.Text = kkmsosioa;
                TextObject yohu = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text218"];
                yohu.Text = kkmekonoa;



                TextObject azllljui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text219"];
                azllljui.Text = kkmsenibudayaa;
                TextObject azjullllli = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text220"];
                azjullllli.Text = kkmolahragaa;
                TextObject azjuili = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text221"];
                azjuili.Text = kkmtika;
                TextObject azj78ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text222"];
                azj78ui.Text = kkmpkwua;
                TextObject azj88ui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text223"];
                azj88ui.Text = kkmjawaa;
                TextObject azjui777 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text224"];
                azjui777.Text = kkmbahasaraba;












                TextObject jyui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text145"];
                jyui.Text = "";

                TextObject j7udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text146"];
                j7udi.Text = "";

                TextObject ju7di = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text147"];
                ju7di.Text = "";


                TextObject jud7i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text148"];
                jud7i.Text = "";

                TextObject jud77i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text149"];
                jud77i.Text = "";

                TextObject judi7 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text150"];
                judi7.Text = "";

                TextObject ju77di = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text151"];
                ju77di.Text = "";

                TextObject jud66i = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text152"];
                jud66i.Text = "";

                TextObject ju66di = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text153"];
                ju66di.Text = "";

                TextObject j67udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text154"];
                j67udi.Text = "";

                TextObject j76udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text155"];
                j76udi.Text = "";

                TextObject j767udi = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text156"];
                j767udi.Text = "";

                TextObject avcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111"];
                avcqsyuk.Text = lbhsj.Text;



                TextObject jui = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text144"];
                jui.Text = "";

                TextObject asaDasl = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text32"];
                asaDasl.Text = "IPS";


              
                TextObject ksl = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text18"];
                ksl.Text = "PKWU";
                TextObject aksl = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text19"];
                aksl.Text = "Sejarah";
                TextObject kssl = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text20"];
                kssl.Text = "-";




                TextObject vsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112"];
                vsyuk.Text = txtpkwu.Text;

                TextObject vcsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113"];
                vcsyuk.Text = txtsejarahips.Text;

                TextObject vcsyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114"];
                vcsyfuk.Text = "-";




                TextObject vqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116"];
                vqqsyuk.Text = lbnpk.Text;

                TextObject vcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117"];
                vcqsyuk.Text = lbnsj.Text;

                TextObject vcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118"];
                vcsqyfuk.Text = "-";


                TextObject avqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110"];
                avqqsyuk.Text = lbhpk.Text;

                TextObject aavcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111"];
                aavcqsyuk.Text = lbhsj.Text;

                TextObject avcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112"];
                avcsqyfuk.Text = "-";





                TextObject vvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112a"];
                vvsyuk.Text = txtpkwu0.Text;

                TextObject vvcsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113a"];
                vvcsyuk.Text = txtsejarahips0.Text;

                TextObject vvcsyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114a"];
                vvcsyfuk.Text = "-";





                TextObject vvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116a"];
                vvqqsyuk.Text = lbnpk1.Text;

                TextObject vvcqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117a"];
                vvcqsyuk.Text = lbnsj1.Text;

                TextObject vvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118a"];
                vvcsqyfuk.Text = "-";







                TextObject avvcq4syuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111a"];
                avvcq4syuk.Text = label36v.Text;
                TextObject avvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112a"];
                avvcsqyfuk.Text = "-";





                TextObject avvsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112aa"];
                avvsyuk.Text = txtpkwuaaa.Text;

                TextObject avvcsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113aa"];
                avvcsyuk.Text = txtsejarahipsaaa.Text;

                TextObject avvcsyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114aa"];
                avvcsyfuk.Text = "-";









                TextObject avvaqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116aa"];
                avvaqqsyuk.Text = lbnpk2.Text;

           

                TextObject vrvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118aa"];
                vrvcsqyfuk.Text = "-";









                TextObject avrvqqsyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110aa"];
                avrvqqsyuk.Text = lbhpk2.Text;


                TextObject avrvcsqyfuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112aa"];
                avrvcsqyfuk.Text = "-";

                
                     TextObject re4 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text262"];
                re4.Text = label33v.Text;



                TextObject avvsyuak1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text165"];
                avvsyuak1.Text = txtpkwuaaa.Text;


                TextObject avvsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1112aaa"];
                avvsyuk1.Text = txtpkwu1.Text;

                TextObject avvcsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1113aaa"];
                avvcsyuk1.Text = txtsejarahips1.Text;

                TextObject avvcsyfuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1114aaa"];
                avvcsyfuk1.Text = "-";




                TextObject avvaqqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1116aaa"];
                avvaqqsyuk1.Text = lbnpk3.Text;

                TextObject arvvcqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1117aaa"];
                arvvcqsyuk1.Text = lbnsj3.Text;

                TextObject vrvcsqyfuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1118aaa"];
                vrvcsqyfuk1.Text = "-";





                TextObject avrvqqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11110aaa"];
                avrvqqsyuk1.Text = lbhpk3.Text;


                TextObject avrvcqsyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11111aaa"];
                avrvcqsyuk1.Text = lbhsj3.Text;

                TextObject avrvcsqyfuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text11112aaa"];
                avrvcsqyfuk1.Text = "-";

             


            }


            else
            {

            }




            TextObject a9a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text84"];
            a9a.Text = txtpramuka.Text;
            TextObject a65 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text85"];
            a65.Text = txtarab.Text;

            TextObject a455 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text87"];
            a455.Text = txtpramukaa0.Text;
            TextObject a567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text86"];
            a567.Text = txtaraba0.Text;

            TextObject a89 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text88"];
            a89.Text = txtpramukaaa.Text;
            TextObject a8j = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text89"];
            a8j.Text = txtarabaaa.Text;

            TextObject a90 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text90"];
            a90.Text = txtpramuka1.Text;
            TextObject aklk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text91"];
            aklk.Text = txtarab1.Text;




            TextObject aa9a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text92"];
            aa9a.Text = txtkelakuan.Text;
            TextObject aa65 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text93"];
            aa65.Text = txtdisiplin.Text;
            TextObject aa455 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text94"];
           aa455.Text = txtkettrampil.Text;
            TextObject aa567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text95"];
            aa567.Text = txtkebersihan.Text;

            TextObject aa89 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text98"];
            aa89.Text = txtkelakuana0.Text;
            TextObject aa8j = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text99"];
            aa8j.Text = txtdisiplina0.Text;
            TextObject aa90 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text100"];
            aa90.Text = txtkettrampila0.Text;
            TextObject aaklk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text101"];
            aaklk.Text = txtkebersihana0.Text;



            TextObject aaa9a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text104"];
            aaa9a.Text = txtkelakuanaaa.Text;
            TextObject aaa65 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text105"];
            aaa65.Text = txtdisiplinaaa.Text;
            TextObject aaa455 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text106"];
            aaa455.Text = txtkettrampilaaa.Text;
            TextObject aaa567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text107"];
            aaa567.Text = txtkebersihanaaa.Text;

            TextObject aaa89 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text110"];
            aaa89.Text = txtkelakuan1.Text;
            TextObject aaa8j = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text111"];
            aaa8j.Text = txtdisiplin1.Text;
            TextObject aaa90 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text112"];
            aaa90.Text = txtkettrampil1.Text;
            TextObject aaaklk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text113"];
            aaaklk.Text = txtkebersihan1.Text;










            TextObject oa9a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text116"];
            oa9a.Text = txtsakit.Text;
            TextObject oa65 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text117"];
            oa65.Text = txtizin.Text;
            TextObject osa65 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text118"];
            osa65.Text = txttanpa.Text;

            TextObject oa455 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text119"];
            oa455.Text = txtsakita0.Text;
            TextObject oa567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text120"];
            oa567.Text = txtizina0.Text;
            TextObject osa567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text121"];
            osa567.Text = txttanpaa0.Text;

            TextObject oa89 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text122"];
           oa89.Text = txtsakitaaa.Text;
            TextObject oa8j = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text123"];
            oa8j.Text = txtizinaaa.Text;
            TextObject osa8j = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text124"];
            osa8j.Text = txttanpaaaa.Text;

            TextObject oa90 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text125"];
            oa90.Text = txtizin1.Text;
            TextObject oaklk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text126"];
            oaklk.Text = txtsakit1.Text;
            TextObject osaklk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text127"];
            osaklk.Text = txttanpa1.Text;


            TextObject oaa455 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text128"];
            oaa455.Text = txtcatatan1.Text;
            TextObject oaa567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text129"];
            oaa567.Text = txtcatatan2.Text;

            TextObject oaaa567 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text131"];
            oaaa567.Text = txtperingkat.Text;




            TextObject sese = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text4"];
            sese.Text = se1;

            TextObject sese1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text5"];
            sese1.Text = se2;

            TextObject lname_text = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pelagaram"];
            lname_text.Text = pelagama.Text;

            TextObject text = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pkn"];
            text.Text = pelpkn.Text;

            TextObject a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["indo"];
            a.Text = pelindo.Text;

            TextObject aa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text46"];
            aa.Text = pelinggris.Text;

            TextObject aaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text47"];
            aaa.Text = pelmtk.Text;

            TextObject saaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text48"];
            saaa.Text = pelgeograf.Text;

            TextObject saaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text49"];
            saaaa.Text = pelsosiolog.Text;

            TextObject saaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text50"];
            saaaaa.Text = pelekonomi.Text;

            TextObject saaqaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text51"];
            saaqaaa.Text = pelolahraga.Text;

            TextObject saaqaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text52"];
            saaqaaaa.Text = peltik.Text;

            TextObject saaqaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text53"];
            saaqaaaaa.Text = pelbjawa.Text;

            TextObject saaqaaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text54"];
            saaqaaaaaa.Text = peltambahan.Text;

            TextObject saaqaaaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text55"];
            saaqaaaaaaa.Text = label1.Text;

            TextObject saaqaaaaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text56"];
            saaqaaaaaaaa.Text = label25.Text;

            TextObject qq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text57"];
            qq.Text = label27.Text;
            TextObject qssaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text248"];
            qssaq.Text = label27.Text;

            TextObject qsq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text58"];
            qsq.Text = label29.Text;

            TextObject qsaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text59"];
            qsaq.Text = label31.Text;


            TextObject qsaaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text60"];
            qsaaq.Text = label41.Text;

            TextObject qsaxaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text61"];
            qsaxaq.Text = label43.Text;

            TextObject vv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text62"];
            vv.Text = label44.Text;

            TextObject vav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text63"];
            vav.Text = label46.Text;

            TextObject vaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text64"];
            vaav.Text = label47.Text;

            TextObject vaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text65"];
            vaaav.Text = label48.Text;

            TextObject vaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text66"];
            vaaaav.Text = label49.Text;

            TextObject v32aaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text36"];
            v32aaaav.Text = extratambahan;


            TextObject ssaawaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text132"];
            ssaawaaav.Text = pelsenibudy.Text;

            TextObject ssaawaaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text133"];
            ssaawaaav1.Text = label45.Text;

            TextObject ssaawaaav2 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text134"];
            ssaawaaav2.Text = label52.Text;



            TextObject fg = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text67"];
            fg.Text = label2.Text;

            TextObject vaataav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text68"];
            vaataav.Text = label26.Text;

            TextObject vtaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text69"];
            vtaaaav.Text = label28.Text;

            TextObject vraaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text70"];
            vraaaav.Text = label30.Text;

            TextObject vaayyaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text71"];
            vaayyaav.Text = label32.Text;

            TextObject vaaiaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text72"];
            vaaiaav.Text = label42.Text;

            TextObject vaaaayuv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text73"];
            vaaaayuv.Text = label50.Text;

            TextObject tyy = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text74"];
            tyy.Text = label51.Text;

                      TextObject vukaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text75"];
            vukaaaav.Text = label53.Text;

            TextObject vaaaukav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text76"];
            vaaaukav.Text = label54.Text;

            TextObject ukvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text77"];
            ukvaaaav.Text = label55.Text;

            TextObject vaaaavuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text78"];
            vaaaavuk.Text = label56.Text;




            TextObject vyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1111"];
            vyuk.Text = penjurusansejarah.Text;

        

            TextObject vqyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1115"];
            vqyuk.Text = label39.Text;

           

            TextObject avqyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1119"];
            avqyuk.Text = label40.Text;

         




            //



            TextObject ssaaw3aaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text135"];
            ssaaw3aaav.Text = pelsenibudy1.Text;

            TextObject ssaaw2aaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text136"];
            ssaaw2aaav1.Text = label45v.Text;

            TextObject ssaaw1aaav2 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text137"];
            ssaaw1aaav2.Text = label52v.Text;


            TextObject alname_text = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pelagaram1"];
            alname_text.Text = pelagama1.Text;

            TextObject atext = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pkna"];
           atext.Text = pelpkn1.Text;

            TextObject ama = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["indoa"];
            ama.Text = pelindo1.Text;

            TextObject maaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text46a"];
            maaa.Text = pelinggris1.Text;

            TextObject maaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text47a"];
            maaaa.Text = pelmtk1.Text;

            TextObject smaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text48a"];
            smaaa.Text = pelgeograf1.Text;

            TextObject smaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text49a"];
            smaaaa.Text = pelsosiolog1.Text;

            TextObject smaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text50a"];
            smaaaaa.Text = pelekonomi1.Text;

            TextObject smaaqaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text51a"];
            smaaqaaa.Text = pelolahraga1.Text;

            TextObject smaaqaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text52a"];
            smaaqaaaa.Text = peltik1.Text;

            TextObject samaqaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text53a"];
            samaqaaaaa.Text = pelbjawa1.Text;

            TextObject samaqaaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text54a"];
            samaqaaaaaa.Text = peltambahan1.Text;

            
            TextObject samaqaaaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text55a"];
            samaqaaaaaaa.Text = label1v.Text;

            TextObject saamqaaaaaaaa = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text56a"];
            saamqaaaaaaaa.Text = label25v.Text;

            TextObject qmq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text57a"];
            qmq.Text = label27v.Text;

            TextObject qmsq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text58a"];
            qmsq.Text = label29v.Text;

            TextObject qmsaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text59a"];
            qmsaq.Text = label31v.Text;


            TextObject qmsaaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text60a"];
            qmsaaq.Text = label41v.Text;

            TextObject qmsaxaq = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text61a"];
            qmsaxaq.Text = label43v.Text;

            TextObject vmv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text62a"];
            vmv.Text = label44v.Text;

            TextObject vmav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text63a"];
            vmav.Text = label46v.Text;

            TextObject vmaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text64a"];
            vmaav.Text = label47v.Text;

            TextObject vmaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text65a"];
            vmaaav.Text = label48v.Text;

            TextObject vamaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text66a"];
            vamaaav.Text = label49v.Text;

                    TextObject fmg = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text67a"];
            fmg.Text = label2v.Text;

            TextObject vamataav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text68a"];
            vamataav.Text = label26v.Text;

            TextObject vtamaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text69a"];
            vtamaaav.Text = label28v.Text;

            TextObject vrmaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text70a"];
            vrmaaaav.Text = label30v.Text;

            TextObject vmaayyaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text71a"];
            vmaayyaav.Text = label32v.Text;

            TextObject vmaaiaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text72a"];
            vmaaiaav.Text = label42v.Text;

            TextObject vmaaaayuv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text73a"];
            vmaaaayuv.Text = label50v.Text;

            TextObject tmyy = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text74a"];
            tmyy.Text = label51v.Text;

            TextObject vumkaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text75a"];
            vumkaaaav.Text = label53v.Text;

            TextObject vamaaukav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text76a"];
            vamaaukav.Text = label54v.Text;

            TextObject ukmvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text77a"];
            ukmvaaaav.Text = label55v.Text;

            TextObject mvaaaavuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text78a"];
            mvaaaavuk.Text = label56v.Text;










            TextObject vvyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1111a"];
            vvyuk.Text = penjurusansejarah1.Text;

          


            TextObject vvqyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1115a"];
            vvqyuk.Text = label39v.Text;


            TextObject avvqyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1119a"];
            avvqyuk.Text = label40v.Text;

         



            ////////////////////////



            TextObject alname_text1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pelagaram1a"];
            alname_text1.Text = pelagama1a.Text;

            TextObject atext1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pkn1"];
            atext1.Text = pelpkn1a.Text;

            TextObject ama1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["indo1"];
            ama1.Text = pelindo1a.Text;

            TextObject maaa1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text461"];
            maaa1.Text = pelinggris1a.Text;

            TextObject maaaa1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text471"];
            maaaa1.Text = pelmtk1a.Text;

            TextObject smaaa1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text481"];
            smaaa1.Text = pelgeograf1a.Text;

            TextObject smaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text491"];
            smaaa1a.Text = pelsosiolog1a.Text;

            TextObject smaaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text501"];
            smaaaa1a.Text = pelekonomi1a.Text;

            TextObject smaaqaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text511"];
            smaaqaa1a.Text = pelolahraga1a.Text;

            TextObject smaaqaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text521"];
            smaaqaaa1a.Text = peltik1a.Text;

            TextObject samaqaaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text531"];
            samaqaaaa1a.Text = pelbjawa1a.Text;

            TextObject samaqaaaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text541"];
            samaqaaaaa1a.Text = peltambahan1a.Text;


            TextObject samaqaaaaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text551"];
            samaqaaaaaa1a.Text = label1va.Text;

            TextObject saamqaaaaaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text561"];
            saamqaaaaaaa1a.Text = label25va.Text;

            TextObject qm1q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text571"];
            qm1q.Text = label27va.Text;

            TextObject qms1q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text581"];
            qms1q.Text = label29va.Text;

            TextObject qmsa1q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text591"];
            qmsa1q.Text = label31va.Text;



            TextObject ssaaw3daaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text138"];
            ssaaw3daaav.Text = pelsenibudy1a.Text;

            TextObject ssaaw2daaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text139"];
            ssaaw2daaav1.Text = label45va.Text;

            TextObject ssaaw1daaav2 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text140"];
            ssaaw1daaav2.Text = label52va.Text;


            TextObject qmsaa1q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text601"];
            qmsaa1q.Text = label41va.Text;

            TextObject qmsaxa1q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text611"];
            qmsaxa1q.Text = label43va.Text;

            TextObject vm1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text621"];
            vm1v.Text = label44va.Text;

            TextObject vma1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text631"];
            vma1v.Text = label46va.Text;

            TextObject vmaa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text641"];
            vmaa1v.Text = label47va.Text;

            TextObject vmaaa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text651"];
            vmaaa1v.Text = label48va.Text;

            TextObject vamaa1av = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text661"];
            vamaa1av.Text = label49va.Text;

            TextObject fm1g = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text671"];
            fm1g.Text = label2va.Text;

            TextObject vamataa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text681"];
            vamataa1v.Text = label26va.Text;

            TextObject vtamaaa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text691"];
            vtamaaa1v.Text = label28va.Text;

            TextObject vrmaaaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text701"];
            vrmaaaav1.Text = label30va.Text;

            TextObject vmaayyaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text711"];
            vmaayyaav1.Text = label32va.Text;

            TextObject vmaaiaa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text721"];
            vmaaiaa1v.Text = label42va.Text;

            TextObject vmaaaay1uv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text731"];
            vmaaaay1uv.Text = label50va.Text;

            TextObject tmy1y = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text741"];
            tmy1y.Text = label51va.Text;

            TextObject vumkaaaa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text751"];
            vumkaaaa1v.Text = label53va.Text;

            TextObject vamaauk1av = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text761"];
            vamaauk1av.Text = label54va.Text;

            TextObject u1kmvaaaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text771"];
            u1kmvaaaav.Text = label55va.Text;

            TextObject mv1aaaavuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text781"];
            mv1aaaavuk.Text = label56va.Text;








            TextObject avvyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1111aa"];
            avvyuk.Text = penjurusansejarah1a.Text;

           


            TextObject avevqyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1115aa"];
            avevqyuk.Text = label39va.Text;

          

            TextObject arvvqyuk = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1119aa"];
            arvvqyuk.Text = label40va.Text;

          




            ///////////////////////////////////


            TextObject alname1_text1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pelagaram1aa"];
            alname1_text1.Text = pelagama1aa.Text;

            TextObject a1text1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["pknz"];
            a1text1.Text = pelpkn1aa.Text;

            TextObject a1ma1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["indoz"];
            a1ma1.Text = pelindo1aa.Text;

            TextObject ma1aa1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text46z"];
            ma1aa1.Text = pelinggris1aa.Text;

            TextObject ma1aaa1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text47z"];
            ma1aaa1.Text = pelmtk1aa.Text;

            TextObject sm1aaa1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text48z"];
            sm1aaa1.Text = pelgeograf1aa.Text;

            TextObject smaa1a1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text49z"];
            smaa1a1a.Text = pelsosiolog1aa.Text;

            TextObject smaaaa11a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text50z"];
            smaaaa11a.Text = pelekonomi1aa.Text;

            TextObject smaaqaa11a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text51z"];
            smaaqaa11a.Text = pelolahraga1aa.Text;

            TextObject smaaqaaa11a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text52z"];
            smaaqaaa11a.Text = peltik1aa.Text;

            TextObject samaqaaaa11a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text53z"];
            samaqaaaa11a.Text = pelbjawa1aa.Text;

            TextObject samaqaaaaa11a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text54z"];
            samaqaaaaa11a.Text = peltambahan1aa.Text;


            TextObject samaqaaaaaa11a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text55z"];
            samaqaaaaaa11a.Text = label1vaa.Text;

            TextObject saamq1aaaaaaa1a = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text56z"];
            saamq1aaaaaaa1a.Text = label25vaa.Text;

            TextObject qm11q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text57z"];
            qm11q.Text = label27vaa.Text;

            TextObject qms11q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text58z"];
            qms11q.Text = label29vaa.Text;

            TextObject qmsa11q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text59z"];
            qmsa11q.Text = label31vaa.Text;


            TextObject ssaa2w3daaav = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text141"];
            ssaa2w3daaav.Text = pelsenibudy1aa.Text;

            TextObject ssaaw22daaav1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text142"];
            ssaaw22daaav1.Text = label45vaa.Text;

            TextObject ssaaw21daaav2 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text143"];
            ssaaw21daaav2.Text = label52vaa.Text;



            TextObject qmsaa11q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text60z"];
            qmsaa11q.Text = label41vaa.Text;

            TextObject qmsaxa11q = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text61z"];
            qmsaxa11q.Text = label43vaa.Text;

            TextObject vm11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text62z"];
            vm11v.Text = label44vaa.Text;

            TextObject vma11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text63z"];
            vma11v.Text = label46vaa.Text;

            TextObject vmaa11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text64z"];
            vmaa11v.Text = label47vaa.Text;

            TextObject vmaaa11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text65z"];
            vmaaa11v.Text = label48vaa.Text;

            TextObject vamaa11av = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text66z"];
            vamaa11av.Text = label49vaa.Text;

            TextObject fm11g = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text67z"];
            fm11g.Text = label2vaa.Text;

            TextObject vamataa11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text68z"];
            vamataa11v.Text = label26vaa.Text;

            TextObject vtamaaa11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text69z"];
            vtamaaa11v.Text = label28vaa.Text;

            TextObject vrmaaaav11 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text70z"];
            vrmaaaav11.Text = label30vaa.Text;

            TextObject vmaayyaav11 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text71z"];
            vmaayyaav11.Text = label32vaa.Text;

            TextObject vmaaiaa11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text72z"];
            vmaaiaa11v.Text = label42vaa.Text;

            TextObject vmaaaay11uv = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text73z"];
            vmaaaay11uv.Text = label50vaa.Text;

            TextObject tmy11y = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text74z"];
            tmy11y.Text = label51vaa.Text;

            TextObject vumkaaaa11v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text75z"];
            vumkaaaa11v.Text = label53vaa.Text;

            TextObject vamaauk11av = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text76z"];
            vamaauk11av.Text = label54vaa.Text;

            TextObject u1kmvaaaa1v = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text77z"];
            u1kmvaaaa1v.Text = label55vaa.Text;

            TextObject mv1aaaavu1k = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text78z"];
            mv1aaaavu1k.Text = label56vaa.Text;



            TextObject avvyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1111aaa"];
            avvyuk1.Text = penjurusansejarah1aa.Text;

          

            TextObject avevqyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1115aaa"];
            avevqyuk1.Text = label39vaa.Text;

          

            TextObject arvvqyuk1 = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text1119aaa"];
            arvvqyuk1.Text = label40vaa.Text;

          





            frm.crystalReportViewer1.ReportSource = studrpt;
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refres();
        }

        private void pelsemster_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }
    }
}
