using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlprojek
{
    class Valuetambahket
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

        public Valuetambahket(string nomer, string namalengkap, string tahunpel, string kelas, string semester, string pendagamanilai, string penpkn, string penindo, string peninggris, string penmtk, string penprogbiologi, string penprogfisika, string penprogkimia, string penprogsejarah, string penproggeografi, string penprogsosiologi, string penprogekonomi, string penprogsenibudaya, string penprogolahraga, string penprogtik, string penjawa, string pentambahan)
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
    }
}
