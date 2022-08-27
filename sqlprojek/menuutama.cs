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
    public partial class menuutama : Form
    {
        public static string txtstatus;
        public menuutama()
        {
            InitializeComponent();
            t();
          anji();
        }

        public void anji()
        {
            button10.Visible = false;
        }
        public void t()
        {
            timer1.Stop();
            button3.Visible = false;
            button6.Visible = false;
            button2d.Visible = false;
            button8.Visible = false;
            button2d.Visible = false;
            txsiwaipa.Visible = false;
            txsiswaips.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
          
                FormStudentInfo a = new FormStudentInfo();
                a.Show();
                button2d.Visible = false;
                txsiwaipa.Visible = false;
                txsiswaips.Visible = false;
                button3.Visible = false;
                button6.Visible = false;
                button8.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSiswa a = new DataSiswa();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "SEMUA")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                txtstatus = "SEMUA";
                TampilNilai a = new TampilNilai();
                a.Text = txtstatus;
                menuutama h = new menuutama();
                h.Visible = false;
                a.Show();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printnilai a = new printnilai();
            a.Show();
        }

        private void menuutama_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            Application.Exit();
         
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "IPA")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {

                txtstatus = "IPA";
                TampilNilai a = new TampilNilai();
                a.Text = txtstatus;
                a.Show();
                menuutama h = new menuutama();
                h.Visible = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "IPS")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {

                txtstatus = "IPS";
                TampilNilai a = new TampilNilai();
                a.Text = txtstatus;
                a.Show();
                menuutama h = new menuutama();
                h.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button6.Visible = true;
            button8.Visible = true;

            button2d.Visible = false;
            txsiwaipa.Visible = false;
            txsiswaips.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
                percobaan a = new percobaan();
                a.Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            button6.Visible = false;
            button8.Visible = false;

            button2d.Visible = true;
            txsiwaipa.Visible = true;
            txsiswaips.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel4.Width += 15;
            if(panel4.Width>= 877)
            {
                timer1.Stop();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Pilih Kelas......")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {

                txtstatus = "Pilih Kelas......";
                DataSiswa a = new DataSiswa();
                a.Text = txtstatus;


                
                a.Show();
            }
        }

        private void txsiwaipa_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "IPA")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                txtstatus = "IPA";
                DataSiswa a = new DataSiswa();
                a.Text = txtstatus;
                menuutama h = new menuutama();
                h.Visible = false;
                a.Show();
            }
           
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txsiswaips_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "IPS")
                {
                    Isopen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (Isopen == false)
            {
                txtstatus = "IPS";
                DataSiswa a = new DataSiswa();
                a.Text = txtstatus;

              
                a.Show();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            txsiwaipa.Visible = false;
button6.Visible = false;
            txsiswaips.Visible = false;
            button8.Visible = false;
            button2d.Visible = false;
            button3.Visible = false;

            timer1.Start();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            

        }

        private void Tutup_Click(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            berdasarnoinduk n = new berdasarnoinduk();
            n.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://wa.me/6285643450737");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            kkm a = new kkm();
            a.Show();
        }
    }
}
