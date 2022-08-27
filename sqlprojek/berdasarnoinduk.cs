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
namespace sqlprojek
{
    public partial class berdasarnoinduk : Form
    {
        public berdasarnoinduk()
        {
            InitializeComponent();
            load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nomor Induk Siswa", typeof(string));
            dt.Columns.Add("Nomor Induk Siswa Nasional", typeof(string));
            dt.Columns.Add("Nama Lengkap", typeof(string));
            dt.Columns.Add("Jenis Kelamin", typeof(string));
            dt.Columns.Add("Kelas", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
            }
            ds.Tables.Add(dt);
            ds.WriteXmlSchema("ANJIRRR.xml");
         printsebagiannisn fb = new printsebagiannisn();
            Properties.cuk cr = new Properties.cuk();
         cr.SetDataSource(ds);
        fb.crystalReportViewer1.ReportSource = cr;
           fb.crystalReportViewer1.Refresh();
         fb.Show();
        }

        private void load()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataAdapter adptr = new MySqlDataAdapter();
                      

        string qry = "select nis, nisn,namalengkap,jeniskelamin,status from siswasma";
           

            DataTable dt = new DataTable();
            cmd.Connection = conn;
            cmd.CommandText = qry;
          
            adptr.SelectCommand = cmd;
           adptr.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void berdasarnoinduk_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void berdasarnoinduk_Load_1(object sender, EventArgs e)
        {

        }
    }
}
