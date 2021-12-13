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
        
        public CuratorForm(DatabaseContext.ApplicationContext db)
        {
            InitializeComponent();
            presenter = new PresenterCurator(this, db);
            Width = 1600;
            Height = 900;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.NoControl;
            SetGrid();
            presenter.FindAllGroups();

        }
        private PresenterCurator presenter;
        private int _numOfColomns = 5;
        private void SetGrid()
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnCount = _numOfColomns;
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[1].ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "GroupId";
            dataGridView.Columns[2].HeaderText = "Name";
            dataGridView.Columns[3].HeaderText = "E-Mail";
            dataGridView.Columns[4].HeaderText = "Group";
            presenter.UpdateDataGrid();
        }
        private void CreateBt_Click(object sender, EventArgs e)
        {
            presenter.Create(GroupCB.Text, NameTB.Text, EmailTB.Text);
        }

        private void FindBut_Click(object sender, EventArgs e)
        {
            //presenter.Show(IdTB.Text);
        }

        private void ChangeBut_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count != 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                string id = dataGridView[0, rowIndex].Value.ToString();
                string group = dataGridView[4, rowIndex].Value.ToString();
                string name = dataGridView[2, rowIndex].Value.ToString(); ;
                string email = dataGridView[3, rowIndex].Value.ToString(); ;
                presenter.Change(group, name, email, id);
            }
            else
            {
                DisplayError("Выберите элемент");
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count != 0)
            {
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите удалить элемент?",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                    string id = dataGridView[0, rowIndex].Value.ToString();
                    presenter.Delete(id);
                }
            }
            else
            {
                DisplayError("Выберите элемент");
            }
        }
        private void AverageBut_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count != 0)
            {
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;
                string id = dataGridView[0, rowIndex].Value.ToString();
                presenter.CalculateAverageAge(id);
            }
            else
            {
                DisplayError("Выберите элемент");
            }
        }
        public void DisplayError(string errorText)
        {
            MessageBox.Show(errorText);
        }

        public void DisplayData(string groupId, string name, string email)
        {
            /*ChGroupIdTB.Text = groupId;
            ChNameTB.Text = name;
            ChEmailTB.Text = email;*/
        }
        public void UpdGrid(List<List<string>> matrix)
        {
            dataGridView.Rows.Clear();
            foreach (var list in matrix)
            {
                dataGridView.Rows.Add(list[0], list[1], list[2], list[3], list[4]);
            }

        }

        public string AverageAge { set => AvgLabel.Text = value; }
        public void DisplaySuccess()
        {
            //SuccessLabel.Text = "Успешно!";
        }
        public void SetComboBox(List<string> groupName)
        {
            foreach (var el in groupName)
                GroupCB.Items.Add(el);
        }
        public void ClearFields()
        {
            NameTB.Clear();
            GroupCB.Text = "";
            EmailTB.Clear();
        }
    }
}
