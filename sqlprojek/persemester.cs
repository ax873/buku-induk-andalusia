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
    public partial class persemester : Form
    {

        public static string idd;
        public static string tdxtstatus;
        public static string tdxtnamalengkap;
        public static string tdxtket;
        public static string kdata;
        public static string semes;
        public static string cuk;
        public static string exttr;

        public persemester()
        {
            InitializeComponent();
            anj();
            tampil();
        }
        public void anj()
        {

            label1.Text = TampilNilai.id;
            label2.Text = TampilNilai.txtstatus;
            label3.Text = TampilNilai.txtnamalengkap;
            label4.Text = TampilNilai.txtket;
            label5.Text = TampilNilai.kata;
            txtex.Text = TampilNilai.extr;
            if (label5.Text == "PRINT NILAI")
            {

                button2.Visible = false;
                button4.Visible = false;
                button6.Visible = false;

                button1.Size = new Size(154, 55);
                button1.Text = "Semester 1 dan 2";
                button3.Text = "Semester 3 dan 4";
                button3.Size = new Size(154, 55);
                button5.Text = "Semester 5 dan 6";
                button5.Size = new Size(154, 55);
            }

        }

        private void persemester_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label5.Text=="PRINT NILAI")
            {

                

                idd = label1.Text;
                semes = "SEMESTER1";
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                exttr = txtex.Text;
                cuk = "1";
                Datanilai a = new Datanilai();
                a.Text = idd;
              //  a.Size = new Size(669, 674);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = semes;
                a.Text = cuk;
                a.Show();
            }
            else
            {
                
                idd = label1.Text;
                semes = "SEMESTER1";
                cuk = "1";
                exttr = txtex.Text;
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
             //   a.Size = new Size(733, 720);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = semes;
                a.Text = cuk;
                a.Show();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label5.Text == "PRINT NILAI")
            {
                idd = label1.Text;
                semes = "SEMESTER2";
                cuk = "2";
                exttr = txtex.Text;
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
                //  a.Size = new Size(669, 674);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = semes;
                a.Text = cuk;
                a.Show();
            }
            else
            {
                idd = label1.Text;
                semes = "SEMESTER2";
                cuk = "2";
                exttr = txtex.Text;
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
             //   a.Size = new Size(733, 720);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = semes;
                a.Text = exttr;
                a.Text = cuk;
                a.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label5.Text == "PRINT NILAI")
            {
                idd = label1.Text;
                semes = "SEMESTER3";
                cuk = "3";
                tdxtstatus = label2.Text;
                exttr = txtex.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
                //  a.Size = new Size(669, 674);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = cuk;
                a.Text = semes;
                a.Show();
            }
            else
            {
                idd = label1.Text;
                semes = "SEMESTER3";
                cuk = "3";
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                exttr = txtex.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
             //   a.Size = new Size(733, 720);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = cuk;
                a.Text = semes;
                a.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label5.Text == "PRINT NILAI")
            {
                idd = label1.Text;
                semes = "SEMESTER4";
                exttr = txtex.Text;
                cuk = "4";
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
                //  a.Size = new Size(669, 674);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = semes;
                a.Text = cuk;
                a.Show();
            }
            else
            {
                idd = label1.Text;
                semes = "SEMESTER4";
                cuk = "4";
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                exttr = txtex.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
             //   a.Size = new Size(733, 720);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = cuk;
                a.Text = exttr;
                a.Text = semes;
                a.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label5.Text == "PRINT NILAI")
            {
                idd = label1.Text;
                semes = "SEMESTER5";
                cuk = "5";
                tdxtstatus = label2.Text;
                exttr = txtex.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
                //  a.Size = new Size(669, 674);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = exttr;
                a.Text = kdata;
                a.Text = cuk;
                a.Text = semes;
                a.Show();
            }
            else
            {
                idd = label1.Text;
                semes = "SEMESTER5";
                cuk = "5";
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                exttr = txtex.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
              //  a.Size = new Size(733, 720);
                a.Text = tdxtstatus;
                a.Text = cuk;
                a.Text = exttr;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = semes;
                a.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label5.Text == "PRINT NILAI")
            {
                idd = label1.Text;
                semes = "SEMESTER6";
                cuk = "6";
                tdxtstatus = label2.Text;

                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                exttr = txtex.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                a.Text = idd;
                //  a.Size = new Size(669, 674);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = semes;
                a.Text = cuk;
                a.Show();
            }
            else
            {
                idd = label1.Text;
                cuk = "6";
                semes = "SEMESTER6";
                tdxtstatus = label2.Text;
                tdxtnamalengkap = label3.Text;
                tdxtket = label4.Text;
                kdata = label5.Text;
                Datanilai a = new Datanilai();
                exttr = txtex.Text;
                a.Text = idd;
              //  a.Size = new Size(733, 720);
                a.Text = tdxtstatus;
                a.Text = tdxtnamalengkap;
                a.Text = tdxtket;
                a.Text = kdata;
                a.Text = exttr;
                a.Text = semes;
                a.Text = cuk;
                a.Show();
            }
        }
        public void tampil()
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 10;
            if (panel3.Width >= 400)
            {
                timer1.Stop();
                panel3.Width = 0;
                timer1.Start();
            }
           
           
         

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
          //  panel6.Width -= 40;

            if (panel6.Width >= 900)
            {
                timer2.Stop();
                panel6.Width = 0;
                timer2.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            panel23.Width += 15;
            if (panel23.Width >= 400)
            {
                timer1.Stop();
                panel23.Width = 0;
                timer1.Start();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
