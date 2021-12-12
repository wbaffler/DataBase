using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            db = new DatabaseContext.ApplicationContext();
            newStudentForm = new StudentForm(db);
            newGroupForm = new GroupForm(db);
            newCuratorForm = new CuratorForm(db);
            InitializeComponent();
        }
        private CuratorForm newCuratorForm;
        private GroupForm newGroupForm;
        private StudentForm newStudentForm;
        private DatabaseContext.ApplicationContext db;
        private void StudentBut_Click(object sender, EventArgs e)
        {

            newStudentForm.Show();
        }

        private void GroupBut_Click(object sender, EventArgs e)
        {

            newGroupForm.Show();
        }

        private void CuratorBut_Click(object sender, EventArgs e)
        {

            newCuratorForm.Show();
        }
    }
}
