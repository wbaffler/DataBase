using Presentation.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class GroupForm : Form
    {
        private PresenterGroup presenter;
        public GroupForm(DatabaseContext.ApplicationContext db)
        {
            InitializeComponent();
            presenter = new PresenterGroup(this, db);
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            presenter.Create(NameTB.Text);
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            presenter.Show(IdTB.Text);
        }

        private void ChangeBut_Click(object sender, EventArgs e)
        {
            presenter.Change(NameTB.Text, IdTB.Text);
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            presenter.Delete(IdTB.Text);
        }

        public void DisplayError(string errorText)
        {
            MessageBox.Show(errorText);
        }

        public void DisplayData(string name)
        {
            ChNameTB.Text = name;
        }
        public void DisplaySuccess()
        {
            SuccessLabel.Text = "Успешно!";
        }
    }
}
