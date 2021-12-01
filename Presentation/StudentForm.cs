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
        private PresenterStudent presenter;

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

        private void NumberInGroupBut_Click(object sender, EventArgs e)
        {
            presenter.CalculateNumberOfStudents(IdTB.Text);
        }

        private void CuratorNameBut_Click(object sender, EventArgs e)
        {
            presenter.NameOfCurator(IdTB.Text);
        }
        public void DisplayError(string errorText)
        {
            MessageBox.Show(errorText);
        }

        public void DisplayData(string groupId, string name, string age)
        {
            ChGroupIdTB.Text = groupId;
            ChNameTB.Text = name;
            ChAgeTB.Text = age;
        }

        public string NumberOfStudents { set => NumInGroupLabel.Text = value;  } 
        public string CuratorName { set => CuratorNameLabel.Text = value; }
        public void DisplaySuccess()
        {
            SuccessLabel.Text = "Успешно!";
        }
        

    }
}
