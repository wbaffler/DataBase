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
    public partial class CuratorForm : Form
    {
        private PresenterCurator presenter;
        public CuratorForm()
        {
            InitializeComponent();
            presenter = new PresenterCurator(this);
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
        private void AverageBut_Click(object sender, EventArgs e)
        {
            presenter.CalculateAverageAge(IdTB.Text);
        }
        public void DisplayError(string errorText)
        {
            MessageBox.Show(errorText);
        }

        public void DisplayData(string groupId, string name, string email)
        {
            ChGroupIdTB.Text = groupId;
            ChNameTB.Text = name;
            ChEmailTB.Text = email;
        }

        public string AverageAge { set => AverageAgeLabel.Text = value; }
        public void DisplaySuccess()
        {
            SuccessLabel.Text = "Успешно!";
        }

        
    }
}
