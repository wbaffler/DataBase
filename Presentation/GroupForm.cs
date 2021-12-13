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
        
        public GroupForm(DatabaseContext.ApplicationContext db)
        {
            InitializeComponent();
            presenter = new PresenterGroup(this, db);
            Width = 1600;
            Height = 900;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.NoControl;
            SetGrid();
        }
        private PresenterGroup presenter;
        private int _numOfColomns = 3;
        private void SetGrid()
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnCount = _numOfColomns;
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[2].ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.Columns[0].HeaderText = "Id";
            dataGridView.Columns[1].HeaderText = "Name";
            dataGridView.Columns[2].HeaderText = "Time";
            presenter.UpdateDataGrid();
        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            presenter.Create(NameTB.Text);
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
                string name = dataGridView[1, rowIndex].Value.ToString(); ;
                presenter.Change(name, id);
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

        public void DisplayError(string errorText)
        {
            MessageBox.Show(errorText);
        }

        public void DisplayData(string name)
        {
            //ChNameTB.Text = name;
        }
        public void DisplaySuccess()
        {
            //SuccessLabel.Text = "Успешно!";
        }
        public void UpdGrid(List<List<string>> matrix)
        {
            dataGridView.Rows.Clear();
            foreach (var list in matrix)
            {
                dataGridView.Rows.Add(list[0], list[1], list[2]);
            }

        }
        public void ClearFields()
        {
            NameTB.Clear();
        }
    }
}
