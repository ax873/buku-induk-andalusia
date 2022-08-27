using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlprojek
{
    class ValueTambah
    {

        private string nomer;
        private string namalengkap;
        private string tahunpel;
        private string kelas;
        private string semester;
        private string pendagamanilai;
        private string penpkn;
        private string penindo;
        private string peninggris;
        private string penmtk;
        private string penprogbiologi;
        private string penprogfisika;
        private string penprogkimia;
        private string penprogsejarah;
        private string penproggeografi;
        private string penprogsosiologi;
        private string penprogekonomi;
        private string penprogsenibudaya;
        private string penprogolahraga;
        private string penprogtik;
        private string penjawa;
        private string pentambahan;

        private string pramuka;
        private string arab;
        private string kelakuan;
        private string disiplin;
        private string trampilan;
        private string kebersihan;
        private string sakit;
        private string izin;
        private string tanpaizin;
        private string catatatan1;
        private string catatan2;
        private string peringkat;

        private string mtkpeminatan;
        private string pelajaranarab;
        private string pkwu;
        private string sejarahips;

        public ValueTambah(string nomer, string namalengkap, string tahunpel, string kelas, string semester, string pendagamanilai, string penpkn, string penindo, string peninggris, string penmtk, string penprogbiologi, string penprogfisika, string penprogkimia, string penprogsejarah, string penproggeografi, string penprogsosiologi, string penprogekonomi, string penprogsenibudaya, string penprogolahraga, string penprogtik, string penjawa, string pentambahan, string pramuka, string arab, string kelakuan, string disiplin, string trampilan, string kebersihan, string sakit, string izin, string tanpaizin, string catatatan1, string catatan2, string peringkat, string mtkpeminatan, string pelajaranarab, string pkwu, string sejarahips)
        {
            this.Nomer = nomer;
            this.Namalengkap = namalengkap;
            this.Tahunpel = tahunpel;
            this.Kelas = kelas;
            this.Semester = semester;
            this.Pendagamanilai = pendagamanilai;
            this.Penpkn = penpkn;
            this.Penindo = penindo;
            this.Peninggris = peninggris;
            this.Penmtk = penmtk;
            this.Penprogbiologi = penprogbiologi;
            this.Penprogfisika = penprogfisika;
            this.Penprogkimia = penprogkimia;
            this.Penprogsejarah = penprogsejarah;
            this.Penproggeografi = penproggeografi;
            this.Penprogsosiologi = penprogsosiologi;
            this.Penprogekonomi = penprogekonomi;
            this.Penprogsenibudaya = penprogsenibudaya;
            this.Penprogolahraga = penprogolahraga;
            this.Penprogtik = penprogtik;
            this.Penjawa = penjawa;
            this.Pentambahan = pentambahan;
            this.Pramuka = pramuka;
            this.Arab = arab;
            this.Kelakuan = kelakuan;
            this.Disiplin = disiplin;
            this.Trampilan = trampilan;
            this.Kebersihan = kebersihan;
            this.Sakit = sakit;
            this.Izin = izin;
            this.Tanpaizin = tanpaizin;
            this.Catatatan1 = catatatan1;
            this.Catatan2 = catatan2;
            this.Peringkat = peringkat;
            this.Mtkpeminatan = mtkpeminatan;
            this.Pelajaranarab = pelajaranarab;
            this.Pkwu = pkwu;
            this.Sejarahips = sejarahips;
        }

        public string Nomer { get => nomer; set => nomer = value; }
        public string Namalengkap { get => namalengkap; set => namalengkap = value; }
        public string Tahunpel { get => tahunpel; set => tahunpel = value; }
        public string Kelas { get => kelas; set => kelas = value; }
        public string Semester { get => semester; set => semester = value; }
        public string Pendagamanilai { get => pendagamanilai; set => pendagamanilai = value; }
        public string Penpkn { get => penpkn; set => penpkn = value; }
        public string Penindo { get => penindo; set => penindo = value; }
        public string Peninggris { get => peninggris; set => peninggris = value; }
        public string Penmtk { get => penmtk; set => penmtk = value; }
        public string Penprogbiologi { get => penprogbiologi; set => penprogbiologi = value; }
        public string Penprogfisika { get => penprogfisika; set => penprogfisika = value; }
        public string Penprogkimia { get => penprogkimia; set => penprogkimia = value; }
        public string Penprogsejarah { get => penprogsejarah; set => penprogsejarah = value; }
        public string Penproggeografi { get => penproggeografi; set => penproggeografi = value; }
        public string Penprogsosiologi { get => penprogsosiologi; set => penprogsosiologi = value; }
        public string Penprogekonomi { get => penprogekonomi; set => penprogekonomi = value; }
        public string Penprogsenibudaya { get => penprogsenibudaya; set => penprogsenibudaya = value; }
        public string Penprogolahraga { get => penprogolahraga; set => penprogolahraga = value; }
        public string Penprogtik { get => penprogtik; set => penprogtik = value; }
        public string Penjawa { get => penjawa; set => penjawa = value; }
        public string Pentambahan { get => pentambahan; set => pentambahan = value; }
        public string Pramuka { get => pramuka; set => pramuka = value; }
        public string Arab { get => arab; set => arab = value; }
        public string Kelakuan { get => kelakuan; set => kelakuan = value; }
        public string Disiplin { get => disiplin; set => disiplin = value; }
        public string Trampilan { get => trampilan; set => trampilan = value; }
        public string Kebersihan { get => kebersihan; set => kebersihan = value; }
        public string Sakit { get => sakit; set => sakit = value; }
        public string Izin { get => izin; set => izin = value; }
        public string Tanpaizin { get => tanpaizin; set => tanpaizin = value; }
        public string Catatatan1 { get => catatatan1; set => catatatan1 = value; }
        public string Catatan2 { get => catatan2; set => catatan2 = value; }
        public string Peringkat { get => peringkat; set => peringkat = value; }
        public string Mtkpeminatan { get => mtkpeminatan; set => mtkpeminatan = value; }
        public string Pelajaranarab { get => pelajaranarab; set => pelajaranarab = value; }
        public string Pkwu { get => pkwu; set => pkwu = value; }
        public string Sejarahips { get => sejarahips; set => sejarahips = value; }
    }
}
