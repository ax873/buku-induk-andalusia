using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace sqlprojek
{using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
    public partial class FormStudent : Form
    {
       
        private readonly FormStudentInfo _parent;
      public  string id, name, reg, @class, section;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void updateinfo()
        {
            txtlabel.Text = "Update";
            btsimpan.Text = "Update";
            txtname.Text = name;
            txtsect.Text = section;
            txtclass.Text = @class;
            txtreg.Text = reg;







        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataSiswa a = new DataSiswa();
            a.Show();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {



            printcover frm = new printcover();
            coverCrystalReport1 studrpt = new coverCrystalReport1();

            TextObject sesqe = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["tpnama"];
            sesqe.Text= txtname.Text;

            TextObject sese = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["tpnip"];
            sese.Text = txtreg.Text;

            TextObject sesqse = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text37"];
            sesqse.Text = txtname.Text;

            TextObject ssese = (TextObject)studrpt.ReportDefinition.Sections["Section1"].ReportObjects["Text38"];
            ssese.Text = txtreg.Text;



            frm.crystalReportViewer1.ReportSource = studrpt;
            frm.Show();




        }

        public void saveinfo()
        {
            txtlabel.Text = "Add Student";
            btsimpan.Text = "Save";
        }

        public void clear()
        {
            txtreg.Text = txtsect.Text = txtclass.Text = txtname.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            if(btsimpan.Text == "Save")
            {
                Student std = new Student(txtname.Text.Trim(), txtreg.Text.Trim(), txtclass.Text.Trim(), txtsect.Text.Trim());
                dbstuden.AddStuden(std);
                clear();
            }
            if (btsimpan.Text == "Update")
            {
                Student std = new Student(txtname.Text.Trim(), txtreg.Text.Trim(), txtclass.Text.Trim(), txtsect.Text.Trim());
                dbstuden.UpdateStudent(std, id);
            }
            _parent.display();

        }
    }
}
