using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlprojek
{
    class Studenttambah
    {
        public Studenttambah(string nis, string nisn, string namaLengkap, string namaPanggilan, string jenisKelamin, string tempatLahir, string agama, string kewarganegaraan, string anakKe, string jumlahSaudara, string anakYatim, string bahasaSehari, string alamatPeserta, string selamaSekolahSama, string jarakSekolah, string kendaraanYangdikendarai, string beratDiterima, string tinggiDiterima, string beratLulus, string tinggilulus, string golonganDarah, string penyakit, string kelainanLain, string diterimasekolahPadatgl, string asalSMP, string alamatSMP, string tgldanNoijasahsmp, string diterimadiPindahan, string dikelasPindahan, string dariSMAPindahan, string alamatsmaPindahan, string asalSMPdanNoijasahpindahan, string alamatpindahan, string alasanpindahan, string namaAyah, string tempatLahirAyah, string pendidikantertinggiAyah, string pekerjaanAYah, string penghasilanAyah, string alamatAyah, string namaibu, string tempatLahiribu, string pendidikantertinggiIbu, string pekerjaanIbu, string penghasilanIbu, string alamatIbu, string gambar, string status, string tahunMasuk, string keterangan, string kewarganegaraanibu, string kewarganegaraanayah, string tam1, string tam2, string tam3)
        {
            Nis = nis;
            Nisn = nisn;
            NamaLengkap = namaLengkap;
            NamaPanggilan = namaPanggilan;
            JenisKelamin = jenisKelamin;
            TempatLahir = tempatLahir;
            Agama = agama;
            Kewarganegaraan = kewarganegaraan;
            AnakKe = anakKe;
            JumlahSaudara = jumlahSaudara;
            AnakYatim = anakYatim;
            BahasaSehari = bahasaSehari;
            AlamatPeserta = alamatPeserta;
            SelamaSekolahSama = selamaSekolahSama;
            JarakSekolah = jarakSekolah;
            KendaraanYangdikendarai = kendaraanYangdikendarai;
            BeratDiterima = beratDiterima;
            TinggiDiterima = tinggiDiterima;
            BeratLulus = beratLulus;
            Tinggilulus = tinggilulus;
            GolonganDarah = golonganDarah;
            Penyakit = penyakit;
            KelainanLain = kelainanLain;
            DiterimasekolahPadatgl = diterimasekolahPadatgl;
            AsalSMP = asalSMP;
            AlamatSMP = alamatSMP;
            TgldanNoijasahsmp = tgldanNoijasahsmp;
            DiterimadiPindahan = diterimadiPindahan;
            DikelasPindahan = dikelasPindahan;
            DariSMAPindahan = dariSMAPindahan;
            AlamatsmaPindahan = alamatsmaPindahan;
            AsalSMPdanNoijasahpindahan = asalSMPdanNoijasahpindahan;
            Alamatpindahan = alamatpindahan;
            Alasanpindahan = alasanpindahan;
            NamaAyah = namaAyah;
            TempatLahirAyah = tempatLahirAyah;
            PendidikantertinggiAyah = pendidikantertinggiAyah;
            PekerjaanAYah = pekerjaanAYah;
            PenghasilanAyah = penghasilanAyah;
            AlamatAyah = alamatAyah;
            Namaibu = namaibu;
            TempatLahiribu = tempatLahiribu;
            PendidikantertinggiIbu = pendidikantertinggiIbu;
            PekerjaanIbu = pekerjaanIbu;
            PenghasilanIbu = penghasilanIbu;
            AlamatIbu = alamatIbu;
            Gambar = gambar;
            Status = status;
            TahunMasuk = tahunMasuk;
            Keterangan = keterangan;
            Kewarganegaraanibu = kewarganegaraanibu;
            Kewarganegaraanayah = kewarganegaraanayah;
            Tam1 = tam1;
            Tam2 = tam2;
            Tam3 = tam3;
        }

        public string Nis { get; set; }
        public string Nisn { get; set; }
        public string NamaLengkap { get; set; }
        public string NamaPanggilan { get; set; }

        public string JenisKelamin { get; set; }
        public string TempatLahir { get; set; }
        public string Agama { get; set; }
        public string Kewarganegaraan { get; set; }

        public string AnakKe { get; set; }
        public string JumlahSaudara { get; set; }
        public string AnakYatim { get; set; }
        public string BahasaSehari { get; set; }


        public string AlamatPeserta { get; set; }
        public string SelamaSekolahSama { get; set; }
        public string JarakSekolah { get; set; }
        public string KendaraanYangdikendarai { get; set; }

        public string BeratDiterima { get; set; }
        public string TinggiDiterima { get; set; }
        public string BeratLulus { get; set; }
        public string Tinggilulus { get; set; }

        public string GolonganDarah { get; set; }
        public string Penyakit { get; set; }
        public string KelainanLain { get; set; }
        public string DiterimasekolahPadatgl { get; set; }

        public string AsalSMP { get; set; }
        public string AlamatSMP { get; set; }
        public string TgldanNoijasahsmp { get; set; }
        public string DiterimadiPindahan { get; set; }

        public string DikelasPindahan { get; set; }
        public string DariSMAPindahan { get; set; }
        public string AlamatsmaPindahan { get; set; }
        public string AsalSMPdanNoijasahpindahan { get; set; }
        public string Alamatpindahan { get; set; }
        public string Alasanpindahan { get; set; }
        public string NamaAyah { get; set; }
        public string TempatLahirAyah { get; set; }
        public string PendidikantertinggiAyah { get; set; }
        public string PekerjaanAYah { get; set; }
        public string PenghasilanAyah { get; set; }
        public string AlamatAyah { get; set; }

        public string Namaibu { get; set; }
        public string TempatLahiribu { get; set; }
        public string PendidikantertinggiIbu { get; set; }
        public string PekerjaanIbu { get; set; }
        public string PenghasilanIbu { get; set; }
        public string AlamatIbu{ get; set; }

        public string Gambar { get; set; }
        public string Status { get; set; }
        public string TahunMasuk { get; set; }
        public string Keterangan { get; set; }
        public string Kewarganegaraanibu { get; set; }
        public string Kewarganegaraanayah { get; set; }
        public string Tam1 { get; set; }
        public string Tam2 { get; set; }
        public string Tam3 { get; set; }


    }



}

