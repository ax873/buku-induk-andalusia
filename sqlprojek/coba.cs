using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace sqlprojek
{
    public partial class coba : Form
    {
        public coba()
        {
            InitializeComponent();
            anj();
            load();
        }

        public void load()
        {
            string connecton = "datasource=localhost;port=3306;username=root;password=;database=studen";
            string query = "select * from percobaan";
            MySqlConnection conn = new MySqlConnection(connecton);
            MySqlCommand cmd = new MySqlCommand(query,conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);
            MySqlCommand cmd = new MySqlCommand();
           


            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hidupkan XAMPP dulu lalu coba lagi");
                conn.Close();

                // MessageBox.Show("MySQL Connection! \n"+ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return conn;

        }

        private void anj()
        {
            dbstuden.disp("SELECT IMAGE From percobaan", dataGridView1);

        }
        private void coba_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             //string sql = "INSERT INTO percobaan VALUES (NULL, NAMA, '"+Path.GetFileName(pictureBox1.ImageLocation) +"')";
          string sql = "SELECT IMAGE From percobaan";

           MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dt.Columns.Add("PICTURE", Type.GetType("System.Byte[]"));
            foreach (DataRow row in dt.Rows)
            {
                row["PICTURE"] = File.ReadAllBytes(Application.StartupPath + @"\Image\" + Path.GetFileName(row["IMAGE"].ToString()));

            }
            dataGridView1.DataSource = dt;
           
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


            //   string query = "insert into percobaan (NULL,nama," % + +% ",)";

            File.Copy(textBox1.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Choiec |*.png;*.jpg;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
             
                textBox1.Text = openfd.FileName;
                pictureBox1.Image = new Bitmap(openfd.FileName);
                pictureBox1.ImageLocation = openfd.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          //  string sql = "insert into percobaan (null,nama, " +Path.GetFileName(pictureBox1.ImageLocation) + ",)";
           // string sql = "INSERT INTO percobaan(id, nama, IMAGE) VALUES (null,anjir," ",)";
            string sql = "INSERT INTO percobaan(id, nama, IMAGE) VALUES (null,'"+textBox1.Text+"','"+ Path.GetFileName(pictureBox1.ImageLocation) + "')";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader dr;
          
            dr = cmd.ExecuteReader();

          
            conn.Close();

            

            File.Copy(textBox1.Text, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));
         //   MessageBox.Show(""+);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();
            string insertquery = "INSERT INTO percobaan(id, nama, IMAGE) VALUES (null,'anjir',@img)";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertquery, conn);

            command.Parameters.Add("@img", MySqlDbType.Blob);


            command.Parameters["@img"].Value = img;


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("berhasil");
            }
            conn.Close();
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=studen";
            MySqlConnection conn = new MySqlConnection(sql);
           
            conn.Open();
            string insertquery =" Select * from percobaan where id =171";

            MySqlCommand command = new MySqlCommand(insertquery, conn);
            DataTable tablle = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
          
            da.Fill(tablle);
           // textBox1.Name = tablle.Rows[1][1].ToString();
           if (tablle.Rows.Count > 0)
            {
               
                byte[] img = (byte[])tablle.Rows[1][2];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                dataGridView1.Dispose();
            }
           
           
        }
    }
}
