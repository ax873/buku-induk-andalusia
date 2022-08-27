using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ExcelDataReader;




namespace sqlprojek
{
    public partial class percobaan : Form
    {
        IExcelDataReader reader;
        int nj;
        MySqlCommand command, cmd;
        public percobaan()
        {
            InitializeComponent();
            //tampil();

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


        public void tampil()
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


            String selectquer = "SELECT gambar from siswasma where no ='66'";
            MySqlCommand command = new MySqlCommand(selectquer, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            adp.Fill(table);

            byte[] img = (byte[])table.Rows[0][0];

            MemoryStream ms = new MemoryStream();
            pictureBox1.Image = new Bitmap(ms);
            dataGridView1.Dispose();
        }
        private void percobaan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string connectionString = "SERVER = 139.162.16.216; PORT = 3306; DATABASE = jokipw_studen; UID = jokipw_root; PASSWORD = AYtIeYFw4Tnw";
            // Wait for 5 second delay in the command  
            string queryString = "waitfor delay '00:00:05'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(queryString, connection);
                // Setting command timeout to 1 second  
                command.CommandTimeout = 1;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Got expected SqlException due to command timeout ");
                    Console.WriteLine(ex);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "vincens";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from student_tabel", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");
                conn.Close();

                // MySqlDataReader reader = command.ExecuteReader;


            }
        }

        public void cek()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true } });
                    dataGridView1.DataSource = result.Tables["student_tabel"];
                    string sqal = "datasource=localhost;port=3306;username=root;password=;database=studen";
                    MySqlConnection conan = new MySqlConnection(sqal);
                    //    int i = 0;
                    //   do
                    //   {
                    nj = dataGridView1.Rows.Count;

                    for (int i = 0; i < nj; i++)
                    {

                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        conan.Open();
                        command = new MySqlCommand("insert into  student_tabel(ID,Name,Reg,Class,Section,CreateArt) values(null,@name,@reg,@class,@section,@section)", conan);
                        command.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                        command.Parameters.AddWithValue("@name", dataGridView1.Rows[i].Cells[1].Value);
                        command.Parameters.AddWithValue("@reg", dataGridView1.Rows[i].Cells[2].Value);
                        command.Parameters.AddWithValue("@class", dataGridView1.Rows[i].Cells[3].Value);
                        command.Parameters.AddWithValue("@section", dataGridView1.Rows[i].Cells[4].Value);
                        command.ExecuteNonQuery();
                        conan.Close();
                    }

                    MessageBox.Show("Success menambahkan" + nj + " Data");  //   i++;
                    reader.Close();
                    //  nj=  dataGridView1.Rows.Count - 1;
                    //     } while (i < dataGridView1.Rows.Count);

                }



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //   Microsoft.Office.Interop.Excel.Application xlapp;
            //    Microsoft.Office.Interop.Excel.Workbook xlworbook;
            //     Microsoft.Office.Interop.Excel.Worksheet xlworkshet;
            //      Microsoft.Office.Interop.Excel.Range xlrange;
            //     int xlrow;
            //     string strfilemn;
            //       openfd.Filter = "Excel Office|*.xls;*xlsx";
            //        openfd.ShowDialog();
            //        strfilemn = openfd.FileName;
            //       if (strfilemn !="")
            //        {
            //            xlapp = new Microsoft.Office.Interop.Excel.Application();
            //        xlworbook = xlapp.Workbooks.Open(strfilemn);
            //         xlworkshet = xlworbook.Worksheets["Sheet1"];
            //       xlrange = xlworkshet.UsedRange;

            //       int i = 0;
            //      for (xlrow= 2; xlrow<=xlrange.Rows.Count; xlrow++)
            //         {

            //               dataGridView1.Rows.Add(i, xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text, xlrange.Cells[xlrow, 4].Text, xlrange.Cells[xlrow, 5].Text, xlrange.Cells[xlrow, 6].Text);
            // i++;
            ////          }
            //    xlworbook.Close();
            ///        xlapp.Quit();
            //


            // }




        }

        private void button5_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Semua Siswa";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;
                Excellapp.Interactive = false;
                MySqlCommand command = new MySqlCommand("select * from siswasma", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                conn.Close();
                
                MessageBox.Show("Import succecs");


                // MySqlDataReader reader = command.ExecuteReader;
            }

        }

        private void button6_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Nilai Semua Pengetahuan";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from nilaipengetahuan", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");
                conn.Close();

                // MySqlDataReader reader = command.ExecuteReader;
            }


        }

        private void button7_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Nilai Pengetahuan";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from nilaiketerampilan", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");
                conn.Close();

                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button11_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Export Semua Nilai Pengetahuan 'IPA'";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from nilaipengetahuan ", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");


                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button9_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Export Semua Siswa IPA";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from siswasma WHERE status= 'IPA'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");
                conn.Close();

                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button14_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Export Semua Siswa IPS";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from siswasma WHERE status= 'IPS'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");
                conn.Close();

                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Export Semua Nilai Pengetahuan 'IPS'";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from nilaiketerampilan WHERE status = 'IPS'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");


            }
        }

        private void button15_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Nilai Pengetahuan";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from nilaiketerampilan where status= 'IPA'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");


                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button16_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Nilai Pengetahuan";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from nilaiketerampilan where status= 'IPS'", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");


                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button8_Click(object sender, EventArgs e)
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
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "Nilai Semua Prestasi";
            saveFileDialog1.Filter = "Excel File(2003)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                object misvalue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application Excellapp = new Microsoft.Office.Interop.Excel.Application();
                Excellapp.Visible = false;
                Excellapp.Interactive = false;
                Microsoft.Office.Interop.Excel.Workbook wb = Excellapp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.ActiveSheet;

                MySqlCommand command = new MySqlCommand("select * from prestasi", conn);
                MySqlDataAdapter sda = new MySqlDataAdapter();

                sda.SelectCommand = command;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sda.Update(dt);

                ws = Excellapp.Worksheets.Add(misvalue, misvalue, misvalue, misvalue);
                ws.Name = "Sheet 1";
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;

                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                    }
                }
                wb.SaveAs(saveFileDialog1.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misvalue, misvalue, misvalue, misvalue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misvalue, misvalue, misvalue, misvalue);
                wb.Close(true, misvalue, misvalue);
                Excellapp.Quit();
                MessageBox.Show("Import succecs");

                conn.Close();
                // MySqlDataReader reader = command.ExecuteReader;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;

            }
        }

        private void Backup()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=;database=studen;";
            string file = "D:\\backup.sql";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
             //   using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                   //     mb.ExportToFile(file);
                        conn.Close();
                    }
                }
            }
        }


        private void button12_Click(object sender, EventArgs e)
        {
            string sqal = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conan = new MySqlConnection(sqal);
            string database = conan.Database.ToString();
            if (button12.Text == string.Empty)
            {

            }
            else
            {
                string cmd = "SELECT * INTO OUTFILE 'prestasi' FROM studen";
                conan.Open();
                MySqlCommand com = new MySqlCommand(cmd, conan);
                com.ExecuteNonQuery();
                MessageBox.Show("DATABASE TELAH DI BACKUP");
                conan.Close();
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration() { ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true } });
                    dataGridView1.DataSource = result.Tables["Sheet 1"];
                    string sqal = "datasource=localhost;port=3306;username=root;password=;database=studen";
                    MySqlConnection conan = new MySqlConnection(sqal);
                    //    int i = 0;
                    //   do
                    //   {
                    nj = dataGridView1.Rows.Count;
                    for (int i = 0; i < nj; i++)
                    {

                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        conan.Open();
                        command = new MySqlCommand("INSERT INTO siswasma(no,nis,nisn,namalengkap,namapanggilan,jeniskelamin,tempatlahir,agama,kewarganegaraan,anake,jumlahsaudara,anakyatim,bahasasehari,alamatpeserta,selamasekolahsama,jaraksekolah,kendaraanyangdikendarai,beratditerima,tinggiditerima,beratlulus,tinggilulus,golongandarah,penyakit,kelainanlain,diterimasekolahpada,asalsmp,alamatsmp,tanggaldannoijasahsmp,diterimadipindahan,dikelaspindahan,darismapindahan,alamatsmapindahan,asalsmpdannoijasahpindahan,alamatpindahan,alasanpindahan,namayah,tempatlahirayah,pendidikanayah,pekerjaanayah,penghasilanayah,alamatayah,namaibu,tempatlahiribu,pendidikanibu,pekerjaanibu,penghasilanibu,alamatibu,gambar,status,tahunmasuk,keterangan,kewarganegaraanibu,kewarganegaraanayah) VALUES " +
                            "(null,@nis,@nisn,@namalengkap,@namapanggilan,@jeniskelamin,@tempatlahir,@agama,@kewarganegaraan,@anake,@jumlahsaudara,@anakyatim,@bahasaseharihari," +
                            "@alamatpeserta,@selamasekolahtinggaldi,@txtjrak,@sekolahjalankaki,@berat,@tinggi,@beratketikalulus,@tinggiketikalulus,@golongandarah,@riwayatpenyakit," +
                            "@kelainanlain,@diterimadisekolahpadatanggal,@asalsmp,@alamatsmp,@tgldaannoijazah,@diterimadisekolahpindah,@pindahandikelas,@darisma," +
                            "@alamatsmapindahan,@asalpindahandanno,@alamatsmapindahan,@alasanpindah,@namaayah,@lahirayah,@pendidikanayah,@pekerjaanayah,@penghasilanayah,@alamatayah," +
                            "@namaibu,@tempatlahiribu,@pendidikanibu,@pekerjaanibu,@penghasilanibu,@alamatibu,@gambar,@status,@tahun,@keterangan,@kewarganegaraanibu," +
                            "@kewarganegaraanayah)", conan);
                                                command.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[0].Value);
                        command.Parameters.AddWithValue("@nis", dataGridView1.Rows[i].Cells[1].Value);
                        command.Parameters.AddWithValue("@nisn", dataGridView1.Rows[i].Cells[2].Value);
                        command.Parameters.AddWithValue("@namalengkap", dataGridView1.Rows[i].Cells[3].Value);
                        command.Parameters.AddWithValue("@namapanggilan", dataGridView1.Rows[i].Cells[4].Value);
                        command.Parameters.AddWithValue("@agama", dataGridView1.Rows[i].Cells[7].Value);
                        command.Parameters.AddWithValue("@jeniskelamin", dataGridView1.Rows[i].Cells[5].Value);
                        command.Parameters.AddWithValue("@tempatlahir", dataGridView1.Rows[i].Cells[6].Value);
                        command.Parameters.AddWithValue("@kewarganegaraan", dataGridView1.Rows[i].Cells[8].Value);
                        command.Parameters.AddWithValue("@anake", dataGridView1.Rows[i].Cells[9].Value);
                        command.Parameters.AddWithValue("@jumlahsaudara", dataGridView1.Rows[i].Cells[10].Value);
                        command.Parameters.AddWithValue("@anakyatim", dataGridView1.Rows[i].Cells[11].Value);
                        command.Parameters.AddWithValue("@bahasaseharihari", dataGridView1.Rows[i].Cells[12].Value);
                        command.Parameters.AddWithValue("@alamatpeserta", dataGridView1.Rows[i].Cells[13].Value);
                        command.Parameters.AddWithValue("@selamasekolahtinggaldi", dataGridView1.Rows[i].Cells[14].Value);
                        command.Parameters.AddWithValue("@txtjrak", dataGridView1.Rows[i].Cells[15].Value);
                        command.Parameters.AddWithValue("@sekolahjalankaki", dataGridView1.Rows[i].Cells[16].Value);
                        command.Parameters.AddWithValue("@berat", dataGridView1.Rows[i].Cells[17].Value);
                        command.Parameters.AddWithValue("@tinggi", dataGridView1.Rows[i].Cells[18].Value);
                        command.Parameters.AddWithValue("@beratketikalulus", dataGridView1.Rows[i].Cells[19].Value);
                        command.Parameters.AddWithValue("@tinggiketikalulus", dataGridView1.Rows[i].Cells[20].Value);
                        command.Parameters.AddWithValue("@golongandarah", dataGridView1.Rows[i].Cells[21].Value);
                        command.Parameters.AddWithValue("@riwayatpenyakit", dataGridView1.Rows[i].Cells[22].Value);
                        command.Parameters.AddWithValue("@kelainanlain", dataGridView1.Rows[i].Cells[23].Value);
                        command.Parameters.AddWithValue("@diterimadisekolahpadatanggal", dataGridView1.Rows[i].Cells[24].Value);
                        command.Parameters.AddWithValue("@asalsmp", dataGridView1.Rows[i].Cells[25].Value);
                        command.Parameters.AddWithValue("@alamatsmp", dataGridView1.Rows[i].Cells[26].Value);
                        command.Parameters.AddWithValue("@tgldaannoijazah", dataGridView1.Rows[i].Cells[27].Value);
                        command.Parameters.AddWithValue("@diterimadisekolahpindah", dataGridView1.Rows[i].Cells[28].Value);
                        command.Parameters.AddWithValue("@pindahandikelas", dataGridView1.Rows[i].Cells[29].Value);
                        command.Parameters.AddWithValue("@darisma", dataGridView1.Rows[i].Cells[30].Value);
                        command.Parameters.AddWithValue("@alamatsmapindahan", dataGridView1.Rows[i].Cells[31].Value);
                        command.Parameters.AddWithValue("@asalpindahandanno", dataGridView1.Rows[i].Cells[32].Value);
                        command.Parameters.AddWithValue("@alasmapindahan", dataGridView1.Rows[i].Cells[33].Value);
                        command.Parameters.AddWithValue("@alasanpindah", dataGridView1.Rows[i].Cells[34].Value);
                        command.Parameters.AddWithValue("@namaayah", dataGridView1.Rows[i].Cells[35].Value);
                        command.Parameters.AddWithValue("@lahirayah", dataGridView1.Rows[i].Cells[36].Value);
                        command.Parameters.AddWithValue("@pendidikanayah", dataGridView1.Rows[i].Cells[37].Value);
                        command.Parameters.AddWithValue("@pekerjaanayah", dataGridView1.Rows[i].Cells[38].Value);
                        command.Parameters.AddWithValue("@penghasilanayah", dataGridView1.Rows[i].Cells[39].Value);
                        command.Parameters.AddWithValue("@alamatayah", dataGridView1.Rows[i].Cells[40].Value);
                        command.Parameters.AddWithValue("@namaibu", dataGridView1.Rows[i].Cells[41].Value);
                        command.Parameters.AddWithValue("@tempatlahiribu", dataGridView1.Rows[i].Cells[42].Value);
                        command.Parameters.AddWithValue("@pendidikanibu", dataGridView1.Rows[i].Cells[43].Value);
                        command.Parameters.AddWithValue("@pekerjaanibu", dataGridView1.Rows[i].Cells[44].Value);
                        command.Parameters.AddWithValue("@penghasilanibu", dataGridView1.Rows[i].Cells[45].Value);
                        command.Parameters.AddWithValue("@alamatibu", dataGridView1.Rows[i].Cells[46].Value);
                        command.Parameters.AddWithValue("@gambar", dataGridView1.Rows[i].Cells[47].Value);
                        command.Parameters.AddWithValue("@status", dataGridView1.Rows[i].Cells[48].Value);
                        command.Parameters.AddWithValue("@tahun", dataGridView1.Rows[i].Cells[49].Value);
                        command.Parameters.AddWithValue("@keterangan", dataGridView1.Rows[i].Cells[50].Value);
                        command.Parameters.AddWithValue("@kewarganegaraanayah", dataGridView1.Rows[i].Cells[51].Value);
                        command.Parameters.AddWithValue("@kewarganegaraanibu", dataGridView1.Rows[i].Cells[52].Value);
                        
                        command.ExecuteNonQuery();
                        conan.Close();
                    }

                    MessageBox.Show("Success menambahkan" + nj + " Data");  //   i++;
                    reader.Close();

                    //  nj=  dataGridView1.Rows.Count - 1;
                    //     } while (i < dataGridView1.Rows.Count);

                }

            }
        }
    }
}