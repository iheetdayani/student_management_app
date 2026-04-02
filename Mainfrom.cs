using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aDDBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDSTUDENT AD = new ADDSTUDENT();
            AD.MdiParent = this;
            AD.Show();
        }

        private void uPDATESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Updatestudent up = new Updatestudent();
            up.MdiParent = this;
            up.Show();
        }

        private void dELETESTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DELETEBYNAME NAME = new DELETEBYNAME();
            NAME.MdiParent = this;
            NAME.Show();
        }

        private void lISTSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liststudent LIST = new Liststudent();
            LIST.MdiParent = this;
            LIST.Show();
        }
    }
}
