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
    public partial class splacescree : Form
    {
        public splacescree()
        {
            InitializeComponent();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {

            el3.Width += 20;
            if (el3.Width >= 400)
            {
                timer1.Stop();
                menuutama a = new menuutama();
                a.Show();
                Hide();
            }

          
        }

        private void el3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splacescree_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
