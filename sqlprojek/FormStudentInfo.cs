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
    public partial class FormStudentInfo : Form
    {
        FormStudent  form;
        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }


        public void display()
        {
          

            dbstuden.displayseacr("SELECT ID, Name, Reg, Class, Section From student_tabel", dataGridView1);

        }
        private void btsave_Click(object sender, EventArgs e)
        {
            form.clear();
            form.saveinfo();
            form.ShowDialog();
          //  FormStudentInfo n = new FormStudentInfo();
            form.Hide();


        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            dbstuden.displayseacr("SELECT ID, Name, Reg, Class, Section From student_tabel WHERE Name LIKE '%"+txtsearch.Text+"%'", dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.clear();
              form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.name= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.reg= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.@class= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.section= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.updateinfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {

            if (MessageBox.Show("delete?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)== DialogResult.Yes)
         
                {
                    dbstuden.Deletestudent(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    display();
                }
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datanilai a = new Datanilai();
            a.Show();
        }

        private void FormStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
