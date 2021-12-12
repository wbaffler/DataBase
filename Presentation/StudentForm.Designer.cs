
namespace Presentation
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateBut = new System.Windows.Forms.Button();
            this.FindBut = new System.Windows.Forms.Button();
            this.ChangeBut = new System.Windows.Forms.Button();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.NumberInGroupBut = new System.Windows.Forms.Button();
            this.CuratorNameBut = new System.Windows.Forms.Button();
            this.NumInGroupLabel = new System.Windows.Forms.Label();
            this.CuratorNameLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateBut
            // 
            this.CreateBut.Location = new System.Drawing.Point(1312, 22);
            this.CreateBut.Name = "CreateBut";
            this.CreateBut.Size = new System.Drawing.Size(242, 34);
            this.CreateBut.TabIndex = 7;
            this.CreateBut.Text = "Создать ";
            this.CreateBut.UseVisualStyleBackColor = true;
            this.CreateBut.Click += new System.EventHandler(this.CreateBut_Click);
            // 
            // FindBut
            // 
            this.FindBut.Location = new System.Drawing.Point(1312, 85);
            this.FindBut.Name = "FindBut";
            this.FindBut.Size = new System.Drawing.Size(242, 34);
            this.FindBut.TabIndex = 11;
            this.FindBut.Text = "Найти";
            this.FindBut.UseVisualStyleBackColor = true;
            this.FindBut.Click += new System.EventHandler(this.FindBut_Click);
            // 
            // ChangeBut
            // 
            this.ChangeBut.Location = new System.Drawing.Point(1312, 137);
            this.ChangeBut.Name = "ChangeBut";
            this.ChangeBut.Size = new System.Drawing.Size(242, 34);
            this.ChangeBut.TabIndex = 18;
            this.ChangeBut.Text = "Изменить";
            this.ChangeBut.UseVisualStyleBackColor = true;
            this.ChangeBut.Click += new System.EventHandler(this.ChangeBut_Click);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(1312, 194);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(242, 34);
            this.DeleteBut.TabIndex = 19;
            this.DeleteBut.Text = "Удалить";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // NumberInGroupBut
            // 
            this.NumberInGroupBut.Location = new System.Drawing.Point(1236, 283);
            this.NumberInGroupBut.Name = "NumberInGroupBut";
            this.NumberInGroupBut.Size = new System.Drawing.Size(318, 83);
            this.NumberInGroupBut.TabIndex = 20;
            this.NumberInGroupBut.Text = "Подсчитать студентов в группе";
            this.NumberInGroupBut.UseVisualStyleBackColor = true;
            this.NumberInGroupBut.Click += new System.EventHandler(this.NumberInGroupBut_Click);
            // 
            // CuratorNameBut
            // 
            this.CuratorNameBut.Location = new System.Drawing.Point(1236, 392);
            this.CuratorNameBut.Name = "CuratorNameBut";
            this.CuratorNameBut.Size = new System.Drawing.Size(318, 83);
            this.CuratorNameBut.TabIndex = 21;
            this.CuratorNameBut.Text = "Вывести имя куратора";
            this.CuratorNameBut.UseVisualStyleBackColor = true;
            this.CuratorNameBut.Click += new System.EventHandler(this.CuratorNameBut_Click);
            // 
            // NumInGroupLabel
            // 
            this.NumInGroupLabel.AutoSize = true;
            this.NumInGroupLabel.Location = new System.Drawing.Point(48, 464);
            this.NumInGroupLabel.Name = "NumInGroupLabel";
            this.NumInGroupLabel.Size = new System.Drawing.Size(0, 25);
            this.NumInGroupLabel.TabIndex = 22;
            // 
            // CuratorNameLabel
            // 
            this.CuratorNameLabel.AutoSize = true;
            this.CuratorNameLabel.Location = new System.Drawing.Point(431, 464);
            this.CuratorNameLabel.Name = "CuratorNameLabel";
            this.CuratorNameLabel.Size = new System.Drawing.Size(0, 25);
            this.CuratorNameLabel.TabIndex = 23;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(1204, 785);
            this.dataGridView.TabIndex = 25;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 844);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.CuratorNameLabel);
            this.Controls.Add(this.NumInGroupLabel);
            this.Controls.Add(this.CuratorNameBut);
            this.Controls.Add(this.NumberInGroupBut);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ChangeBut);
            this.Controls.Add(this.FindBut);
            this.Controls.Add(this.CreateBut);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateBut;
        private System.Windows.Forms.Button FindBut;
        private System.Windows.Forms.Button ChangeBut;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button NumberInGroupBut;
        private System.Windows.Forms.Button CuratorNameBut;
        private System.Windows.Forms.Label NumInGroupLabel;
        private System.Windows.Forms.Label CuratorNameLabel;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}