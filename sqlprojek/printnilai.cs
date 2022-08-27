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
    public partial class printnilai : Form
    {
        public static string astaga;
        public string id;
        public printnilai()
        {
            InitializeComponent();
            display();
        }
        public void display()
        {
         //   dbstuden.disp("SELECT no, nis, namalengkap, status, keterangan From siswasma", dataGridView1);
        }
        private void printnilai_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

             //   id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

                 astaga  = "lain";
                Datanilai a = new Datanilai();
                a.Text = id;
                a.Text = astaga;
                              a.Show();
            }

            else
            {

            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
