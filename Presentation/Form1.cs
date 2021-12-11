﻿using System;
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
        private DatabaseContext.ApplicationContext db;
        private void StudentBut_Click(object sender, EventArgs e)
        {
            StudentForm newForm = new StudentForm(db);
            newForm.Show();
        }

        private void GroupBut_Click(object sender, EventArgs e)
        {
            GroupForm newForm = new GroupForm(db);
            newForm.Show();
        }

        private void CuratorBut_Click(object sender, EventArgs e)
        {
            CuratorForm newForm = new CuratorForm(db);
            newForm.Show();
        }
    }
}
