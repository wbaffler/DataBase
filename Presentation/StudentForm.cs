using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presentation.Presenter;
using Core;

namespace Presentation
{
    public partial class StudentForm : Form, IView
    {
        private Presenter.PresenterStudent presenter;

        public StudentForm()
        {
            InitializeComponent();
            presenter = new PresenterStudent(this);
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            presenter.Create(GroupIdTB.Text, NameTB.Text, AgeTB.Text);
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            presenter.Show(IdTB.Text);
        }

        private void ChangeBut_Click(object sender, EventArgs e)
        {
            presenter.Change(GroupIdTB.Text, NameTB.Text, AgeTB.Text, IdTB.Text);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            presenter.Delete(IdTB.Text);
        }
        public void DisplayError(string errorText)
        {
            MessageBox.Show(errorText);
        }

        public void DisplayData(List<string> data)
        {
            ChGroupIdTB.Text = data[0];
            ChNameTB.Text = data[1];
            ChAgeTB.Text = data[2];
        }
    }
}
