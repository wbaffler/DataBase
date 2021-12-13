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
            InitializeComponent();
        }
        private CuratorForm newCuratorForm;
        private GroupForm newGroupForm;
        private StudentForm newStudentForm;
        private DatabaseContext.ApplicationContext db;
        private void StudentBut_Click(object sender, EventArgs e)
        {
            newStudentForm = new StudentForm(db);
            newStudentForm.ShowDialog();
        }

        private void GroupBut_Click(object sender, EventArgs e)
        {
            newGroupForm = new GroupForm(db);
            newGroupForm.ShowDialog();
        }

        private void CuratorBut_Click(object sender, EventArgs e)
        {
            newCuratorForm = new CuratorForm(db);
            newCuratorForm.ShowDialog();
        }
    }
}
