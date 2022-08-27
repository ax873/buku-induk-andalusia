using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlprojek
{
    class dbstuden
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Hidupkan XAMPP dulu lalu coba lagi");
                conn.Close();

                // MessageBox.Show("MySQL Connection! \n"+ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return conn;

        }

        internal static void displa(string v, DataGridView dataGridView1)
        {
            throw new NotImplementedException();
        }

        public static void tambahpengetahuan(ValueTambah std)
        {
            string sql = "INSERT INTO nilaipengetahuan VALUES (@nomer, @namalengkap, @tahunpel, @kelas, @semester, @pendagamanilai," +
                "@penpkn,@penindo,@peninggris,@penmtk,@penprogbiologi,@penprogfisika,@penprogkimia,@penprogsejarah,@penproggeografi," +
                "@penprogsosiologi,@penprogekonomi,@penprogsenibudaya,@penprogolahraga,@penprogtik,@penjawa,@pentambahan,@pramuka," +
                "@tambahanextra,@kelakuan,@disiplin,@trampilan,@kebersihan,@sakit,@izin" +
                ",@tanpaizin,@catatan1,@catatan2,@peringkat,@mtkpeminatan,@arab,@pkwu,@sejarah)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nomer", MySqlDbType.VarChar).Value = std.Nomer;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = std.Namalengkap;
            cmd.Parameters.Add("@tahunpel", MySqlDbType.VarChar).Value = std.Tahunpel;
            cmd.Parameters.Add("@kelas", MySqlDbType.VarChar).Value = std.Kelas;

            cmd.Parameters.Add("@mtkpeminatan", MySqlDbType.VarChar).Value = std.Mtkpeminatan;
            cmd.Parameters.Add("@arab", MySqlDbType.VarChar).Value = std.Pelajaranarab;
            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = std.Pkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = std.Sejarahips;

            cmd.Parameters.Add("@semester", MySqlDbType.VarChar).Value = std.Semester;
            cmd.Parameters.Add("@pendagamanilai", MySqlDbType.VarChar).Value = std.Pendagamanilai;
            cmd.Parameters.Add("@penpkn", MySqlDbType.VarChar).Value = std.Penpkn;
            cmd.Parameters.Add("@penindo", MySqlDbType.VarChar).Value = std.Penindo;
            cmd.Parameters.Add("@peninggris", MySqlDbType.VarChar).Value = std.Peninggris;
            cmd.Parameters.Add("@penmtk", MySqlDbType.VarChar).Value = std.Penmtk;
            cmd.Parameters.Add("@penprogbiologi", MySqlDbType.VarChar).Value = std.Penprogbiologi;
            cmd.Parameters.Add("@penprogfisika", MySqlDbType.VarChar).Value = std.Penprogfisika;
            cmd.Parameters.Add("@penprogkimia", MySqlDbType.VarChar).Value = std.Penprogkimia;
            cmd.Parameters.Add("@penprogsejarah", MySqlDbType.VarChar).Value = std.Penprogsejarah;
            cmd.Parameters.Add("@penproggeografi", MySqlDbType.VarChar).Value = std.Penproggeografi;
            cmd.Parameters.Add("@penprogsosiologi", MySqlDbType.VarChar).Value = std.Penprogsosiologi;

            cmd.Parameters.Add("@penprogekonomi", MySqlDbType.VarChar).Value = std.Penprogekonomi;
            cmd.Parameters.Add("@penprogsenibudaya", MySqlDbType.VarChar).Value = std.Penprogsenibudaya;
            cmd.Parameters.Add("@penprogolahraga", MySqlDbType.VarChar).Value = std.Penprogolahraga;
            cmd.Parameters.Add("@penprogtik", MySqlDbType.VarChar).Value = std.Penprogtik;
            cmd.Parameters.Add("@penjawa", MySqlDbType.VarChar).Value = std.Penjawa;
            cmd.Parameters.Add("@pentambahan", MySqlDbType.VarChar).Value = std.Pentambahan;

            cmd.Parameters.Add("@pramuka", MySqlDbType.VarChar).Value = std.Pramuka;
            cmd.Parameters.Add("@tambahanextra", MySqlDbType.VarChar).Value = std.Arab;
            cmd.Parameters.Add("@trampilan", MySqlDbType.VarChar).Value = std.Trampilan;
            cmd.Parameters.Add("@kebersihan", MySqlDbType.VarChar).Value = std.Kebersihan;
            cmd.Parameters.Add("@sakit", MySqlDbType.VarChar).Value = std.Sakit;
            cmd.Parameters.Add("@izin", MySqlDbType.VarChar).Value = std.Izin;
            cmd.Parameters.Add("@tanpaizin", MySqlDbType.VarChar).Value = std.Tanpaizin;
            cmd.Parameters.Add("@catatan1", MySqlDbType.VarChar).Value = std.Catatatan1;
            cmd.Parameters.Add("@catatan2", MySqlDbType.VarChar).Value = std.Catatan2;
            cmd.Parameters.Add("@peringkat", MySqlDbType.VarChar).Value = std.Peringkat;
            cmd.Parameters.Add("@disiplin", MySqlDbType.VarChar).Value = std.Disiplin;
            cmd.Parameters.Add("@kelakuan", MySqlDbType.VarChar).Value = std.Kelakuan;



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilNilai a = new TampilNilai();
                a.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        internal static void tambhakkm(tambahkkm st)
        {

            string sqll = "DELETE FROM kkm where no='1' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll, con);
            string sql = "INSERT INTO kkm VALUES(@agama,@pkn,@indo,@inggris,@mtk,@jawa,@sosiologi,@biologi,@fisika,@kimia,@geografi,@ekonomi,@sejarahindo,@senibudaya,@olahraga," +
                "@tik,@bahasaarab,@pkwu,@sejarah,@matematikaminat,'1')";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inggris", MySqlDbType.VarChar).Value =st.Kkminggris ;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = st.Kkmagama;
            cmd.Parameters.Add("@pkn", MySqlDbType.VarChar).Value = st.Kkmpk;
            cmd.Parameters.Add("@indo", MySqlDbType.VarChar).Value = st.Kkmindonesia;

       
            cmd.Parameters.Add("@mtk", MySqlDbType.VarChar).Value = st.Kkmmatematika;
            cmd.Parameters.Add("@jawa", MySqlDbType.VarChar).Value = st.Kkmjawa;
            cmd.Parameters.Add("@sosiologi", MySqlDbType.VarChar).Value = st.Kkmsosiologi;
            cmd.Parameters.Add("@biologi", MySqlDbType.VarChar).Value = st.Kkmbiologi;

          
            cmd.Parameters.Add("@fisika", MySqlDbType.VarChar).Value = st.Kkmfisika;
            cmd.Parameters.Add("@kimia", MySqlDbType.VarChar).Value = st.Kkmkimia;
            cmd.Parameters.Add("@geografi", MySqlDbType.VarChar).Value = st.Kkmgeograf;
            cmd.Parameters.Add("@ekonomi", MySqlDbType.VarChar).Value = st.Kkmekonomi;
     
            cmd.Parameters.Add("@sejarahindo", MySqlDbType.VarChar).Value = st.Kkmsejarahindo;
            cmd.Parameters.Add("@senibudaya", MySqlDbType.VarChar).Value = st.Kkmsenibudaya;
            cmd.Parameters.Add("@tik", MySqlDbType.VarChar).Value = st.Kkmtik;
            cmd.Parameters.Add("@bahasaarab", MySqlDbType.VarChar).Value = st.Kkmbahasaarab;

            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = st.Kkmolahraga;


            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = st.Kkmpkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = st.Kkmsejarah;
            cmd.Parameters.Add("@matematikaminat", MySqlDbType.VarChar).Value = st.Kkmpeminatan;


            try
            {

               cmdd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        internal static void tambhakkm2(tambahkkm st)
        {

            string sqll = "DELETE FROM kkm where no='2' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll, con);



            string sql = "INSERT INTO kkm VALUES(@agama,@pkn,@indo,@inggris,@mtk,@jawa,@sosiologi,@biologi,@fisika,@kimia,@geografi,@ekonomi,@sejarahindo,@senibudaya,@olahraga," +
                "@tik,@bahasaarab,@pkwu,@sejarah,@matematikaminat,'2')";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inggris", MySqlDbType.VarChar).Value = st.Kkminggris;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = st.Kkmagama;
            cmd.Parameters.Add("@pkn", MySqlDbType.VarChar).Value = st.Kkmpk;
            cmd.Parameters.Add("@indo", MySqlDbType.VarChar).Value = st.Kkmindonesia;


            cmd.Parameters.Add("@mtk", MySqlDbType.VarChar).Value = st.Kkmmatematika;
            cmd.Parameters.Add("@jawa", MySqlDbType.VarChar).Value = st.Kkmjawa;
            cmd.Parameters.Add("@sosiologi", MySqlDbType.VarChar).Value = st.Kkmsosiologi;
            cmd.Parameters.Add("@biologi", MySqlDbType.VarChar).Value = st.Kkmbiologi;


            cmd.Parameters.Add("@fisika", MySqlDbType.VarChar).Value = st.Kkmfisika;
            cmd.Parameters.Add("@kimia", MySqlDbType.VarChar).Value = st.Kkmkimia;
            cmd.Parameters.Add("@geografi", MySqlDbType.VarChar).Value = st.Kkmgeograf;
            cmd.Parameters.Add("@ekonomi", MySqlDbType.VarChar).Value = st.Kkmekonomi;

            cmd.Parameters.Add("@sejarahindo", MySqlDbType.VarChar).Value = st.Kkmsejarahindo;
            cmd.Parameters.Add("@senibudaya", MySqlDbType.VarChar).Value = st.Kkmsenibudaya;
            cmd.Parameters.Add("@tik", MySqlDbType.VarChar).Value = st.Kkmtik;
            cmd.Parameters.Add("@bahasaarab", MySqlDbType.VarChar).Value = st.Kkmbahasaarab;

            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = st.Kkmolahraga;


            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = st.Kkmpkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = st.Kkmsejarah;
            cmd.Parameters.Add("@matematikaminat", MySqlDbType.VarChar).Value = st.Kkmpeminatan;


            try
            {

             cmdd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        internal static void tambhakkm3(tambahkkm st)
        {

            string sqll = "DELETE FROM kkm where no='3' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll, con);



            string sql = "INSERT INTO kkm VALUES(@agama,@pkn,@indo,@inggris,@mtk,@jawa,@sosiologi,@biologi,@fisika,@kimia,@geografi,@ekonomi,@sejarahindo,@senibudaya,@olahraga," +
                "@tik,@bahasaarab,@pkwu,@sejarah,@matematikaminat,'3')";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inggris", MySqlDbType.VarChar).Value = st.Kkminggris;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = st.Kkmagama;
            cmd.Parameters.Add("@pkn", MySqlDbType.VarChar).Value = st.Kkmpk;
            cmd.Parameters.Add("@indo", MySqlDbType.VarChar).Value = st.Kkmindonesia;


            cmd.Parameters.Add("@mtk", MySqlDbType.VarChar).Value = st.Kkmmatematika;
            cmd.Parameters.Add("@jawa", MySqlDbType.VarChar).Value = st.Kkmjawa;
            cmd.Parameters.Add("@sosiologi", MySqlDbType.VarChar).Value = st.Kkmsosiologi;
            cmd.Parameters.Add("@biologi", MySqlDbType.VarChar).Value = st.Kkmbiologi;


            cmd.Parameters.Add("@fisika", MySqlDbType.VarChar).Value = st.Kkmfisika;
            cmd.Parameters.Add("@kimia", MySqlDbType.VarChar).Value = st.Kkmkimia;
            cmd.Parameters.Add("@geografi", MySqlDbType.VarChar).Value = st.Kkmgeograf;
            cmd.Parameters.Add("@ekonomi", MySqlDbType.VarChar).Value = st.Kkmekonomi;

            cmd.Parameters.Add("@sejarahindo", MySqlDbType.VarChar).Value = st.Kkmsejarahindo;
            cmd.Parameters.Add("@senibudaya", MySqlDbType.VarChar).Value = st.Kkmsenibudaya;
            cmd.Parameters.Add("@tik", MySqlDbType.VarChar).Value = st.Kkmtik;
            cmd.Parameters.Add("@bahasaarab", MySqlDbType.VarChar).Value = st.Kkmbahasaarab;

            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = st.Kkmolahraga;


            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = st.Kkmpkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = st.Kkmsejarah;
            cmd.Parameters.Add("@matematikaminat", MySqlDbType.VarChar).Value = st.Kkmpeminatan;


            try
            {

            cmdd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        internal static void tambhakkm4(tambahkkm st)
        {

            string sqll = "DELETE FROM kkm where no ='4' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll, con);



            string sql = "INSERT INTO kkm VALUES(@agama,@pkn,@indo,@inggris,@mtk,@jawa,@sosiologi,@biologi,@fisika,@kimia,@geografi,@ekonomi,@sejarahindo,@senibudaya,@olahraga," +
                "@tik,@bahasaarab,@pkwu,@sejarah,@matematikaminat,'4')";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inggris", MySqlDbType.VarChar).Value = st.Kkminggris;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = st.Kkmagama;
            cmd.Parameters.Add("@pkn", MySqlDbType.VarChar).Value = st.Kkmpk;
            cmd.Parameters.Add("@indo", MySqlDbType.VarChar).Value = st.Kkmindonesia;


            cmd.Parameters.Add("@mtk", MySqlDbType.VarChar).Value = st.Kkmmatematika;
            cmd.Parameters.Add("@jawa", MySqlDbType.VarChar).Value = st.Kkmjawa;
            cmd.Parameters.Add("@sosiologi", MySqlDbType.VarChar).Value = st.Kkmsosiologi;
            cmd.Parameters.Add("@biologi", MySqlDbType.VarChar).Value = st.Kkmbiologi;


            cmd.Parameters.Add("@fisika", MySqlDbType.VarChar).Value = st.Kkmfisika;
            cmd.Parameters.Add("@kimia", MySqlDbType.VarChar).Value = st.Kkmkimia;
            cmd.Parameters.Add("@geografi", MySqlDbType.VarChar).Value = st.Kkmgeograf;
            cmd.Parameters.Add("@ekonomi", MySqlDbType.VarChar).Value = st.Kkmekonomi;

            cmd.Parameters.Add("@sejarahindo", MySqlDbType.VarChar).Value = st.Kkmsejarahindo;
            cmd.Parameters.Add("@senibudaya", MySqlDbType.VarChar).Value = st.Kkmsenibudaya;
            cmd.Parameters.Add("@tik", MySqlDbType.VarChar).Value = st.Kkmtik;
            cmd.Parameters.Add("@bahasaarab", MySqlDbType.VarChar).Value = st.Kkmbahasaarab;

            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = st.Kkmolahraga;


            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = st.Kkmpkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = st.Kkmsejarah;
            cmd.Parameters.Add("@matematikaminat", MySqlDbType.VarChar).Value = st.Kkmpeminatan;


            try
            {

               cmdd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        internal static void tambhakkm5(tambahkkm st)
        {

            string sqll = "DELETE FROM kkm where no='5' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll, con);



            string sql = "INSERT INTO kkm VALUES(@agama,@pkn,@indo,@inggris,@mtk,@jawa,@sosiologi,@biologi,@fisika,@kimia,@geografi,@ekonomi,@sejarahindo,@senibudaya,@olahraga," +
                "@tik,@bahasaarab,@pkwu,@sejarah,@matematikaminat,'5')";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inggris", MySqlDbType.VarChar).Value = st.Kkminggris;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = st.Kkmagama;
            cmd.Parameters.Add("@pkn", MySqlDbType.VarChar).Value = st.Kkmpk;
            cmd.Parameters.Add("@indo", MySqlDbType.VarChar).Value = st.Kkmindonesia;


            cmd.Parameters.Add("@mtk", MySqlDbType.VarChar).Value = st.Kkmmatematika;
            cmd.Parameters.Add("@jawa", MySqlDbType.VarChar).Value = st.Kkmjawa;
            cmd.Parameters.Add("@sosiologi", MySqlDbType.VarChar).Value = st.Kkmsosiologi;
            cmd.Parameters.Add("@biologi", MySqlDbType.VarChar).Value = st.Kkmbiologi;


            cmd.Parameters.Add("@fisika", MySqlDbType.VarChar).Value = st.Kkmfisika;
            cmd.Parameters.Add("@kimia", MySqlDbType.VarChar).Value = st.Kkmkimia;
            cmd.Parameters.Add("@geografi", MySqlDbType.VarChar).Value = st.Kkmgeograf;
            cmd.Parameters.Add("@ekonomi", MySqlDbType.VarChar).Value = st.Kkmekonomi;

            cmd.Parameters.Add("@sejarahindo", MySqlDbType.VarChar).Value = st.Kkmsejarahindo;
            cmd.Parameters.Add("@senibudaya", MySqlDbType.VarChar).Value = st.Kkmsenibudaya;
            cmd.Parameters.Add("@tik", MySqlDbType.VarChar).Value = st.Kkmtik;
            cmd.Parameters.Add("@bahasaarab", MySqlDbType.VarChar).Value = st.Kkmbahasaarab;

            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = st.Kkmolahraga;


            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = st.Kkmpkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = st.Kkmsejarah;
            cmd.Parameters.Add("@matematikaminat", MySqlDbType.VarChar).Value = st.Kkmpeminatan;


            try
            {

             cmdd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        internal static void tambhakkm6(tambahkkm st)
        {

            string sqll = "DELETE FROM kkm where no ='6' ";
            MySqlConnection con = GetConnection();
            MySqlCommand cmdd = new MySqlCommand(sqll, con);



            string sql = "INSERT INTO kkm VALUES(@agama,@pkn,@indo,@inggris,@mtk,@jawa,@sosiologi,@biologi,@fisika,@kimia,@geografi,@ekonomi,@sejarahindo,@senibudaya,@olahraga," +
                "@tik,@bahasaarab,@pkwu,@sejarah,@matematikaminat,'6')";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@inggris", MySqlDbType.VarChar).Value = st.Kkminggris;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = st.Kkmagama;
            cmd.Parameters.Add("@pkn", MySqlDbType.VarChar).Value = st.Kkmpk;
            cmd.Parameters.Add("@indo", MySqlDbType.VarChar).Value = st.Kkmindonesia;


            cmd.Parameters.Add("@mtk", MySqlDbType.VarChar).Value = st.Kkmmatematika;
            cmd.Parameters.Add("@jawa", MySqlDbType.VarChar).Value = st.Kkmjawa;
            cmd.Parameters.Add("@sosiologi", MySqlDbType.VarChar).Value = st.Kkmsosiologi;
            cmd.Parameters.Add("@biologi", MySqlDbType.VarChar).Value = st.Kkmbiologi;


            cmd.Parameters.Add("@fisika", MySqlDbType.VarChar).Value = st.Kkmfisika;
            cmd.Parameters.Add("@kimia", MySqlDbType.VarChar).Value = st.Kkmkimia;
            cmd.Parameters.Add("@geografi", MySqlDbType.VarChar).Value = st.Kkmgeograf;
            cmd.Parameters.Add("@ekonomi", MySqlDbType.VarChar).Value = st.Kkmekonomi;

            cmd.Parameters.Add("@sejarahindo", MySqlDbType.VarChar).Value = st.Kkmsejarahindo;
            cmd.Parameters.Add("@senibudaya", MySqlDbType.VarChar).Value = st.Kkmsenibudaya;
            cmd.Parameters.Add("@tik", MySqlDbType.VarChar).Value = st.Kkmtik;
            cmd.Parameters.Add("@bahasaarab", MySqlDbType.VarChar).Value = st.Kkmbahasaarab;

            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = st.Kkmolahraga;


            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = st.Kkmpkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = st.Kkmsejarah;
            cmd.Parameters.Add("@matematikaminat", MySqlDbType.VarChar).Value = st.Kkmpeminatan;


            try
            {

             cmdd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }


        public static void ubahdatapengetahuan(ValueTambah stdd, string id)
        {
            string sql = "UPDATE nilaipengetahuan SET namalengkap=@namalengkap,no= @id, tahunpel= @tahunpel ,kelas=@kelas, semester=@semester ," +
                "pendagamanilai=@pendagamanilai, penpkn= @penpkn,penindo=@penindo,peninggris=@peninggris,penmtk=@penmtk," +
                "penprogbiologi=@penprogbiologi,penprogfisika=@penprogfisika,penprogkimia=@penprogkimia,penprogsejarah=@penprogsejarah" +
                ",penproggeografi=@penproggeografi,penprogsosiologi=@penprogsosiologi,penprogekonomi=@penprogekonomi," +
                "penprogsenibudaya=@penprogsenibudaya,penprogolahraga=@penprogolahraga,penprogtik=@penprogtik,penjawa=@penjawa," +
                "pentambahan=@pentambahan,pramuka=@pramuka,tambahanextra=@tambahanextra,trampilan=@trampilan," +
                "kebersihan=@kebersihan,sakit=@sakit,izin=@izin," +
                "tanpaizin=@tanpaizin,catatan1=@catatan1,catatan2=@catatan2," +
                "peringkat=@peringkat,disiplin=@disiplin,kelakuan=@kelakuan,mtkpeminatan=@mtkpeminatan,arab=@arab,pkwu=@pkwu,sejarah=@sejarah  WHERE semester=@semester";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = stdd.Namalengkap;
            cmd.Parameters.Add("@tahunpel", MySqlDbType.VarChar).Value = stdd.Tahunpel;
            cmd.Parameters.Add("@kelas", MySqlDbType.VarChar).Value = stdd.Kelas;

            cmd.Parameters.Add("@mtkpeminatan", MySqlDbType.VarChar).Value = stdd.Mtkpeminatan;
            cmd.Parameters.Add("@arab", MySqlDbType.VarChar).Value = stdd.Pelajaranarab;
            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = stdd.Pkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = stdd.Sejarahips;

            cmd.Parameters.Add("@semester", MySqlDbType.VarChar).Value = stdd.Semester;
            cmd.Parameters.Add("@pendagamanilai", MySqlDbType.VarChar).Value = stdd.Pendagamanilai;
            cmd.Parameters.Add("@penpkn", MySqlDbType.VarChar).Value = stdd.Penpkn;
            cmd.Parameters.Add("@penindo", MySqlDbType.VarChar).Value = stdd.Penindo;
            cmd.Parameters.Add("@peninggris", MySqlDbType.VarChar).Value = stdd.Peninggris;
            cmd.Parameters.Add("@penmtk", MySqlDbType.VarChar).Value = stdd.Penmtk;
            cmd.Parameters.Add("@penprogbiologi", MySqlDbType.VarChar).Value = stdd.Penprogbiologi;
            cmd.Parameters.Add("@penprogfisika", MySqlDbType.VarChar).Value = stdd.Penprogfisika;
            cmd.Parameters.Add("@penprogkimia", MySqlDbType.VarChar).Value = stdd.Penprogkimia;
            cmd.Parameters.Add("@penprogsejarah", MySqlDbType.VarChar).Value = stdd.Penprogsejarah;
            cmd.Parameters.Add("@penproggeografi", MySqlDbType.VarChar).Value = stdd.Penproggeografi;
            cmd.Parameters.Add("@penprogsosiologi", MySqlDbType.VarChar).Value = stdd.Penprogsosiologi;

            cmd.Parameters.Add("@penprogekonomi", MySqlDbType.VarChar).Value = stdd.Penprogekonomi;
            cmd.Parameters.Add("@penprogsenibudaya", MySqlDbType.VarChar).Value = stdd.Penprogsenibudaya;
            cmd.Parameters.Add("@penprogolahraga", MySqlDbType.VarChar).Value = stdd.Penprogolahraga;
            cmd.Parameters.Add("@penprogtik", MySqlDbType.VarChar).Value = stdd.Penprogtik;
            cmd.Parameters.Add("@penjawa", MySqlDbType.VarChar).Value = stdd.Penjawa;
            cmd.Parameters.Add("@pentambahan", MySqlDbType.VarChar).Value = stdd.Pentambahan;

            cmd.Parameters.Add("@pramuka", MySqlDbType.VarChar).Value = stdd.Pramuka;
            cmd.Parameters.Add("@tambahanextra", MySqlDbType.VarChar).Value = stdd.Arab;
            cmd.Parameters.Add("@trampilan", MySqlDbType.VarChar).Value = stdd.Trampilan;
            cmd.Parameters.Add("@kebersihan", MySqlDbType.VarChar).Value = stdd.Kebersihan;
            cmd.Parameters.Add("@sakit", MySqlDbType.VarChar).Value = stdd.Sakit;
            cmd.Parameters.Add("@izin", MySqlDbType.VarChar).Value = stdd.Izin;
            cmd.Parameters.Add("@tanpaizin", MySqlDbType.VarChar).Value = stdd.Tanpaizin;
            cmd.Parameters.Add("@catatan1", MySqlDbType.VarChar).Value = stdd.Catatatan1;
            cmd.Parameters.Add("@catatan2", MySqlDbType.VarChar).Value = stdd.Catatan2;
            cmd.Parameters.Add("@peringkat", MySqlDbType.VarChar).Value = stdd.Peringkat;
            cmd.Parameters.Add("@disiplin", MySqlDbType.VarChar).Value = stdd.Disiplin;
            cmd.Parameters.Add("@kelakuan", MySqlDbType.VarChar).Value = stdd.Kelakuan;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ubah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilNilai a = new TampilNilai();
                a.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
        public static void tambahketerampilan(ValueTambah std)
        {


            string sql = "INSERT INTO nilaiketerampilan VALUES (@nomer, @namalengkap, @tahunpel, @kelas, @semester, @pendagamanilai," +
                "@penpkn,@penindo,@peninggris,@penmtk,@penprogbiologi,@penprogfisika,@penprogkimia,@penprogsejarah,@penproggeografi," +
                "@penprogsosiologi,@penprogekonomi,@penprogsenibudaya,@penprogolahraga,@penprogtik,@penjawa,@pentambahan,@pramuka," +
                "@tambahanextra,@kelakuan,@disiplin,@trampilan,@kebersihan,@sakit,@izin" +
                ",@tanpaizin,@catatan1,@catatan2,@peringkat,@mtkpeminatan,@arab,@pkwu,@sejarah)";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nomer", MySqlDbType.VarChar).Value = std.Nomer;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = std.Namalengkap;
            cmd.Parameters.Add("@tahunpel", MySqlDbType.VarChar).Value = std.Tahunpel;
            cmd.Parameters.Add("@kelas", MySqlDbType.VarChar).Value = std.Kelas;
            cmd.Parameters.Add("@mtkpeminatan", MySqlDbType.VarChar).Value = std.Mtkpeminatan;
            cmd.Parameters.Add("@arab", MySqlDbType.VarChar).Value = std.Pelajaranarab;
            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = std.Pkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = std.Sejarahips;

            cmd.Parameters.Add("@semester", MySqlDbType.VarChar).Value = std.Semester;
            cmd.Parameters.Add("@pendagamanilai", MySqlDbType.VarChar).Value = std.Pendagamanilai;
            cmd.Parameters.Add("@penpkn", MySqlDbType.VarChar).Value = std.Penpkn;
            cmd.Parameters.Add("@penindo", MySqlDbType.VarChar).Value = std.Penindo;
            cmd.Parameters.Add("@peninggris", MySqlDbType.VarChar).Value = std.Peninggris;
            cmd.Parameters.Add("@penmtk", MySqlDbType.VarChar).Value = std.Penmtk;
            cmd.Parameters.Add("@penprogbiologi", MySqlDbType.VarChar).Value = std.Penprogbiologi;
            cmd.Parameters.Add("@penprogfisika", MySqlDbType.VarChar).Value = std.Penprogfisika;
            cmd.Parameters.Add("@penprogkimia", MySqlDbType.VarChar).Value = std.Penprogkimia;
            cmd.Parameters.Add("@penprogsejarah", MySqlDbType.VarChar).Value = std.Penprogsejarah;
            cmd.Parameters.Add("@penproggeografi", MySqlDbType.VarChar).Value = std.Penproggeografi;
            cmd.Parameters.Add("@penprogsosiologi", MySqlDbType.VarChar).Value = std.Penprogsosiologi;

            cmd.Parameters.Add("@penprogekonomi", MySqlDbType.VarChar).Value = std.Penprogekonomi;
            cmd.Parameters.Add("@penprogsenibudaya", MySqlDbType.VarChar).Value = std.Penprogsenibudaya;
            cmd.Parameters.Add("@penprogolahraga", MySqlDbType.VarChar).Value = std.Penprogolahraga;
            cmd.Parameters.Add("@penprogtik", MySqlDbType.VarChar).Value = std.Penprogtik;
            cmd.Parameters.Add("@penjawa", MySqlDbType.VarChar).Value = std.Penjawa;
            cmd.Parameters.Add("@pentambahan", MySqlDbType.VarChar).Value = std.Pentambahan;

            cmd.Parameters.Add("@pramuka", MySqlDbType.VarChar).Value = std.Pramuka;
            cmd.Parameters.Add("@tambahanextra", MySqlDbType.VarChar).Value = std.Arab;
            cmd.Parameters.Add("@trampilan", MySqlDbType.VarChar).Value = std.Trampilan;
            cmd.Parameters.Add("@kebersihan", MySqlDbType.VarChar).Value = std.Kebersihan;
            cmd.Parameters.Add("@sakit", MySqlDbType.VarChar).Value = std.Sakit;
            cmd.Parameters.Add("@izin", MySqlDbType.VarChar).Value = std.Izin;
            cmd.Parameters.Add("@tanpaizin", MySqlDbType.VarChar).Value = std.Tanpaizin;
            cmd.Parameters.Add("@catatan1", MySqlDbType.VarChar).Value = std.Catatatan1;
            cmd.Parameters.Add("@catatan2", MySqlDbType.VarChar).Value = std.Catatan2;
            cmd.Parameters.Add("@peringkat", MySqlDbType.VarChar).Value = std.Peringkat;
            cmd.Parameters.Add("@disiplin", MySqlDbType.VarChar).Value = std.Disiplin;
            cmd.Parameters.Add("@kelakuan", MySqlDbType.VarChar).Value = std.Kelakuan;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tambah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilNilai a = new TampilNilai();
                a.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        public static void ubahdataketerampilan(ValueTambah stdd, string id)
        {
            string sql = "UPDATE nilaiketerampilan SET namalengkap=@namalengkap,no= @id, tahunpel= @tahunpel ,kelas=@kelas, semester=@semester ," +
      "pendagamanilai=@pendagamanilai, penpkn= @penpkn,penindo=@penindo,peninggris=@peninggris,penmtk=@penmtk," +
      "penprogbiologi=@penprogbiologi,penprogfisika=@penprogfisika,penprogkimia=@penprogkimia,penprogsejarah=@penprogsejarah" +
      ",penproggeografi=@penproggeografi,penprogsosiologi=@penprogsosiologi,penprogekonomi=@penprogekonomi," +
      "penprogsenibudaya=@penprogsenibudaya,penprogolahraga=@penprogolahraga,penprogtik=@penprogtik,penjawa=@penjawa," +
      "pentambahan=@pentambahan,pramuka=@pramuka,tambahanextra=@tambahanextra,trampilan=@trampilan," +
      "kebersihan=@kebersihan,sakit=@sakit,izin=@izin," +
      "tanpaizin=@tanpaizin,catatan1=@catatan1,catatan2=@catatan2," +
      "peringkat=@peringkat,disiplin=@disiplin,kelakuan=@kelakuan,mtkpeminatan=@mtkpeminatan,arab=@arab,pkwu=@pkwu,sejarah=@sejarah  WHERE semester=@semester";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = stdd.Namalengkap;
            cmd.Parameters.Add("@tahunpel", MySqlDbType.VarChar).Value = stdd.Tahunpel;
            cmd.Parameters.Add("@kelas", MySqlDbType.VarChar).Value = stdd.Kelas;


            cmd.Parameters.Add("@mtkpeminatan", MySqlDbType.VarChar).Value = stdd.Mtkpeminatan;
            cmd.Parameters.Add("@arab", MySqlDbType.VarChar).Value = stdd.Pelajaranarab;
            cmd.Parameters.Add("@pkwu", MySqlDbType.VarChar).Value = stdd.Pkwu;
            cmd.Parameters.Add("@sejarah", MySqlDbType.VarChar).Value = stdd.Sejarahips;

            cmd.Parameters.Add("@semester", MySqlDbType.VarChar).Value = stdd.Semester;
            cmd.Parameters.Add("@pendagamanilai", MySqlDbType.VarChar).Value = stdd.Pendagamanilai;
            cmd.Parameters.Add("@penpkn", MySqlDbType.VarChar).Value = stdd.Penpkn;
            cmd.Parameters.Add("@penindo", MySqlDbType.VarChar).Value = stdd.Penindo;
            cmd.Parameters.Add("@peninggris", MySqlDbType.VarChar).Value = stdd.Peninggris;
            cmd.Parameters.Add("@penmtk", MySqlDbType.VarChar).Value = stdd.Penmtk;
            cmd.Parameters.Add("@penprogbiologi", MySqlDbType.VarChar).Value = stdd.Penprogbiologi;
            cmd.Parameters.Add("@penprogfisika", MySqlDbType.VarChar).Value = stdd.Penprogfisika;
            cmd.Parameters.Add("@penprogkimia", MySqlDbType.VarChar).Value = stdd.Penprogkimia;
            cmd.Parameters.Add("@penprogsejarah", MySqlDbType.VarChar).Value = stdd.Penprogsejarah;
            cmd.Parameters.Add("@penproggeografi", MySqlDbType.VarChar).Value = stdd.Penproggeografi;
            cmd.Parameters.Add("@penprogsosiologi", MySqlDbType.VarChar).Value = stdd.Penprogsosiologi;

            cmd.Parameters.Add("@penprogekonomi", MySqlDbType.VarChar).Value = stdd.Penprogekonomi;
            cmd.Parameters.Add("@penprogsenibudaya", MySqlDbType.VarChar).Value = stdd.Penprogsenibudaya;
            cmd.Parameters.Add("@penprogolahraga", MySqlDbType.VarChar).Value = stdd.Penprogolahraga;
            cmd.Parameters.Add("@penprogtik", MySqlDbType.VarChar).Value = stdd.Penprogtik;
            cmd.Parameters.Add("@penjawa", MySqlDbType.VarChar).Value = stdd.Penjawa;
            cmd.Parameters.Add("@pentambahan", MySqlDbType.VarChar).Value = stdd.Pentambahan;
            cmd.Parameters.Add("@pramuka", MySqlDbType.VarChar).Value = stdd.Pramuka;
            cmd.Parameters.Add("@tambahanextra", MySqlDbType.VarChar).Value = stdd.Arab;
            cmd.Parameters.Add("@trampilan", MySqlDbType.VarChar).Value = stdd.Trampilan;
            cmd.Parameters.Add("@kebersihan", MySqlDbType.VarChar).Value = stdd.Kebersihan;
            cmd.Parameters.Add("@sakit", MySqlDbType.VarChar).Value = stdd.Sakit;
            cmd.Parameters.Add("@izin", MySqlDbType.VarChar).Value = stdd.Izin;
            cmd.Parameters.Add("@tanpaizin", MySqlDbType.VarChar).Value = stdd.Tanpaizin;
            cmd.Parameters.Add("@catatan1", MySqlDbType.VarChar).Value = stdd.Catatatan1;
            cmd.Parameters.Add("@catatan2", MySqlDbType.VarChar).Value = stdd.Catatan2;
            cmd.Parameters.Add("@peringkat", MySqlDbType.VarChar).Value = stdd.Peringkat;
            cmd.Parameters.Add("@disiplin", MySqlDbType.VarChar).Value = stdd.Disiplin;
            cmd.Parameters.Add("@kelakuan", MySqlDbType.VarChar).Value = stdd.Kelakuan;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ubah Berhasil ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilNilai a = new TampilNilai();
                a.Show();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
        public static void disp(string query, DataGridView dataGridView11)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
        
            DataTable tbl = new DataTable();
          adp.Fill(tbl);

         
            dataGridView11.DataSource = tbl;
            conn.Close();
        }

        public static void dissp(string query, DataGridView dataGridView11)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            DataTable tbl = new DataTable();
            adp.Fill(tbl);


          //  tbl.Columns.Add("gambar", Type.GetType("System.Byte[]"));
        //    foreach (DataRow row in tbl.Rows)
        //    {
      //          row["gambar"] = File.ReadAllBytes(Application.StartupPath + @"\Image\" + Path.GetFileName(row["gambar"].ToString()));
       //     }

            dataGridView11.DataSource = tbl;
            conn.Close();
        }




        public static void disptextbox(string query, DataGridView dataGridView11)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
            }
            
        }

        public static void HAPUS(string id)
        {
            string sql = "DELETE FROM siswasma WHERE nis =@id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di DELETE. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        public static void Tambahdata(Studenttambah sud)
        {
            string sql = "INSERT INTO siswasma VALUES (NULL, @nis ,@nisn ,@namalengkap ,@namapanggilan,  @jeniskelamin,@tempatlahir,@agama,@kewarganegaraan,@anake,@jumlahsaudara,@anakyatim,@bahasasehari,@alamatpeserta,@selamasekolahsama,@jaraksekolah,@kendaraanyangdikendarai,@beratditerima,@tinggiditerima,@beratlulus,@tinggilulus,@golongandarah,@penyakit,@kelainanlain,@diterimasekolahpada,@asalsmp,@alamatsmp,@tanggaldannoijasahsmp,@diterimapindahan,@dikelaspindahan,@darismapindahan,@alamatsmapindahan,@asalsmpdannoijasahpindahan,@alamatpindahan,@alasanpindahan,@namayah,@tempatlahirayah,@pendidikanayah,@pekerjaanayah,@penghasilanayah,@alamatayah,@namaibu,@tempatlahiribu,@pendidikanibu,@pekerjaanibu,@penghasilanibu,@alamatibu,@gambar,@status,@tahunmasuk,@keterangan,@kewarganegaraanibu,@kewarganegaraanayah,@tam1,@tam2,@tam3)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@nis", MySqlDbType.VarChar).Value = sud.Nis;
            cmd.Parameters.Add("@nisn", MySqlDbType.VarChar).Value = sud.Nisn;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = sud.NamaLengkap;
            cmd.Parameters.Add("@namapanggilan", MySqlDbType.VarChar).Value = sud.NamaPanggilan;
            cmd.Parameters.Add("@jeniskelamin", MySqlDbType.VarChar).Value = sud.JenisKelamin;
            cmd.Parameters.Add("@tempatlahir", MySqlDbType.VarChar).Value = sud.TempatLahir;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = sud.Agama;
            cmd.Parameters.Add("@kewarganegaraan", MySqlDbType.VarChar).Value = sud.Kewarganegaraan;
            cmd.Parameters.Add("@anake", MySqlDbType.VarChar).Value = sud.AnakKe;
            cmd.Parameters.Add("@jumlahsaudara", MySqlDbType.VarChar).Value = sud.JumlahSaudara;
            cmd.Parameters.Add("@anakyatim", MySqlDbType.VarChar).Value = sud.AnakYatim;
            cmd.Parameters.Add("@bahasasehari", MySqlDbType.VarChar).Value = sud.BahasaSehari;
            cmd.Parameters.Add("@alamatpeserta", MySqlDbType.VarChar).Value = sud.AlamatPeserta;
            cmd.Parameters.Add("@selamasekolahsama", MySqlDbType.VarChar).Value = sud.SelamaSekolahSama;
            cmd.Parameters.Add("@jaraksekolah", MySqlDbType.VarChar).Value = sud.JarakSekolah;
            cmd.Parameters.Add("@kendaraanyangdikendarai", MySqlDbType.VarChar).Value = sud.KendaraanYangdikendarai;
            cmd.Parameters.Add("@beratditerima", MySqlDbType.VarChar).Value = sud.BeratDiterima;
            cmd.Parameters.Add("@tinggiditerima", MySqlDbType.VarChar).Value = sud.TinggiDiterima;
            cmd.Parameters.Add("@beratlulus", MySqlDbType.VarChar).Value = sud.BeratLulus;
            cmd.Parameters.Add("@tinggilulus", MySqlDbType.VarChar).Value = sud.Tinggilulus;
            cmd.Parameters.Add("@golongandarah", MySqlDbType.VarChar).Value = sud.GolonganDarah;
            cmd.Parameters.Add("@penyakit", MySqlDbType.VarChar).Value = sud.Penyakit;
            cmd.Parameters.Add("@kelainanlain", MySqlDbType.VarChar).Value = sud.KelainanLain;
            cmd.Parameters.Add("@diterimasekolahpada", MySqlDbType.VarChar).Value = sud.DiterimasekolahPadatgl;
            cmd.Parameters.Add("@asalsmp", MySqlDbType.VarChar).Value = sud.AsalSMP;
            cmd.Parameters.Add("@alamatsmp", MySqlDbType.VarChar).Value = sud.AlamatSMP;
            cmd.Parameters.Add("@tanggaldannoijasahsmp", MySqlDbType.VarChar).Value = sud.TgldanNoijasahsmp;
            cmd.Parameters.Add("@diterimapindahan", MySqlDbType.VarChar).Value = sud.DiterimadiPindahan;
            cmd.Parameters.Add("@dikelaspindahan", MySqlDbType.VarChar).Value = sud.DikelasPindahan;
            cmd.Parameters.Add("@darismapindahan", MySqlDbType.VarChar).Value = sud.DariSMAPindahan;
            cmd.Parameters.Add("@alamatsmapindahan", MySqlDbType.VarChar).Value = sud.AlamatsmaPindahan;
            cmd.Parameters.Add("@asalsmpdannoijasahpindahan", MySqlDbType.VarChar).Value = sud.AsalSMPdanNoijasahpindahan;
                        cmd.Parameters.Add("@alamatpindahan", MySqlDbType.VarChar).Value = sud.Alamatpindahan;
            cmd.Parameters.Add("@alasanpindahan", MySqlDbType.VarChar).Value = sud.Alasanpindahan;
            cmd.Parameters.Add("@namayah", MySqlDbType.VarChar).Value = sud.NamaAyah;
            cmd.Parameters.Add("@tempatlahirayah", MySqlDbType.VarChar).Value = sud.TempatLahirAyah;
            cmd.Parameters.Add("@pendidikanayah", MySqlDbType.VarChar).Value = sud.PendidikantertinggiAyah;
            cmd.Parameters.Add("@pekerjaanayah", MySqlDbType.VarChar).Value = sud.PekerjaanAYah;
            cmd.Parameters.Add("@penghasilanayah", MySqlDbType.VarChar).Value = sud.PenghasilanAyah;
            cmd.Parameters.Add("@alamatayah", MySqlDbType.VarChar).Value = sud.AlamatAyah;
            cmd.Parameters.Add("@namaibu", MySqlDbType.VarChar).Value = sud.Namaibu;

            cmd.Parameters.Add("@tempatlahiribu", MySqlDbType.VarChar).Value = sud.TempatLahiribu;
            cmd.Parameters.Add("@pendidikanibu", MySqlDbType.VarChar).Value = sud.PendidikantertinggiIbu;
            cmd.Parameters.Add("@pekerjaanibu", MySqlDbType.VarChar).Value = sud.PekerjaanIbu;
            cmd.Parameters.Add("@penghasilanibu", MySqlDbType.VarChar).Value = sud.PenghasilanAyah;
            cmd.Parameters.Add("@alamatibu", MySqlDbType.VarChar).Value = sud.AlamatIbu;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = sud.Status;
            cmd.Parameters.Add("@gambar", MySqlDbType.VarChar).Value = sud.Gambar;
            cmd.Parameters.Add("@tahunmasuk", MySqlDbType.VarChar).Value = sud.TahunMasuk;
            cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = sud.Keterangan;
            cmd.Parameters.Add("@kewarganegaraanibu", MySqlDbType.VarChar).Value = sud.Kewarganegaraanibu;
            cmd.Parameters.Add("@kewarganegaraanayah", MySqlDbType.VarChar).Value = sud.Kewarganegaraanayah;
            cmd.Parameters.Add("@tam1", MySqlDbType.VarChar).Value = sud.Tam1;
            cmd.Parameters.Add("@tam2", MySqlDbType.VarChar).Value = sud.Tam2;
            cmd.Parameters.Add("@tam3", MySqlDbType.VarChar).Value = sud.Tam3;



            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
       public static void ubahdata(Studenttambah sud , string id)
        {
            string sql = "UPDATE siswasma SET nis=@nis, nisn= @nisn ,tempatlahir=@tempatlahir, namalengkap=@namalengkap ,namapanggilan=@namapanggilan, jeniskelamin= @jeniskelamin,tempatlahir=@tempatlahir,agama=@agama," +
                "kewarganegaraan=@kewarganegaraan,anake=@anake,jumlahsaudara=@jumlahsaudara,anakyatim=@anakyatim,bahasasehari=@bahasasehari," +
                "alamatpeserta=@alamatpeserta,selamasekolahsama=@selamasekolahsama,jaraksekolah=@jaraksekolah,kendaraanyangdikendarai=@kendaraanyangdikendarai" +
                ",beratditerima=@beratditerima,tinggiditerima=@tinggiditerima,beratlulus=@beratlulus,tinggilulus=@tinggilulus,golongandarah=@golongandarah,penyakit=@penyakit," +
                "kelainanlain=@kelainanlain,diterimasekolahpada=@diterimasekolahpada,asalsmp=@asalsmp,alamatsmp=@alamatsmp,tanggaldannoijasahsmp=@tanggaldannoijasahsmp," +
                "diterimadipindahan=@diterimapindahan,dikelaspindahan=@dikelaspindahan,darismapindahan=@darismapindahan,alamatsmapindahan=@alamatsmapindahan,asalsmpdannoijasahpindahan=@asalsmpdannoijasahpindahan,alamatpindahan=@alamatpindahan,alasanpindahan=@alasanpindahan,namayah=@namayah,tempatlahirayah=@tempatlahirayah,pendidikanayah=@pendidikanayah,pekerjaanayah=@pekerjaanayah,penghasilanayah=@penghasilanayah,alamatayah=@alamatayah,namaibu=@namaibu,tempatlahiribu=@tempatlahiribu,pendidikanibu=@pendidikanibu,pekerjaanibu=@pekerjaanibu,penghasilanibu=@penghasilanibu,alamatibu=@alamatibu,gambar=@gambar,status=@status,tahunmasuk=@tahunmasuk,keterangan=@keterangan,kewarganegaraanibu=@kewarganegaraanibu,kewarganegaraanayah= @kewarganegaraanayah,tam1=@tam1,tam2=@tam2,tam3=@tam3 WHERE no=@id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nis", MySqlDbType.VarChar).Value = sud.Nis;
            cmd.Parameters.Add("@nisn", MySqlDbType.VarChar).Value = sud.Nisn;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = sud.NamaLengkap;
            cmd.Parameters.Add("@namapanggilan", MySqlDbType.VarChar).Value = sud.NamaPanggilan;
            cmd.Parameters.Add("@jeniskelamin", MySqlDbType.VarChar).Value = sud.JenisKelamin;
            cmd.Parameters.Add("@tempatlahir", MySqlDbType.VarChar).Value = sud.TempatLahir;
            cmd.Parameters.Add("@agama", MySqlDbType.VarChar).Value = sud.Agama;
            cmd.Parameters.Add("@kewarganegaraan", MySqlDbType.VarChar).Value = sud.Kewarganegaraan;
            cmd.Parameters.Add("@anake", MySqlDbType.VarChar).Value = sud.AnakKe;
            cmd.Parameters.Add("@jumlahsaudara", MySqlDbType.VarChar).Value = sud.JumlahSaudara;
            cmd.Parameters.Add("@anakyatim", MySqlDbType.VarChar).Value = sud.AnakYatim;
            cmd.Parameters.Add("@bahasasehari", MySqlDbType.VarChar).Value = sud.BahasaSehari;
            cmd.Parameters.Add("@alamatpeserta", MySqlDbType.VarChar).Value = sud.AlamatPeserta;
            cmd.Parameters.Add("@selamasekolahsama", MySqlDbType.VarChar).Value = sud.SelamaSekolahSama;
            cmd.Parameters.Add("@jaraksekolah", MySqlDbType.VarChar).Value = sud.JarakSekolah;
            cmd.Parameters.Add("@kendaraanyangdikendarai", MySqlDbType.VarChar).Value = sud.KendaraanYangdikendarai;
            cmd.Parameters.Add("@beratditerima", MySqlDbType.VarChar).Value = sud.BeratDiterima;
            cmd.Parameters.Add("@tinggiditerima", MySqlDbType.VarChar).Value = sud.TinggiDiterima;
            cmd.Parameters.Add("@beratlulus", MySqlDbType.VarChar).Value = sud.BeratLulus;
            cmd.Parameters.Add("@tinggilulus", MySqlDbType.VarChar).Value = sud.Tinggilulus;
            cmd.Parameters.Add("@golongandarah", MySqlDbType.VarChar).Value = sud.GolonganDarah;
            cmd.Parameters.Add("@penyakit", MySqlDbType.VarChar).Value = sud.Penyakit;
            cmd.Parameters.Add("@kelainanlain", MySqlDbType.VarChar).Value = sud.KelainanLain;
            cmd.Parameters.Add("@diterimasekolahpada", MySqlDbType.VarChar).Value = sud.DiterimasekolahPadatgl;
            cmd.Parameters.Add("@asalsmp", MySqlDbType.VarChar).Value = sud.AsalSMP;
            cmd.Parameters.Add("@alamatsmp", MySqlDbType.VarChar).Value = sud.AlamatSMP;
            cmd.Parameters.Add("@tanggaldannoijasahsmp", MySqlDbType.VarChar).Value = sud.TgldanNoijasahsmp;
            cmd.Parameters.Add("@diterimapindahan", MySqlDbType.VarChar).Value = sud.DiterimadiPindahan;
            cmd.Parameters.Add("@dikelaspindahan", MySqlDbType.VarChar).Value = sud.DikelasPindahan;
            cmd.Parameters.Add("@darismapindahan", MySqlDbType.VarChar).Value = sud.DariSMAPindahan;
            cmd.Parameters.Add("@alamatsmapindahan", MySqlDbType.VarChar).Value = sud.AlamatsmaPindahan;
            cmd.Parameters.Add("@asalsmpdannoijasahpindahan", MySqlDbType.VarChar).Value = sud.AsalSMPdanNoijasahpindahan;
            cmd.Parameters.Add("@alamatpindahan", MySqlDbType.VarChar).Value = sud.Alamatpindahan;
            cmd.Parameters.Add("@alasanpindahan", MySqlDbType.VarChar).Value = sud.Alasanpindahan;
            cmd.Parameters.Add("@namayah", MySqlDbType.VarChar).Value = sud.NamaAyah;
            cmd.Parameters.Add("@tempatlahirayah", MySqlDbType.VarChar).Value = sud.TempatLahirAyah;
            cmd.Parameters.Add("@pendidikanayah", MySqlDbType.VarChar).Value = sud.PendidikantertinggiAyah;
            cmd.Parameters.Add("@pekerjaanayah", MySqlDbType.VarChar).Value = sud.PekerjaanAYah;
            cmd.Parameters.Add("@penghasilanayah", MySqlDbType.VarChar).Value = sud.PenghasilanAyah;
            cmd.Parameters.Add("@alamatayah", MySqlDbType.VarChar).Value = sud.AlamatAyah;
            cmd.Parameters.Add("@namaibu", MySqlDbType.VarChar).Value = sud.Namaibu;

            cmd.Parameters.Add("@tempatlahiribu", MySqlDbType.VarChar).Value = sud.TempatLahiribu;
            cmd.Parameters.Add("@pendidikanibu", MySqlDbType.VarChar).Value = sud.PendidikantertinggiIbu;
            cmd.Parameters.Add("@pekerjaanibu", MySqlDbType.VarChar).Value = sud.PekerjaanIbu;
            cmd.Parameters.Add("@penghasilanibu", MySqlDbType.VarChar).Value = sud.PenghasilanAyah;
            cmd.Parameters.Add("@alamatibu", MySqlDbType.VarChar).Value = sud.AlamatIbu;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = sud.Status;
            cmd.Parameters.Add("@gambar", MySqlDbType.VarChar).Value = sud.Gambar;
            cmd.Parameters.Add("@tahunmasuk", MySqlDbType.VarChar).Value = sud.TahunMasuk;
            cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = sud.Keterangan;
            cmd.Parameters.Add("@kewarganegaraanibu", MySqlDbType.VarChar).Value = sud.Kewarganegaraanibu;
            cmd.Parameters.Add("@kewarganegaraanayah", MySqlDbType.VarChar).Value = sud.Kewarganegaraanayah;
            cmd.Parameters.Add("@tam1", MySqlDbType.VarChar).Value = sud.Tam1;
            cmd.Parameters.Add("@tam2", MySqlDbType.VarChar).Value = sud.Tam2;
            cmd.Parameters.Add("@tam3", MySqlDbType.VarChar).Value = sud.Tam3;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }


        public static void AddStuden (Student std)
        {
            string sql = "INSERT INTO student_tabel VALUES (NULL, @StudentName, @StudentReg, @StudentClass, @StudentSection, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@StudentReg", MySqlDbType.VarChar).Value = std.Reg;
            cmd.Parameters.Add("@StudentClass", MySqlDbType.VarChar).Value = std.Class;
            cmd.Parameters.Add("@StudentSection", MySqlDbType.VarChar).Value = std.Section;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("sukses","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n"+ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
      
           
        public static void tambahprestasi(clasprestasi std)
        {
            string sql = "INSERT INTO prestasi VALUES (@no, @namalengkap, @status, @keterangan, @iq, @kepribadian, @kesenian, @olahraga,@organisasi, @pramuka," +
                "@karya, @bea1, @bea2, @bea3, @dari1, @dari2, @dari3,@lanjutke,@alamatke,@pindahke,@tanggalpindahke,@alamatpindahke" +
                ",@putussekolahke,@catatanselama,@namawali,@tempatlahirwali,@kewarganegaraan,@pendidikantertinggiwali," +
                "@pekerjaan,@penghasilan,@alamat,@hubungan,@tamat)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@lanjutke", MySqlDbType.VarChar).Value = std.Melanjutkan;
            cmd.Parameters.Add("@alamatke", MySqlDbType.VarChar).Value = std.Alamatmelanjutkan;
            cmd.Parameters.Add("@pindahke", MySqlDbType.VarChar).Value = std.Pindahsekolahke;
            cmd.Parameters.Add("@tanggalpindahke", MySqlDbType.VarChar).Value = std.Tanggalpindah;
            cmd.Parameters.Add("@alamatpindahke", MySqlDbType.VarChar).Value = std.Alamatsekolahpindahan;
            cmd.Parameters.Add("@putussekolahke", MySqlDbType.VarChar).Value = std.Putussekolah;
            cmd.Parameters.Add("@catatanselama", MySqlDbType.VarChar).Value = std.Catatanlain;
            cmd.Parameters.Add("@namawali", MySqlDbType.VarChar).Value = std.Namawali;
            cmd.Parameters.Add("@tempatlahirwali", MySqlDbType.VarChar).Value = std.Tempatlahirwali;
            cmd.Parameters.Add("@kewarganegaraan", MySqlDbType.VarChar).Value = std.Kewarganegaraan;
            cmd.Parameters.Add("@pendidikantertinggiwali", MySqlDbType.VarChar).Value = std.Pendidikantertinggiwali;
            cmd.Parameters.Add("@pekerjaan", MySqlDbType.VarChar).Value = std.Pekerjaan;
            cmd.Parameters.Add("@penghasilan", MySqlDbType.VarChar).Value = std.Penghasilan;

            cmd.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = std.Alamat;
            cmd.Parameters.Add("@hubungan", MySqlDbType.VarChar).Value = std.Hubungan;
            cmd.Parameters.Add("@tamat", MySqlDbType.VarChar).Value = std.Tamat;

            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = std.Namalengkap;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = std.Status;
            cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = std.Keterangan;
            cmd.Parameters.Add("@iq", MySqlDbType.VarChar).Value = std.Iq;
            cmd.Parameters.Add("@kepribadian", MySqlDbType.VarChar).Value = std.Kepribadian;
            cmd.Parameters.Add("@kesenian", MySqlDbType.VarChar).Value = std.Kesenian;
            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = std.Olahraga;
            cmd.Parameters.Add("@pramuka", MySqlDbType.VarChar).Value = std.Pramuka;
            cmd.Parameters.Add("@karya", MySqlDbType.VarChar).Value = std.Karya;
            cmd.Parameters.Add("@bea1", MySqlDbType.VarChar).Value = std.Bea1;
            cmd.Parameters.Add("@bea2", MySqlDbType.VarChar).Value = std.Bea2;
            cmd.Parameters.Add("@bea3", MySqlDbType.VarChar).Value = std.Bea3;
             cmd.Parameters.Add("@dari1", MySqlDbType.VarChar).Value = std.Dari1;
            cmd.Parameters.Add("@dari2", MySqlDbType.VarChar).Value = std.Dari2;
            cmd.Parameters.Add("@dari3", MySqlDbType.VarChar).Value = std.Dari3;
            cmd.Parameters.Add("@no", MySqlDbType.VarChar).Value = std.No;
            cmd.Parameters.Add("@organisasi", MySqlDbType.VarChar).Value = std.Organisasi;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di insert. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }
        internal static void ubahdaa(clasprestasi std, string id)
        {
            string sql = "UPDATE prestasi SET namalengkap=@namalengkap, status= @status ,keterangan=@keterangan, iq=@iq ,kepribadian=@kepribadian, kesenian= @kesenian," +
               "olahraga=@olahraga,pramuka=@pramuka,karya=@karya,bea1=@bea1,bea2=@bea2,bea3=@bea3,dari1=@dari1,dari2=@dari2,dari3=@dari3," +
               "organisasi=@organisasi,melanjutkan=@melanjutkan,alamatmelanjutkan=@alamatmelanjutkan,pindahsekolahke=@pindahsekolahke,tanggalpindah=@tanggalpindah,alamatsekolahpindahan=@alamatsekolahpindahan," +
               "putussekolah=@putussekolah,catatanlain=@catatanlain,namawali=@namawali,tempatlahirwali=@tempatlahirwali,kewarganegaraan=@kewarganegaraan,pendidikantertinggiwali=@pendidikantertinggiwali,pekerjaan=@pekerjaan," +
               "penghasilan=@penghasilan,alamat=@alamat,hubungan=@hubungan,tamat=@tamat WHERE no=@no";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@namalengkap", MySqlDbType.VarChar).Value = std.Namalengkap;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = std.Status;
            cmd.Parameters.Add("@keterangan", MySqlDbType.VarChar).Value = std.Keterangan;
            cmd.Parameters.Add("@iq", MySqlDbType.VarChar).Value = std.Iq;
            cmd.Parameters.Add("@kepribadian", MySqlDbType.VarChar).Value = std.Kepribadian;
            cmd.Parameters.Add("@kesenian", MySqlDbType.VarChar).Value = std.Kesenian;
            cmd.Parameters.Add("@olahraga", MySqlDbType.VarChar).Value = std.Olahraga;
            cmd.Parameters.Add("@pramuka", MySqlDbType.VarChar).Value = std.Pramuka;
            cmd.Parameters.Add("@karya", MySqlDbType.VarChar).Value = std.Karya;
            cmd.Parameters.Add("@bea1", MySqlDbType.VarChar).Value = std.Bea1;
            cmd.Parameters.Add("@bea2", MySqlDbType.VarChar).Value = std.Bea2;
            cmd.Parameters.Add("@bea3", MySqlDbType.VarChar).Value = std.Bea3;
            cmd.Parameters.Add("@dari1", MySqlDbType.VarChar).Value = std.Dari1;
            cmd.Parameters.Add("@dari2", MySqlDbType.VarChar).Value = std.Dari2;
            cmd.Parameters.Add("@dari3", MySqlDbType.VarChar).Value = std.Dari3;
            cmd.Parameters.Add("@no", MySqlDbType.VarChar).Value = std.No;
            cmd.Parameters.Add("@organisasi", MySqlDbType.VarChar).Value = std.Organisasi;

            cmd.Parameters.Add("@melanjutkan", MySqlDbType.VarChar).Value = std.Melanjutkan;
            cmd.Parameters.Add("@alamatmelanjutkan", MySqlDbType.VarChar).Value = std.Alamatmelanjutkan;
            cmd.Parameters.Add("@pindahsekolahke", MySqlDbType.VarChar).Value = std.Pindahsekolahke;
            cmd.Parameters.Add("@tanggalpindah", MySqlDbType.VarChar).Value = std.Tanggalpindah;
            cmd.Parameters.Add("@alamatsekolahpindahan", MySqlDbType.VarChar).Value = std.Alamatsekolahpindahan;
            cmd.Parameters.Add("@putussekolah", MySqlDbType.VarChar).Value = std.Putussekolah;
            cmd.Parameters.Add("@catatanlain", MySqlDbType.VarChar).Value = std.Catatanlain;
            cmd.Parameters.Add("@namawali", MySqlDbType.VarChar).Value = std.Namawali;
            cmd.Parameters.Add("@tempatlahirwali", MySqlDbType.VarChar).Value = std.Tempatlahirwali;
            cmd.Parameters.Add("@kewarganegaraan", MySqlDbType.VarChar).Value = std.Kewarganegaraan;
            cmd.Parameters.Add("@pendidikantertinggiwali", MySqlDbType.VarChar).Value = std.Pendidikantertinggiwali;
            cmd.Parameters.Add("@pekerjaan", MySqlDbType.VarChar).Value = std.Pekerjaan;
            cmd.Parameters.Add("@penghasilan", MySqlDbType.VarChar).Value = std.Penghasilan;

            cmd.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = std.Alamat;
            cmd.Parameters.Add("@hubungan", MySqlDbType.VarChar).Value = std.Hubungan;
            cmd.Parameters.Add("@tamat", MySqlDbType.VarChar).Value = std.Tamat;


            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di inser. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }


        public static void UpdateStudent(Student std,string id)
        {
            string sql = "UPDATE student_tabel SET Name = @StudentName, Reg=@StudentReg, Class = @StudentClass, Section =  @StudentSection WHERE ID =@StudentID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = std.Name;
            cmd.Parameters.Add("@StudentReg", MySqlDbType.VarChar).Value = std.Reg;
            cmd.Parameters.Add("@StudentClass", MySqlDbType.VarChar).Value = std.Class;
            cmd.Parameters.Add("@StudentSection", MySqlDbType.VarChar).Value = std.Section;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("UPDATE sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di UPDATE. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

     

        public static void Deletestudent(string id)
        {
            string sql = "DELETE FROM student_tabel WHERE ID =@StudentID";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@StudentID", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE sukses", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("studen tidak di DELETE. \n" + ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }
        public static void displayseacr(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }

    }
}
