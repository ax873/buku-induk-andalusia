using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlprojek
{
    class clasprestasi
    {
        private string no;
        private string namalengkap;
        private string status;
        private string keterangan;
        private string iq;
        private string kepribadian;
        private string kesenian;
        private string olahraga;
        private string organisasi;
        private string pramuka;
        private string karya;
        private string bea1;
        private string bea2;
        private string bea3;
        private string dari1;
        private string dari2;
        private string dari3;
               private string melanjutkan;
        private string alamatmelanjutkan;
        private string pindahsekolahke;
        private string tanggalpindah;
        private string alamatsekolahpindahan;
        private string putussekolah;
        private string catatanlain;
        private string namawali;
        private string tempatlahirwali;
        private string kewarganegaraan;
        private string pendidikantertinggiwali;
        private string pekerjaan;
        private string penghasilan;
        private string alamat;
        private string hubungan;
        private string tamat;

        public clasprestasi(string no, string namalengkap, string status, string keterangan, string iq, string kepribadian, string kesenian, string olahraga, string organisasi, string pramuka, string karya, string bea1, string bea2, string bea3, string dari1, string dari2, string dari3, string melanjutkan, string alamatmelanjutkan, string pindahsekolahke, string tanggalpindah, string alamatsekolahpindahan, string putussekolah, string catatanlain, string namawali, string tempatlahirwali, string kewarganegaraan, string pendidikantertinggiwali, string pekerjaan, string penghasilan, string alamat, string hubungan, string tamat)
        {
            this.No = no;
            this.Namalengkap = namalengkap;
            this.Status = status;
            this.Keterangan = keterangan;
            this.Iq = iq;
            this.Kepribadian = kepribadian;
            this.Kesenian = kesenian;
            this.Olahraga = olahraga;
            this.Organisasi = organisasi;
            this.Pramuka = pramuka;
            this.Karya = karya;
            this.Bea1 = bea1;
            this.Bea2 = bea2;
            this.Bea3 = bea3;
            this.Dari1 = dari1;
            this.Dari2 = dari2;
            this.Dari3 = dari3;
            this.Melanjutkan = melanjutkan;
            this.Alamatmelanjutkan = alamatmelanjutkan;
            this.Pindahsekolahke = pindahsekolahke;
            this.Tanggalpindah = tanggalpindah;
            this.Alamatsekolahpindahan = alamatsekolahpindahan;
            this.Putussekolah = putussekolah;
            this.Catatanlain = catatanlain;
            this.Namawali = namawali;
            this.Tempatlahirwali = tempatlahirwali;
            this.Kewarganegaraan = kewarganegaraan;
            this.Pendidikantertinggiwali = pendidikantertinggiwali;
            this.Pekerjaan = pekerjaan;
            this.Penghasilan = penghasilan;
            this.Alamat = alamat;
            this.Hubungan = hubungan;
            this.Tamat = tamat;
        }

        public string No { get => no; set => no = value; }
        public string Namalengkap { get => namalengkap; set => namalengkap = value; }
        public string Status { get => status; set => status = value; }
        public string Keterangan { get => keterangan; set => keterangan = value; }
        public string Iq { get => iq; set => iq = value; }
        public string Kepribadian { get => kepribadian; set => kepribadian = value; }
        public string Kesenian { get => kesenian; set => kesenian = value; }
        public string Olahraga { get => olahraga; set => olahraga = value; }
        public string Organisasi { get => organisasi; set => organisasi = value; }
        public string Pramuka { get => pramuka; set => pramuka = value; }
        public string Karya { get => karya; set => karya = value; }
        public string Bea1 { get => bea1; set => bea1 = value; }
        public string Bea2 { get => bea2; set => bea2 = value; }
        public string Bea3 { get => bea3; set => bea3 = value; }
        public string Dari1 { get => dari1; set => dari1 = value; }
        public string Dari2 { get => dari2; set => dari2 = value; }
        public string Dari3 { get => dari3; set => dari3 = value; }
        public string Melanjutkan { get => melanjutkan; set => melanjutkan = value; }
        public string Alamatmelanjutkan { get => alamatmelanjutkan; set => alamatmelanjutkan = value; }
        public string Pindahsekolahke { get => pindahsekolahke; set => pindahsekolahke = value; }
        public string Tanggalpindah { get => tanggalpindah; set => tanggalpindah = value; }
        public string Alamatsekolahpindahan { get => alamatsekolahpindahan; set => alamatsekolahpindahan = value; }
        public string Putussekolah { get => putussekolah; set => putussekolah = value; }
        public string Catatanlain { get => catatanlain; set => catatanlain = value; }
        public string Namawali { get => namawali; set => namawali = value; }
        public string Tempatlahirwali { get => tempatlahirwali; set => tempatlahirwali = value; }
        public string Kewarganegaraan { get => kewarganegaraan; set => kewarganegaraan = value; }
        public string Pendidikantertinggiwali { get => pendidikantertinggiwali; set => pendidikantertinggiwali = value; }
        public string Pekerjaan { get => pekerjaan; set => pekerjaan = value; }
        public string Penghasilan { get => penghasilan; set => penghasilan = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Hubungan { get => hubungan; set => hubungan = value; }
        public string Tamat { get => tamat; set => tamat = value; }
    }
}
